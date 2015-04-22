using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    class Employee : Person
    {
        public DateTime dateOfEmployment;
        public double salary;
        public uint availableDaysOff;
        public List<Leave> allLeaves = new List<Leave>(); // lista de concedii pentru un angajat

        public Employee(string LastName, string FirstName, string dateOfBirth, string dateOfEmployment, double salary, uint availableDaysOff )
        {
            this.lastName = LastName;
            this.firstName = FirstName;
            this.dateOfBirth = Convert.ToDateTime(dateOfBirth);
            this.dateOfEmployment = Convert.ToDateTime(dateOfEmployment);
            this.salary = salary;
            this.availableDaysOff = availableDaysOff;
        }

        public void DisplayInfo()  // afiseaza informatiile despre un angajat
        {
            Console.WriteLine("Angajat: {0} {1}\nSalariu: {2}\nZile libere: {3}\n", lastName, firstName, salary, availableDaysOff);
        }

        private int SubstractDays(uint days)
        {
            if (days > this.availableDaysOff)
            {
                return 1;  // daca numarul de zile e prea mare decat disponibil returneaza 1 
            }
            else
            {
                this.availableDaysOff = this.availableDaysOff - days;
                return 2;
            }
        }

        public void AddNewLeave(Leave concediu) // un concediu nou
        {
            int flag = SubstractDays(concediu.duration);
            if (flag == 1)
                throw new InvalidLeaveException();
            else
                allLeaves.Add(concediu);
            concediu.employee = this.lastName + " " + this.firstName;
        }

        public void GetLeaveList()   // afiseaza lista de concedii a unui angajat
        {
            Console.WriteLine("Lista de concedii a angajatului {0} {1}\n", this.firstName, this.lastName);
            foreach (Leave a in allLeaves)
            {
                Console.Write("Tip: {0}\nIncepand cu:{1}\nDurata:{2}\n", a.leaveType, a.startingDate.ToString("dd/MM/yyyy"), a.duration);
            }
        }
    }


    class InvalidLeaveException : Exception
    {
        public InvalidLeaveException() : base(String.Format("Durata concediului nu poate fi mai mare decat numarul de zile ramase! ")) { }
    }
}
