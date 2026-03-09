namespace TributeBandManager.Components.Models.ToDos
{
    public static class ToDoRepository
    {
        private static List<ToDo> ToDos { get; set; } = new List<ToDo>
        {
            new ToDo
            {
                Id = 1,
                Name = "Item 1",
                Completed = false,
                TimeStampCompleted = null
            },
            new ToDo
            {
                Id = 2,
                Name = "Item 2",
                Completed = false,
                TimeStampCompleted = null
            },
            new ToDo
            {
                Id = 3,
                Name = "Item 3",
                Completed = false,
                TimeStampCompleted = null
            },
            new ToDo
            {
                Id = 4,
                Name = "Item 4",
                Completed = false,
                TimeStampCompleted = null
            }
        };

        public static List<ToDo> GetToDos()
        {
            return ToDos;
        }

        public static void AddToDo(ToDo toDo)
        {
            int maxId = ToDos.Any() ? ToDos.Max(td => td.Id) : 0;
            toDo.Id = maxId + 1;
            ToDos.Add(toDo);
        }
    }
}
