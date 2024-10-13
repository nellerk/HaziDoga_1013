namespace HaziDoga_1013.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime PublishedDate { get; set; }
        public int AuthorId { get; set; }

        public Author Author { get; set; }
    }

}
