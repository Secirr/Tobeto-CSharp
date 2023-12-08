using System;
namespace Core.Utilities.Results.Contrete
{
	public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data) : base(false, data)
        {

        }

        public ErrorDataResult(string message, T data) : base(message, false, data)
        {

        }

        public ErrorDataResult() : base(false, default)
        {

        }

        public ErrorDataResult(string message) : base(message, false, default)
        {

        }
    }
}

