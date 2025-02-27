﻿using System;

namespace GitExercise
{
    public static class OptionsManager
    {
        public static string[] OptionsList = {
            "a - Add",
            "s - Subtract",
            "m - Multiply",
            "d - Devide",
            "dr - Devide Remainder",
            "ex - Exit"
        };

        public static void Add(double a, double b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        public static void Multiply(double a, double b)
        {
            Console.WriteLine($"{a} x {b} = {a * b}");
        }

        public static void Subtract(double a, double b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }


        public static void DivideRemainder(double a, double b)
        {
            Console.WriteLine($"{a} % {b} = {a % b} :f2");
        }

        public static void Devide(double a, double b)
        {
            Console.WriteLine($"{a} / {b} = {a / b}");
        }
        public static void AbsoluteDevision(double a, double b)
        {
            Console.WriteLine($"{a} - {b} = {Math.Abs(a - b)}");
        }
    }
}
