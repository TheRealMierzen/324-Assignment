﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace StatAPI
{

    public class StatAPI
    {

        private List<double> theList;

        public StatAPI()
        {
            theList = new List<double>();
        }

        public bool checkValidN(int value)
        {

            if (value > 25 || value < 5)
                return false;

            return true;

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

        public void clearList()
        {
            this.theList.Clear();
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

        public double min()
        {
            return theList.Min();
        }
        
        public double Average(int n)
        {
            double ave = 0.0;

            for (int i = 0; i < theList.Count; i++)
            {
                ave += theList[i];
            }

            ave = ave / n;

            return ave;
        }

        public double GetMedian()
        {
            double[] lys = theList.ToArray();
            if (lys == null || lys.Length == 0)
                throw new System.Exception("Median of an empty array can not be found");

            double[] clone = (double[])lys.Clone();
            Array.Sort(clone);

            int size = clone.Length;
            int mid = size / 2;
            double median = (size % 2 != 0) ? (double)clone[mid] : ((double)clone[mid] + (double)clone[mid - 1]) / 2;
            return median;

        }
        
        public double StandardDeviation(int n)
        {
            double sd = 0.0;
            double avg = Average(n);

            double sumOfSqueresDiff = theList.Select(val => (val - avg) * (val - avg)).Sum();
            sd = Math.Sqrt(sumOfSqueresDiff / theList.Count);

            return sd;
        }

    }

}
