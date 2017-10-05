namespace BuzzFizz.Constants
{
    using System.Collections.Generic;

    public class ValueProvidersConstants
    {
        public static readonly Dictionary<int, string> ThreeAndFiveReplacement = new Dictionary<int, string>
                                                                          {
                                                                              { 3, "Buzz" },
                                                                              { 5, "Fizz" }
                                                                          };
    }
}