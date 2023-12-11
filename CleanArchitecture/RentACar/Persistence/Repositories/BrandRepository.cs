using System;
using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Context;

namespace Persistence.Repositories
{
    public class BrandRepository : EfRepositoryBase<Brand, Guid, BaseDbContext>, IBrandRepository  //EfRepositoryBase<TEntity, TEntityId, TContext>
    {
        public BrandRepository(BaseDbContext context) : base(context)
        {

        }
    }

}

