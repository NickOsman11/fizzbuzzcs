using System;

namespace FizzBuzz
{
    class program
    {
        static void Main (String[] args)
        {
            FizzBuzz fizzbuzz = new FizzBuzz();
            for (int i = 1; i < 101; i++) 
            {
                Console.WriteLine(fizzbuzz.FizzBuzzFor(i));
            }
        }
    }
}