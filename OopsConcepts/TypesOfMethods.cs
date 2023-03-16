using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    //Types of Methods
    // 1.Virtual method
    public class TypesOfMethod
    {
        public void Virtual()
        {
            Console.WriteLine("calling to instance method");
        }
        public void TakeReference()
        {
            this.Virtual();   // Calling to instance method
        }

        // 2. Static method
        public static int StaticMethod()
        {
            return 2;
        }
    }
}
