namespace Model
{
    public class Genre : DataObject
    {
        public string? GenreName { get; set; }
        public virtual ICollection<Book>? Books { get; set; } = new List<Book>();


    }

}
