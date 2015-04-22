using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    class Leave
    {    
        public string leaveType;
        public DateTime startingDate;
        public uint duration;
        public string employee;

        public Leave(string startingDate, uint duration, string leavetype)
        {
            this.startingDate = Convert.ToDateTime(startingDate);
            this.duration = duration;
            this.leaveType = leavetype;
        }
    }
}
