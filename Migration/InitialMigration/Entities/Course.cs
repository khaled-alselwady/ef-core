namespace InitialMigration.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }

        public ICollection<Section> Sections { get; set; } = [];
    }
}
