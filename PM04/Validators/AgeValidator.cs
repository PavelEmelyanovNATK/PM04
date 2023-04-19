using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM04.Validators
{
    public class AgeValidator : IValidator<string>
    {
        public bool Validate(string value)
        {
            if (!int.TryParse(value, out var age)) return false;

            return age > 0;
        }
    }
}
