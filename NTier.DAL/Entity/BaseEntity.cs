namespace NTier.DAL.Entity
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
            IsActive = true;
        }
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        //public DateTime CreatedDate { get; set; } = DateTime.Now;
        public bool IsActive { get; set;}
    }
}
