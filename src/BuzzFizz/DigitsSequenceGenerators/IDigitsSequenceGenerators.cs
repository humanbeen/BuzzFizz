namespace BuzzFizz.DigitsSequenceGenerators
{
    using System.Collections;
    using System.Collections.Generic;

    public interface IDigitsSequenceGenerators
    {
        IEnumerable<long> Generate(long start, long end);
    }
}