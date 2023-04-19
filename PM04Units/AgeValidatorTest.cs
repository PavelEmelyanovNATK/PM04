using Microsoft.VisualStudio.TestTools.UnitTesting;
using PM04.Validators;
using System;

namespace PM04Units
{
    [TestClass]
    public class AgeValidatorTest
    {
        [TestMethod]
        public void WithLetters()
        {
            DoTest("123aas", false);
        }

        [TestMethod]
        public void WithoutLetters()
        {
            DoTest("14", true);
        }

        [TestMethod]
        public void Negative()
        {
            DoTest("-15", false);
        }

        private void DoTest(string input, bool awaitedResult)
        {
            var validator = new AgeValidator();
            var result = validator.Validate(input);
            Assert.AreEqual(result, awaitedResult);
        }
    }
}
