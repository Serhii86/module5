using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestUnitTests
{
    [TestClass]
    public class MSTestUnitTestForCalculator
    {
        [ClassInitialize]
        public static void ClassInit(TestContext context) => Console.WriteLine("Class initializing and starting test execution");

        [ClassCleanup]
        public static void ClassClean() => Console.WriteLine("Class cleaning up and finishing test execution");

        [TestMethod, TestCategory("SumTests")]
        public void SumOfPositiveNumbers() => Assert.AreEqual(new CSharpCalculator.Calculator().Add(5, 5), 10);

        [TestMethod, TestCategory("SumTests")]
        public void SumOfNegativeNumbers() => Assert.AreEqual(new CSharpCalculator.Calculator().Add(-2, -3), -5);

        [TestMethod, TestCategory("SumTests")]
        public void SumOfPositiveAndNegativeNumbers() => Assert.AreEqual(new CSharpCalculator.Calculator().Add(9, -3), 6);

        [TestMethod, TestCategory("SubtractTests")]
        public void SubtractOfPositiveNumbers() => Assert.AreEqual(new CSharpCalculator.Calculator().Sub(25, 24), 1);

        [TestMethod, TestCategory("SubtractTests")]
        public void SubtractOfNegativeNumbers() => Assert.AreEqual(new CSharpCalculator.Calculator().Sub(-11, -1), -10);

        [TestMethod, TestCategory("SubtractTests")]
        public void SubtractOfZeroAndPositiveNumber() => Assert.AreEqual(new CSharpCalculator.Calculator().Sub(0, 3), -3);

        [TestMethod, TestCategory("SubtractTests")]
        public void SubtractOfZeroAndNegativeNumber() => Assert.AreEqual(new CSharpCalculator.Calculator().Sub(0, -99), 99);

        [TestMethod, TestCategory("DivideTests")]
        public void DivideOfPositiveNumbers() => Assert.AreEqual(new CSharpCalculator.Calculator().Divide(0, -99), 0);

        [TestMethod, TestCategory("DivideTests")]
        public void DivideOfNegativeNumbers() => Assert.AreEqual(new CSharpCalculator.Calculator().Divide(0, -99), 0);

        [TestMethod, TestCategory("DivideTests")]
        public void DivideOfZeroAndPositiveNumbers() => Assert.AreEqual(new CSharpCalculator.Calculator().Divide(0, 33), 0);

        [TestMethod, TestCategory("DivideTests")]
        public void DivideOfZeroAndNegativeNumbers() => Assert.AreEqual(new CSharpCalculator.Calculator().Divide(0, -100), 0);

        [TestMethod, TestCategory("MultyplyTests")]
        public void MultyplyOfPositiveNumbers() => Assert.AreEqual(new CSharpCalculator.Calculator().Multiply(7, 8), 56);

    }
}
