using System.Collections.Generic;
using Xunit;
using Moq;

namespace WordReversalApp.UnitTests
{
    public class WordReversalProcessorTests
    {
        [Fact]
        public void Process_ShouldCallDependenciesCorrectly()
        {
            // Arrange
            var mockReverser = new Mock<IWordReverser>();
            mockReverser.Setup(r => r.ReverseWords(It.IsAny<string>())).Returns("mock result");

            var mockInputReader = new Mock<IInputReader>();
            mockInputReader.Setup(r => r.ReadNumberOfCases()).Returns(1);
            mockInputReader.Setup(r => r.ReadTestCases(1)).Returns(new List<string> { "test case" });

            var mockOutputWriter = new Mock<IOutputWriter>();

            var processor = new WordReversalProcessor(mockReverser.Object, mockInputReader.Object, mockOutputWriter.Object);

            // Act
            processor.Process();

            // Assert
            mockInputReader.Verify(r => r.ReadNumberOfCases(), Times.Once);
            mockInputReader.Verify(r => r.ReadTestCases(1), Times.Once);
            mockReverser.Verify(r => r.ReverseWords("test case"), Times.Once);
            mockOutputWriter.Verify(w => w.WriteResult(1, "mock result"), Times.Once);
        }
    }
}