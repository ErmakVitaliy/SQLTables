using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SQLTables.Domain.Entity;

namespace SQLTables.DBContext.ConfigTables
{
    public class CityConfig : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasData(new City { Id = 1, Name = "Москва", DaysDelivery = 5 });
            builder.HasData(new City { Id = 2, Name = "Санкт-Петербург", DaysDelivery = 3 });
            builder.HasData(new City { Id = 3, Name = "Владивосток", DaysDelivery = 12 });
        }
    }
}
