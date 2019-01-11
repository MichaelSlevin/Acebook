using System.Collections.Generic;
namespace TodoApi.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }

    public class TodoList
    {
        public List<TodoItem> TodoItemArray = new List<TodoItem>();

        public TodoList()
        {

        }
        public List<TodoItem> GetItems() 
        {
            return TodoItemArray;
        }

        public void AddItem(TodoItem item)
        {
            TodoItemArray.Add(item);
        }
    }

}