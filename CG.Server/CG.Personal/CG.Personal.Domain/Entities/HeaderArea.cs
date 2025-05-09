using CG.Personal.Domain.Abstractions;

namespace CG.Personal.Domain.Entities;

public sealed class HeaderArea : Entity
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Profession { get; set; } = string.Empty;
}
