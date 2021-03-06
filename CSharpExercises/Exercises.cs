﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    public static class Exercises
    {
        // Example Exercise:
        // Create a method called HelloWorld that returns the following string - "Hello World!"
        public static string HelloWorld()
        {
            return "Hello World!";
        }

        /* Alright - your turn now! */

        // 1. Create a method called SayHello that accepts a string representing a name and returns a welcome message (E.g. "Hello John!")
        public static string SayHello()
        {
            Console.WriteLine("Please enter first name");
            string inputFirst = Console.ReadLine();
            Console.WriteLine($"Hello + {inputFirst}");
            return "Hello " + inputFirst + "!";
        }
        // 2. Create a method called Sum that accepts two integers and returns their sum.

        public static int Sum()
        {
            Console.WriteLine("Please enter the first number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int sum = firstNumber + secondNumber;
            Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is {sum}");
            return sum;
        }
        // 3. Create a method called Divide that accepts two decimals and returns the result of dividing the two numbers as a decimal.

        public static decimal Divide()
        {
            Console.WriteLine("Please enter the first number");
            string stringFirst = Console.ReadLine();
            Console.WriteLine("Please enter second number");
            string stringSecond = Console.ReadLine();
            decimal firstDecimal = decimal.Parse(stringFirst);
            decimal secondDecimal = decimal.Parse(stringSecond);
            decimal result = firstDecimal / secondDecimal;
            Console.WriteLine($"The result of {stringFirst} divided by {stringSecond} is {result}");
            return result;
        }
        // 4. Create a method called CanOpenCheckingAccount that accepts an integer representing a customers age, returning true if the age is greater than or equal to 18, or false if the argument is less than 18.

        public static bool CanOpenCheckingAccount()
        {
            Console.WriteLine("Please enter age");
            int ageInput = Convert.ToInt32(Console.ReadLine());
            if (ageInput >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 5. Create a method called GetFirstName that accepts a string representing a full name (e.g. "John Smith"), and returns only the first name.
        public static string GetFirstName()
        {
            Console.WriteLine("Enter full name");
            string name = Console.ReadLine();
            Console.WriteLine(name.Split(' ').First());
            return name.Split(' ').First();
        }

        // 6. Create a method called ReverseStringHard that accepts a string and returns the string in reverse. (No built in functions allowed)
        public static string ReverseStringHard()
        {
            Console.WriteLine("Enter a string to reverse");
            string hardReverse = Console.ReadLine();
            string output = "";
            for (int i = hardReverse.Length - 1; i >= 0; i--)
            {
                output += hardReverse[i];
            }
            return output;
        }
        // 7. Create a method called ReverseStringEasy that accepts a string and returns the string in reverse. (Using only built in functions)
        public static string ReverseStringEasy()
        {
            Console.WriteLine("Enter a string to reverse");
            string quoteReversed = Console.ReadLine();
            char[] charArray = quoteReversed.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        // 8. Create a method called PrintTimesTable that accepts an integer and returns the times table as a string for that number up to the 10th multiplication.
        /* e.g. 10 should return
         * 10 * 1 = 10
         * 10 * 2 = 20
         * 10 * 3 = 30
         * 10 * 4 = 40
         * 10 * 5 = 50
         * 10 * 6 = 60
         * 10 * 7 = 70
         * 10 * 8 = 80
         * 10 * 9 = 90
         * 10 * 10 = 10 */
        public static string PrintTimesTable()
        {
            Console.WriteLine("Enter a number to display its Times Table");
            int givenNumber = Convert.ToInt32(Console.ReadLine());
            if (givenNumber == 0)
                return "0";
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", givenNumber, i, givenNumber * i);
            }

            return givenNumber.ToString();
        }

        // 9. Create a method called ConvertKelvinToFahrenheit that accepts a double representing a temperature in kelvin and returns a double containing the temperature in Fahrenheit.
        public static double ConvertKelvinToFahrenheit()
        {
            double inputKelvin = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine((((inputKelvin) - 273.15) * 1.80) + 32.00);
            return inputKelvin;
        }

        // 10. Create a method called GetAverageHard that accepts an array of integers and returns the average value as a double. (No built in functions allowed)
        public static double GetAverageHard()
        {
            /*int sum = 0;
            for(int i : array) sum += int;
            return ((double) sum)/array.length;*/

            int[] numbers = new int[7];
            for (int i = 0; i < 7; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                numbers[i] = number;
            }
            double result = numbers.Sum() / numbers.Length;
            Console.WriteLine(result);
            return result;
        }

        
        // 11. Create a method called GetAverageEasy that accepts an array of integers and returns the average value as a double. (Using only built in functions)
        public static double GetAverageEasy()
        {
            int[] numbers = new int[7];
            for (int i = 0; i < 7; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                numbers[i] = number;
            }
            double average = numbers.Average();
            Console.WriteLine(average);
            return average;
        }
        
        // 12. Create a method called DrawTriangle that accepts two integers - number and width and returns a string containing a drawn triangle using the number parameter.
        /* e.g. Number: 8, Width: 8 should return
         * 88888888
         * 8888888
         * 888888
         * 88888
         * 8888
         * 888
         * 88
         * 8 */

        // 13. Create a method called GetMilesPerHour that accepts a double representing distance and three integers representing hours, minutes and seconds. The method should return the speed in MPH rounded to the nearest whole number as a string. (e.g. "55MPH")


        // 14. Create a method called IsVowel that accepts a char parameter and returns true if the parameter is a vowel or false if the parameter is a consonant.
        
        
        // 15. Create a method called IsConsonant that accepts a char parameter and returns true if the parameter is a consonant or false if the parameter is a vowel.
        
        
        // 16. The Collatz conjecture, named after Lothar Collatz of Germany, proposed the following conjecture in 1937. 
        // Beginning with an integer n > 1, repeat the following until n == 1. If n is even, halve it. If n is odd, triple it and add 1. Following these steps, the function will always arrive at the number 1.
        // Create a method called CollatzConjecture that accepts an integer and returns the number of steps required to get to n == 1 as an integer.

        
        
        // 17. Create a method called GetNext7Days that accepts a DateTime object and returns an array of DateTime objects containing the next 7 days (including the given day).
        
        
        // 18. Create a method called IsInLeapYear that accepts a DateTime object and returns true if the date falls within a leap year and false if not. (No built in functions allowed)
       
        
        // 19. Create a method called MortgageCalculator that accepts 2 decimals representing loan balance and interest rate, an integer representing loan term in years, and an integer representing the payment period.
        /* Payment periods: 1 - Monthly, 2 - Bi-Monthly (Every 2 months) */

        
        
        // 20. Create a method called DuckGoose that accepts an integer. Iterate from 1 to this integer, building a string along the way.
        // If the current number in the iteration:
        //   Is divisible by 3, append "Duck" + Environment.NewLine; to the string.
        //   Is divisible by 5, append "Goose" + Environment.NewLine; to the string.
        //   Is divisible by both 3 and 5, append "DuckGoose" + Environment.NewLine; to the string.
        //   Is none of the above, append the number as a string + Environment.NewLine; to the string.
        /* Example - if the input to this method is 20, the following string should be returned
         * 1
         * 2
         * Duck
         * 4
         * Goose
         * Duck
         * 7
         * 8
         * Duck
         * Goose
         * 11
         * Duck
         * 13
         * 14
         * DuckGoose
         * 16
         * 17
         * Duck
         * 19
         * Goose
         */

       
        
        // If you've finished all these challenges, sign up for CodeWars.com and try to complete a few C# challenges there!
    }
}