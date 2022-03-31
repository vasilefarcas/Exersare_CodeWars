using System;
using System.Linq;
namespace Exersare_CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(SongDecoder("WUBWUBIWUBAMWUBWUBX"));

            // Console.WriteLine(findNB(1071225));

            //object[] haystack = { '3', "123124234", null, "needle", "world", "hay", 2, '3', true, false };
            // Console.WriteLine(findNeedle(haystack));

            // int[] BinaryArray= { 1, 1, 1, 1 };
            // Console.WriteLine(binnaryArrayToNumber(BinaryArray));

            // Console.WriteLine(AbbrevName2("Sam Harris"));

            // Console.WriteLine(CenturyFromYear(1901));

            // neterminata
            // DescendingOrder(145263);

            /*
            int[] a = {120, 144, 19, 161, 19, 144, 19, 11};
            int[] b = { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };
            Console.WriteLine(comp(a,b));

            */
            // Console.WriteLine(TowerBuilder(5));

            /*
            string[] lstOfArt = { "ABART 20", "CDXEF 50", "BKWRK 25", "BTSQZ 89", "DRTYM 60" };
            string[] lstOf1stLetter = { "A", "B", "C", "W" };
            Console.WriteLine(stockSummary(lstOfArt, lstOf1stLetter));
            */

            /*
            string str = "This website is for losers LOL!";
            Console.WriteLine(Disemvowel(str));
        */
            /*
            int[] seq = { 1, 2, 2, 3, 3, 3, 4, 3, 3, 3, 2, 2, 1 };
            Console.WriteLine(find_it(seq));
            */



            // Console.WriteLine(IsPrime(97));

            // Console.WriteLine(MultiplicationTable(3));

            // Console.WriteLine(NthRank("COLIN, AMANDBA, AMANDAB, CAROL, PauL, JOSEPH", new int[] { 1, 4, 4, 5, 2, 1 }, 6));

            // Console.WriteLine(sumTwoSmallestNumbers(new int[] { 5, 8, 12, 19, 22 }));

        }


        public static int DescendingOrder2(int num)
        {
            int l = Convert.ToString(num).Length;
            int[] v = new int[l];
            for (int i = 0; i < l; i++)
            {
                v[i] = num % 10;
                num /= 10;
            }
            Array.Sort(v);
            for (int i = l-1; i > 0; i--)
            {
                num *= 10 + v[i];

            }


            return num;
        }

        public static int CountBits(int n)
        {
            int nr = 0;
            while (n != 0)
            {
                nr += n % 2;
                n /= 2;
            }
            return nr;
        }

        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            int p = numbers.Min();
            numbers[Array.IndexOf(numbers, p)] = numbers.Max();
            int d = numbers.Min();
            return p + d;
        }

        public static string NthRank(string st, int[] we, int n)
        {
            string[] nume = st.Split(',', StringSplitOptions.RemoveEmptyEntries);
            int poz = 0, max = 0;
            for (int i = 0; i < n; i++)
            {
                string aux = nume[i];
                int win = aux.Length;
                int num = aux.Length;
                Console.WriteLine(aux);
                for (int j = 0; j < num; j++)
                {
                    if ((int)aux[j] > 96)
                        win += (int)aux[j] - 96;
                    else
                        win += (int)aux[j] - 64;
                }
                win *= we[i];
                if (win > max)
                {
                    max = win;
                    poz = i;
                }
                Console.WriteLine(n);
            }
            return nume[poz];
        }

        public static int[,] MultiplicationTable(int size)
        {
            int[,] a = new int[size, size];
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    a[i, j] = (i + 1) * (j + 1);

            return a;
        }

        public static string ToCamelCase(string str)
        {
            char[] rem = { '-', '_' };
            string res = str;
            int i = 0;
            for (; i < str.Length; i++)
                if (res[i] == rem[0] || res[i] == rem[1])
                {
                    while (res[i] == rem[0] || res[i] == rem[1])
                        i++;

                }
            return str;
        }

        public static int[] TwoSum(int[] numbers, int target)
        {
            int[] v = new int[2];
            for (int i = 0; i < numbers.Length; i++)
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == target)
                    {
                        v[0] = i;
                        v[1] = j;
                    }
                }
            return v;
        }

        public static bool IsPrime(int n)
        {
            if (n < 2)
                return false;
            if (n % 2 == 0)
                return false;
            for (int i = 3; i * i <= n; i++)
                if (n % i == 0)
                    return false;

            return true;
        }

        public static int find_it(int[] seq)
        {
            int crnt = seq[0], nr = 0;
            for (int i = 0; i < seq.Length; i++)
            {
                crnt = seq[i];
                nr = 0;
                for (int j = 0; j < seq.Length; j++)
                    if (crnt == seq[j])
                        nr++;

                if (nr % 2 == 1)
                    return crnt;
            }
            return -1;
        }

        public static bool ArrayMadness(int[] a, int[] b) => a.Sum(t => Math.Pow(t, 2)) > b.Sum(s => Math.Pow(s, 3));
        /*
        public static string[] TowerBuilder(int nFloors)
        {
            string[] result = new String[10];
            int i = 0,j;
            for(i;i<=nFloors;i++)
            {
                for (j = 1; j < nFloors; j++)
                result[i] += ' ';
            }    
            return new string[0];
        }
        */
        static bool comp(int[] a, int[] b)
        {
            int i;
            if (a == null || b == null)
                return false;
            for (i = 0; i <= a.Length - 1; i++)
                if (Array.IndexOf(b, a[i] * a[i]) != -1)
                    b[Array.IndexOf(b, a[i] * a[i])] = 0;
                else
                    return false;
            return true;
        }

        public static int Gimme(double[] inputArray)
        {
            if (inputArray[0] < inputArray[2] && inputArray[2] < inputArray[1])
                return 2;
            if (inputArray[0] < inputArray[1] && inputArray[1] < inputArray[2])
                return 1;
            if (inputArray[1] < inputArray[0] && inputArray[0] < inputArray[2])
                return 0;
            if (inputArray[1] < inputArray[2] && inputArray[2] < inputArray[0])
                return 2;
            if (inputArray[2] < inputArray[1] && inputArray[1] < inputArray[0])
                return 1;
            if (inputArray[2] < inputArray[0] && inputArray[0] < inputArray[1])
                return 0;

            return 0;
        }

        public static long MinValue(int[] a)
        {
            long numar = 0;
            int[] v = new int[10];
            int i = 0;
            for (i = 0; i < a.Length; i++)
                v[a[i]]++;
            i = 0;
            if (v[0] != 0)
            {
                i = 1;
                while (v[i] == 0)
                    i++;
                numar = numar * 10 + i;
                numar = numar * 10;
            }
            for (i = i + 1; i < 10; i++)
                if (v[i] != 0)
                    numar = numar * 10 + i;
            return numar;
        }

        public static string Disemvowel(string str)
        {
            int i = 0, lungime = str.Length;
            string voc = "aeiouAEIOU";
            string result = string.Empty;
            while (i < lungime)
            {
                if (voc.IndexOf(str[i]) == -1)
                    result += str[i];
                i++;
            }
            return result;
        }

        public static string stockSummary(String[] lstOfArt, String[] lstOf1stLetter)
        {
            string rezultat = string.Empty, litera;
            int numere;
            int[] s = new int[lstOf1stLetter.Length];
            for (int i = 0; i < lstOfArt.Length; i++)
            {
                for (int j = 0; j < lstOf1stLetter.Length; j++)
                {
                    litera = lstOfArt[i].Substring(0, 1);
                    if (litera == lstOf1stLetter[j])
                    {
                        int q = lstOfArt[i].Length - 1;
                        try
                        {
                            while (int.Parse(lstOfArt[i].Substring(q, 1)) >= 0 && int.Parse(lstOfArt[i].Substring(q, 1)) <= 9)
                                q--;
                        }
                        catch (Exception)
                        {

                        }
                        q++;
                        numere = int.Parse(lstOfArt[i].Substring(q, Math.Abs(q - lstOfArt[i].Length)));
                        s[j] += numere;
                        break;
                    }
                }
            }
            int ok = 1;
            for (int i = 0; i < lstOf1stLetter.Length; i++)
                if (s[i] != 0)
                {
                    ok = 0;
                    break;
                }
            if (ok == 1)
                return string.Empty;
            rezultat += "(" + lstOf1stLetter[0] + " : " + s[0] + ")";
            for (int i = 1; i < lstOf1stLetter.Length; i++)
                rezultat += " - (" + lstOf1stLetter[i] + " : " + s[i] + ")";
            return rezultat;

        }

        public static int RoundToNext5(int n)
        {
            if (n % 5 == 0)
                return n;
            return n + 5 - (n % 5);
        }
        public static string BreakCamelCase(string str)
        {
            int i = 0;
            int lungime;
            lungime = str.Length;
            while (i < lungime - 1)
            {
                if ((str[i] >= 'a' && str[i] <= 'z') && (str[i + 1] >= 'A' && str[i + 1] <= 'Z') || ((str[i] >= 'A' && str[i] <= 'Z') && (str[i + 1] >= 'A' && str[i + 1] <= 'Z')))
                {
                    str = str.Insert(i + 1, " ");
                    lungime++;
                    i++;
                }
                i++;
            }
            return str;
        }

        static void DescendingOrder(int n)
        {
            int[] vector = new int[20];
            int numar = 0, i = 0;
            for (; n > 0; n /= 10, i++)
            {
                vector[i] = n % 10;
                Console.WriteLine(vector[i]);
            }
            int k, j;
            for (j = 0; j <= i - 1; j++)
                for (k = 0; k <= i - j - 1; k++)
                    if (vector[k] < vector[k + 1])
                        Swap(ref vector[k], ref vector[k + 1]);
            for (j = 0; j <= i; j++)
                Console.Write(vector[i]);
        }

        private static void Swap(ref int v1, ref int v2)
        {
            v1 = v1 + v2;
            v2 = v1 - v2;
            v1 = v1 - v2;
        }

        static string AbbrevName(string v)
        {
            string res = String.Empty;
            res = $"" + v[0] + "." + v[v.IndexOf(' ') + 1];
            return res.ToUpper();
        }
        static int CenturyFromYear(int year)
        {
            if (year % 100 >= 1)
                return year / 100 + 1;
            return year / 100;
        }

        public static string AbbrevName2(string name)
        {
            // prin string.join se concateneaza sirul, primul parametru reprezinta caracterul pus intre cuvinte
            // cel de al doilea parametru reprezinta vectorul pe care il voi lipi
            return string.Join(" ", name.Split(' ').Select(w => w[0])).ToUpper();

        }
        static int binnaryArrayToNumber(int[] binaryArray)
        {
            int numar = 0, i = binaryArray.Length, j = 0, a = 1;
            a = (int)Math.Pow(2, i - 1);
            for (j = 0; j < i; j++)
            {
                numar = numar + (binaryArray[j] * a);
                a = a / 2;
            }
            return numar;
        }

        static string findNeedle(object[] haystack)
        {
            int i;
            int nr = 0;
            for (i = 0; i <= haystack.Length - 1; i++)
                if (haystack[i] == "needle")
                {
                    nr = i;
                    i = haystack.Length + 1;
                }
            return "found the needle at position " + nr;

        }
        public static string FindNeedle_better(object[] haystack)
        {
            return "found the needle at position " + Array.IndexOf(haystack, "needle");
        }
        static int findNB(long v)
        {
            long s = 0, nr = 1;
            while (s <= v)
            {
                s = s + (nr * nr * nr);
                nr++;
            }
            // if (s == v)
            // else
            // return -1;
            return Convert.ToInt32(nr);
        }

        public static string SongDecoder(string input)
        {
            int i = 0;
            string result = null;
            /*
             while (i < input.Length - 4)
             {
                 if (input[i] == 'W' && input[i + 1] == 'U' && input[i + 2] == 'B')
                 {
                     i += 3;
                 }
                 else
                     i++;
                 result += input[i];
             }
            */
            string real_result = null;
            result = input.Replace("WUB", " ");
            while (result[i] == ' ')
                i++;
            bool ok = true;
            while (i < result.Length - 1)
            {
                ok = true;
                while (result[i] != ' ' && result[i + 1] != ' ')
                    i++;
                real_result += result[i];
                i++;
            }
            return real_result;
            /*
            i = 0;
            string result2 = null;
            while (i < result.Length-3)
            {
                if (result[i + 1] == 'W' && result[i + 2] == 'U' && result[i + 3] == 'B')
                    i += 4;
                else
                result2 += result[i];
                i++;
            }
            while (i < result.Length)
            {
                result2 += result[i];
                i++;
            }
            return result2;
            */
        }
    }
}
