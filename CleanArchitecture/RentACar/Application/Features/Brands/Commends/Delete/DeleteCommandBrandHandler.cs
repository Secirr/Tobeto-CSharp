using System;
using Application.Services.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.Features.Brands.Commends.Delete
{
	public class DeleteBrandHandler : IRequestHandler<DeleteBrandCommand, DeletedBrandResponse>
	{

        IBrandRepository _brandRepository;

		public DeleteBrandHandler(IBrandRepository brandRepository)
		{
            _brandRepository = brandRepository;
        }

        public async Task<DeletedBrandResponse> Handle(DeleteBrandCommand request, CancellationToken cancellationToken)
        {
            Brand brandDelete = new Brand()
            {
                Name = request.Name
            };

            await _brandRepository.DeleteAsync(brandDelete);

            DeletedBrandResponse deletedBrandResponse = new DeletedBrandResponse()
            {
                Name = brandDelete.Name,
                DeletedDate = DateTime.UtcNow
            };

            return deletedBrandResponse;

        }
    }
}

