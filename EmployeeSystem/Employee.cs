using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystem
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int WorkingHour { get; set; }

        public Branche Branche { get; set; }


        public Employee(string name, string lastname, int workingHour, Branche branche)
        {
            Name = name;
            Lastname = lastname;
            WorkingHour = workingHour;
            Branche = branche;
        }

        public override string ToString()
        {
            return $"Ad: {Name}, Soyad: {Lastname}";
        }
        public override bool Equals(object obj)
        {
            Employee emp = null;
            if (!(obj is Employee))
            {
                Console.WriteLine("Classlar arası uyuşmazlık tespit edildi...");
                return false;
            }
            emp = (Employee)obj;
            return Name.Equals(emp.Name) && Lastname.Equals(emp.Lastname) && Branche.Equals(emp.Branche);


        }
    }


}
