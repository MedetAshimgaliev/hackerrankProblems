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

        public static int[] reverseArray(int[] a)
        {
            int start = 0;
            int end = a.Length-1;

            int temp = 0;

            while(start < end)
            {
                temp = a[start];
                a[start] = a[end];
                a[end] = temp;
                start++;
                end--;
            }

            return a;
        }

        public static int hourglassSum(int[][] arr)
        {
            int maxSum = int.MinValue;
            int rows = arr.Length - 2;
            for (int j = 0; j < rows; j++)
            {
                int columns = arr[j].Length - 2;

                for (int k = 0; k < columns; k++)
                {
                    int sum = arr[j][k] + arr[j][k + 1] + arr[j][k + 2]
                                        + arr[j + 1][k + 1]
                        + arr[j + 2][k] + arr[j + 2][k + 1] + arr[j + 2][k + 2];

                    if (maxSum < sum)
                    {
                        maxSum = sum;
                    }
                }
            }
            return maxSum;
        }

        public static int sockMerchant(int n, int[] ar)
        {
            int[] pairsToSell = new int[n];
            int countToSell = 0;
            foreach (int sock in ar)
            {
                var ind = sock % n;
                pairsToSell[ind] += 1;
                if (pairsToSell[ind] == 2)
                {
                    countToSell++;
                    pairsToSell[ind] = 0;
                }
            }

            return countToSell;
        }


        public static int getTotalX(List<int> a, List<int> b)
        {
            return 0;
        }
        public static void shifLeft(int[] nums)
        {
            int first = nums[0];

            int from = 1;
            for (; from < nums.Length; from++)
            {
                nums[from - 1] = nums[from];
            }

            nums[from - 1] = first;
        }

        public static int[] rotateleft(int[] a, int d)
        {
            int size = a.Length;
            int[] rotatedArr = new int[size];

            int i = 0;
            int rotate_index = d;

            while (rotate_index < size)
            {
                rotatedArr[i] = a[rotate_index];
                i++;
                rotate_index++;
            }

            rotate_index = 0;

            while (rotate_index < d)
            {
                rotatedArr[i] = a[rotate_index];
                i++;
                rotate_index++;
            }

            return rotatedArr;
        }

        public static int countingValleys(int n, string s)
        {
            int v = 0;
            int lvl = 0;

            foreach(char c in s.ToCharArray())
            {
                if (c == 'U')
                {
                    lvl++;
                }
                if (c == 'D')
                {
                    lvl--;
                }

                if(lvl == 0 && c == 'U')
                {
                    v++;
                }
            }
            return v;
        }

        public static int[] breakingRecords(int[] scores)
        {
            //int[] res = new int[] { };

            int countmin = 0;
            int countmax = 0;
            int min = scores[0];
            int max = scores[0];
            for (int i = 0; i < scores.Length; i++)
            {
                

                if (scores[i] < min)
                {
                    min = scores[i];
                    countmin++;
                }

                if (scores[i] > max)
                {
                    max = scores[i];
                    countmax++;
                }
            }

            return new int[] {countmax, countmin};
        }

        public static string catAndMouse(int x, int y, int z)
        {
            int distanceA = Math.Abs(z - x);

            int distanceB = Math.Abs(z - y);

            if (distanceA < distanceB)
            {
                return "Cat A";
            }
            if (distanceB < distanceA)
            {
                return "Cat B";
            }
            else
            {
                return "Mouse C"; 
            }

        }

        public static int designerPdfViewer(int[] h, string word)
        {
            //char c = 'z';
            //int index = (int)c % 32;x
            var alphabetHeight = new Dictionary<char, int>();

            var alphabet = 'a';
            foreach (var height in h)
            {
                alphabetHeight.Add(alphabet++, height);
            }

            var maxAlphabetHeight = 0;
            foreach (var letter in word)
            {
                if (alphabetHeight[letter] > maxAlphabetHeight)
                {
                    maxAlphabetHeight = alphabetHeight[letter];
                }
            }

            var areaOfSelectedText = maxAlphabetHeight * word.Length;

            return areaOfSelectedText;
        }

        public static int birthday(List<int> s, int d, int m)
        {

            var totalWays = 0;

            if (s.Count >= m)
            {
                var barPartSum = 0;
                for (int i = 0; i < m; i++)
                    barPartSum += s[i];

                if (barPartSum == d)
                    totalWays++;

                for (int i = 0; i < s.Count - m; i++)
                {
                    barPartSum = barPartSum - s[i] + s[i + m];

                    if (barPartSum == d)
                        totalWays++;
                }
            }
            return totalWays;
        }

        public static int factorial(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * factorial(n - 1);
            }
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

            int[] a = { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7 };
            //int d = 4;

            //Console.WriteLine(designerPdfViewer(a,"zaba"));

            //Console.WriteLine(countingValleys(8, "UDDDUDUU"));

            //return rotatedArr;

            //Console.WriteLine(string.Join(" ", breakingRecords(a)));

            //foreach (int i in nums)
            //{
            //    Console.WriteLine(i);
            //}

            //int tries = Convert.ToInt32(Console.ReadLine());

            //string[] array = new string[tries];


            //for(int i = 0; i < array.Length; i++)
            //{
            //    array[i] = Console.ReadLine();
            //}



            //for (int i = 0; i < array.Length; i++)
            //{
            //    string res1 = "";
            //    string res2 = "";
            //    for (int j = 0; j < array[i].Length; j++)
            //    {
            //        if (j % 2 == 0)
            //        {
            //            res1 += array[i][j];
            //        }

            //        if (j % 2 == 1)
            //        {
            //            res2 += array[i][j];
            //        }
            //    }

            //    Console.WriteLine(res1 + " " +res2 );
            //}

            int[] arr = {1,4,3,2};

            int[] temp = { };

            for(int i = arr.Length-1; i >= 0; --i)
            {
                Console.Write(arr[i] + " ");
            }
                



        }
    }
}
