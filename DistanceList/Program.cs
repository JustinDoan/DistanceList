using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>() { "JavaScript", "TypeScript", "Ruby", "Pascal", "COBOL" };
            WordList wordList = new WordList(words);
            Console.WriteLine(wordList.FindDistanceTwoWords("JavaScript", "COBOL"));



        }
    }
}
