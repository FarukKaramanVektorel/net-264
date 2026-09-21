using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<Numara> kutu = new Box<Numara>();
            kutu.addValue(null);
            kutu.addValue(null);
            kutu.addValue(null);
            kutu.addValue(null);
            kutu.addValue(null);
            kutu.addValue(null);
            kutu.listValue();
            Box<string> kutu2 = new Box<string>();
            kutu2.addValue("Ali");
            kutu2.addValue("Ayşe");
            kutu2.addValue("Mehmet");
            kutu2.addValue("Elif");
            kutu2.addValue("Ahmet");
            kutu2.listValue();
            Student s = new Student("Ali Keskin", "1234");
            Student s1 = new Student("Tolga Kuru", "1235");
            Student s2 = new Student("Mehtap Keser", "1236");
            Student s3 = new Student("Ayşe Keskin", "1237");
            Box<Student> students = new Box<Student>();
            students.addValue(s);
            students.addValue(s1);
            students.addValue(s2);
            students.addValue(s3);
            students.listValue();
            Numbers<int> numbers = new Numbers<int>();
            Numbers<string> students2 = new Numbers<string>();
            Numbers<Student> students22 = new Numbers<Student>();
            Liste<WildAnimal> wa = new Liste<WildAnimal>();
            Liste<Animal> wa1 = new Liste<Animal>();
            Liste<Pet> wa2 = new Liste<Pet>();
            Console.WriteLine(BuyukSayi(45,90));

            Animal a=NewObjectCreate<Animal>();
            Console.WriteLine(a.Name);


        }

        static T BuyukSayi<T>(T a,T b) where T : IComparable
        {
            return a.CompareTo(b)>0? a : b;
        }

        static T NewObjectCreate<T>() where T : new()
        {
            return new T();
        }
    }
}
