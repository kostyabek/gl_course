using System;
using System.Linq;
using System.Threading;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace C.Sharp.Course
{
    class Program
    {
        public
        static void animation(int delay, Stopwatch timer, Random rand, ConsoleColor textColor) {
            Console.ForegroundColor = textColor;
            timer.Start();
            Thread.Sleep(delay);
            Console.Write('/');
            timer.Stop();
            timer.Start();
            Thread.Sleep(delay);
            Console.CursorLeft--;
            Console.Write('-');
            timer.Stop();
            timer.Start();
            Thread.Sleep(delay);
            Console.CursorLeft--;
            Console.Write('\\');
            timer.Stop();
            timer.Start();
            Thread.Sleep(delay);
            Console.CursorLeft--;
            Console.Write('-');
            timer.Stop();
            timer.Start();
            Thread.Sleep(delay);
            Console.CursorLeft--;
            Console.Write('|');
            timer.Stop();
        }
        static void Main(string[] args)
        {
            ////TASK 1
            //Console.WriteLine("==========TASK 1==========");
            //Console.Write("Enter the line to revert: ");
            //string str1 = Console.ReadLine();
            //char[] IniArr1 = str1.ToCharArray();
            //Array.Reverse(IniArr1);
            //string FinArr1 = String.Concat(IniArr1);
            //Console.WriteLine(FinArr1);

            ////TASK 2
            //Console.WriteLine("==========TASK 2==========");
            //Console.Write("Enter the line: ");
            //string str2 = Console.ReadLine();
            //char[] IniArr2 = str2.ToCharArray();
            //Console.Write("Enter n: ");
            //int n1 = int.Parse(Console.ReadLine());
            //bool flag = false;
            //while (flag == false)
            //{
            //    if (n1 > str2.Length || n1 < 0)
            //    {
            //        Console.WriteLine("ERROR! *n > line length OR n < 0*");
            //        Console.Write("Enter n: ");
            //        n1 = int.Parse(Console.ReadLine());
            //    }
            //    else
            //    {
            //        for (int i = n1 - 1; i < str2.Length; i += n1)
            //        {
            //            IniArr2[i] = char.ToUpper(IniArr2[i]);
            //        }
            //        string FinArr2 = String.Concat(IniArr2);
            //        Console.WriteLine(FinArr2);
            //        flag = true;
            //    }
            //}
            //flag = false;

            ////TASK 3
            //Console.WriteLine("==========TASK 3==========");
            //Console.Write("Enter the line: ");
            //string str3 = Console.ReadLine();
            //char[] IniArr3 = str3.ToCharArray();
            //Console.Write("Enter n: ");
            //int n2 = int.Parse(Console.ReadLine());
            //while (flag == false)
            //{
            //    if (n2 > str3.Length || n2 < 0)
            //    {
            //        Console.WriteLine("ERROR! *n > line length OR n < 0*");
            //        Console.Write("Enter n: ");
            //        n2 = int.Parse(Console.ReadLine());
            //    }
            //    else
            //    {
            //        IniArr3[n2 - 1] = char.ToUpper(IniArr3[n2 - 1]);
            //        string FinArr3 = String.Concat(IniArr3);
            //        Console.WriteLine(FinArr3);
            //        flag = true;
            //    }
            //}

            ////TASK 4
            //Console.WriteLine("==========TASK 4==========");
            //Console.Write("Enter the line: ");
            //string str4 = Console.ReadLine();
            //char[] IniArr4 = str4.ToCharArray();
            //for (int i = 0; i < IniArr4.Length; i++)
            //{
            //    if (char.IsDigit(IniArr4[i]) == true)
            //    {
            //        Console.WriteLine("No letters");
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine("There are letters in the line!");
            //        break;
            //    }
            //}

            ////TASK 5
            //Console.WriteLine("==========TASK 5==========");
            //Console.Write("Enter the line: ");
            //string str5 = Console.ReadLine(), str5_c;
            //str5_c = str5;
            //char[] IniArr5 = str5.ToCharArray();

            //Array.Reverse(IniArr5);
            //string FinArr5 = String.Concat(IniArr5);
            //if (str5_c == FinArr5)
            //{
            //    Console.WriteLine("Palindrome!");
            //}
            //else
            //{
            //    Console.WriteLine("Not palindrome!");
            //}

            ////TASK 6
            //Console.WriteLine("==========TASK 6==========");
            //Console.Write("Enter the 1st number: ");
            //int n3 = int.Parse(Console.ReadLine());
            //Console.Write("Enter the 2nd number: ");
            //int n4 = int.Parse(Console.ReadLine()), result;
            //result = n3 * n4;
            //Console.WriteLine("result = {0}", result);

            ////TASK 7
            //Console.WriteLine("==========TASK 7==========");
            //string str7 = Console.ReadLine();
            //str7 = Regex.Replace(str7, "[A-Za-z]", "");
            //Console.WriteLine(str7);

            ////TASK 8
            //Console.WriteLine("==========TASK 7==========");
            //string str8 = Console.ReadLine();
            //str8 = Regex.Replace(str8, "[ ]", "");
            //Console.WriteLine(str8);

            //EXTRA TASK
            Console.CursorLeft = 0;
            Console.Write('[');
            Console.CursorLeft = 37;
            Console.Write(']');
            Console.CursorLeft = 1;
            Console.ForegroundColor = ConsoleColor.White;

            int curPos = 1, delay;
            ConsoleColor textColor = ConsoleColor.White;
            Console.CursorLeft = curPos;
            Random rand = new Random();
            Stopwatch timer = new Stopwatch();
            while (Console.CursorLeft < 37)
            {
                switch (curPos)
                {
                    case 1:
                        textColor = ConsoleColor.Red;
                        break;
                    case 10:
                        Console.CursorLeft = 1;
                        textColor = ConsoleColor.DarkYellow;
                        for (int i = 0; i < 9; i++)
                        {
                            Console.Write('|');
                        }
                        break;
                    case 19:
                        Console.CursorLeft = 1;
                        textColor = ConsoleColor.Yellow;
                        for (int i = 0; i < 17; i++)
                        {
                            Console.Write('|');
                        }
                        break;
                    case 28:
                        Console.CursorLeft = 1;
                        textColor = ConsoleColor.Green;
                        for (int i = 0; i < 26; i++)
                        {
                            Console.Write('|');
                        }
                        break;
                }
                delay = rand.Next(100, 150);
                animation(delay, timer, rand, textColor);
                Console.CursorLeft = 39;
                Console.Write("{0:0.00}", (100 / 37f * curPos));
                Console.Write('%');
                Console.CursorLeft = curPos++;
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
    }
}
