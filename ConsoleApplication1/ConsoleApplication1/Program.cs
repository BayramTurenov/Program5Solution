using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();

            int myAgeDoubled = DoubleIt(34);
            Console.WriteLine(DoubleIt(myAgeDoubled));
        }

        /// <summary>
        /// Writes "Hello world" to the console
        /// </summary>
        static void HelloWorld()
        {
            Console.WriteLine("Hello world");
            
        }
        static int DoubleIt(int someNumber)
        {
            return someNumber * 2;
        }
        /// <summary>
        ///Prints numbers to the console from start to the end 
        /// </summary>
        /// <param name="startNumber"></param>
        /// <param name="endNumber"></param>
        static void LoopSomeNumbers(int startNumber, int endNumber)
        {
            for(int i = startNumber; i<=endNumber; i = i + 1)
            {
                Console.WriteLine(i);
            }
        }
        /// <summary>
        /// Runs a series of numbers
        /// </summary>
        static void LoopTests()
        {
            LoopSomeNumbers(5,10);
            LoopSomeNumbers(863428,863430);
            LoopSomeNumbers(31,DoubleIt(DoubleIt(31)));
        }

        


        /// <summary>
        /// String that of vowels in a string
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        static int VowelCounter3000(string inputString) 
        {
            //declares a counter fro the vowels
            int numberOfVowelsFound = 0;
            //loop over each letter of the string
            for (int i = 0; i < inputString.Length; i = i + 1)
            {
                string letter = inputString[i].ToString().ToLower();
                if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u")
                {
                    //
                    numberOfVowelsFound = numberOfVowelsFound + 1;
                    //alternative way of checking to see if its a vowel
                    if ("aeiou".Contains(letter)) { }

                }
                //loop complete, time to write the output
                Console.WriteLine(inputString + " has" + numberOfVowelsFound + " vowels in it");
                return numberOfVowelsFound;
            }
        }

            static void VowelCounter3000Tests()
            {
            int totalNumberVowelCounted = 0;
                totalNumberVowelCounted += VowelCounter3000("bla bla");
                totalNumberVowelCounted += VowelCounter3000("I eat bla bla");
                Console.WriteLine("Total is VowelCounter3000");
            }

        }
    }

