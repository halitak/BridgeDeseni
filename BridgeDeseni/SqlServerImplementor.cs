using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDeseni
{
    class SqlServerImplementor:DbImplementor
    {
        public override void Execute(string sql)
        {
            Console.WriteLine("{0} - Sql Server işletildi",sql);
        }
        public override void OpenCon(string sqlCon)
        {
            Console.WriteLine("{0} - Sql Con. açıldı", sqlCon);
        }
    }
}
