using Microsoft.VisualStudio.TestTools.UnitTesting;
using PM04.Validators;
using System;

namespace PM04Units
{
    [TestClass]
    public class NameValidatorTest
    {
        [TestMethod]
        public void OneLetter()
        {
            DoTest("a", false);
        }

        [TestMethod]
        public void TwoLetters()
        {
            DoTest("aw", false);
        }

        [TestMethod]
        public void TreeLetters()
        {
            DoTest("aws", true);
        }

        [TestMethod]
        public void MoreThan30()
        {
            DoTest("awsasdasdasdasdasdasdadasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasd", false);
        }

        private void DoTest(string input, bool awaitedResult)
        {
            var validator = new NameValidator();
            var result = validator.Validate(input);
            Assert.AreEqual(result, awaitedResult);
        }
    }
}
