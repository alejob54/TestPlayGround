using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class Excercise1
    {
        [Theory]
        [InlineData("two-two-one-two",-3)]
        [InlineData("one+two-one-one+two+one",4)]
        [InlineData("two",2)]
        public void TestExcercise1(string input, int result)
        {
            //Arrange
            var excercise1 = new TestPlayGround._99._MS_Test.Excercise1();
            //Act
            var output = excercise1.Solution(input);

            //Assert
            Assert.Equal(result, output);
        }

        [Theory]
        [InlineData(new int[] { 2,7,4,6,3,1 },true)]
        [InlineData(new int[] { -1, -1 }, false)]
        [InlineData(new int[] { 2, -1 }, true)]
        [InlineData(new int[] { 1,2,3,4 }, true)]
        [InlineData(new int[] { -1,-3,4,7,7,7 }, false)]
        public void TestExcercise2(int[] input, bool  result)
        {
            //Arrange
            var excercise2 = new TestPlayGround._99._MS_Test.Excercise2();
            //Act
            var output = excercise2.Solution(input);

            //Assert
            Assert.Equal(result, output);
        }
    }
}
