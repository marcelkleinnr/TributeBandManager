namespace TributeBandManager.Components.Models.ToDos
{
    public class ToDo
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool Completed { get; set; }
        public DateTime? TimeStampCompleted { get; set; }
    }
}
