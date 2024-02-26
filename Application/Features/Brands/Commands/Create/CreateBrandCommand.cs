using Application.Services.Repositories;
using Domain.Entites;
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
        private readonly IBrandRepository _brandRepository;

        public CreateBrandCommandHandler(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task<CreatedBrandResponse> Handle(CreateBrandCommand request, CancellationToken cancellationToken)
        {
            Brand brand = new()
            {
                Name = request.Name,
                Id = Guid.NewGuid()
            };
            var result = await _brandRepository.AddAsync(brand);
            CreatedBrandResponse createdBrandResponse = new()
            {
                Name = result.Name,
                Id = result.Id
            };
            return createdBrandResponse;
        }
    }
}
