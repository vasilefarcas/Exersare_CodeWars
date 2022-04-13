using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_04_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        public static string NumberToString(int num) => num.ToString();

        public static string PrinterError(String s)
        {
            int err = 0;
            for (int i = 0; i < s.Length; i++)
                if (s[i] > 'm')
                    err++;
            return err + "/" + s.Length;
        }

        public int Min(int[] list)
        {
            int min = list[0];
            foreach (int item in list)
            {
                if (item > min)
                    min = item;
            }
            return min;
        }
        public int Max(int[] list)
        {
            int max = list[0];
            foreach (int item in list)
            {
                if (item > max)
                    max = item;
            }
            return max;
        }

        public static int Grow(int[] x)
        {
            int p = 1;
            foreach (int item in x)
                p *= item;
            return p;
        }

        public static int[] ReverseSeq(int n)
        {
           int[] v=new int[n];
            for (int i = 0; i < n; i++)
                v[i] = n - i;
            return v;
        }
    }
}
