using System.ComponentModel.DataAnnotations.Schema;

namespace SQLTables.Domain.Entity
{
    public class Client
    {
        [Column("client_id")]
        public int Id { get; set; }
        [Column("name_client")]
        public string? NameClient { get; set; }
        [Column("city_id")]
        public int CityId { get; set; }
        public City? City { get; set; }
        public string? Email { get; set; }
        public IEnumerable<Buy>? Buys { get; set; }
    }
}
