using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    internal class Overloading
    {
        public int Add(int a,int b)
        {
            return a+b;
        }
        public void Add(float a,int c,int d)
        {
            Console.WriteLine("a+c+d :"+a+c+d);
        }
        public void Add(double b,float c,int a)
        {
            Console.WriteLine("b+c+a:{0}",b+c+a);
        }
    }
}
