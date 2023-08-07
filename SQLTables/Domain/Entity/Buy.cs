using System.ComponentModel.DataAnnotations.Schema;

namespace SQLTables.Domain.Entity
{
    public class Buy
    {
        [Column("buy_id")]
        public int Id { get; set; }
        [Column("buy_description")]
        public string? Description { get; set; }
        [Column("client_id")]
        public int ClientId { get; set; }
        public Client? Client { get; set; }
    }
}
