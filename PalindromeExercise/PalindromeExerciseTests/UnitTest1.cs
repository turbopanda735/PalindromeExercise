using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)] // ← you will need to put some test data and expected result here.
        [InlineData("kayak", true)]
        [InlineData("poop", true)]
        [InlineData("palindrome", false)]
        [InlineData("exercise", false)]
        public void PalindromeTest(string str, bool expected)
        {
            //arrange
            var palindrome = new PalindromeExercise.WordSmith();

            //act
            var actual = palindrome.IsAPalindrome(str);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
