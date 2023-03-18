using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    //Overloading
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
        public void Add(double b,float c,int a,int e)
        {
            Console.WriteLine("b+c+a+e:{0}",b+c+a+e);
        }
    }
    //Overriding example
    public class Animal
    {
        public virtual void Run()
        {
            Console.WriteLine("animals are running");
        }
    }
    class Lion : Animal
    {
        public override void Run()
        {
            Console.WriteLine("Lion is running fast");
        }
    }
}
