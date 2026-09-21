using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Nodes;

namespace CSLT_26C1INF5090051_C2.SESSION08
{
    internal class btslide
    {
        static int calAvg(int[] a)
        {
            int sum = 0;
            foreach (int v in a)
            {
                sum += v;
            }
            return sum / a.Length; ;
        }
        public static void Main(string[] args)
        {
           
        }
        static bool searchByValue(int[] a, int x)
        {
            foreach (int v in a)
                if (v == x)
                    return true;
            return false;
        }
        //find the index of an array element
        static int searchIndex (int[]a,int x)
        {
            for (int i = 0; i < a.Length; i++)
                if (a[i] == x)
                    return i;
            return -1;
        }
        //remive a specific element from an array
    }
}
