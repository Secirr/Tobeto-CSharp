using System;
using Core.Persistence.Repositories;

namespace Domain.Entities
{
	public class Instructor : Entity<Guid>
	{
        //Entity'den Id si geliyor (primary key)

        public string FirstName { get; set; }

		public string LastName { get; set; }

		public int Age { get; set; }

		public List<CourseInstructor> CourseInstructors { get; set; } //Çoka çok tabloya bağlantı veriyoruz

	}
}

