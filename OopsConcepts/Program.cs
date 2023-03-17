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
            
            Console.WriteLine("Choose given option : \n1) Class and opbject concept \n2) Inheritance example \n3) Polymorphism exapmle with their type0s \n" +
                "4) Encapsulation Example \n5) Abstraction Example \n6)Types of variables \n7) Types of methods \n8) Value types Ad Reference types " +
                "\n9)Types of Inheritance" );
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
                case 4:
                    EncapsulationExample example = new EncapsulationExample();
                    example.Employee();
                   string Name = "Shivani";
                    example.Display();
                    break;
                case 5:
                    Shape shape = new Rectangle();
                    shape.Show();
                    shape = new Square();
                    shape.Show();
                    break;
                case 6:
                    TypesOfVariables types = new TypesOfVariables();
                    types.Display();
                    Console.WriteLine("instance variable : " +types.d);
                    TypesOfVariables.name = "Shivani";
                    Console.WriteLine("Name :"+ TypesOfVariables.name + "  Salary : " + TypesOfVariables.salary); //static field directly call class
                    Console.WriteLine("const variable : " + TypesOfVariables.max); //const also a static field
                    Console.WriteLine("readonly variable : " +types.value);
                    break;
                case 7:
                    Console.WriteLine("Virtual method ===>");
                   TypesOfMethod method=new TypesOfMethod(); //for to call virtual method ,object is to create
                    method.TakeReference();
                    Console.WriteLine("Static Method ===>");
                    Console.WriteLine("return value " +TypesOfMethod.StaticMethod());
                    break;

                case 8:
                    Console.WriteLine(" \n *** Value Type ***");
                    ValueType.Value_Type();
                    Console.WriteLine("\n *** Reference Type ***");
                    ReferenceType.TypeReference();
                    break;

                case 9:
                    Console.WriteLine("\n *** Single Inheritance ***");
                    DebitCard card = new DebitCard();
                    card.Credit();
                    card.Debit();
                    Console.WriteLine("\n *** Hierarchical Inheritance ***");
                    B b = new B();
                    Console.WriteLine( b.Msg());
                    Console.WriteLine(b.GetMsg());
                    C c = new C();
                    Console.WriteLine(c.Msg());
                    Console.WriteLine(c.GeTinfo());
                    Console.WriteLine("\n ** Multiple Inheritance **");
                    SmartWatch smartWatch = new SmartWatch();
                    smartWatch.PhoneModel();
                    smartWatch.MobileModel();
                    smartWatch.WatchModel();
                    Console.WriteLine(" \n ** Multilevel Inheritance ** ");
                    Womens womens = new Womens();
                    womens.TotalPeople();
                    womens.TotalMen();
                    womens.TotalWomens();
                    break;

            }

        }
    }
}