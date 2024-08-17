namespace InitialMigration.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string? FName { get; set; }
        public string? LName { get; set; }

        public ICollection<Section> Sections { get; set; } = [];
    }
}
