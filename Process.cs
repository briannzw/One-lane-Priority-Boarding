using System;
using System.ComponentModel;
using static ProjectSO.Form1;

namespace ProjectSO
{

    public class Process
    {
        [DisplayName("ID")]
        public int pid { get; set; }        // ID
        [DisplayName("Arrive")]
        public int at { get; set; }         // Arrival Time
        [DisplayName("Process Time")]
        public int bt { get; set; }         // Burst Time
        public int rt;        // Remaining Time
        [DisplayName("Priority Group")]
        public PriorityGroup priority { get; set; }   // Priority

        public Process(int pid, int at, int bt, PriorityGroup priority)
        {
            this.pid = pid;
            this.at = at;
            this.bt = bt;
            this.rt = bt;
            this.priority = priority;
        }

        [DisplayName("%")]
        public float percentage => (float)Math.Floor((bt - rt) * 100f / bt);

        public int ct;          // Completion Time
        public int wt;          // Waiting Time
        public int tat;         // Turnarount Time

        public void Reset() { rt = bt; ct = 0; wt = 0; tat = 0; }
    }
}
