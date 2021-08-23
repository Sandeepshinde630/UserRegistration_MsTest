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
    }
}
