using NUnit.Framework;
using Shouldly;

namespace BuzzFizz.Test
{
    public class BuzzFizzTests
    {
        [Test(Description = "This shows a possible way to write your tests")]
        [TestCase(3, 6)]
        [TestCase(4, 8)]
        public void When_multiplying_numbers_by_two_then_result_is_doubled(int originalValue, int expectedValue)
        {
            // Arrange / Act
            var result = originalValue * 2;

            // Assert
            result.ShouldBe(expectedValue);
        }

        [Test()]
        public void When_the_value_is_a_multiples_of_three_then_output_should_be_buzz()
        {
            // Arrange

            // Act

            // Assert
        }
    }
}
