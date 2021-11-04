using System;

namespace greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime morning = new DateTime(2000, 1, 1, 7, 0, 0);
            DateTime afternoon = new DateTime(2000, 1, 1, 12, 0, 0);
            DateTime evening = new DateTime(2000, 1, 1, 18, 0, 0);
            DateTime night = new DateTime(2000, 1, 1, 21, 0, 0);
            
            DateTime cur = DateTime.Now;

            if (cur.TimeOfDay > morning.TimeOfDay && cur.TimeOfDay<afternoon.TimeOfDay)
            {
                Console.WriteLine("Good Morning");
            }
            if (cur.TimeOfDay > afternoon.TimeOfDay && cur.TimeOfDay < evening.TimeOfDay)
            {
                Console.WriteLine("Good Afternoon");
            }
            if (cur.TimeOfDay > evening.TimeOfDay && cur.TimeOfDay < night.TimeOfDay)
            {
                Console.WriteLine("Good Evening");
            }
            if (cur.TimeOfDay < morning.TimeOfDay || cur.TimeOfDay > night.TimeOfDay)
            {
                Console.WriteLine("Good Night");
            }

        }
    }
}
