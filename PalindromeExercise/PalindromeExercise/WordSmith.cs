using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(String input) {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            String inputReversed = new string(chars);
            if (input == inputReversed) return true;
            else return false;
        }
    }
}
