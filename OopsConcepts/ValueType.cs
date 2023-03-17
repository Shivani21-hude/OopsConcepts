using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    //A data type is a value type if it holds a data value within its own memory space.
    //It means the variables of these data types directly contain values.
    internal class ValueType
    {
        public static void Value_Type()
        {

            int x = 100;
            Console.WriteLine("Before modifying the value of x:"+x);
            ChangevalueType(x);
            Console.WriteLine("After modyfying the value of x in the method : " +x);
        }
        public static void ChangevalueType(int x)
        {
             x = 10 + x;
            Console.WriteLine("Within method -x value is " + x);
        }
    }
}
