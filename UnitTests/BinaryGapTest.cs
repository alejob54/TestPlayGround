using TestPlayGround;

namespace UnitTests
{
    public class BinaryGapTest
    {
        [Theory]
        [InlineData(1041, 5)] // 10000010001
        [InlineData(15, 0)]   // 1111
        [InlineData(32, 0)]   // 100000
        [InlineData(9, 2)]    // 1001
        [InlineData(529, 4)]  // 1000010001
        public void Solution_Returns_CorrectResult(int N, int expected)
        {
            // Arrange
            var binaryGap = new BinaryGap();
            
            // Act
            var result = binaryGap.Solution(N);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}