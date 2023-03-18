using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesModifiers
{
    // public modifier
    public class PublicTest
    {
        public string Name; // the code is accessible anywhere
        public void Public()
        {
            Name = "Shivani";
            Console.WriteLine("Name : " + Name);
        }
    }

    //private modifier
    public class PrivateTest
    {
        private double salary; // the code is accessible within class only
      
       public void Private()
        {
            salary = 2000;
            Console.WriteLine("Salary : " +salary);
        }
    }
   
    //internal  modifier
    public class InternalTest
    {
        internal string name = "Vishakha"; //the code is accessible within the same project only
        public  void Internal()
        {
          
            Console.WriteLine("name : " + name);
        }
    }

    //protected modifier
    class ProtectedTest
    {
        protected double salary=2000; // the code is accessible with in the class or with in child class by inheritance
        public void Protect()
        {
            Console.WriteLine("salary : " +salary);
        }
    }
    class Test : ProtectedTest
    {
       public void TestProtect()
        {
            Console.WriteLine("...");
        }
    }
    
    // protected internal modifier 
    class ProtectedInternalTest
    {
        //the code is accible with ihe current project or derived from the contanining class
        protected internal string name = "Vrutik";
        protected internal void Msg()
        {
            Console.WriteLine("name : " +name);
        }
    }

}
