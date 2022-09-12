namespace FizzBuzz
{
    public class FizzBuzz
    {
        private static bool IsDivisibleBy(int a, int b)
        {
            return a % b == 0;
        }
        public string FizzBuzzFor(int n)
        {
            string output = "";
            if (IsDivisibleBy(n, 3)) 
            {
                output += "Fizz";
            }
            if (IsDivisibleBy(n, 5))
            {
                output += "Buzz";
            }
            if (IsDivisibleBy(n, 7))
            {
                output += "Bang";
            }
            if (IsDivisibleBy(n, 11))
            {
                output = "Bong";
            }


            if (output != "")
            {
                return output;
            }
            return n.ToString();
        }
    }
}