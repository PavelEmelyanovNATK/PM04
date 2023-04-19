using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM04.Validators
{
    public class SurnameValidator : IValidator<string>
    {
        public bool Validate(string value)
        {
            return value.Length >= 2 && value.Length <= 35;
        }
    }
}
