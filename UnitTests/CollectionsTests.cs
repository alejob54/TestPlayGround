using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPlayGround._98._Study;

namespace UnitTests
{
    public class CollectionsTests
    {
        #region Direct Access Collections

        [Theory]
        [InlineData("Alejandro")]
        [InlineData("Mango")]
        [InlineData("Lola")]
        public void TestString(string name)
        {
            Collections collections = new();

            var response = collections.TestStrings(name);
            Assert.Equal(response.Length, name.Length);
        }

        [Theory]
        [InlineData(new object[] { new string[] { "1", "2", "3", "4", "5", "6" }, "654321" })]
        [InlineData(new object[] { new string[] { "0", "1", "2", "3" }, "3210" })]
        [InlineData(new object[] { new string[] { "9", "9", "7" }, "799" })]
        public void TestArray(string[] array, string reversed)
        {
            Collections collections = new();

            var response = collections.TestArrays(array);
            Assert.Equal(response.Length, reversed.Length);
            Assert.Equal(string.Join("", response).ToString(), reversed);
        }

        [Theory]
        [InlineData(new object[] { "Alejandro", "Bastidas" })]
        public void TestStruct(string name, string lastname)
        {
            Collections collections = new();

            var response = collections.TestStruct(name, lastname);
            Assert.Equal(response, string.Join(" ", name, lastname));
            Assert.Equal(response.Length, (name.Length + lastname.Length)+1);
            Assert.Contains(" ", response);
        }

        #endregion
    }
}
