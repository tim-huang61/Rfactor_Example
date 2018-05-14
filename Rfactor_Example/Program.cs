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
            string result;
            var calendar = new TaiwanCalendar();
            var hour = calendar.GetHour(dateTime);
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

            result = "Hi, " + user + ". " + result;

            return result;
        }
    }
}