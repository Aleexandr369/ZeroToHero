using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    class Leave
    {    
        private LeaveType leaveType;
        private DateTime startingDate;
        private uint duration;
        private string employee;

        public LeaveType LeaveT
        {
            get { return leaveType; } 
            set { leaveType = value; }
        }

        public DateTime StartingDate
        {
            get { return startingDate; }
            set { startingDate = value; }
        }

        public uint Duration
        {
            get { return duration; }
            set { duration = value; }
        }
        
        public string PEmployee
        {
            set { employee = value; }
            get { return employee; }
        }

        public Leave(string startingDate, uint duration, LeaveType leavetype)
        {
            this.startingDate = Convert.ToDateTime(startingDate);
            this.duration = duration;
            this.leaveType = leavetype;
        }
    }
}
