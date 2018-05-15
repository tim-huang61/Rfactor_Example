namespace Rfactor_Example
{
    public class Greeting
    {
        public string GetFirstGreeting(string user)
        {
            return "Hi, " + user + ". ";
        }

        public string GetSecondGreeting(int hour)
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