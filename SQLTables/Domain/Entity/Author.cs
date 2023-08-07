using System.ComponentModel.DataAnnotations.Schema;

namespace SQLTables.Domain.Entity
{
    public class Author
    {
        [Column("author_id")]
        public int Id { get; set; }
        [Column("name_author")]
        public string? Name { get; set; }
        public IEnumerable<Book>? Books { get; set; }
    }
}
