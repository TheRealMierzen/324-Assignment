using System;
using System.Collections.Generic;

namespace StatAPI
{

    public class StatAPI
    {

        private List<double> theList;

        public StatAPI()
        {
            theList = new List<double>();
        }

        public void AddNRandomNumbers(int N, double min, double max)
        {
            Random myRandom = new Random();
            for (int i = 0; i < N; i++)
            {
                double random = myRandom.NextDouble() * (max - min) + min;
                theList.Add(random);
            }
        }

        public double Max()
        {
            int maxindex = -1;
            double maxvalue = 0;
            for (int i = 0; i < theList.Count; i++)
            {
                if (maxindex == -1 || maxvalue < theList[i])
                {
                    maxindex = i;
                    maxvalue = theList[i];
                }
            }
            if (maxindex == -1)
                return 0;
            else
                return theList[maxindex];
        }

        public double SumTotal()
        {
            double j = 0;
            for (int i = 0; i < theList.Count; i++)
            {
                j = j + theList[i];
            }
            return j;
        }

        public string PrintNumbers()
        {
            string output = "";
            for (int i = 0; i < theList.Count; i++)
            {
                output += theList[i].ToString() + " ";
            }
            return output;
        }

    }

}
