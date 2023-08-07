using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SQLTables.Domain.Entity;

namespace SQLTables.DBContext.ConfigTables
{
    public class BuyBookConfig : IEntityTypeConfiguration<BuyBook>
    {
        public void Configure(EntityTypeBuilder<BuyBook> builder)
        {
            builder.HasData(new BuyBook { Id = 1, BuyId = 1, BookId = 1, Amount = 1 });
            builder.HasData(new BuyBook { Id = 2, BuyId = 1, BookId = 7, Amount = 2 });
            builder.HasData(new BuyBook { Id = 3, BuyId = 1, BookId = 3, Amount = 1 });
            builder.HasData(new BuyBook { Id = 4, BuyId = 2, BookId = 8, Amount = 2 });
            builder.HasData(new BuyBook { Id = 5, BuyId = 3, BookId = 3, Amount = 2 });
            builder.HasData(new BuyBook { Id = 6, BuyId = 3, BookId = 2, Amount = 1 });
            builder.HasData(new BuyBook { Id = 7, BuyId = 3, BookId = 1, Amount = 1 });
            builder.HasData(new BuyBook { Id = 8, BuyId = 4, BookId = 5, Amount = 1 });
        }
    }
}
