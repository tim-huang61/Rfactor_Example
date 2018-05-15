namespace Rfactor_Example
{
    public class NightGreetingRule : IGreetingRule
    {
        public string GetGreeting()
        {
            return "Good night!";
        }

        public bool IsRight(int hour)
        {
            return hour >= 19 && hour < 6;
        }
    }
}