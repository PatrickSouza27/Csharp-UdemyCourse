using System;
using Exercicio2.Classes;


namespace Exercicio2
{
    class Program
    {
        static void Main()
        {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that´s awesome!");
            Post p1 = new Post
            (
                 DateTime.Parse("21/06/2018 13:05:44"),
                 "Traveling to  new Zealand",
                 "I'm going to visit this wonderful country!",
                 12
  
            );
            p1.AddCommments(c1);
            p1.AddCommments(c2);

            Comment c3 = new Comment("Good nigth");
            Comment c4 = new Comment("May the force be with you");
            Post p2 = new Post(DateTime.Parse("28/07/2018 23:14:19"), "Good nigth guys", "See you tomorrow", 5);
            p2.AddCommments(c3);
            p2.AddCommments(c4);


            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
