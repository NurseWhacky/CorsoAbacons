namespace Model
{
        public class Author : DataObject
        {
            public string? FirstName { get; set; }
            public string? LastName { get; set; }
        public string? Nationality { get; set; }
        public DateTime BirthDate { get; set; }
        public virtual ICollection<Book>? Books { get; set; } = new List<Book>();

    }
}
