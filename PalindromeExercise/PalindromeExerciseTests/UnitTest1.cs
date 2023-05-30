using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("radar", true)]
        [InlineData("dummy", false)]
        [InlineData("RaceCar", true)]
        public void PTest(string word, bool expected)
        {
            var test1 = new WordSmith();

            var actual = test1.IsAPalindrome(word);

            Assert.Equal(expected, actual);
        }
    }
}
