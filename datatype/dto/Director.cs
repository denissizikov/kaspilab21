using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datatype.dto
{
    public class Director : AManager
    {
        public override void Manage()
        {
            Console.WriteLine("Give em orders");
        }

        public override void Work()
        {
            Manage();
        }
    }
}
