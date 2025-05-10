using AK.BlogWebApp.Domain.Abstractions;

namespace AK.BlogWebApp.Domain.Entities
{
    public sealed class DocumentCategory : Entity
    {
        public string Title { get; set; } = string.Empty;
    }
}
