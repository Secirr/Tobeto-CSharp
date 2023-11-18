using System;
namespace Core.Utilities.Results.Contrete
{
	public class ErrorResult : Result
	{
        public ErrorResult() : base(false)
        {

        }

        public ErrorResult(string message) : base(message, false)
        {

        }
    }
}

