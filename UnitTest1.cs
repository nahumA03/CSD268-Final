using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CanDriveTests
{
    [TestClass]
    public class UnitTest1
    {
        public bool CanDrive(int age)
        {

            const int drivingAge = 16; return age >= drivingAge;

        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsFalse(CanDrive(int.MinValue));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsFalse(CanDrive(int.MinValue + 1));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsFalse(CanDrive(15));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsTrue(CanDrive(16));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.IsTrue(CanDrive(17));
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.IsTrue(CanDrive(int.MaxValue - 1));
        }

        [TestMethod]
        public void TestMethod7()
        {
            Assert.IsTrue(CanDrive(int.MaxValue));
        }
    }
}
