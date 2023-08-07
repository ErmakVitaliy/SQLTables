using System.ComponentModel.DataAnnotations.Schema;

namespace SQLTables.Domain.Entity
{
    public class Book
    {
        [Column("book_id")]
        public int Id { get; set; }
        public string? Title { get; set; }
        [Column("author_id")]
        public int AuthorId { get; set; }
        public Author? Author { get; set; }
        [Column("genre_id")]
        public int GenreId { get; set; }
        public Genre? Genre { get; set; }
        public decimal? Price { get; set; }
        public int Amount { get; set; }
    }
}
