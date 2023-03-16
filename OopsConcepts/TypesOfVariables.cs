using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
     class TypesOfVariables
    {
        int a = 12; //instance variable
        public double d = 3.4;
        public static int salary = 9000; //static variable
        public static string name;
        public const float max = 9.7f; //const variable
        public readonly int value; //readonly variable
        public void Display()
        {
            int b = 10; //local variable 
            Console.WriteLine("integer {0}, {1}: " ,a,b);
           
        }
    }
}
