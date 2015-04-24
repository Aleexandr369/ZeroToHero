using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace MyHomework
{
    
    enum LeaveType { medical, holiday, other } ;
   
    class Program
    {
        static void Main(string[] args)
        {
            
            CultureInfo ci = new CultureInfo("ro");  // se seteaza limba pentru a putea fi siguri ca stringurile pentru data sunt scrise corect
            Thread.CurrentThread.CurrentCulture = ci; // pentru un singur thread
           
            Employee angajat = new Employee("Alexandru", "Dumitrache", "15/09/1990", "20/05/2015", 2000, 30);
            angajat.DisplayInfo();

            Leave concediu = new Leave("16/03/2016", 11, LeaveType.holiday.ToString()); 
            angajat.AddNewLeave(concediu);

            Console.WriteLine("Dupa concediu:\n");
            angajat.DisplayInfo();
            
            concediu = new Leave("17/03/2014", 8, LeaveType.holiday.ToString());
            angajat.AddNewLeave(concediu);

            angajat.GetLeaveList(2013);            
        }
    }
}
