using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capsulation
{
     class Capsulation
    {
        private string username = "root", password = "admin", mark = new string('-',6), LoginName;
            public string checkName
        {
            get
            {
                return username;
            }
        }
        public string checkPassword
        {
            get
            {
                return password;
            }
        }
        public string setLoginName
        {
            set
            {
                LoginName = value;
            }
        }
        public void dbLogin()
        {
            Console.WriteLine("{0}\n< Database Bağlantısı Oluştu >\n{1}", mark, mark);
            Console.WriteLine("-> Bağlantı sağlayan kişi: {0}\n-> Bağlantı sağlanan zaman : {1}\n{2}", LoginName, DateTime.Now.ToString("dd/MM/yyyy HH:mm"), mark);
        }

    }
}
