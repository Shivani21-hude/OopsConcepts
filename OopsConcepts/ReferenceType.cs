using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    public class Student
    {
        public string name { get; set; }
        public int Id { get; set; }
    }

    //Unlike value types, a reference type doesn't store its value directly. Instead, it stores the address where the value is being stored.
    internal class ReferenceType
    {
        public static void TypeReference()
        {

            Student student = new Student();
            student.Id = 102;
            student.name = "Shivani";
            Console.WriteLine("Before modify :" + student.Id + " " + student.name );
            ChangeReferenceType(student);
            Console.WriteLine("After modify : " +student.Id + " " + student.name);
        }
        public static void ChangeReferenceType(Student s)
        {
            s.Id = 100;
            s.name = "Shiva";
            Console.WriteLine("Within method : " + s.Id + " " + s.name);
        }

    }
}
