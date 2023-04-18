using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SlavaWorkz;

namespace Unit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MainWindow mw = new MainWindow();
            string field1 = "gfhfghk";
            string field2 = "fgdffdfgd";
            string field3 = "+1-111-111-11-11";
            string expected = "Ввод прошел успешно!";

            // Act
            string actual = Class.Verification(field1, field2, field3);

            // Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string field1 = "gfhfghk";
            string field2 = "fgdffdfgd";
            string field3 = "1-111-111-11-11";
            string expected = "Неверный формат ввода! Проверьте ввод и повторите попытку.";

            // Act
            string actual = Class.Verification(field1, field2, field3);

            // Assert

            Assert.AreEqual(expected, actual);
        }
    }
}
