namespace ProjectSO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtLogs = new TextBox();
            groupBox2 = new GroupBox();
            btn_random = new Button();
            btn_start = new Button();
            cb_speed = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            num_passenger = new NumericUpDown();
            groupBox3 = new GroupBox();
            GanttChartPanel = new Panel();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox5 = new GroupBox();
            list_ready = new ListBox();
            CountTime = new Label();
            lbl_time = new Label();
            label3 = new Label();
            lbl_waitavg = new Label();
            label4 = new Label();
            lbl_turnavg = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_passenger).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtLogs);
            groupBox1.Location = new Point(759, 151);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(277, 390);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Logs";
            // 
            // txtLogs
            // 
            txtLogs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtLogs.BackColor = SystemColors.ActiveCaptionText;
            txtLogs.Font = new Font("Microsoft Sans Serif", 8.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtLogs.ForeColor = Color.Lime;
            txtLogs.Location = new Point(7, 26);
            txtLogs.Margin = new Padding(4);
            txtLogs.Multiline = true;
            txtLogs.Name = "txtLogs";
            txtLogs.ReadOnly = true;
            txtLogs.ScrollBars = ScrollBars.Both;
            txtLogs.Size = new Size(263, 357);
            txtLogs.TabIndex = 0;
            txtLogs.WordWrap = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_random);
            groupBox2.Controls.Add(btn_start);
            groupBox2.Controls.Add(cb_speed);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(num_passenger);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1024, 75);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Control";
            // 
            // btn_random
            // 
            btn_random.Location = new Point(312, 28);
            btn_random.Name = "btn_random";
            btn_random.Size = new Size(124, 29);
            btn_random.TabIndex = 6;
            btn_random.Text = "Randomize List";
            btn_random.UseVisualStyleBackColor = true;
            btn_random.Click += btn_random_Click;
            // 
            // btn_start
            // 
            btn_start.Location = new Point(486, 28);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(94, 29);
            btn_start.TabIndex = 5;
            btn_start.Text = "START";
            btn_start.UseVisualStyleBackColor = true;
            btn_start.Click += btn_start_Click;
            // 
            // cb_speed
            // 
            cb_speed.FormattingEnabled = true;
            cb_speed.Items.AddRange(new object[] { "0.5", "0.75", "1.0", "1.5", "2.0", "4.0", "8.0" });
            cb_speed.Location = new Point(867, 32);
            cb_speed.Name = "cb_speed";
            cb_speed.Size = new Size(151, 28);
            cb_speed.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(728, 35);
            label2.Name = "label2";
            label2.Size = new Size(133, 20);
            label2.TabIndex = 3;
            label2.Text = "Simulation Speed :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 1;
            label1.Text = "Total Passengers :";
            // 
            // num_passenger
            // 
            num_passenger.Location = new Point(136, 30);
            num_passenger.Name = "num_passenger";
            num_passenger.Size = new Size(150, 27);
            num_passenger.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(GanttChartPanel);
            groupBox3.Location = new Point(12, 416);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(741, 125);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Gantt Chart";
            // 
            // GanttChartPanel
            // 
            GanttChartPanel.AutoScroll = true;
            GanttChartPanel.AutoScrollMargin = new Size(5000, 0);
            GanttChartPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            GanttChartPanel.BorderStyle = BorderStyle.Fixed3D;
            GanttChartPanel.Location = new Point(6, 26);
            GanttChartPanel.Margin = new Padding(4);
            GanttChartPanel.Name = "GanttChartPanel";
            GanttChartPanel.Size = new Size(729, 93);
            GanttChartPanel.TabIndex = 7;
            GanttChartPanel.Scroll += GanttChartPanel_Scroll;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new Point(12, 151);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(621, 259);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Passengers List";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(612, 224);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(list_ready);
            groupBox5.Location = new Point(639, 151);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(114, 259);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Ready Queue";
            // 
            // list_ready
            // 
            list_ready.FormattingEnabled = true;
            list_ready.ItemHeight = 20;
            list_ready.Location = new Point(6, 26);
            list_ready.Name = "list_ready";
            list_ready.Size = new Size(102, 224);
            list_ready.TabIndex = 0;
            // 
            // CountTime
            // 
            CountTime.AutoSize = true;
            CountTime.Location = new Point(104, 107);
            CountTime.Name = "CountTime";
            CountTime.Size = new Size(17, 20);
            CountTime.TabIndex = 7;
            CountTime.Text = "0";
            // 
            // lbl_time
            // 
            lbl_time.AutoSize = true;
            lbl_time.Location = new Point(18, 107);
            lbl_time.Name = "lbl_time";
            lbl_time.Size = new Size(53, 20);
            lbl_time.TabIndex = 8;
            lbl_time.Text = "Time : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(151, 107);
            label3.Name = "label3";
            label3.Size = new Size(167, 20);
            label3.TabIndex = 10;
            label3.Text = "Average Waiting Time : ";
            // 
            // lbl_waitavg
            // 
            lbl_waitavg.AutoSize = true;
            lbl_waitavg.Location = new Point(324, 107);
            lbl_waitavg.Name = "lbl_waitavg";
            lbl_waitavg.Size = new Size(17, 20);
            lbl_waitavg.TabIndex = 9;
            lbl_waitavg.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(375, 107);
            label4.Name = "label4";
            label4.Size = new Size(198, 20);
            label4.TabIndex = 12;
            label4.Text = "Average Turn Around Time : ";
            // 
            // lbl_turnavg
            // 
            lbl_turnavg.AutoSize = true;
            lbl_turnavg.Location = new Point(579, 107);
            lbl_turnavg.Name = "lbl_turnavg";
            lbl_turnavg.Size = new Size(17, 20);
            lbl_turnavg.TabIndex = 11;
            lbl_turnavg.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 553);
            Controls.Add(label4);
            Controls.Add(lbl_turnavg);
            Controls.Add(label3);
            Controls.Add(lbl_waitavg);
            Controls.Add(lbl_time);
            Controls.Add(CountTime);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "One-lane Boarding Simulator";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_passenger).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Label label2;
        private Label label1;
        private NumericUpDown num_passenger;
        private Button btn_random;
        private Button btn_start;
        private ComboBox cb_speed;
        private DataGridView dataGridView1;
        private ListBox list_ready;
        private Label CountTime;
        private Label lbl_time;
        private Panel GanttChartPanel;
        private TextBox txtLogs;
        private Label label3;
        private Label lbl_waitavg;
        private Label label4;
        private Label lbl_turnavg;
    }
}