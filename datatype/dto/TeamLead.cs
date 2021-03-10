using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datatype.dto
{
    class TeamLead : Employee, IManager
    {
        public void Manage()
        {
            Console.WriteLine("Go CODE!!!");
        }

        public override void Work()
        {
            Console.WriteLine("Tired to manage, code and coffee");
        }
    }
}
