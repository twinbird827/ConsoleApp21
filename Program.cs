using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                C();
            }
            catch (Exception e)
            {
                Output(e, "Main message");
            }
            Console.Read();
        }

        static void Output(Exception e, string message)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(message);
            Console.WriteLine("*****");
            Console.WriteLine(e.Message);
            Console.WriteLine("*****");
            Console.WriteLine(e.ToString());
        }

        static void A()
        {
            throw new Exception("A exception");
        }

        static void B()
        {
            try
            {
                A();
            }
            catch (Exception e)
            {
                Output(e, "B message");
                throw new Exception("B exception", e);
            }
        }

        static void C()
        {
            try
            {
                B();
            }
            catch (Exception e)
            {
                Output(e, "C message");
                throw new Exception("C exception", e);
            }
        }
    }
}
