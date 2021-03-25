using NUnit.Framework;
using XamarinCI.Shared;

namespace XamarinCI.UnitTest
{
    public class CustomUnitTest
    {
        [Test]
        public void CalcTestTrue()
        {
            var calc = new CalculatorModel(new Model { X = 0, Y = 3 });
            var result = calc.Calculate();
            Assert.IsTrue(result == 3);
        }

        [Test]
        public void CalcTestFalse()
        {
            var calc = new CalculatorModel(new Model { X = 6, Y = 3 });
            var result = calc.Calculate();
            Assert.IsFalse(result == 3);
        }
    }
}