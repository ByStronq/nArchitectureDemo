using Core.Persistence.Repositories;

namespace Domain.Entities;

public class Brand : Entity<Guid>
{
    public string Name { get; set; } = default!;

    public Brand(Guid id, string name)
    {
        Id = id;
        Name = name;
    }
}
