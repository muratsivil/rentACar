﻿namespace Application.Features.Brands.Queries;

public class GetByIdBrandResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    // you can add more properties here like created date, created by, etc.
}
