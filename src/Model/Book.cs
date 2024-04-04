namespace Model
{
    public class Book : DataObject
    {
        public string? Title { get; set; }
        public string? Publisher { get; set; }
        public DateTime PublishinDate { get; set; }
        public float Price { get; set; }

    }
}
