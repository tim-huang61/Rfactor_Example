using System;
using System.Globalization;

namespace Rfactor_Example
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(new HelloWorld().SayHello(DateTime.Now, "Tim"));

            Console.Read();
        }
    }

    public class HelloWorld
    {
        public string SayHello(DateTime dateTime, string user)
        {
            var calendar = new TaiwanCalendar();
            var hour = calendar.GetHour(dateTime);

            return "Hi, " + user + ". " + GetSecondGreeting(hour);
        }

        private static string GetSecondGreeting(int hour)
        {
            string result;
            if (hour >= 6 && hour < 12)
            {
                result = "Good morning!";
            }
            else if (hour >= 6 && hour < 19)
            {
                result = "Good afternoon!";
            }
            else
            {
                result = "Good night!";
            }

            return result;
        }
    }
}