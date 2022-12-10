using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinantialManager.Domain
{
    public class OperationResult<T> : OperationResult
    {
        public T? Result { get; set; }

        protected OperationResult(T result):base()
        {
            Result = result;
        }

        protected OperationResult(string message) : base(message)
        {            
        }

        protected OperationResult(Exception ex) : base(ex)
        {
        }

        public static OperationResult<T> SuccessResult(T result)
        {
            return new OperationResult<T>(result);
        }       

    }
}
