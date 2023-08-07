using System.ComponentModel.DataAnnotations.Schema;

namespace SQLTables.Domain.Entity
{
    public class BuyBook
    {
        [Column("buy_book_id")]
        public int Id { get; set; }
        [Column("buy_id")]
        public int BuyId { get; set; }
        public Buy? Buy { get; set; }
        [Column("book_id")]
        public int BookId { get; set; }
        public Book? Book { get; set; }
        public int Amount { get; set; }
    }
}
