using System;
using System.Buffers.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace integrals_parsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Carla Baysinger
            //Integrals and Parsing
            //April 19th 2024

            Part1();
            Part2();
            Part3();
        } //main

        public static void Part1()
        {
            //1. 5 + 3 =
            //2. 10 - 4 =
            //3. 6 * 2 =
            //4. 12 + 7 =
            // 5. 20 - 9 =
            //6. 4 * 5 =

            int f = 5;
            int t = 3;
            int sum = f + t;
            Console.WriteLine($"{f} + {t} = {sum}");

            int te = 10;
            int fo = 4;
            int dif = te - fo;
            Console.WriteLine($"{te} - {fo} = {dif}");

            int s = 6;
            int mul = s * fo;
            Console.WriteLine($"{s} * {fo} = {mul}");

            int tw = 12;
            int se = 7;
            int sum2 = tw + se;
            Console.WriteLine($"{tw} + {se} = {sum2}");

            int ty = 20;
            int n = 9;
            int dif2 = ty - n;
            Console.WriteLine($"{ty} - {9} = {dif2}");

            int mul2 = fo * f;
            Console.WriteLine($"{fo} * {f} = {mul2}");
        }

        public static void Part2()
        {
            Console.Write("Enter number 1: ");

            string userResponse1 = Console.ReadLine();

            int num1 = int.Parse(userResponse1);

            Console.Write("Enter number 2: ");

            string userResponse2 = Console.ReadLine();

            int num2 = int.Parse(userResponse1);

            int q1 = num1 + num2;

            int q2 = num1 - num2;

            int q3 = q1 * q2;

            Console.WriteLine("Question 1: " + num1 + " + " + num2 + " = " + q1);

            Console.WriteLine("Question 2: " + num1 + " - " + num2 + " = " + q2);

            Console.WriteLine("Question 3: " + q1 + " * " + q2 + " = " + q3);
        }

        public static void Part3()
        {
            int value = 543;
            int base10 = 10;
            int sum = 0;
            int singleValue = value % base10;
            sum += singleValue;
            value /= base10;

            Console.WriteLine($"Current Value: {value}");
            Console.WriteLine($"Sum: {sum}");
            singleValue = value % base10;
            sum += singleValue;
            value /= base10;
            Console.WriteLine($"Current Value: {value}");
            Console.WriteLine($"Sum: {sum}");
            singleValue = value % base10;
            sum += singleValue;
            value /= base10;


            Console.WriteLine($"Current Value: {value}");
            Console.WriteLine($"Sum: {sum}");

            //Can an Integral hold a whole number? yes
            //What happens when you try to assign one? has a squigally until its used
            //Why and when do we "parse" a value(convert a string type to another type like int )? when it needs to be changed for computer to understand
            //What is the main difference between the different integral types? size
        }

    }
}
