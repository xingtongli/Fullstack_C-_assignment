using System;

namespace _02UnderstandingTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int obyte = 1;
            int tbyte = 2;
            int fbyte = 4;
            int ebyte = 8;
            byte b_min = byte.MinValue;
            byte b_max = byte.MaxValue;
            Console.WriteLine($"byte type has {obyte} byte, and range is {b_min} to {b_max}.");
            short s_min = short.MinValue;
            short s_max = short.MaxValue;
            Console.WriteLine($"short type has {tbyte} byte, and range is {s_min} to {s_max}.");
            int i_min = int.MinValue;
            int i_max = int.MaxValue;
            Console.WriteLine($"int type has {fbyte} byte, and range is {i_min} to {i_max}.");
            long l_min = long.MinValue;
            long l_max = long.MaxValue;
            Console.WriteLine($"long type has {ebyte} byte, and range is {l_min} to {l_max}.");
            sbyte sb_min = sbyte.MinValue;
            sbyte sb_max = sbyte.MaxValue;
            Console.WriteLine($"sbyte type has {obyte} byte, and range is {sb_min} to {sb_max}.");
            ushort us_min = ushort.MinValue;
            ushort us_max = ushort.MaxValue;
            Console.WriteLine($"ushort type has {tbyte} byte, and range is {us_min} to {us_max}.");
            uint ui_min = uint.MinValue;
            uint ui_max = uint.MaxValue;
            Console.WriteLine($"uint type has {fbyte} byte, and range is {ui_min} to {ui_max}.");
            ulong ul_min = ulong.MinValue;
            ulong ul_max = ulong.MaxValue;
            Console.WriteLine($"ulong type has {ebyte} byte, and range is {ul_min} to {ul_max}.");
            float f_min = float.MinValue;
            float f_max = float.MaxValue;
            Console.WriteLine($"float type has {fbyte} byte, and range is {f_min} to {f_max}.");
            double d_min = double.MinValue;
            double d_max = double.MaxValue;
            Console.WriteLine($"double type has {ebyte} byte, and range is {d_min} to {d_max}.");
            decimal de_min = decimal.MinValue;
            decimal de_max = decimal.MaxValue;
            Console.WriteLine($"decimal type has 16 byte, and range is {de_min} to {de_max}.");
        }
    }
}
