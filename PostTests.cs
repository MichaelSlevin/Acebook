using NUnit.Framework;
using System;
using TodoApi.Models;
namespace TodoApi
{
    [TestFixture, Description("this is a description")]
    public class Test
    {
        [Test, Description("Practice test: 1=2")]
        public void TestCase()
        {
            // //arrange
            // string expectedResult = "FizzBuzz";
            // int n = 15;
            // FizzBuzz2 fb = new FizzBuzz2();
            //
            // string actual = fb.ReturnFizzBuzz(n);
            // //act
            //
            // //assert
            // Assert.AreEqual(expectedResult, actual);
            Assert.AreEqual(1, 2);
        }
    }
}
