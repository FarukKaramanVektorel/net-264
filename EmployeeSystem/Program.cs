using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Yönetici asgari ücret*5 , Ofis Çalışanı, Pazarlama, Muhasebe, Üretim
            // 225 saat bir asgari ücret mesai asgari saat ücretinin 1,5 katı
            Branche branche = new Branche("Pazarlama", 1.05);

            Employee e = new Employee("Ali","Keskin",45,branche);
            Employee e2 = new Employee("Ali","Keskin",45,branche);

            if (e.Equals(branche))
            {
                Console.WriteLine("iki obje aynı kişi");
            }
            else
            {
                Console.WriteLine("Farklı kişiler");
            }

            Console.WriteLine(e.ToString());
        }
    }
}
