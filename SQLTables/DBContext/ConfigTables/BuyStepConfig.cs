using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SQLTables.Domain.Entity;

namespace SQLTables.DBContext.ConfigTables
{
    public class BuyStepConfig : IEntityTypeConfiguration<BuyStep>
    {
        public void Configure(EntityTypeBuilder<BuyStep> builder)
        {
            builder.HasData(new BuyStep { Id = 1, BuyId = 1, StepId = 1, DateStepBeg= new DateTime(2020,02,20), DateStepEnd = new DateTime(2020, 02, 20) });
            builder.HasData(new BuyStep { Id = 2, BuyId = 1, StepId = 2, DateStepBeg = new DateTime(2020, 02, 20), DateStepEnd = new DateTime(2020, 02, 21) });
            builder.HasData(new BuyStep { Id = 3, BuyId = 1, StepId = 3, DateStepBeg = new DateTime(2020, 02, 22), DateStepEnd = new DateTime(2020, 03, 07) });
            builder.HasData(new BuyStep { Id = 4, BuyId = 1, StepId = 3, DateStepBeg = new DateTime(2020, 03, 08), DateStepEnd = new DateTime(2020, 03, 08) });
            builder.HasData(new BuyStep { Id = 5, BuyId = 2, StepId = 1, DateStepBeg = new DateTime(2020, 02, 28), DateStepEnd = new DateTime(2020, 02, 28) });
            builder.HasData(new BuyStep { Id = 6, BuyId = 2, StepId = 2, DateStepBeg = new DateTime(2020, 02, 29), DateStepEnd = new DateTime(2020, 03, 01) });
            builder.HasData(new BuyStep { Id = 7, BuyId = 2, StepId = 3, DateStepBeg = new DateTime(2020, 03, 02) });
            builder.HasData(new BuyStep { Id = 8, BuyId = 2, StepId = 4 });
            builder.HasData(new BuyStep { Id = 9, BuyId = 3, StepId = 1, DateStepBeg = new DateTime(2020, 03, 05), DateStepEnd = new DateTime(2020, 03, 05) });
            builder.HasData(new BuyStep { Id = 10, BuyId = 3, StepId = 2, DateStepBeg = new DateTime(2020, 03, 05), DateStepEnd = new DateTime(2020, 03, 06) });
            builder.HasData(new BuyStep { Id = 11, BuyId = 3, StepId = 3, DateStepBeg = new DateTime(2020, 03, 06), DateStepEnd = new DateTime(2020, 03, 10) });
            builder.HasData(new BuyStep { Id = 12, BuyId = 3, StepId = 4, DateStepBeg = new DateTime(2020, 03, 11) });
            builder.HasData(new BuyStep { Id = 13, BuyId = 4, StepId = 1, DateStepBeg = new DateTime(2020, 03, 20) });
            builder.HasData(new BuyStep { Id = 14, BuyId = 4, StepId = 2 });
            builder.HasData(new BuyStep { Id = 15, BuyId = 4, StepId = 3 });
            builder.HasData(new BuyStep { Id = 16, BuyId = 4, StepId = 4 });
        }
    }
}
