using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsInheritance
{
    internal class Engine
    {
        public string engineNumber { get; set; }

        public Engine(string number)
        {
            engineNumber = number;
        }
    }
}
