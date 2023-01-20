using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Examples
{
    internal class Boat : Vehicle
    {
        //public string powered = "Wind";

        public override string Move()
        {
            return $"{GetType().Name} floats";
        }

        public string Float()
        {
            return "Floating";
        }
    }
}
