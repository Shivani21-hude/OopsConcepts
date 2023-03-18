using AccesModifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesOfConstructors
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==> Protect modifier ");
            PublicTest p1 =new PublicTest();
            p1.Public();
            Console.WriteLine(" \n ==> private modifier");
            PrivateTest p2=new PrivateTest();
            p2.Private();
            Console.WriteLine("\n ==> internal modifier");
            InternalTest n = new InternalTest();
            n.Internal();
            Console.WriteLine("\n ==> protect modifier");
            Test test=new Test();
            test.Protect();
            test.TestProtect();
            Console.WriteLine("\n ==> protected internal modifier");
            ProtectedInternalTest p=new ProtectedInternalTest();
            p.Msg();

        }
    }
}