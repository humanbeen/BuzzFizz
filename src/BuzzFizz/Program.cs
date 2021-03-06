﻿namespace BuzzFizz
{
    using System;

    using DigitsSequenceGenerators;

    using Formatters;

    using Printers;

    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Write a program that prints to the console the numbers from 1 to 100
             * But for multiples of three print "Buzz" instead of the number 
             * and for the multiples of five print "Fizz".
             * For numbers which are multiples of both three and five print "BuzzFizz"
             */

            IDigitsPrinter digitsPrinter = new ConsoleDigitsPrinter(new ThreeAndFiveDigitFormater(), new DigitsConsistentSequenceGenerator());

            digitsPrinter.Print(1, 100);

            Console.ReadLine();
        }
    }
}
