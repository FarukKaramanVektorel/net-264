using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance2
{
    internal sealed class Oracle:DataBase
    {
		private string _version;

        public const int VALUE=2;
        public readonly string INFO_CLUP;

        public Oracle(string path, string userName, string password,string version) : base(path, userName, password)
        {
            
            Version = version;
        }

        public string Version
		{
			get { return _version; }
			set {if(value!=null) _version = value; }
		}

        public override void connection()
        {
            if (!isConnecting)
            {
                Console.WriteLine($"Oracle {Version} Veritabanına bağlanıldı");
                isConnecting = true;
            }
            else
            {
                Console.WriteLine($"Oracle {Version} bağlantısı zaten açık");
            }

           
        }

        public override void disconnect()
        {
            
            if (isConnecting)
            {
                Console.WriteLine($"Oracle {Version} Veritabanı bağlantı kesildi");
                isConnecting = true;
            }
            else
            {
                Console.WriteLine($"Oracle {Version} bağlantısı zaten kapalı");
            }
        }
    }
}
