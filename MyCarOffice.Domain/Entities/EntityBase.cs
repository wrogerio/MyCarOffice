namespace MyCarOffice.Domain.Entities;

public class EntityBase
{
    public Guid Id { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public DateTime? UpdatedAt { get; set; }
}