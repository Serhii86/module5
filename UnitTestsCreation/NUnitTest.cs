using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest;
using NUnit.Framework;

//[assembly: Parallelizable(ParallelScope.Fixtures)]
//[assembly: LevelOfParallelism(3)]
namespace NUnitTest
{
    
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class NUnitTestsForCalculator
    {
        [OneTimeSetUp]
        public void Setup() => Console.WriteLine("Starting test execution");

        [OneTimeTearDown]
        public void TearDown() => Console.WriteLine("Finishing tests execution");

        [Category("SumTests")]
        [Test]
        public void SumOfPositiveNumbers() => Assert.That(Calc.Sum(5, 5), Is.EqualTo(10));

        [Category("SumTests")]
        [Test]
        public void SumOfNegativeNumbers() => Assert.That(Calc.Sum(-2, -3), Is.EqualTo(-5));

        [Category("SumTests")]
        [Test]
        public void SumOfPositiveAndNegativeNumbers() => Assert.That(Calc.Sum(9, -3), Is.EqualTo(6));

        [Category("SubstractTests")]
        [Test]
        public void SubtractOfPositiveNumbers() => Assert.That(Calc.Subtract(25, 24), Is.EqualTo(1));

        [Category("SubtractTests")]
        [Test]
        public void SubtractOfNegativeNumbers() => Assert.That(Calc.Subtract(-11, -1), Is.EqualTo(-10));

        [Category("SubtractTests")]
        [Test]
        public void SubtractOfZeroAndPositiveNumber() => Assert.That(Calc.Subtract(0, 3), Is.EqualTo(-3));

        [Category("SubtractTests")]
        [Test]
        public void SubtractOfZeroAndNegativeNumber() => Assert.That(Calc.Subtract(0, -99), Is.EqualTo(99));

        [Category("DivideTests")]
        [Test]
        public void DivideOfPositiveNumbers() => Assert.That(Calc.Divide(25, 5), Is.EqualTo(5));

        [Category("DivideTests")]
        [Test]
        public void DivideOfNegativeNumbers() => Assert.That(Calc.Divide(-3, -3), Is.EqualTo(1));

        [Category("DivideTests")]
        [Test]
        public void DivideOfZeroAndPositiveNumbers() => Assert.That(Calc.Divide(0, 33), Is.EqualTo(0));

        [Category("DivideTests")]
        [Test]
        public void DivideOfZeroAndNegativeNumbers() => Assert.That(Calc.Divide(0, -100), Is.EqualTo(0));

        [Category("MultyplyTests")]
        [Test]
        public void MultyplyOfPositiveNumbers() => Assert.That(Calc.Multiply(7, 8), Is.EqualTo(56));

        [Category("MultyplyTests")]
        [Test]
        public void MultyplyOfNegativeNumbers() => Assert.That(Calc.Multiply(-3, -4), Is.EqualTo(12));

        [Category("MultyplyTests")]
        [Test]
        public void MultyplyOfNegativeAndPositiveNumbers() => Assert.That(Calc.Multiply(-1, 81), Is.EqualTo(-81));

        [Category("MultyplyTests")]
        [Test]
        public void MultyplyOfZeroAndNegativeNumbers() => Assert.That(Calc.Multiply(0, -200), Is.EqualTo(0));

        [Category("MultyplyTests")]
        [Test]
        public void MultyplyOfZeroAndPositiveNumbers() => Assert.That(Calc.Multiply(0, 1000), Is.EqualTo(0));
    }
}
