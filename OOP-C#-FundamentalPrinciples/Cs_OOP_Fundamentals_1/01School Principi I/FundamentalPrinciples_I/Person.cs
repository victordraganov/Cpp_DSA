using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01School
{
    public class Person
    {
        private string name;

        public string Name
        {
            get{return this.name;}
            set { this.name = value; }
        }

         public Person(string name = "Pesho")
       {
         this.Name = name;
       }
    }
}
