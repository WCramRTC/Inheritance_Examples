using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Examples
{
    internal class Air : Vehicle
    {


        public override string Move()
        {
            return $"{GetType().Name} flys";
        }

        public string Fly()
        {
            return "Flying";
        }

    }
}
