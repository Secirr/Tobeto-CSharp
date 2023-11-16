using System;
namespace Core.Utilities.Results
{

	//Temel voidler için başlangıç

	public interface IResult
	{
		

		bool Succes { get; }

		string Message { get; }
	}
}

