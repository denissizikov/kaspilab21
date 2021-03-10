using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datatype.dto
{
    class BigBoss : Employee, ISuperManager
    {
        public void Manage()
        {
            Supermanage();
        }

        public void Supermanage()
        {
            Console.WriteLine("Do greate manager job");
        }

        public override void Work()
        {
            Manage();
        }
    }
}
