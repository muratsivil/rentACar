﻿namespace Application.Features.Brands.Commands.Create;

public class CreatedBrandResponse
{
    // Objects that I need to response
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Status { get; set; }
    public DateTime CreatedDate { get; set; }
}
