using UnitTestTargetProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace MyUnitTests
{
    [TestClass]
    public class MyTargetClassTests
    {
        [TestMethod]
        public void VerifySummation()
        {
            const int intFirstNumber = 15;
            const int intsecondNumber = 10;
            var objTargetClass = new MyTargetClass();
            var intResult = objTargetClass.AddNumbers(intFirstNumber, intsecondNumber);
            Assert.AreEqual(15 + 10, intResult);
        }

        [TestMethod]
        public void VerifySubtraction()
        {
            const int intFirstNumber = 15;
            const int intsecondNumber = 10;
            var objTargetClass = new MyTargetClass();
            var intResult = objTargetClass.SubractNumbers(intFirstNumber, intsecondNumber);
            Assert.AreEqual(15 - 10, intResult);
        }

        [TestMethod]
        public void VerifyDivision()
        {
            const int intFirstNumber = 15;
            const int intsecondNumber = 10;
            var objTargetClass = new MyTargetClass();
            
            // in this though there seems to be some data loss.
            var intResult = objTargetClass.DivideNumbers(intFirstNumber, intsecondNumber);

            // ensure this is always a int.
            Assert.AreEqual((int)(15 / 10), intResult);
        }
    }
}
