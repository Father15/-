using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.RegularExpressions;
using MAIN_LIBRARY;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var group = new Group1();
            // Act
            group.Godpostuplenija = 2022;

            // Assert
            Assert.AreEqual(2022, group.Godpostuplenija);
        }
    }
}
