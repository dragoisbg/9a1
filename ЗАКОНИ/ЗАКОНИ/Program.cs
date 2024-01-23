using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЗАКОНИ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            bool a = false;
            
            bool b = false;
            Console.WriteLine((a || b) + "e 0");
            Console.WriteLine(" 0 i 1  ="+( a || !b)+ " e 1");
            Console.WriteLine((!a || b) + " e 1");
            Console.WriteLine((a || b) + " e 0");
           




        }
    }
}
