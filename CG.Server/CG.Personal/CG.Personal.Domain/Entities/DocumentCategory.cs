using CG.Personal.Domain.Abstractions;

namespace CG.Personal.Domain.Entities
{
    public sealed class DocumentCategory : Entity
    {
        public string Title { get; set; } = string.Empty;
    }
}
