using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SQLTables.Domain.Entity;

namespace SQLTables.DBContext.ConfigTables
{
    public class ClientConfig : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasData(new Client { Id = 1, NameClient = "Баранов Павел", CityId = 3, Email= "baranov@test" });
            builder.HasData(new Client { Id = 2, NameClient = "Абрамова Катя", CityId = 1, Email = "abramova@test" });
            builder.HasData(new Client { Id = 3, NameClient = "Семенонов Иван", CityId = 2, Email = "semenov@test" });
            builder.HasData(new Client { Id = 4, NameClient = "Яковлева Галина", CityId = 1, Email = "yakovleva@test" });
        }
    }
}
