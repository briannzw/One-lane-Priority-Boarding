namespace ProjectSO
{
    using System.ComponentModel;
    using static Functions;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public enum PriorityGroup
        {
            First,
            Business,
            Window,
            Middle,
            Aisle,
            Max     // Use for priority only
        }

        private List<Process> processList;

        BindingSource source;
        BindingList<Process> bindingList;

        private void Form1_Load(object sender, EventArgs e)
        {
            TextBoxWriter writer = new TextBoxWriter(txtLogs);
            Console.SetOut(writer);
            GanttChartPanel.Invalidate();
            GanttChartPanel.Controls.Clear();
            processList = new List<Process>();

            bindingList = new BindingList<Process>(processList);
            source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (num_passenger.Value == 0)
            {
                MessageBox.Show("Jumlah penumpang tidak boleh 0!");
                return;
            }

            foreach (Process process in processList)
            {
                process.Reset();
            }

            Refresh();
            txtLogs.Clear();
            txtLogs.Refresh();
            GanttChartPanel.Controls.Clear();

            GanttChart(processList.Count);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = source;
        }

        private void GanttChart(int n)
        {
            GanttChartPanel.CreateGraphics();

            CountTime.Text = "" + 0;
            lbl_time.Show();
            CountTime.Show();
            CountTime.Refresh();
            lbl_time.Refresh();


            Priority_Preemptive(n);
        }

        private void btn_random_Click(object sender, EventArgs e)
        {
            processList.Clear();

            Random random = new Random();
            int pid, at, bt;
            for (int i = 0; i < num_passenger.Value; i++)
            {
                pid = i+1;
                at = (i == 0) ? 1 : random.Next(1, 30);
                bt = random.Next(1, 12);
                PriorityGroup priority = RandomEnumValue<PriorityGroup>(false);
                processList.Add(new Process(pid, at, bt, priority));
            }

            bindingList = new BindingList<Process>(processList);
            source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = source;
        }

        public struct RGB
        {
            public int x, y, z;
        }

        private void Priority_Preemptive(int n)
        {
            int i = 0, current = 0, count = 0, time = 0, end = 0;

            Random rand = new Random();
            int[] processGantt = new int[100];
            RGB[] colorStandar = new RGB[100];
            RGB[] colorProcess = new RGB[100];

            float waitavg = 0, turnavg = 0;

            int xx, yy, zz;

            //Define color of Process
            for (i = 0; i < n; i++)
            {
                //Random color
                xx = rand.Next(70, 255);
                yy = rand.Next(70, 255);
                zz = rand.Next(50, 255);
                //Red - Green - Black
                colorStandar[i].x = xx;
                colorStandar[i].y = yy;
                colorStandar[i].z = zz;
            }

            processList.Add(new Process(0, 0, 0, PriorityGroup.Max));

            Process lastProcess = processList[0];

            HashSet<int> waitQueue = new HashSet<int>();

            for (time = 1; count < n; time++)
            {
                current = n;

                for (i = 0; i < n; i++)
                {
                    if (processList[i].at <= time && processList[i].rt > 0)
                    {
                        if (processList[i].at == time)
                        {
                            Console.WriteLine("[Time: " + time + "] " + processList[i].pid + " is Boarding...");
                        }

                        if (!waitQueue.Contains(processList[i].pid))
                            waitQueue.Add(processList[i].pid);

                        if ((int)processList[i].priority < (int)processList[current].priority)
                        {
                            current = i;
                            processGantt[time] = i;
                            colorProcess[time] = colorStandar[i];
                        }
                    }
                }

                // CONSOLE
                if (waitQueue.Contains(processList[current].pid)) waitQueue.Remove(processList[current].pid);
                foreach(var wait in waitQueue)
                {
                    if (wait == lastProcess.pid)
                    {
                        Console.WriteLine("[Time: " + time + "] " + wait + " is Turning...");
                        if (!list_ready.Items.Contains(wait))
                        {
                            list_ready.Items.Add(wait);
                        }
                        continue;
                    }
                    if (!list_ready.Items.Contains(wait))
                    {
                        Console.WriteLine("[Time: " + time + "] " + wait + " is Waiting...");
                        list_ready.Items.Add(wait);
                    }
                }

                if (processList[current].pid > 0 && processList[current] != lastProcess)
                {
                    Console.WriteLine("[Time: " + time + "] " + processList[current].pid + " is Processing...");
                    if(list_ready.Items.Contains(processList[current].pid)) list_ready.Items.Remove(processList[current].pid);
                }
                list_ready.Refresh();
                // END CONSOLE

                lastProcess = processList[current];

                processList[current].rt--;
                if (processList[current].rt == 0)//Process already done
                {
                    count++;
                    end = time + 1;
                    processList[current].ct = end;
                    processList[current].wt = end - processList[current].at - processList[current].bt;
                    processList[current].tat = end - processList[current].at;
                }


                for (i = 0; i < n; i++)
                {
                    waitavg += processList[i].wt;
                    turnavg += processList[i].tat;
                }

                lbl_waitavg.Text = string.Format("{0:0.##}", waitavg / time);
                lbl_turnavg.Text = string.Format("{0:0.##}", turnavg / time);
                CountTime.Text = "" + time;
                lbl_waitavg.Refresh();
                lbl_turnavg.Refresh();
                CountTime.Refresh();

                Process temp = processList[n];
                processList.Remove(processList[n]);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = source;
                dataGridView1.Refresh();
                processList.Add(temp);



                //---------------------------
                //Drawing...
                Font font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular);
                
                drawProcess(processGantt, colorProcess, font, time, time-1, 20, 50);
                GanttChartPanel.Refresh();
                txtLogs.Refresh();
            }

            //Show result
            txtLogs.AppendText(Environment.NewLine);
            Console.Write("Process ID\tWaiting Time\tTunarround Time");
            for (i = 0; i < n; i++)
            {
                txtLogs.AppendText(Environment.NewLine);
                Console.Write(" {0}\t\t", processList[i].pid);
                Console.Write(" {0}\t\t{1}", processList[i].wt, processList[i].tat);
            }

            processList.Remove(processList[n]);

            list_ready.Items.Clear();
            list_ready.Refresh();
        }

        private void GanttChartPanel_Scroll(object sender, ScrollEventArgs e)
        {
            GanttChartPanel.Update();
        }

        public void drawProcess(int[] processGantt, RGB[] colorProcess, Font font, int i, int k, int sizex, int sizey)
        {
            TextBox txb = new TextBox();
            txb.Location = new Point(k * 20, 2);
            txb.Name = string.Format("P{0}", k);
            txb.Tag = string.Format("[{0}]", k);
            txb.Multiline = true;
            txb.BorderStyle = 0;
            txb.Font = font;
            txb.Text = string.Format("P{0}", processGantt[i] + 1);
            txb.Text += "\r\n" + i;
            txb.BackColor = Color.FromArgb(255, colorProcess[i].x, colorProcess[i].y, colorProcess[i].z);
            txb.AutoSize = false;
            txb.ReadOnly = true;
            txb.Margin = new Padding(0, 0, 0, 0);
            txb.Size = new Size(sizex, sizey);
            GanttChartPanel.Controls.Add(txb);
        }
    }
}