using System.Collections.Generic;
using System;

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

    public class Post
    {

        public long Id { get; set; }
        public long UserId { get; set; }
        public string Content { get; set; }
        public System.DateTime CreatedOn { get; set; }
        
    }
    public class User
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

}