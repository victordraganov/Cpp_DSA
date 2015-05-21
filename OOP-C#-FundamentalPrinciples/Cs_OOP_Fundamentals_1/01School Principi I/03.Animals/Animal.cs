using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Animals
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }

        public Animal(string name, int age, string sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }
        public Animal()
        {
            this.Name = "Puhi";
            this.Age = 2;
            this.Sex = "male";
        }
        public static double GetAverageAge(Animal[] animals)
        {
            double average = 0;
            foreach (var animal in animals)
            {
                average += animal.Age;
            }

            return average/animals.Length;
        }
    }
}
