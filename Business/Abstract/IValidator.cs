using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IValidator<T>
    {
         string ErrorMessage { get; set; }
         bool Validation(T entity);
    }
}
