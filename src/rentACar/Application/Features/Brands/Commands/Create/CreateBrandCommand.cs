using MediatR;

namespace Application.Features.Brands.Commands.Create;

public class CreateBrandCommand : IRequest<CreatedBrandResponse>
{
    public string Name { get; set; } = default!;

    public class CreateBrandCommandHandler
        : IRequestHandler<CreateBrandCommand, CreatedBrandResponse>
    {
        public Task<CreatedBrandResponse> Handle(
            CreateBrandCommand request,
            CancellationToken cancellationToken
        )
        {
            CreatedBrandResponse response = new() { Id = Guid.NewGuid(), Name = request.Name };

            return Task.FromResult(response);
        }
    }
}
