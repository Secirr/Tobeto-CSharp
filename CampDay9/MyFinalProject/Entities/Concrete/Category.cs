using System;
using Core.Entitites;

namespace Entities.Concrete
{

	//Çıplak class kalmasın

	public class Category : IEntity
	{
		public int CategoryId { get; set; }

		public string CategoryName { get; set; }
	}
}

