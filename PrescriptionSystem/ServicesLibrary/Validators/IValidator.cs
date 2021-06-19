using System;
using System.Collections.Generic;
using System.Net.Cache;
using System.Text;

namespace ServicesLibrary.Validators
{
    public interface IValidator
    {
         IValidator SetNext(IValidator checker);
         object Validate(object request);
    }
}
