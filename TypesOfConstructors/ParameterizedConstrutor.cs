using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesOfConstructors
{
    public class ParameterizedConstrutor
    {
        public int Rollno;
        public string Name;
        public ParameterizedConstrutor(int rollno,String name)
        {
            this.Rollno = rollno;
            this.Name = name;

        }
        public void Display()
        {
            Console.WriteLine("Name : " +Name + " Roll no : " +Rollno);
        }
    }
}
