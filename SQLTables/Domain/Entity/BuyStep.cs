using System.ComponentModel.DataAnnotations.Schema;

namespace SQLTables.Domain.Entity
{
    public class BuyStep
    {
        [Column("buy_step_id")]
        public int Id { get; set; }
        [Column("buy_id")]
        public int BuyId { get; set; }
        public Buy? Buy { get; set; }
        [Column("step_id")]
        public int StepId { get; set; }
        public Step? Step { get; set; }
        [Column("date_step_beg")]
        public DateTime? DateStepBeg { get; set; }
        [Column("date_step_end")]
        public DateTime? DateStepEnd { get; set; }
    }
}
