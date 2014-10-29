using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingOf
{
    class Program
    {
        static void Main(string[] args)
        {
            LoopOverAList();
            LoopOverWordsInAString("the quick brown fox jump over lazzy dog");
            Console.ReadKey();
        }
        static void LoopOverAList()
        {
            //create list of sports
            List<string> sportList = new List<string>() { "Baseball", "Tennis" };
            //add Football to the sportList
            sportList.Add("Football");
            //loop over the sport list and display all elements that contain the world "ball"
            for (int i = 0; i < sportList.Count(); i++)
            {
            //get the current sport out of sportlist
                string currentSport = sportList[i];
                //check to see if its a sport contains "ball"
                if (currentSport.Contains("ball"))
                {
                    //its true
                    Console.WriteLine(currentSport);
                }
            }
        }
        static void LoopOverWordsInAString(string inputString)
        {
            List<string> wordList = inputString.Split(' ').ToList();
            for (int i = 0; i < wordList.Count(); i = i + 1)
            {
                Console.WriteLine(wordList[i]);
            }
        }
     }
}
