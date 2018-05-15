namespace Rfactor_Example
{
    public interface IGreetingRule
    {
        string GetGreeting();

        bool IsRight(int hour);
    }
}