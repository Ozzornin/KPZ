using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class DatabaseRepository
    {
        private static readonly DatabaseRepository instance = new DatabaseRepository();

        static DatabaseRepository() { }

        private DatabaseRepository() { }

        public static DatabaseRepository GetInstance
        {
            get { return instance; }
        }

        public void DBConnect()
        {
            Console.WriteLine("Connected :)");
        }

        public int getSomethingFromDb()
        {
            return 2312122 ;
        }
    }
}
