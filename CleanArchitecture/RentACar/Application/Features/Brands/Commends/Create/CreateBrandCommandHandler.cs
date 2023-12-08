using System;
using Application.Services.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.Features.Brands.Commends.Create
{
    public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand,CreatedBrandResponse> //CreateBrandCommand'ı Handler ettiğinde sonuç olarak CreatedBrandResponse'u vereceksin.
    {
        IBrandRepository _brandRepository;

        public CreateBrandCommandHandler(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task<CreatedBrandResponse> Handle(CreateBrandCommand request, CancellationToken cancellationToken)
        {
            Brand brand = new Brand();
            brand.Name = request.Name;
            brand.Id = Guid.NewGuid();


            var createdBrand = await _brandRepository.AddAsync(brand); //Bana brand ver.

            CreatedBrandResponse createdBrandResponse = new CreatedBrandResponse();
            createdBrandResponse.Id = createdBrand.Id;
            createdBrandResponse.Name = createdBrand.Name;
            createdBrandResponse.CreatedDAte = createdBrand.CreatedDate;

            return createdBrandResponse;
        }
    }
}

