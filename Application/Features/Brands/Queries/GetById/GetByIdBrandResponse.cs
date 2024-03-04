namespace Application.Features.Brands.Queries;

public class GetByIdBrandResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Status { get; set; } = "Initial";

    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public DateTime? DeletedDate { get; set; }
    // you can add more properties here like created date, created by, etc.
}
