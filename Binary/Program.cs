using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(IsLeftMostBitSet(0x32));
            Console.WriteLine(IsRightMostBitSet(0x01));
            Console.WriteLine(IsBitSet(0x16, 0x01 << 4));
            Console.WriteLine(GetRightMostSetBit(0x01));
            PrintInventory(0x43);
            
            Console.ReadKey();
        }

        static bool IsLeftMostBitSet(uint value)
        {
            if ((value & 0x32) == 0x32)
            {
                return true;
            }else
            {
                return false;
            }
        }

        static bool IsRightMostBitSet(uint value)
        {
            if ((value & 0x01) == 0x01)
            {
                return true;
            }else
            {
                return false;
            }
        }

        static bool IsBitSet(uint value, byte bit_to_check)
        {
            if((value & bit_to_check) == bit_to_check)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        static int GetRightMostSetBit(uint value)
        {
            if ((value & 0x01) == 0x01)
                return 0;

            else if ((value & 0x01 << 1) == 0x01 << 1)
                return 1;

            else if ((value & 0x01 << 2) == 0x01 << 2)
                return 2;

            else if ((value & 0x01 << 3) == 0x01 << 3)
                return 3;

            else if ((value & 0x01 << 4) == 0x01 << 4)
                return 4;

            else if ((value & 0x01 << 5) == 0x01 << 5)
                return 5;

            else if ((value & 0x01 << 6) == 0x01 << 6)
                return 6;

            else if ((value & 0x01 << 7) == 0x01 << 7)
                return 7;

            return -1;
        }

        
        static void PrintInventory(byte value)
        {
            if ((value & 0x01) == 0x01)
                Console.Write("1");
            else
                Console.Write(0);

            if ((value & 0x01 << 7) == 0x01 << 7)
                Console.Write("1");
            else
                Console.Write(0);

            if ((value & 0x01 << 6) == 0x01 << 6)
                Console.Write("1");
            else
                Console.Write(0);

            if ((value & 0x01 << 5) == 0x01 << 5)
                Console.Write("1");
            else
                Console.Write(0);

            if ((value & 0x01 << 4) == 0x01 << 4)
                Console.Write("1");
            else
                Console.Write(0);

            if ((value & 0x01 << 3) == 0x01 << 3)
                Console.Write("1");
            else
                Console.Write(0);

            if ((value & 0x01 << 2) == 0x01 << 2)
                Console.Write("1");
            else
                Console.Write(0);

            if ((value & 0x01 << 1) == 0x01 << 1)
                Console.Write("1");
            else
                Console.Write(0);
        }


    }
}
