using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    public abstract class Shape
    {
        public abstract void Show();
    }
    public class Rectangle : Shape
    {
        public override void Show()
        {
            Console.WriteLine("Draw Rectangle");
        }
    }
    public class Square : Shape
    {
        public override void Show()
        {
            Console.WriteLine("Draw Square");
        }
    }
}
