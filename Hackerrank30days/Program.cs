using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hackerrank30days
{
    class Program
    {
        static long aVeryBigSum(long[] ar)
        {
            long result = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                result +=  ar[i];
            }

            return result;

        }

        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> result = new List<int>();

            int alice = 0;
            int bob = 0;
            for(int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    alice++;
                }
                if (a[i] < b[i])
                {
                    bob++;
                }
                if (a[i] == b[i])
                {
                    continue;
                }
                
            }
            int[] array = { alice, bob };
            result = array.ToList();
            return result;
        }

        public static int diagonalDifference(List<List<int>> arr)
        {
            int d1 = 0;
            int d2 = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr.Count; j++)
                {
                    if (i == j)
                    {
                        d1 += arr[i][j];
                    }
                    if (arr.Count == i + j + 1)
                    {
                        d2 += arr[i][j];
                    }
                }
            }

            return Math.Abs(d1 - d2);
        }

        public static void plusMinus(int[] Arr)
        {
            float count = 0;

            float pos = 0;
            float neg = 0;
            float zero = 0;

            for(int i = 0; i < Arr.Length; i++)
            {
                count++;

                if (Arr[i]>0)
                {
                    pos++;
                }

                if (Arr[i] < 0)
                {
                    neg++;
                }
                if (Arr[i] == 0)
                {
                    zero++;
                }

            }

            Console.WriteLine(pos / count);
            Console.WriteLine(neg / count);
            Console.WriteLine(zero / count);
            Console.ReadLine();


        }

        public static void staircase(int n)
        { 
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new String(' ',n-i) + new String('#',i));
            }

            
        }

        public static void solve(double meal_cost, int tip_percent, int tax_percent)
        {
            var tip = Convert.ToDecimal(meal_cost)*(Convert.ToDecimal(tip_percent) / 100);

            var tax = Convert.ToDecimal(meal_cost) * (Convert.ToDecimal(tax_percent) / 100);

            var cost = Convert.ToDecimal(meal_cost);

            Console.WriteLine(Math.Round(tip + tax + cost,0));

        }

        public static void ConditionalStatements()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            if (N % 2 == 1)
            {
                Console.WriteLine("Wierd");
            }
            if (N % 2 == 0  && N>=2 && N<=5)
            {
                Console.WriteLine("Not Wierd");
            }
            if(N%2==0 && N >= 6 && N<=20)
            {
                Console.WriteLine("Wierd");
            }
            if (N % 2==0 && N>20)
            {
                Console.WriteLine("Not Wierd");
            }
        }

        public static void miniMaxSum(int[] arr)
        {
            Array.Sort(arr);
            long min = 0;
            long max = 0;
            for(int i = 1; i < arr.Length; i++)
            {
                max += arr[i];
            }

            for(int i = 0;i < arr.Length - 1; i++)
            {
                min += arr[i];
            }

            string res = min.ToString() + " " + max.ToString();

            Console.WriteLine(res);
        }

        public static int birthdayCakeCandles(int[] ar)
        {
            int max = -999;
            for(int i = 0; i < ar.Length; i++)
            {
                if (ar[i] > max)
                {
                    max = ar[i];
                }
            }

            int count = 0;

            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] == max)
                {
                    count++;
                }
            }

            return count;
        }

        public static string timeConversion(string s)
        {
            string result = "";
            var time = s;
            var amOrPm = time.Substring(8);
            var hourComponent = time.Substring(0, 2);
            var remainingTimeComponent = time.Substring(2, 6);
            if (amOrPm == "AM" && hourComponent == "12")
            {
                hourComponent = "00";
            }
            else if (amOrPm == "PM")
            {
                var numericHourComponent = int.Parse(hourComponent);
                if (numericHourComponent != 12)
                {
                    hourComponent = Convert.ToString(12 + numericHourComponent);
                }
            }
            result = hourComponent + remainingTimeComponent;
            return result;
        }


        public static List<int> gradingStudents(List<int> grades)
        {

            for (int i = 0; i < grades.Count; i++)
            {
                var item = grades[i];
                if (item >= 38)
                {
                    var diff = 5 - (item % 5);
                    if (diff < 3)
                        grades[i] = item + diff;
                }
            }

            return grades;


        }


        public static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int appleCount = 0;
            int orangeCount = 0;

            for(int i = 0; i < apples.Length; i++)
            {
                apples[i] = apples[i] + a;
                if (apples[i] >= s && apples[i] <= t)
                {
                    appleCount++;
                }
            }

            for(int i = 0; i < oranges.Length; i++)
            {
                oranges[i] = oranges[i] + b;
                if (oranges[i] >= s && oranges[i] <= t)
                {
                    orangeCount++;
                }
            }

            Console.WriteLine(appleCount);

            Console.WriteLine(orangeCount);

        }

        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            var sameLocationPossible = "";
            if (x1 < x2 && v1 < v2)
                sameLocationPossible = "NO";

            else if (x2 < x1 && v2 < v1)
                sameLocationPossible = "NO";

            else if (x2 < x1)
            {
                //v2 > v1
                var numberOfJumps = ((double)(x1 - x2)) / (v2 - v1);
                //check whether number of jumps is a whole number  i.e no fractional part.
                if (numberOfJumps % 1 == 0)
                    sameLocationPossible = "YES";
                else
                    sameLocationPossible = "NO";
            }
            else
            {
                //v1 > v2
                var numberOfJumps = ((double)(x2 - x1)) / (v1 - v2);
                //check whether number of jumps is a whole number  i.e no fractional part.
                if (numberOfJumps % 1 == 0)
                    sameLocationPossible = "YES";
                else
                    sameLocationPossible = "NO";
            }
            return sameLocationPossible;
        }



        static void Main(string[] args)
        {

            //List<List<int>> arr = new List<List<int>>();
            //int[] alice = { 17, 28, 30 };
            //var a = alice.ToList();
            //arr.Add(a);

            //int[] Bob = { 99, 16, 8 };
            //var b = Bob.ToList();
            //arr.Add(b);

            //int[] Her = { 99, 16, 8 };
            //var c = Her.ToList();
            //arr.Add(c);

            //int[] alice = { 4,73,67,38,33 };
            //List<int> grades = alice.ToList();

            //int[] nums = new int[] { 2,1,5,4,5};
            //string time = "07:05:45PM";

            //foreach (int grade in gradingStudents(grades))
            //{
            //    Console.WriteLine(grade);
            //}

            //int[] apples = { 2,3,-4 };
            //int[] oranges = { 3,-2,-4 };
            //countApplesAndOranges(7,10,4,12,apples,oranges);

            Console.WriteLine(kangaroo(2, 1, 1, 2));
        }
    }
}
