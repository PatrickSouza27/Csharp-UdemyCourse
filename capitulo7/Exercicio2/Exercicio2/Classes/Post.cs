using System;
using Exercicio2.Classes;
using System.Text;
namespace Exercicio2.Classes
{
    internal class Post
    {
        public DateTime Date { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post(DateTime date, string? title, string? content, int likes)
        {
            Date = date;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddCommments(Comment s)
        {
            Comments.Add(s);
        }
        public void RemoveComments(Comment s)
        {
            Comments.Remove(s);
        }
        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            /*
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append("Likes - ");
            sb.AppendLine(Date.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments:");
            */
            foreach (Comment s in Comments)
            {
                sb.AppendLine(s.Text);
            }
            return ($"\n{Title}\n{Likes} - {Date.ToString("dd/MM/yyyy HH:mm:ss")}\n{Content}\nComments:\n{sb.ToString()}");
        }
    }
}
