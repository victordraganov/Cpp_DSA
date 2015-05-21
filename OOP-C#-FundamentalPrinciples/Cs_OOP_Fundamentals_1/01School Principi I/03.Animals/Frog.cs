namespace _03.Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Frog : Animal,ISound
    {
        public Frog(string name, int age, string sex) : base(name,age,sex)
        {

        }
        public void MakeSound()
        {
            Console.WriteLine("{0}- Ribit!",this.Name);
        }
    }
}
