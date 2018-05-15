namespace Rfactor_Example
{
    public class AfternoonGreetingRule: IGreetingRule
    {
        public string GetGreeting()
        {
            return "Good afternoon!";
        }

        public bool IsRight(int hour)
        {
            return hour >= 6 && hour < 19;
        }
    }
}