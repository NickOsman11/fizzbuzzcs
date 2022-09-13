namespace FizzBuzz{

    public class Rule3: Rule
    {
        public Rule3(): base(3)
        {
        }

        protected override string ApplyRule(string prevResult)
        {
            return prevResult + "Fizz";
        }
        

    }
}