using MediatR;

namespace Application.Features.Brands.Commands.Create;

public class CreateBrandCommand : IRequest<CreatedBrandResponse> // CreateBrandResponse is what it return
{
    public string Name { get; set; }

    /* 
    If CreateBrandCommand request comes, automaticly handler will be start with IRequestHandler.
    The first parameter of IRequestHandler, what is the request. And the second one is, what will be response.
    */
    public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand, CreatedBrandResponse>
    {
        public Task<CreatedBrandResponse> Handle(CreateBrandCommand request, CancellationToken cancellationToken)
        {
            CreatedBrandResponse createdBrandResponse = new CreatedBrandResponse();
            createdBrandResponse.Name = request.Name;
            createdBrandResponse.Id = Guid.NewGuid();
            return null;
        }
    }
}
