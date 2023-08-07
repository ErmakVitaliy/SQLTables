using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SQLTables.Domain.Entity;

namespace SQLTables.DBContext.ConfigTables
{
    public class AuthorConfig : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasData(new Author { Id = 1, Name = "Булгаков М.А." });
            builder.HasData(new Author { Id = 2, Name = "Достоевский Ф.М." });
            builder.HasData(new Author { Id = 3, Name = "Есенин С.А" });
            builder.HasData(new Author { Id = 4, Name = "Пастернак Б.Л" });
            builder.HasData(new Author { Id = 5, Name = "Лермонтов М.Ю." });
        }
    }
}
