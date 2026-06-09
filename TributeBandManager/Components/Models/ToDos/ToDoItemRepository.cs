namespace TributeBandManager.Components.Models.ToDos
{
    public static class ToDoItemRepository
    {
        private static List<ToDoItem> ToDos { get; set; } = new List<ToDoItem>
        {
            new ToDoItem
            {
                Id = 1,
                Name = "Item 1",
                Completed = false
            },
            new ToDoItem
            {
                Id = 2,
                Name = "Item 2",
                Completed = false
            },
            new ToDoItem
            {
                Id = 3,
                Name = "Item 3",
                Completed = false
            },
            new ToDoItem
            {
                Id = 4,
                Name = "Item 4",
                Completed = false
            }
        };

        public static List<ToDoItem> GetToDos()
        {
            return ToDos.OrderBy(tasks => tasks.Completed).ThenByDescending(tasks => tasks.Id).ToList();
        }

        public static void AddToDo(ToDoItem toDo)
        {
            int maxId = ToDos.Any() ? ToDos.Max(td => td.Id) : 0;
            toDo.Id = maxId + 1;
            toDo.Name = "New Task";
            ToDos.Add(toDo);
        }
    }
}
