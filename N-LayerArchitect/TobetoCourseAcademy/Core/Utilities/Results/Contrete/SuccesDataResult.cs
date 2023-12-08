using System;
namespace Core.Utilities.Results.Contrete
{
    public class SuccesDataResult<T> : DataResult<T>
    {
        public SuccesDataResult(T data) : base(true, data)
        {

        }

        public SuccesDataResult(string message, T data) : base(message, true, data)
        {

        }

        public SuccesDataResult() : base(true,default)
        {

        }

        public SuccesDataResult(string message) : base(message, true, default)
        {

        }


    }
}

