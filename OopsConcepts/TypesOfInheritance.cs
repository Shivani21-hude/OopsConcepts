using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    //Single Inheritance
    public class CreditCard
    {
        public string name;
        public void Credit()
        {
            Console.WriteLine("balance is credeted");
        }
    }
    public class DebitCard : CreditCard
    {
        public void Debit()
        {
            name = "Shivani";
            Console.WriteLine("Balance is debeted");
            Console.WriteLine("Name : "+ name);
        }
    }
    // Hierarchical Inheritance
    public class A
    {
        public string Msg()
        {
            return "This is A class";
        }
    }
    public class B : A
    {
        public string GetMsg()
        {
            Msg();
            return "This is B class";
        }
    }

        public class C : A
        {
            public string GeTinfo()
            {
                Msg();
                return "This is B class";
            }
        }
    

    //Multiple inheritance

    public interface Mobile
    {
        public void PhoneModel();
        
    }
    public interface SmartPhone
    {
        public void MobileModel();
       
    }
    public class SmartWatch : Mobile, SmartPhone 
    { 
        public void WatchModel()
        {
           
            Console.WriteLine("Apple ");
        }
        public void PhoneModel()
        {
            Console.WriteLine("Nokia");
        }
        public void MobileModel()
        {
         Console.WriteLine("Redmi note 8 pro");
        }
    }

    //Multilevel inheritance
    public class People
    {
        public void TotalPeople()
        {
            Console.WriteLine("their are 20 peoples");
        }
    }
        public class Men:People
        {
            public void TotalMen()
            {
                Console.WriteLine("Their are 10 mens");
            }
        }
        public class Womens : Men
        {
            public void TotalWomens()
            {
                Console.WriteLine("Their are 10 womens");
            }
        }
}

