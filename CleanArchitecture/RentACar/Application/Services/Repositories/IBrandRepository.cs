using System;
using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories
{
    public interface IBrandRepository : IRepository<Brand, Guid>, IAsyncRepository<Brand, Guid>
	{
	}
}

