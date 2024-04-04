namespace Model
{
    public abstract class DataObject
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastModified { get; set; }


    }
}
