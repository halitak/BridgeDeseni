using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDeseni
{
    abstract class DbImplementor
    {
        public abstract void Execute(string sql);
        public abstract void OpenCon(string sqlCon);
    }
}
