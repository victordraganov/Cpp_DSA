// WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker. 
namespace _02StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Worker : Human
    {
        private int weekSalary;
        private int workHoursPerDay;

        public int WeekSalary
        {
            get { return this.weekSalary; }
            set { this.weekSalary = value; }
        }

        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set { this.workHoursPerDay = value; }
        }

        public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay) : this()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.weekSalary = weekSalary;
            this.workHoursPerDay = workHoursPerDay;

        }

        public Worker()
        {
            this.FirstName = "Sasho";
            this.LastName = "Sashev";
            this.WeekSalary = 100;
            this.WorkHoursPerDay = 8;
        }

        public double MoneyPerHour()
        {
            double moneyPH= this.weekSalary/ (5*this.workHoursPerDay);

            return moneyPH;
        }
        public static void SortByMoneyPH(List<Worker> workers)
        {
            Console.WriteLine("Sorted by money per hour:");
            var sorted = from worker in workers
                         orderby worker.MoneyPerHour()
                         select worker;
            foreach (var worker in sorted)
            {
                Console.WriteLine(String.Format("{0} {1} - {2}",worker.FirstName,worker.LastName,worker.MoneyPerHour()));
            }
        }
    }
}
