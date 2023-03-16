using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    internal class EncapsulationExample
    {
        private double Salary;
        public string Name;
        public void Employee()
        {
            Salary = 90000;
            Name="Shivani";

        }
        public void Display()
        {
            Console.WriteLine("salary: "+ Salary + " Name :" +Name);
        }
    }
}
