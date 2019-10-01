using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary
{
    class Program
    {
        //const byte Test = 1111 | 1111;
        const byte Question1a = 0x10 >> 1;
        const byte Question1b = 0x15 << 1;
        const byte Question1c = 0x01 << 4;
        
        //const byte Question1d = ;

        //const byte Question2a = ;
        static void Main(string[] args)
        {
            Console.WriteLine(Question1a);
            Console.WriteLine(Question1b);
            Console.WriteLine(Question1c);
            //Console.WriteLine(Test);
            //Console.WriteLine(Question2a);
            Console.ReadKey();
        }
    }
}
