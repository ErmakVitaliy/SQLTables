using System.ComponentModel.DataAnnotations.Schema;

namespace SQLTables.Domain.Entity
{
    public class City
    {
        [Column("city_id")]
        public int Id { get; set; }
        [Column("name_city")]
        public string? Name { get; set; }
        [Column("days_delivery")]
        public int DaysDelivery { get; set; }
        public IEnumerable<Client>? Clients { get; set; }
    }
}
