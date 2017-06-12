using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDeseni
{
    class Program
    {
        static void Main(string[] args)
        {
            DbAbstraction absDb = new DbRefinedAbstraction(new SqlServerImplementor());
            absDb.ConOpen("e-ticaret Db");
            absDb.Exec("select*from urun");
            absDb = new DbRefinedAbstraction(new OracleImplementor());
            absDb.ConOpen("e-ticaret Db");
            absDb.Exec("select*from urun");

            Console.ReadKey();
        }
    }
}
