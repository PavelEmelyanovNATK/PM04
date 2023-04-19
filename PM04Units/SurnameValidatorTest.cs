using Microsoft.VisualStudio.TestTools.UnitTesting;
using PM04.Validators;
using System;

namespace PM04Units
{
    [TestClass]
    public class SurnameValidatorTest
    {
        [TestMethod]
        public void OneLetter()
        {
            DoTest("a", false);
        }

        [TestMethod]
        public void TwoLetters()
        {
            DoTest("aw", true);
        }

        [TestMethod]
        public void TreeLetters()
        {
            DoTest("aws", true);
        }

        [TestMethod]
        public void MoreThan35()
        {
            DoTest("awsasdasdasdasdasdasdadasdasdasdasdasdaasdasdasdsdasdasdasdasdasdasdasdasdasdasd", false);
        }

        private void DoTest(string input, bool awaitedResult)
        {
            var validator = new SurnameValidator();
            var result = validator.Validate(input);
            Assert.AreEqual(result, awaitedResult);
        }
    }
}
