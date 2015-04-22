using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    class Leave
    {
        public enum leaveType
        {
            Medical,
            Holiday,
            Other
        };
        public leaveType leavetype;
        public DateTime startingDate;
        public int duration;
        public string employee;
    }
}
