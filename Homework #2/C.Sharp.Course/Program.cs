using System;
using System.IO;
using System.Linq;
using System.Threading;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace C.Sharp.Course
{
    enum DoW { 
        Monday = 1,
        Tueday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    class Program
    {
        static string Task1()
        {
            Console.WriteLine("=====TASK 1=====");
            DateTime date = DateTime.Now;
            Console.WriteLine("It is {0}, my dudes", date.DayOfWeek);
            string day = date.DayOfWeek.ToString();
            return day;
        }
        static void Task2()
        {
            Console.Write("Enter the length of an array: ");
            string len = Console.ReadLine();
            int N = int.Parse(len);
            int[] arr = new int[N];
            Random rand1 = new Random();
            for (int i = 0; i < N; i++)
            {
                arr[i] = rand1.Next(-1000, 1000);
            }
            Task2Ops(arr, N);
        }
        static void Task2Ops(int[] arr, int N)
        {
            int min, max;
            double average;
            min = arr.Min();
            max = arr.Max();
            average = arr.Average();
            Console.WriteLine("Max: {0}, Min: {1}", max, min);
        }
        static void Task3()
        {
            Console.WriteLine("=====TASK 3=====");
            Console.Write("Enter the number: ");
            string reader = Console.ReadLine();
            int number = int.Parse(reader);
            int[] arr = new int[1000];
            Random rand2 = new Random();
            int count = 0;
            for (int i = 0; i < 1000; i++)
            {
                arr[i] = rand2.Next(0, 100);
            }
            foreach (int item in arr)
            {
                if (number.Equals(item))
                    count++;
            }
            Console.WriteLine("There are {0} {1}s in array", count, number);
        }
        static void Task4()
        {
            Console.WriteLine("=====TASK 4=====");
            DateTime date1 = new DateTime(2012, 11, 1, 12, 58, 17), date2 = new DateTime(2015, 12, 31, 9, 18, 2);
            Console.WriteLine("Date1: {1}, Date2: {0}", date2, date1);
            Console.WriteLine(date2.Subtract(date1));

        }
        static void Task5()
        {
            Console.WriteLine("=====TASK 5=====");
            DateTime date3 = new DateTime(2017, 10, 10, 13, 10, 5);
            Console.WriteLine("Initial: {0}", date3);
            Random rand3 = new Random();
            Console.Write("Operation [0] - add, [1] - sub: ");
            int N = rand3.Next(72, 1000);
            string reader = Console.ReadLine();
            int switcher = int.Parse(reader);
            Console.WriteLine("Hours: {0}", N);
            switch (switcher)
            {
                case '0':
                    Console.WriteLine("Adding: {0}", date3.AddHours(-N));
                    break;
                case '1':
                    Console.WriteLine("Subtraction: {0}", date3.AddHours(-N));
                    break;
            }
        }
        static void Task6()
        {
            Console.WriteLine("=====TASK 6=====");
            Console.WriteLine("Enter the line: ");
            string line = Console.ReadLine();
            Console.Write("Enter the character: ");
            string reader = Console.ReadLine();
            char symbol = char.Parse(reader);
            int counter = 0;
            char[] arr = line.ToCharArray();
            foreach (char item in arr)
            {
                if (item.Equals(symbol))
                    counter++;
            }
            Console.WriteLine("There are {0} {1}s in the line", counter, symbol);

        }
        static void Main(string[] args)
        {
            bool flag = false;
            Console.Write("What task do you want to execute?\nChoose from 1 to 6\n");
            while (flag == false)
            {
                Console.Write("Enter the number: ");
                string reader = Console.ReadLine();
                int switcher = int.Parse(reader), num;
                switch (switcher)
                {
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                    case 3:
                        Task3();
                        break;
                    case 4:
                        Task4();
                        break;
                    case 5:
                        Task5();
                        break;
                    case 6:
                        Task6();
                        break;
                    default:
                        Console.WriteLine("WHOOPS! Wrong value...");
                        break;
                }
                Console.Write("Continue? [1] - yes, [anything] - no\nAnswer: ");
                reader = Console.ReadLine();
                num = int.Parse(reader);
                if (num != 1)
                    flag = true;
            }
            string filePath = @"D:\someText.txt";
            using (StreamWriter sw = new StreamWriter(filePath, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(Task1());
                //sw.WriteLine(10);
                //sw.WriteLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum");
            }
            int[] textArrIn = new int[1000];
            Random rand = new Random();
            using (StreamWriter sw = new StreamWriter(filePath, true, System.Text.Encoding.Default))
                for (int i = 0; i < 1000; i++)
                {
                    textArrIn[i] = rand.Next(0, 1000);
                    sw.WriteLine(textArrIn[i]);
                }
            List<int> textArrOut = new List<int>();
            using (StreamReader sr = new StreamReader(filePath, System.Text.Encoding.Default))
                try
                {
                    while (sr.ReadLine() != null)
                    {
                        textArrOut.Add(int.Parse(sr.ReadLine()));
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("ERROR! Not digits in the line...");
                }
            Console.WriteLine("Max in file: {0}\nMin in file: {1}\nAverage in file: {2}", textArrOut.Max(), textArrOut.Min(), textArrOut.Average());
            using (StreamWriter sw = new StreamWriter(filePath, true, System.Text.Encoding.Default))
                sw.WriteLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum");
        }
    }
}