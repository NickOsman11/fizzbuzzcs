namespace FizzBuzz{

    public abstract class Rule{

        public int ruleNumber;

        public Rule(int ruleNumber)
        {
            this.ruleNumber = ruleNumber;
        }

        protected abstract string ApplyRule(string prevResult);

        public string CheckAndApplyRule(int i, string prevResult)
        {   
            if (i % ruleNumber == 0){
                return ApplyRule(prevResult);
            }
            return prevResult;

        }


    }
}
