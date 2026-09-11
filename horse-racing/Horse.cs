using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace horse_racing
{
    internal class Horse
    {
       

        public string Name { get; set; }
        public int Age { get; set; }
        public int FormStatus { get; set; }
         
        public Horse(string name,int age, int formStatus)
        {
            Name = name;
            Age = age;
            FormStatus= formStatus;
        }


        public int ilerle()
        {
            Random rnd = new Random();
            int katSayi = rnd.Next(5, 9);           
            return FormStatus/katSayi;
        }


        public string info()
        {
            return $"At: {Name}, Yaş: {Age}, Form: {FormStatus}";
        }
    }
}
