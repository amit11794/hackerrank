using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Asian_Pacific_American_Heritage_Month_2021_Coding_Contest
{
    class fundraising_for_asian_pacific_american_heritage
    {
        public void Run()
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int numSeqCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> numSeq = new List<int>();

            for (int i = 0; i < numSeqCount; i++)
            {
                int numSeqItem = Convert.ToInt32(Console.ReadLine().Trim());
                numSeq.Add(numSeqItem);
            }

            int result = getScoreDifference(numSeq);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }

        /*
         * Complete the 'getScoreDifference' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY numSeq as parameter.
         */
        public int getScoreDifference(List<int> numSeq)
        {
            int first_score = 0
                , second_score = 0
                , i = 0;

            while (numSeq.Count() > 0)
            {
                int picked_score = numSeq[0];

                if (i++ % 2 == 0)
                    first_score += picked_score;
                else
                    second_score += picked_score;

                numSeq.RemoveAt(0);

                if (picked_score % 2 == 0)
                    numSeq.Reverse();
            }

            return first_score - second_score;
        }
    }
}
