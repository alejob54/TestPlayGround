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
        [InlineData(805306373, 25)]  // 110000000000000000000000000101
        [InlineData(74901729, 4)]  // 100011101101110100011100001
        [InlineData(66561, 9)]  // 10000010000000001
        [InlineData(561892, 3)]  // 10001001001011100100
        [InlineData(2147483647, 0)]
        [InlineData(1, 0)]
        [InlineData(5, 1)]
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