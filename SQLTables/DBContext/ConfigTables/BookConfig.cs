using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SQLTables.Domain.Entity;

namespace SQLTables.DBContext.ConfigTables
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(new Book { Id = 1, Title = "Мастер и Маргарита", AuthorId = 1, GenreId = 1, Price = 670.99M, Amount = 3 });
            builder.HasData(new Book { Id = 2, Title = "Белая гвардия", AuthorId = 1, GenreId = 1, Price = 540.50M, Amount = 5 });
            builder.HasData(new Book { Id = 3, Title = "Идиот", AuthorId = 2, GenreId = 1, Price = 460.00M, Amount = 10 });
            builder.HasData(new Book { Id = 4, Title = "Братья Карамазовы", AuthorId = 2, GenreId = 1, Price = 799.01M, Amount = 2 });
            builder.HasData(new Book { Id = 5, Title = "Игрок", AuthorId = 2, GenreId = 1, Price = 480.50M, Amount = 10 });
            builder.HasData(new Book { Id = 6, Title = "Стихотворения и поэмы", AuthorId = 3, GenreId = 2, Price = 650.00M, Amount = 15 });
            builder.HasData(new Book { Id = 7, Title = "Черный человек", AuthorId = 3, GenreId = 2, Price = 570.20M, Amount = 6 });
            builder.HasData(new Book { Id = 8, Title = "Лирика", AuthorId = 4, GenreId = 2, Price = 518.99M, Amount = 2 });
        }
    }
}
