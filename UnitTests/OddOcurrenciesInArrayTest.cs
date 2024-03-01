using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPlayGround;
using TestPlayGround._2._Arrays;

namespace UnitTests
{
    public class OddOcurrenciesInArrayTest
    {
        [Theory]
        [InlineData(new int[] { 9, 3, 9, 3, 9, 7, 9 }, 7)]
        public void TestSolution(int[]A, int B)
        {
            // Arrange
            var oddOcurrencies = new OddOcurrencesInArray();

            // Act
            var result = oddOcurrencies.Solution(A);

            // Assert
            Assert.Equal(B, result);
        }
    }
}
