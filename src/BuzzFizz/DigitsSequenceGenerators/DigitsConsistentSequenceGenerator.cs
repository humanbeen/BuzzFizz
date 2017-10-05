namespace BuzzFizz.DigitsSequenceGenerators
{
    using System.Collections.Generic;

    public class DigitsConsistentSequenceGenerator : IDigitsSequenceGenerators
    {
        public IEnumerable<long> Generate(long startDigit, long endDigit)
        {
            var digits = new List<long>();

            for (long digit = startDigit; digit <= endDigit; digit++)
            {
                digits.Add(digit);
            }

            return digits;
        }
    }
}