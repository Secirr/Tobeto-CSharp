using System;
using Core.Persistence.Repositories;

namespace Domain.Entities
{
	public class Course : Entity<Guid>
	{
        public Guid CategoryId { get; set; }

        public string Name { get; set; }

		public decimal Price { get; set; }

        public Category Category { get; set; }

        public List<CourseInstructor> CourseInstructors { get; set; } //Çoka çok tabloya bağlantı veriyoruz
    }
}

