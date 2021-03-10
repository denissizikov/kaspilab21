using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datatype.dto
{
    public abstract class AManager : Employee, IManager
    {
        public abstract void Manage();
    }
}
