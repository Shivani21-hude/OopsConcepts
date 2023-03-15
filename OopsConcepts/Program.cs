using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            
            Console.WriteLine("Choose given option : \n1) Class and opbject concept \n2) Inheritance example" );
            int option=Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    //call the method
                    //Create a object of class ObjectAndClassConcept
                    ObjectAndClassConcept obj = new ObjectAndClassConcept();
                    obj.Addition();
                    ObjectAndClassConcept.Substraction();
                    break;
                case 2:
                   Twowheeler inherit = new Twowheeler();
                    Car car = new Car();
                    inherit.Hock();
                    Console.WriteLine("carname :" + inherit.modelname + "2]" + car.modelname + "Brand name :"  inherit.Brand);
                    break;
            }
        }
    }
}