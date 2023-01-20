using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Examples
{
    // Car - Vehicle, object
    internal class Car : Vehicle
    {

        public override string Move()
        {
            return $"{GetType().Name} drives";
        }

        public string Drive()
        {
            return "Driving";
        }

    }
}
