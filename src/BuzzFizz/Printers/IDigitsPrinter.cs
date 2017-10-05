namespace BuzzFizz.Printers
{
    using System.Collections.Generic;

    public interface IDigitsPrinter
    {
        void Print(long startDigit, long endDigit);
    }
}