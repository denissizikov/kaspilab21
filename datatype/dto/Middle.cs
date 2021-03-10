using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datatype.dto
{
    public class Middle : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Middle is Working");
        }

        public void Plan()
        {
            Console.WriteLine("Middle is planning");
        }
    }
}
