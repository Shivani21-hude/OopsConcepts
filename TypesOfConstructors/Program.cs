using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesOfConstructors
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ** Default Constructor **");
           DefaultConstructorexample E1 = new DefaultConstructorexample();
            Console.WriteLine("\n ** Parameterized consrtuctor **");
            ParameterizedConstrutor e1 = new ParameterizedConstrutor(2,"Shivani");
            e1.Display();

        }
    }
}