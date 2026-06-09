namespace TributeBandManager.Components.Models.ToDos
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool Completed { get; set; }
        public DateTime TimeStampCompleted { get; set; }
    }
}
