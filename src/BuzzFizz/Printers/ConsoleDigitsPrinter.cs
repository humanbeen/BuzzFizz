namespace BuzzFizz.Printers
{
    using System;

    using DigitsSequenceGenerators;

    using Formatters;

    public class ConsoleDigitsPrinter : IDigitsPrinter
    {
        private readonly IDigitFormater digitFormater;
        private readonly IDigitsSequenceGenerators digitsSequenceGenerators;

        public ConsoleDigitsPrinter(IDigitFormater digitFormater, IDigitsSequenceGenerators digitsSequenceGenerators)
        {
            this.digitFormater = digitFormater;
            this.digitsSequenceGenerators = digitsSequenceGenerators;
        }

        public void Print(long startDigit, long endDigit)
        {
            var digits = digitsSequenceGenerators.Generate(startDigit, endDigit);

            foreach (var digit in digits)
            {
                var value = digitFormater.Format(digit);

                Console.WriteLine(value);
            }
        }
    }
}