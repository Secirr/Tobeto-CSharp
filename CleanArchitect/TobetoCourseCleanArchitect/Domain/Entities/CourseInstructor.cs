using System;
using Core.Persistence.Repositories;

namespace Domain.Entities
{
	public class CourseInstructor : Entity<Guid> //Ara tablomuz
	{
		//primary key Entity den geliyor

		public Guid CourseId { get; set; } //foreign key
		public Course Course { get; set; }

		public Guid InstructorId { get; set; } //foreign key
        public Instructor Instructor { get; set; }

	}
}

