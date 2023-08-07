namespace SQLTables.Domain.Entity
{
    public class Step
    {
        public int Id { get; set; }
        public string? NameStep { get; set; }
        public BuyStep? BuyStep { get; set; }
    }
}
