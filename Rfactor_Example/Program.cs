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
            var greeting = new Greeting();
            var hour = calendar.GetHour(dateTime);

            return greeting.GetFirstGreeting(user) + greeting.GetSecondGreeting(hour);
        }
    }
}