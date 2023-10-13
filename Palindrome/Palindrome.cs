using System;
using System.Text;

namespace Palindrome
{
    class Pallindrome
    {
        public (bool, int) IsPalindrome(string input)
        {
            string testString = input.ToUpper();
            var sb = new StringBuilder();

            foreach (char c in testString)
            {
                if (!char.IsPunctuation(c) && !char.IsWhiteSpace(c))
                {
                    sb.Append(c);
                }
            }

            testString = sb.ToString();
            int i = 0, j = testString.Length - 1;

            while (i <= j)
            {
                if (testString[i] != testString[j])
                {
                    return (false, testString.Length);
                }
                i++;
                j--;
            }
            return (true, testString.Length);
        }
    }
}