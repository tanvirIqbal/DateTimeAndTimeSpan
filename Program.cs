using System;

namespace DateTimeAndTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTimeExample();
        }

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
    }
}
