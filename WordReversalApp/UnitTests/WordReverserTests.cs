using System.Collections.Generic;
using Xunit;
using Moq;

namespace WordReversalApp.UnitTests
{
    public class WordReverserTests
    {
        [Fact]
        public void ReverseWords_ShouldReverseWordsInString()
        {
            // Arrange
            var wordReverser = new WordReverser();

            // Act
            var result = wordReverser.ReverseWords("hello world");

            // Assert
            Assert.Equal("world hello", result);
        }

        [Fact]
        public void ReverseWords_ShouldHandleEmptyString()
        {
            // Arrange
            var wordReverser = new WordReverser();

            // Act
            var result = wordReverser.ReverseWords("");

            // Assert
            Assert.Equal(string.Empty, result);
        }
    }
}
