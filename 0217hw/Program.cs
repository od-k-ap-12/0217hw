using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0217hw
{
    class Program
    {
        public static void findEven(int[] arr)
        {
            foreach(int i in arr)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i+" ");
                }
            }
        }
        public static void findOdd(int[] arr)
        {
            foreach (int i in arr)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
        public static void findPrime(int[] arr)
        {
            foreach(int i in arr)
            {
                if (ifPrime(i) == true)
                {
                    Console.Write(i + " ");
                }
            }
        }
        public static void findFibonacci(int[] arr)
        {
            foreach(int i in arr)
            {
                if (ifFibonacci(i) == true)
                {
                    Console.Write(i + " ");
                }
            }
        }
        public static bool ifPrime(int a)
        {
            if (a == 1)
            {
                return true;
            }
            else if (a < 1)
            {
                throw new Exception("Out of range");
            }
            else
            {
                for (int i = 2; i < a; i++)
                {
                    if (a % i == 0)
                        return false;
                }
                return true;
            }
        }

        public static bool ifFibonacci(int a)
        {
            if (a == 1)
            {
                return true;
            }
            else if (a < 1)
            {
                throw new Exception("Out of range");
            }
            else
            {
                int FirstNum = 0;
                int SecondNum = 1;
                int CurrentNum;
                for (int i = 0; i < a; i++)
                {
                    CurrentNum = FirstNum + SecondNum;
                    if (CurrentNum == a)
                    {
                        return true;
                    }
                    else
                    {
                        FirstNum = SecondNum;
                        SecondNum = CurrentNum;
                    }
                }
                return false;
            }
        }
        public static void ShowCurrentTime()
        {
            DateTime datetime = DateTime.Now;
            Console.WriteLine(datetime.ToString("T"));
        }
        public static void ShowCurrentDate()
        {
            DateTime datetime = DateTime.Now;
            Console.WriteLine(datetime.ToString("D"));
        }
        public static void ShowCurrentDayOfWeek()
        {
            DateTime datetime = DateTime.Now;
            Console.WriteLine(datetime.DayOfWeek);
        }
        public static int TriangleArea(int a,int h)
        {
            return a * h * 1 / 2;
        }
        public static int RectangleArea(int a,int b)
        {
            return a * b;
        }
        public delegate int AreaMethods(int a, int b);
        public delegate void DateTimeMethods();
        public delegate void ArrayMethods(int[]arr);
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] arr = new int[20];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1, 10);
            }
            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
            ArrayMethods[] newarr = new ArrayMethods[] { findEven, findOdd, findPrime, findFibonacci };
            for(int i = 0; i < newarr.Length; i++)
            {
                Console.WriteLine();
                newarr[i].Invoke(arr);
            }


            DateTimeMethods[] newdatetime = new DateTimeMethods[] { ShowCurrentDate, ShowCurrentDayOfWeek, ShowCurrentTime};
            for (int i = 0; i < newdatetime.Length; i++)
            {
                Console.WriteLine();
                newdatetime[i]();
            }


            Console.WriteLine();
            int a = 3, b = 4;
            AreaMethods newshape = new AreaMethods(TriangleArea);
            Console.WriteLine(newshape(a,b));
            newshape = RectangleArea;
            Console.WriteLine(newshape(a, b));
        }
    }
}
