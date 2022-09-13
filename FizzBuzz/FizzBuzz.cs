using System.Text.RegularExpressions;

namespace FizzBuzz
{
    public class FizzBuzz
    {

        List<Rule> listOfRules = new List<Rule>{ 
            new Rule3()
        };

        public void FizzBuzzFor(int i)
        {    
            string result = "";
            foreach (Rule rule in listOfRules)
            {
                result = rule.CheckAndApplyRule(i, result);
            }

            if (result == "")
            {
                result = i.ToString();
            }
            
            Console.WriteLine(result);
        }
    }
}