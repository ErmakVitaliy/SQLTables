using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SQLTables.Domain.Entity;

namespace SQLTables.DBContext.ConfigTables
{
    public class StepConfig : IEntityTypeConfiguration<Step>
    {
        public void Configure(EntityTypeBuilder<Step> builder)
        {
            builder.HasData(new Step { Id = 1, NameStep = "Оплата" });
            builder.HasData(new Step { Id = 2, NameStep = "Упаковка" });
            builder.HasData(new Step { Id = 3, NameStep = "Транспортировка" });
            builder.HasData(new Step { Id = 4, NameStep = "Доставка" });
        }
    }
}
