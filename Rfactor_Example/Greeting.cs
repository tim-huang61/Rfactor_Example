using System;
using System.Collections.Generic;

namespace Rfactor_Example
{
    public class Greeting
    {
        private List<IGreetingRule> _greetingRules = new List<IGreetingRule>
        {
            new MorningGreetingRule(),
            new AfternoonGreetingRule(),
            new NightGreetingRule()
        };

        public string GetFirstGreeting(string user)
        {
            return "Hi, " + user + ". ";
        }

        public string GetSecondGreeting(int hour)
        {
            foreach (var greetingRule in _greetingRules)
            {
                if (greetingRule.IsRight(hour))
                {
                    return greetingRule.GetGreeting();
                }
            }

            throw new ArgumentOutOfRangeException();
        }
    }
}