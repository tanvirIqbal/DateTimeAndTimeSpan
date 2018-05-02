using System;

namespace DateTimeAndTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTimeExample();
            TimeSpanExample();
        }

        // Represent Exact Date Time
        public static void DateTimeExample()
        {
            DateTime dateTime = new DateTime(1989,3,28,10,30,45);
            System.Console.WriteLine(dateTime); // 3/28/1989 10:30:45 AM

            System.Console.WriteLine(DateTime.Now); // 5/2/2018 10:15:39 AM
            System.Console.WriteLine(DateTime.Today); //5/2/2018 12:00:00 AM

            System.Console.WriteLine(dateTime.Hour); // 10
            System.Console.WriteLine(dateTime.Minute); // 30
            System.Console.WriteLine(dateTime.Second); // 45

            System.Console.WriteLine(dateTime.ToLongDateString()); // Tuesday, March 28, 1989
            System.Console.WriteLine(dateTime.ToShortDateString()); // 3/28/1989
            System.Console.WriteLine(dateTime.ToLongTimeString()); // 10:30:45 AM
            System.Console.WriteLine(dateTime.ToShortTimeString()); // 10:30 AM
            System.Console.WriteLine(dateTime.ToString("dd MMM yyyy")); // 28 Mar 1989
        }

        public static void TimeSpanExample()
        {
            // Creating
            TimeSpan timeSpan = new TimeSpan(1,2,3); // hour, minute, second
            System.Console.WriteLine(timeSpan); // 01:02:03

            DateTime dateTime1 = new DateTime(1989,3,28,10,30,45);
            DateTime dateTime2 = new DateTime(1989,3,28,10,45,45);
            TimeSpan diffDateTime = dateTime2 - dateTime1;
            System.Console.WriteLine(diffDateTime); // 00:15:00

            // Properties
            System.Console.WriteLine(timeSpan.Hours); // 1
            System.Console.WriteLine(timeSpan.Minutes); // 2
            System.Console.WriteLine(timeSpan.Seconds); // 3
            System.Console.WriteLine(timeSpan.TotalHours); // 1.03416666666667
            System.Console.WriteLine(timeSpan.TotalMinutes); // 62.05
            System.Console.WriteLine(timeSpan.TotalSeconds); // 3723

            // Add, Subtract
            System.Console.WriteLine(timeSpan.Add(TimeSpan.FromMinutes(8))); // 01:10:03
            System.Console.WriteLine(timeSpan.Subtract(TimeSpan.FromMinutes(2))); // 01:00:03

            // Parse
            System.Console.WriteLine(TimeSpan.Parse("02:30:50")); //02:30:50
        }
    }
}
