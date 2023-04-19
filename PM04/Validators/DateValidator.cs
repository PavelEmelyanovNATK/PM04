using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PM04.Validators
{
    public class DateValidator : IValidator<string>
    {
        private readonly Regex m_dateRegex = new Regex("^[0-9][0-9][.,][0-9][0-9][.,][0-9][0-9][0-9][0-9]");
        public bool Validate(string value)
        {
            return m_dateRegex.IsMatch(value) && DateTime.TryParse(value, out _);
        }
    }
}
