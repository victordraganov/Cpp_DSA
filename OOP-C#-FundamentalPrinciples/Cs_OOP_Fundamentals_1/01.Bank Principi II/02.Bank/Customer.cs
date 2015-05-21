using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bank
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    abstract class Customer
    {
        private string name;
        public string Name { get; set; }

        private string iDNumber;
        public string IDNumber { get; set; }
    }
}
