namespace Model
{
    public class Author
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Nationality { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<Book>? Books { get; set; } = new List<Book>();

    }
}
