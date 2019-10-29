using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary
{
    class Program
    {
        const byte Question1a = 0x10 >> 1;
        const byte Question1b = 0x15 << 1;
        const byte Question1c = 0x01 << 4;

        static void Main(string[] args)
        {
            Console.WriteLine(GetRightMostSetBit(4));
            //Console.WriteLine(Question1b);
            //Console.WriteLine(Question1c);
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

        static bool IsBitSet(int value, char bit_to_check)
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

        static int GetRightMostSetBit(int value)
        {
            if ((value & 0x01) == 0x01)
                return 0;

            if ((value & 0x02) == 0x02)
                return 1;

            if ((value & 0x04) == 0x04)
                return 2;

            if ((value & 0x08) == 0x08)
                return 3;

            if ((value & 0x10) == 0x10)
                return 4;

            if ((value & 0x20) == 0x20)
                return 5;

            if ((value & 0x40) == 0x40)
                return 6;

            if ((value & 0x80) == 0x80)
                return 7;

            return -1;
        }

        static public void PrintInventory(byte value)
        {
            if ((value & 0x01) == 0x01)
                Console.Write(value);

            if ((value & 0x01 << 1) == 0x01 << 1)
                Console.Write(value);

            if ((value & 0x01 << 2) == 0x01 << 2)
                Console.Write(value);

            if ((value & 0x01 << 3) == 0x01 << 3)
                Console.Write(value);

            if ((value & 0x01 << 4) == 0x01 << 4)
                Console.Write(value);

            if ((value & 0x01 << 5) == 0x01 << 5)
                Console.Write(value);

            if ((value & 0x01 << 6) == 0x01 << 6)
                Console.Write(value);

            if ((value & 0x01 << 7) == 0x01 << 7)
                Console.Write(value);

        }


    }
}
