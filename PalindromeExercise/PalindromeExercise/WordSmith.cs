using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            if (word.ToLower() == Reverse(word.ToLower()))
                return true;
            else
                return false;
        }
        public string Reverse(string word)
        {
            char[] array = word.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        } 
    }
}
