using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SQLTables.Domain.Entity;

namespace SQLTables.DBContext.ConfigTables
{
    public class BuyConfig : IEntityTypeConfiguration<Buy>
    {
        public void Configure(EntityTypeBuilder<Buy> builder)
        {
            builder.HasData(new Buy { Id = 1, Description = "Доставка только вечером", ClientId = 1 });
            builder.HasData(new Buy { Id = 2, Description = "", ClientId = 3 });
            builder.HasData(new Buy { Id = 3, Description = "Упаковать каждую книгу по отдельности", ClientId = 2 });
            builder.HasData(new Buy { Id = 4, Description = "", ClientId = 1 });
        }
    }
}
