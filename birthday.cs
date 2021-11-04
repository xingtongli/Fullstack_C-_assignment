using System;

namespace birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            int month;
            int day;
            Console.WriteLine("Enter the year");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the month");
            month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the day");
            day = int.Parse(Console.ReadLine());
            DateTime today = DateTime.Today;
            DateTime birthday = new DateTime(year,month,day,0,0,0);
            double totaldays = (today - birthday).TotalDays;
            Console.WriteLine($"The total days age is {totaldays}.");
            double daysToNextAnniversary = 10000 - (totaldays % 10000);
            Console.WriteLine($"There are {daysToNextAnniversary} to the next 10000 days anniversary.");
        }
    }
}
