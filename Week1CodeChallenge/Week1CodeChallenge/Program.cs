using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {

            //Loop for FizzBuzz
            for (int fb = 0; fb < 21; fb++)
            {
                Console.WriteLine(FizzBuzz(fb));

            }

            //Second Loop for FizzBuzz
            for (int bf = 92; bf > 79; bf--)
            {
                Console.WriteLine(FizzBuzz(bf));
            }
            Console.WriteLine(FizzBuzz(-5));
            Console.ReadKey();
            //Yodaizer to Console
            Console.WriteLine(Yodaizer("I love you"));

            Console.WriteLine(Yodaizer("I love Tucker and Maya."));

            TextStats("The dog jumped over the fence. He was on a mission. The squirrel simply climbed a pole.");
            Console.ReadKey();
            //Loop for prime number test
            for (int i = 1; i < 33; i = i + 2)
            {
                IsPrime(i);
                if (IsPrime(i) == true)
                {
                    Console.WriteLine("{0} is a prime number.", i);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
            //OUtput for dash insert
            Console.WriteLine(DashInsert(4422211));

            Console.WriteLine(DashInsert(8675309));



            Console.ReadKey();
        }
        /// <summary>
        /// checks whether a number is divisible by three or 5 or both
        /// </summary>
        /// <param name="number">user input that will be decided if divisble by either 3, 5, or both </param>
        /// <returns> fizz, buzz, fizzbuzz</returns>
        public static string FizzBuzz(int number)
        {

            if (number < 0)
            {
                return "Try a postive number if you want some FizzBuzz!";
            }
            //see if divisible by 5 & 3
            else if (number % 5 == 0 && number % 3 == 0)
            {
                //divisible by 5 & 3
                return "FizzBuzz";
            }
            else if (number % 5 == 0)
            {
                //divisible by 5
                return "Fizz";
            }
            else if (number % 3 == 0)
            {
                //divisible by 3
                return ("Buzz");
            }
            else
            {
                //not divisible by anything
                return number.ToString();
            }


        }
        /// <summary>
        /// takes a string and reverses order. If 3 words, makes it Yoda like speak
        /// </summary>
        /// <param name="text">string goes in here</param>
        /// <returns>return in reverse</returns>
        public static string Yodaizer(string text)
        {
            //split the words into a list
            List<string> wordList = text.Replace(".", "").Split(' ').ToList();
            //reverse it
            wordList.Reverse();
            //Yoda may speak now, but only three words at a time
            if (wordList.Count() == 3)
            {
                return wordList[0] + ", " + wordList[2] + " " + wordList[1];
            }
            //join the list back to a string
            return string.Join(" ", wordList);
        }

        /// <summary>
        /// Counts vowels, consonants and special characters of a string
        /// </summary>
        /// <param name="input">a string to be counted</param>
        public static void TextStats(string input)
        {
            //Place the variables
            int numberOfCharacters = input.Length;
            int numberOfWords = input.Split(' ').Length;
            int numberOfVowels = 0;
            int numberOfConsonants = 0;
            int numberOfSpecialCharacters = 0;

            for (int i = 0; i < input.Length; i++)
            {
                //convert to lower for looping and grab a letter
                string aSingleLetter = input[i].ToString().ToLower();

                //vowel check
                if ("aeiou".Contains(aSingleLetter))
                {
                    numberOfVowels++;
                }
                //with a special character check
                else if ("zxcvbnmlkjhgfdsqwrtyp".Contains(aSingleLetter))
                {
                    numberOfConsonants++;
                }
                else
                {
                    //count it
                    numberOfSpecialCharacters++;
                }




            }
            //Output
            Console.WriteLine("Input: " + input);
            Console.WriteLine("# of Characters: " + numberOfCharacters);
            Console.WriteLine("# of Words: " + numberOfWords);
            Console.WriteLine("# of Vowels: " + numberOfVowels);
            Console.WriteLine("# of Consonants: " + numberOfConsonants);
            Console.WriteLine("# of Special Characters: " + numberOfSpecialCharacters);

        }
        /// <summary>
        /// checks if a number is prime
        /// </summary>
        /// <param name="number">checks every number upto number input</param>
        /// <returns>prime number statement or just the number</returns>
        public static bool IsPrime(int number)
        {
            //1 and 2 are technically prime numbers for this exercise. 1 is not a prime number though
            if (number <= 2) return true;
            // if its even it can't be a prime
            if (number % 2 == 0) return false;
            //loop for the primality 
            for (int i = 3; i < number; i += 2)
            {
                //Its divisible by itself its not a prime 
                if (number % i == 0) return false;
            }
            // Its a prime
            return true;

        }
        public static string DashInsert(int number)
        {
            //convert to string
            string numberString = number.ToString();
            string outString = string.Empty;

            //loop over each digit, this isn't necessary for the last
            for (int i = 0; i < numberString.Length - 1; i++)
            {
                //convert first looped number string back to a number
                int currentDigit = int.Parse(numberString[i].ToString());
                //convert second looped number string to a number 
                int nextDigit = int.Parse(numberString[i + 1].ToString());
                // if both digits are odd
                if (currentDigit % 2 != 0 && nextDigit % 2 != 0)
                {
                    //insert a dash
                    outString += currentDigit + "-";
                }
                else
                {
                    //not odd, so write the number
                    outString += currentDigit;
                }
            }
            //the last number is added
            outString += numberString[numberString.Length - 1];

            //returned... I admit there might have been a slightly cleaner way of writing this function, but I couldn't get it to work.
            return outString;
        }
    }
}
