using System;
using Core.Persistence.Repositories;

namespace Domain.Entities
{
	public class Category : Entity<Guid>
    {

        //Entity'den Id si geliyor (primary key)

		public string Name { get; set; }

        public List<Course> Courses { get; set; }

    }
}

