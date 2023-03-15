using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ***** Welcome to Oops Concepts problems ***** ");
            //Create a object of class ObjectAndClassConcept
            ObjectAndClassConcept obj = new ObjectAndClassConcept();
            Console.WriteLine("Choose given option : \n1)Class and opbject concept ");
            int option=Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    //call the method
                    obj.Addition();
                    ObjectAndClassConcept.Substraction();
                    break;
            }
        }
    }
}