using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Asian_Pacific_American_Heritage_Month_2021_Coding_Contest
{
    class asian_pacific_heritage_coding_contest
    {
        public void Run()
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int firstStringsCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> firstStrings = new List<string>();

            for (int i = 0; i < firstStringsCount; i++)
            {
                string firstStringsItem = Console.ReadLine();
                firstStrings.Add(firstStringsItem);
            }

            int secondStringsCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> secondStrings = new List<string>();

            for (int i = 0; i < secondStringsCount; i++)
            {
                string secondStringsItem = Console.ReadLine();
                secondStrings.Add(secondStringsItem);
            }

            List<string> result = canBeEqualized(firstStrings, secondStrings);

            textWriter.WriteLine(String.Join("\n", result));

            textWriter.Flush();
            textWriter.Close();
        }

        /*
        * Complete the 'canBeEqualized' function below.
        *
        * The function is expected to return a STRING_ARRAY.
        * The function accepts following parameters:
        *  1. STRING_ARRAY firstStrings
        *  2. STRING_ARRAY secondStrings
        */
        public List<string> canBeEqualized(List<string> firstStrings, List<string> secondStrings)
        {
            List<string> output = new List<string>();

            for (int i = 0; i < firstStrings.Count(); i++)
            {
                string firstString = firstStrings[i];
                string secondString = secondStrings[i];

                if (firstString.Length != secondString.Length)
                {
                    output.Add("NO");
                    continue;
                }

                if (firstString.Equals(secondString))
                {
                    output.Add("YES");
                    continue;
                }

                char[] firstSubSecond = firstString.ToCharArray().Except(secondString.ToCharArray()).ToArray();
                char[] secondSubFirst = secondString.ToCharArray().Except(firstString.ToCharArray()).ToArray();

                if (firstSubSecond.Count() == 1)
                {
                    output.Add(comparable(firstString, secondString, firstSubSecond));
                }
                else if (secondSubFirst.Count() == 1)
                {
                    output.Add(comparable(secondString, firstString, secondSubFirst));
                }
                else
                {
                    output.Add("NO");
                }
            }

            return output;
        }

        public string comparable(string str1, string str2, char[] diff)
        {
            bool valid = true;
            char respChar = '\0';

            for (int j = 0; j < str1.Length; j++)
            {
                if (str1[j] == diff[0] && respChar == '\0')
                {
                    respChar = str2[j];
                }
                if (str1[j] == str2[j] || (str1[j] == diff[0] && str2[j] == respChar))
                { }
                else
                {
                    valid = false;
                    break;
                }
            }
            return valid ? "YES" : "NO";
        }
    }
}
