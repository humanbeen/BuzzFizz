using NUnit.Framework;
using Shouldly;

namespace BuzzFizz.Test
{
    public class BuzzFizzTests
    {
        [Test(Description = "This shows a possible way to write your tests")]
        public void When_multiplying_numbers_by_two_then_result_is_correct()
        {
            // Arrange
            var numberToDivide = 3;

            // Act
            var result = numberToDivide * 2;

            // Assert
            result.ShouldBe(6);
        }

        [Test]
        public void When_the_value_is_a_multiple_of_three_then_output_should_be_buzz()
        {
            // Arrange

            // Act

            // Assert
        }
    }
}
