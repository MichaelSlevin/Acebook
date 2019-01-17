using System.Collections.Generic;
using System;
using System.Text;

namespace TodoApi.Models
{
    //public class TodoItem
    //{
    //    public long Id { get; set; }
    //    public string Name { get; set; }
    //    public bool IsComplete { get; set; }
    //}
    public class Encrypt
    {
      //Following resource used for encryption
      //https://www.codingame.com/playgrounds/11117/simple-encryption-using-c-and-xor-technique
      public string EncryptDecrypt(string szPlainText, int szEncryptionKey)
       {
         StringBuilder szInputStringBuild = new StringBuilder(szPlainText);
         StringBuilder szOutStringBuild = new StringBuilder(szPlainText.Length);
         char Textch;
         for (int iCount = 0; iCount < szPlainText.Length; iCount++)
         {
           Textch = szInputStringBuild[iCount];
           Textch = (char)(Textch ^ szEncryptionKey);
           szOutStringBuild.Append(Textch);
         }
         return szOutStringBuild.ToString();
       }
     }

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
            PostArray.Reverse();
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
