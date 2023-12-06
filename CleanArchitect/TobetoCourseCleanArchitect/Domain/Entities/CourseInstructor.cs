using System;
using Core.Persistence.Repositories;

namespace Domain.Entities
{
	public class CourseInstructor : Entity<Guid> //Ara tablomuz
	{
        //Entity'den Id si geliyor (primary key)

        public Guid CourseId { get; set; } //foreign key
		public Course Course { get; set; }

		public Guid InstructorId { get; set; } //foreign key
        public Instructor Instructor { get; set; }

	}
}

