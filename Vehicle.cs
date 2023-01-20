using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Examples
{
    internal class Vehicle
    {

        public string engine = "Steam Powered";

        // virtual - this allows child objects to override our method
        public virtual string Move()
        {
            return $"{GetType().Name} moves";
        }

    }
}
