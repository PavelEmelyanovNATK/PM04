using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM04.Validators
{
    public interface IValidator<TData>
    {
        bool Validate(TData value);
    }
}
