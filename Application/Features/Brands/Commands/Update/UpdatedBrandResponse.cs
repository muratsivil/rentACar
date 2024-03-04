namespace Application.Features.Brands.Commands.Update;

public class UpdatedBrandResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Status { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    // you can add more properties here like created date, created by, etc.

}
