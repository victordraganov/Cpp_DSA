// 02.Define abstract class Human with first name and last name. Define new class Student which is derived from Human and has new field – grade. 
//   Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns money earned 
//   by hour by the worker. Define the proper constructors and properties for this hierarchy. Initialize a list of 10 students and sort them by 
//   grade in ascending order (use LINQ or OrderBy() extension method). Initialize a list of 10 workers and sort them by money per hour in descending
//   order. Merge the lists and sort them by first name and last name.

namespace _02StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<Worker> workers = new List<Worker>();

            workers.Add(new Worker());
            workers.Add(new Worker("Krasi", "Momchilov", 75, 7));
            workers.Add(new Worker("Rusi", "Milev", 450, 7));
            workers.Add(new Worker("Petyr", "Tishev", 65, 6));
            workers.Add(new Worker("Ivan", "Nedqlkov", 200, 8));
            workers.Add(new Worker("Momchil", "Dimitrev", 140, 6));
            workers.Add(new Worker("Manol", "Conchev", 35, 4));
            workers.Add(new Worker("Radian", "Manev", 250, 5));
            workers.Add(new Worker("Deqn", "Stilov", 90, 6));
            workers.Add(new Worker("Atanas", "Kostadinov", 185, 5));
            workers.Add(new Worker("Kyci", "Kolev", 75, 8));

            Worker.SortByMoneyPH(workers);
            Console.WriteLine(new string('-', 25));
            List<Student> students = new List<Student>();

            students.Add(new Student());
            students.Add(new Student("Misho", "Starchev", 4.23));
            students.Add(new Student("Sasho", "Stoilov", 5.23));
            students.Add(new Student("Vicho", "Starchev", 6.00));
            students.Add(new Student("Vasko", "Velikov", 4.55));
            students.Add(new Student("Aleksandyr", "Kolev", 4.68));
            students.Add(new Student("Mihail", "Ivanov", 5.25));
            students.Add(new Student("Ahmed", "Dimov", 5.50));
            students.Add(new Student("Ivailo", "Tonev", 3.80));
            students.Add(new Student("Misho", "Radev", 3.20));

            Student.SortByGrade(students);
            Console.WriteLine(new string('-', 25));

            var merged = workers.Concat<Human>(students);
            merged = merged.OrderBy(human => human.FirstName).ThenBy(human => human.LastName);

            foreach (var human in merged)
            {
                Console.WriteLine(String.Format("{0} {1}",human.FirstName,human.LastName));
            }
        }
    }
}
