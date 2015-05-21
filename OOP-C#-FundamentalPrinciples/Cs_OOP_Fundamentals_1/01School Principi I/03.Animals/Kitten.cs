namespace _03.Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Kitten : Cat
    {
        public Kitten(string name,int age)
            : base(name, age, "female")
        {

        }
    }
}
