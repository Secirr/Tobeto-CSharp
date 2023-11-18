using System;
using Core.Utilities.Results.Abstract;

namespace Core.Utilities.Results.Contrete
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(bool success,T data) : base(success)
        {
           Data = data;
        }

        public DataResult(string message, bool success, T data) : base(message, success)
        {
            Data = data;
        }

        public T Data { get; }
    }
}

