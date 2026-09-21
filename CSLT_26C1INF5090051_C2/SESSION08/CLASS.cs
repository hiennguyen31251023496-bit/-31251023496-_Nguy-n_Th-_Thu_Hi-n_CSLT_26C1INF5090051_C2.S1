using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_26C1INF5090051_C2.SESSION08
{
    internal class CLASS
    {
        static void nhap_mang_ngau_nhien(int[] a)
        {
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(10, 100);
            }
        }

    }
}
