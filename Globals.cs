using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0305
{
    class Program
    {
        static int x; // global variable-- will be known to every function

        static void Foo()
        {
            x++;
        }
        static void Main(string[] args)
        {
            int y; // local variable-- will be known only to Main. or could be sent as a parameter
            Foo();
            Console.WriteLine(x);
        }
    }
}
