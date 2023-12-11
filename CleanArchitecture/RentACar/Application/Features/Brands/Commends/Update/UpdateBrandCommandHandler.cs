using System;
using Application.Services.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.Features.Brands.Commends.Update
{
	public class UpdateBrandCommandHandler : IRequestHandler<UpdateBrandCommand, UpdatedBrandResponse>
	{
        IBrandRepository _brandRepository;

        public UpdateBrandCommandHandler(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task<UpdatedBrandResponse> Handle(UpdateBrandCommand request, CancellationToken cancellationToken)
        {
            Brand brandUpdate = new Brand()
            {
                Name = request.Name
            };

            await _brandRepository.UpdateAsync(brandUpdate);

            UpdatedBrandResponse updatedBrandResponse = new UpdatedBrandResponse()
            {
                Name = brandUpdate.Name,
                UpdatedDate = DateTime.UtcNow
            };

            return updatedBrandResponse;
        }
    }
}

