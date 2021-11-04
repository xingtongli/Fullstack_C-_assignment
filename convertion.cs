using System;

namespace convertion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int century;
            Console.WriteLine("Please input the number of century you want to enter: ");
            input = Console.ReadLine();
            century = Convert.ToInt32(input);
            int year = century * 100;
            int day = (int)(year*365.2422);
            int hour = day * 24;
            long minute = hour * 60;
            long second = minute * 60;
            ulong millisecond = (ulong)(second * 1000);
            ulong microsecond = millisecond * 1000;
            ulong nanosecond = microsecond * 1000;
            Console.WriteLine($"{century} centuries = {year} years = {day} days = {hour} hours = {minute} minutes = {second} seconds = {millisecond} milliseconds = {microsecond} microseconds = {nanosecond} nanoseconds");

         
        }
    }
}
