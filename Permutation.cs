using System;
using System.Collections.Generic;
using System.Text;

namespace SubSet
{
    class Permutation
    {
        public static List<string> GetPermsWithoutDups(string str)
        {
            if (str == null) return null;

            List<string> result = new List<string>();

            if (str.Equals(string.Empty))
            {
                result.Add("");
                return result;
            }

            char first = str[0];
            string remainder = str.Substring(1);
            List<string> words = GetPermsWithoutDups(remainder);
            foreach(var word in words)
            {
                for(int i=0; i<word.Length; i++)
                {
                    string s = InsertCharAt(word, first, i);
                    result.Add(s);
                }
            }

            return result;
        }

        private static string InsertCharAt(string word, char c, int i)
        {
            string begin = word.Substring(0, i);
            string end = word.Substring(i);
            return begin + c + end;
        }
    }
}
