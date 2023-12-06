using MediatR;

namespace Application.Features.Courses.Commands.Create
{
    public class CreateCourseCommandHandler : IRequestHandler<CreateCourseCommand, CreatedCourseResponse>
    {
        public Task<CreatedCourseResponse> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new CreatedCourseResponse {
                                                               Name = request.Name,
                                                               Price = request.Price,
                                                               CategoryId = request.CategoryId
                                                             });
        }
    }
}

