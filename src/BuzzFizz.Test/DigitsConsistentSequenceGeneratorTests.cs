namespace BuzzFizz.Test
{
    using System.Linq;

    using DigitsSequenceGenerators;

    using NUnit.Framework;

    using Shouldly;

    public class DigitsConsistentSequenceGeneratorTests
    {
        [TestCase(1, 5)]
        [TestCase(3, 6)]
        public void Generated_digits_should_start_from_first_passed_digits(long startIndex, long endIndex)
        {
            // Arrange
            var generator = new DigitsConsistentSequenceGenerator();

            // Act
            var result = generator.Generate(startIndex, endIndex);

            // Assert
            result.First().ShouldBe(startIndex);
        }
    }
}