using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    internal interface Fruits //interface class
    {
        public void Draw(); //abstract methos which has no body
    }
    public class Orange : Fruits //inheriot class
    {
        public void Draw()   //inherit method 
        {
            Console.WriteLine("Orange...");
        }
    }
    public class Apple : Fruits
    {
        public void Draw()
        {
            Console.WriteLine("Apple....");
        }
    }
}
