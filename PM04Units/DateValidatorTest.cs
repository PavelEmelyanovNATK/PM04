using Microsoft.VisualStudio.TestTools.UnitTesting;
using PM04.Validators;
using System;

namespace PM04Units
{
    [TestClass]
    public class DateValidatorTest
    {
        [TestMethod]
        public void WithPattern()
        {
            DoTest("10.02.2003", true);
        }

        [TestMethod]
        public void WithoutPattern()
        {
            DoTest("10100321", false);
        }

        private void DoTest(string input, bool awaitedResult)
        {
            var validator = new PM04.Validators.DateValidator();
            var result = validator.Validate(input);
            Assert.AreEqual(result, awaitedResult);
        }
    }

}
