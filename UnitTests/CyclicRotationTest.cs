using TestPlayGround;

namespace UnitTests
{
    public class CyclicRotationTest
    {
        [Theory]
        [InlineData(new int[] { 3, 8, 9, 7, 6 }, new int[] { 9, 7, 6, 3, 8 }, 3)]
        [InlineData(new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 }, 1)]
        [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4 }, 4)]
        [InlineData(new int[] { 1000 }, new int[] { 1000 }, 5)]
        [InlineData(new int[] { 1, 1, 2, 3, 5 }, new int[] { 3, 5, 1, 1, 2 }, 42)]
        public void Solution_Returns_CorrectResult(int[]A, int[] B, int K)
        {
            // Arrange
            var cyclicRotation = new CyclicRotation();

            // Act
            var result = cyclicRotation.Solution(A, K);

            // Assert
            Assert.Equal(B, result);
        }
    }
}
