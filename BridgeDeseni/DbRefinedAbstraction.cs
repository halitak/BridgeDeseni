using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDeseni
{
    class DbRefinedAbstraction:DbAbstraction
    {
        public DbRefinedAbstraction(DbImplementor imp) : base(imp) {
        
        }
        public override void ConOpen(string conStr)
        {
            implementor.OpenCon(conStr);
        }
        public override void Exec(string sql)
        {
            implementor.Execute(sql);
        }
    }
}
