using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDeseni
{
    class OracleImplementor : DbImplementor
    {
        public override void Execute(string sql)
        {
            Console.WriteLine("{0} - Oracle işletildi", sql);
        }
        public override void OpenCon(string sqlCon)
        {
            Console.WriteLine("{0} - Oracle Con. açıldı", sqlCon);
        }
    }
}
