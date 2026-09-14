using OOP_Inheritance2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataBase.ConnectionInfo();

            Console.WriteLine(DataBase.count);

            Oracle oracle = new Oracle("100.45.240.15","root", "1234","11.4");
            Oracle oracle2 = new Oracle("100.45.240.16","root", "1234","11.4");
            MySql mysql = new MySql("100.45.240.14","avmin", "1234");
            MySql mysql2 = new MySql("100.45.240.13","avmin", "1234");
            MySql mysql3 = new MySql("100.45.240.12","avmin", "1234");
            oracle.disconnect();
            oracle.connection();
            DataBase.ConnectionInfo();
            mysql.connection();
            DataBase.ConnectionInfo();

            Console.WriteLine(mysql3.count2);
            Console.WriteLine(DataBase.count);
            
          
        }

       
    }
}
