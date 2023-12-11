using System;
using MediatR;

namespace Application.Features.Brands.Commends.Update
{
	public class UpdateBrandCommand : IRequest<UpdatedBrandResponse>
	{
		public string Name { get; set; }

	}
}

