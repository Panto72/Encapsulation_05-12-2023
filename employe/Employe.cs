using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employe
{
    internal class Employe
    {
        public string Name { get; set; }
        public string job_title { get; set; }
        private double salary { get; set; }

        public double setsalary(double salary)
        {
            this.salary = salary;
            return this.salary;
        }
        public void Promotion(string post)
        {
            this.job_title = post;
            Console.WriteLine($"{Name} is Promoted to {this.job_title}");
        }
    }
}
