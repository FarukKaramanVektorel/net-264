using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance2
{
    internal abstract class DataBase
    {
        private string _path;
        private string _userName;
        private string _password;
        public bool isConnecting { get; set; }
        public static int count { get; set; }
        public  int count2 { get; set; }

        public DataBase(string path, string userName, string password)
        {
            Path= path;
            UserName= userName;
            Password= password;
            isConnecting = false;
            count++;
            count2++;
        }

        public string Password
        {
            get { return _password; }
            set { if (value != null) _password = value; }
        }


        public string UserName
        {
            get { return _userName; }
            set { if (value != null) _userName = value; }
        }


        public string Path
        {
            get { return _path; }
            set { if (value != null) _path = value; }
        }

        public abstract void connection();

        public abstract void disconnect();

        public static void ConnectionInfo()
        {
            Console.WriteLine($"{count} adet veritabanına bağlanıldı...");
        }

    }
}
