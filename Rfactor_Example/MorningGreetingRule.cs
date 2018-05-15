namespace Rfactor_Example
{
    public class MorningGreetingRule : IGreetingRule
    {
        public string GetGreeting()
        {
            return "Good morning!";
        }

        public bool IsRight(int hour)
        {
            return hour >= 6 && hour < 12;
        }
    }
}