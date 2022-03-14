using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<T> : IDataResult<T>
    {
        public DataResult(T data, bool success, string message)
        {
            Data = data;
            Success = success;
            Message = message;
        }
        public T Data { get; }

        public bool Success { get; }

        public string Message { get; }
    }
}
