using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDeseni
{
    abstract class DbAbstraction
    {
        protected DbImplementor implementor;
        public DbAbstraction(DbImplementor imp)
        {
            implementor = imp;
        }
        public DbImplementor Implementor
        {
            set
            {
                implementor = value;
            }
        }
        public abstract void Exec(string sql);
        public abstract void ConOpen(string conStr);
    }
}
