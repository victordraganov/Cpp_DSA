namespace _02StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Student : Human
    {
        private double grade;

        public double Grade
        {
            get { return this.grade; }
            set { this.grade = value; }
        }

        public Student(string firstName, string lastName, double grade) : this()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.grade = grade;
        }

        public Student()
        {
            this.FirstName = "Pesho";
            this.LastName = "Peshev";
            this.grade = 3.50;
        }

        public static void SortByGrade(List<Student> students)
        {
            Console.WriteLine("Sorted by grade:");
            var sorted = from student in students
                         orderby student.grade
                         select student;
            foreach (var student in sorted)
            {
                Console.WriteLine(String.Format("{0} {1} - {2}", student.FirstName, student.LastName, student.Grade));
            }
        }
    }
}
