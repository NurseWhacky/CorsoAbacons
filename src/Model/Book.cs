namespace Model
{
    public class Book : DataObject
    {
        public string? Title { get; set; }
        public string? Publisher { get; set; }
        public DateTime PublishingDate { get; set; }
        public float Price { get; set; }
        public string? Code { get; set; }
        public virtual ICollection<Author>? Authors { get; set; } = new List<Author>();
        public virtual ICollection<Genre>? Genres { get; set; } = new List<Genre>();

    }
}
