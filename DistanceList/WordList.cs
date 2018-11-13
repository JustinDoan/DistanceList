using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceList
{
    class WordList
    {

        List<string> Words;
        public WordList(List<string> words)
        {
            Words = words;
        }

        public int FindDistanceTwoWords(string word1, string word2)
        {
            //Get index of words
            int word1Pos = Words.FindIndex(x => x == word1);
            int word2Pos = Words.FindIndex(x => x == word2);
            //Check if index is -1
            if (word1Pos == -1 || word2Pos == -1){throw new Exception("One or both of the words didn't exist in the list.");}
            //Subtract and get abs value
            int distance = Math.Abs((word1Pos-word2Pos));
            return distance;

        }



    }
}
