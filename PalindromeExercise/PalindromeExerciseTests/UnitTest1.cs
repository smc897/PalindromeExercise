using PalindromeExercise;
using System;
using Xunit;
using Xunit.Sdk;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("tacocat",true)]
        [InlineData("taco",false)]
        [InlineData("racecar",true)]
        public void PalindromeTest(String input, bool expected)
        {
            //arrange
            WordSmith ws = new WordSmith();

            //act
            var actual = ws.IsAPalindrome(input);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
