using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SQLTables.Domain.Entity;

namespace SQLTables.DBContext.ConfigTables
{
    public class GenreConfig : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasData(new Genre { Id = 1, Name = "Роман" });
            builder.HasData(new Genre { Id = 2, Name = "Поэзия" });
            builder.HasData(new Genre { Id = 3, Name = "Приключения" });
        }
    }
}
