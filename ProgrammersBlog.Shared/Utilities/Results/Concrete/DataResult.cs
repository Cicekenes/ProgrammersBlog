using ProgrammersBlog.Shared.Utilities.Results.Abstract;
using ProgrammersBlog.Shared.Utilities.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Shared.Utilities.Results.Concrete
{
    public class DataResult<T> : IDataResult<T>
    {
        public DataResult(ResultStatus status, T data)
        {
            ResultStatus = status;
            Data = data;
        }
        public DataResult(ResultStatus status, string message, T data)
        {
            ResultStatus = status;
            Data = data;
            Message = message;
        }
        public DataResult(ResultStatus status, string message, T data, Exception exception)
        {
            ResultStatus = status;
            Data = data;
            Message = message;
            Exception = exception;
        }
        public T Data { get; }

        public ResultStatus ResultStatus { get; }

        public string Message { get; }

        public Exception Exception { get; }
    }
}
