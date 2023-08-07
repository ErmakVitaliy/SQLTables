using System.ComponentModel.DataAnnotations.Schema;

namespace SQLTables.Domain.Entity
{
    public class Genre
    {
        [Column("genre_id")]
        public int Id { get; set; }
        [Column("name_genre")]
        public string? Name { get; set; }
        public IEnumerable<Book>? Books { get; set; }
    }
}
