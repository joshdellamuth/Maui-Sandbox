using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui_Sandbox.Models
{
    public class Task
    {
        public string TaskId { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public string TaskStatus { get; set; }
        public string TaskGoalLink { get; set; }
        public DateTime TaskStartDate { get; set; }
        public DateTime TaskCompletionDate { get; set; }

    }
}
