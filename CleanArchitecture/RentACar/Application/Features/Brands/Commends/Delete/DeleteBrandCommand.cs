using System;
using MediatR;

namespace Application.Features.Brands.Commends.Delete
{
	public class DeleteBrandCommand : IRequest<DeletedBrandResponse>
	{

		public string Name { get; set; }

	}
}

