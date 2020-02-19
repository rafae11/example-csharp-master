using UnitTestTargetProject;
using Xunit;
using NUnit.Framework;

namespace MyUnitTests
{
    [TestFixture]

    public class MyTargetClassTests
    {
        [Test]

        public void VerifySummation()
        {
            const int intFirstNumber = 15;
            const int intsecondNumber = 10;
            var objTargetClass = new MyTargetClass();
            var intResult = objTargetClass.AddNumbers(intFirstNumber, intsecondNumber);
            NUnit.Framework.Assert.AreEqual(15 + 10, intResult);
        }

        [Test]

        public void VerifySubtraction()
        {
            const int intFirstNumber = 15;
            const int intsecondNumber = 10;
            var objTargetClass = new MyTargetClass();
            var intResult = objTargetClass.SubractNumbers(intFirstNumber, intsecondNumber);
            NUnit.Framework.Assert.AreEqual(15 - 10, intResult);
        }

        [Test]

        public void VerifyDivision()
        {
            const int intFirstNumber = 15;
            const int intsecondNumber = 10;
            var objTargetClass = new MyTargetClass();
            
            // in this though there seems to be some data loss.
            var intResult = objTargetClass.DivideNumbers(intFirstNumber, intsecondNumber);

            // ensure this is always a int.
            NUnit.Framework.Assert.AreEqual((int)(15 / 10), intResult);
        }
    }
}
