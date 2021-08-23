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
        [TestMethod]
        public void TestMobileNumber()
        {
            Pattern pattern = new Pattern();
            bool result3 = pattern.ValidateMobileNumber("91 7757929383");
            Assert.IsTrue(result3);
        }
        [TestMethod]
        public void TestPasswordRule1()
        {
            Pattern pattern = new Pattern();
            bool result4 = pattern.ValidateLastName("Shubhambodake");
            Assert.IsTrue(result4);
        }
        [TestMethod]
        public void TestPasswordRule2()
        {
            Pattern pattern = new Pattern();
            bool result5 = pattern.ValidatePasswordRule2("Shubham@6476");
            Assert.IsTrue(result5);
        }
    }
}
