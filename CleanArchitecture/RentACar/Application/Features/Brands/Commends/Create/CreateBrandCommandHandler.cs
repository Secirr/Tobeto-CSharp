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
            Brand brandCreate = new Brand()
            {
                Name = request.Name
            };


            await _brandRepository.AddAsync(brandCreate);

            CreatedBrandResponse createdBrandResponse = new CreatedBrandResponse()
            {
                Name = brandCreate.Name,
                CreatedDate = brandCreate.CreatedDate
            };

            return createdBrandResponse;
        }
    }
}

