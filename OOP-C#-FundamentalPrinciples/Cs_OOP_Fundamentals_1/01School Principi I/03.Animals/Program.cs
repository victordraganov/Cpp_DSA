//03.Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are Animals. All animals can 
//   produce sound (specified by the ISound interface). Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be
//   only female and tomcats can be only male. Each animal produces a specific sound. Create arrays of different kinds of animals and calculate the 
//   average age of each kind of animal using a static method (you may use LINQ).

namespace _03.Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main()
        {
            Kitten kitty = new Kitten("Sisi",1);
            kitty.MakeSound();
            Dog dog = new Dog("Rex", 3, "male");
            dog.MakeSound();

            Kitten[] kittens = new Kitten[3];
            kittens[0] = kitty;
            kittens[1] = new Kitten("Polly", 2);
            kittens[2] = new Kitten("Muffin", 1);
            Console.WriteLine("Average kittens age: {0}",Animal.GetAverageAge(kittens));

            Dog[] doggs = new Dog[3];
            doggs[0] = dog;
            doggs[1] = new Dog("Alex", 2, "male");
            doggs[2] = new Dog("Maya", 8, "female");
            Console.WriteLine("Average doggs age: {0}",Animal.GetAverageAge(doggs));

            //and so on with all animals...
        }
    }
}
