namespace AK.BlogWebApp.Domain.Abstractions
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        protected Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}
