using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    internal class Vehicle
    {
        public string Brand = "Hero";
        public void Hock()
        {
            Console.WriteLine("tunk...tunk");
        }
    }
    class Car: Vehicle
    {
        public string modelname = "Scarpio";
    }
    class Twowheeler : Vehicle
    {
        public string modelname = "HeroHonda";
    }
}
