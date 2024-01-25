using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp230.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post() { }
        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }
        public void  AddComment(Comment comment)
        {
            Comments.Add(comment);
        }
        public void ShowComments()
        {
            for(int i = 0; i < Comments.Count; i++)
            {
                Console.WriteLine(Comments[i]);
            }
        }
        public override string ToString()
        {
            return Title + "\n" + Likes + " likes - " + Moment + "\n" + Content + "\nComments:\n";
        }
    }
}
