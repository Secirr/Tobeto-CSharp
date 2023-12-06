using System;
using MediatR;

namespace Application.Features.Courses.Commands.Create
{
	public class CreatedCourseResponse //Client'e göstereceklerimiz
	{
        public string Name { get; set; }

        public decimal Price { get; set; }

        public Guid CategoryId { get; set; } //client görsede hazırda oluşacak.
    }
}

