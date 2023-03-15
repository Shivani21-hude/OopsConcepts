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
            
            Console.WriteLine("Choose given option : \n1) Class and opbject concept \n2) Inheritance example \n3) Polymorphism exapmle with their types" );
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
                    Console.WriteLine("carname :" + inherit.modelname + "2]" + car.modelname + "Brand name :" + inherit.Brand);
                    break;
               case 3:
                    Console.WriteLine("Overloading example :");
                    Overloading overloading=new Overloading();
                    Console.WriteLine( "a+b :" + overloading.Add(2,3));
                    overloading.Add(3.3f,4,5);
                    overloading.Add(3.8, 2.1f, 4);
                    Console.WriteLine("\n Overriding Example :");
                    Animal animal = new Animal();
                    animal.Run();
                    animal = new Lion();
                    animal.Run();
                    break;
            }

        }
    }
}