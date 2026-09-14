using OOP_Inheritance2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance2
{
    internal class MySql : DataBase
    {
        public MySql(string path, string userName, string password) : base(path, userName, password)
        {
        }

        public override void connection()
        {
            if (!isConnecting)
            {
                Console.WriteLine($"MySql Veritabanına bağlanıldı");
                isConnecting = true;
            }
            else
            {
                Console.WriteLine($"MySql bağlantısı zaten açık");
            }

           
        }

        public override void disconnect()
        {
            if (isConnecting)
            {
                Console.WriteLine($"MySql Veritabanı bağlantı kesildi");
                isConnecting = true;
            }
            else
            {
                Console.WriteLine($"MaySql bağlantısı zaten kapalı");
            }
        }
    }
}
