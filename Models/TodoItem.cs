using System.Collections.Generic;
using System;

namespace TodoApi.Models
{
    //public class TodoItem
    //{
    //    public long Id { get; set; }
    //    public string Name { get; set; }
    //    public bool IsComplete { get; set; }
    //}

    public class Profile
    {
        public string Username;

        public List<Post> PostArray = new List<Post>();

        public Profile(string username)
        {
            this.Username = username;
        }
        public List<Post> GetPosts() 
        {
            return PostArray;
        }

        public void AddPost(Post post)
        {
            PostArray.Add(post);
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