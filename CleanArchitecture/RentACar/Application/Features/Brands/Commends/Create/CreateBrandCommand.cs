using System;
using MediatR;

namespace Application.Features.Brands.Commends.Create
{
	public class CreateBrandCommand : IRequest<CreatedBrandResponse>
	{
		public string Name { get; set; }
	}
}

