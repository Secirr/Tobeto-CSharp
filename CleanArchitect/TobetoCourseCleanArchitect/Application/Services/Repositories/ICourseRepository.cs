using System;
using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories
{
	public interface ICourseRepository : IAsyncRepository<Course,Guid>, IRepository<Course,Guid> //IAsyncRepository<Course, Guid> Asenkron kullanım için
																								 //IRepository<Course,Guid> Senkron kullanım için
    {
		
	}
}

