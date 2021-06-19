using System;
using System.Collections.Generic;
using System.Net.Cache;
using System.Text;

namespace ServicesLibrary.Validators
{
    public interface IValidator
    {
         void SetNext(IValidator checker);
         object Validate(object request);
    }
}
