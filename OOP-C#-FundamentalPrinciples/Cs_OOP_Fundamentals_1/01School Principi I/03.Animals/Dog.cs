

namespace _03.Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Dog : Animal,ISound
    {
        public Dog(string name, int age, string sex) : base(name,age,sex)
        {

        }
        public void MakeSound()
        {
            Console.WriteLine("{0}- Woof!",this.Name);
        }
    }
}
