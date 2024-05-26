namespace ExcludeEntities.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public string Description { get; set; }

        public Snapshot Snapshot { get; set; } = new Snapshot();
    }
}
