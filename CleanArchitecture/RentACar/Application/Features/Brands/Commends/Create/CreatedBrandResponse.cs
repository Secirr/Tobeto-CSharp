using System;
namespace Application.Features.Brands.Commends.Create
{
	public class CreatedBrandResponse
	{
		public Guid Id { get; set; }

		public string Name { get; set; }

		public DateTime CreatedDAte { get; set; }
	}
}

