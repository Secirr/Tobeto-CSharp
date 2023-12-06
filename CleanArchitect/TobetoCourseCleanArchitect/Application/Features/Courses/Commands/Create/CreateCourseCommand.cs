using System;
using MediatR;

namespace Application.Features.Courses.Commands.Create
{
	public class CreateCourseCommand : IRequest<CreatedCourseResponse> //kulanıcının girebileceği içerikler.
	{
        public string Name { get; set; }

		public decimal Price { get; set; }

        public Guid CategoryId { get; set; } //client görsede hazırda oluşacak. 
    }
}

