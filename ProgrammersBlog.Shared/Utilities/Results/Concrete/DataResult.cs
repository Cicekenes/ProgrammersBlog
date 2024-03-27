using ProgrammersBlog.Shared.Entities.Concrete;
using ProgrammersBlog.Shared.Utilities.Results.Abstract;
using ProgrammersBlog.Shared.Utilities.Results.ComplexTypes;

namespace ProgrammersBlog.Shared.Utilities.Results.Concrete
{
    public class DataResult<T> : IDataResult<T>
    {
        public DataResult(ResultStatus status, T data)
        {
            ResultStatus = status;
            Data = data;
        } 
        public DataResult(ResultStatus status, T data, IEnumerable<ValidationError> validationErrors)
        {
            ResultStatus = status;
            Data = data;
            ValidationErrors = validationErrors;
        }
        public DataResult(ResultStatus status, string message, T data)
        {
            ResultStatus = status;
            Data = data;
            Message = message;
        } 
        public DataResult(ResultStatus status, string message, T data, IEnumerable<ValidationError> validationErrors)
        {
            ResultStatus = status;
            Data = data;
            Message = message;
            ValidationErrors = validationErrors;
        }
        public DataResult(ResultStatus status, string message, T data, Exception exception)
        {
            ResultStatus = status;
            Data = data;
            Message = message;
            Exception = exception;
        } 
        public DataResult(ResultStatus status, string message, T data, Exception exception, IEnumerable<ValidationError> validationErrors)
        {
            ResultStatus = status;
            Data = data;
            Message = message;
            Exception = exception;
            ValidationErrors= validationErrors;
        }
        public T Data { get; }

        public ResultStatus ResultStatus { get; }

        public string Message { get; }

        public Exception Exception { get; }
        public IEnumerable<ValidationError> ValidationErrors { get; set; }
    }
}
