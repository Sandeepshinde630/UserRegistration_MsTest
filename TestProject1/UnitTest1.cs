using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration_MSTest;


namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestValidateFirstName()
        {
            Pattern pattern = new Pattern();
            bool result = pattern.ValidateFirstName("Sandeep");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestValidateLastName()
        {
            Pattern pattern = new Pattern();
            bool result1 = pattern.ValidateLastName("Shinde");
            Assert.IsTrue(result1);
        }

        [TestMethod]
        public void TestValidateEmail()
        {
            Pattern pattern = new Pattern();
            bool result2 = pattern.ValidateEmail("Sandeepshinde630@gmail.com");
            Assert.IsTrue(result2);
        }
    }
}
