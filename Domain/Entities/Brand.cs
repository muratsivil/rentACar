using Core.Persistence.Repositories;

namespace Domain.Entites;

public class Brand : Entity<Guid>
{
    public string Name { get; set; }   
    public string Status { get; set; }

    public Brand()
    {
        
    }
    public Brand(Guid id, string name)
    {
        Id = id;
        Name = name;
    }
}
