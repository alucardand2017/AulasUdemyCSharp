using System;
using ExComentarioPost.Entities;

namespace ExComentarioPost
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment();
            c1.Text = "Have a nice trip";
            Comment c2 = new Comment();
            c2.Text = "Wow that's awseone!";

            Post pos1 = new Post(
                DateTime.Parse("2018-08-15T13:05:04Z"),
                "Traveling to the New Zeland",
                "I'm going to visit this wonderfull country",
                12);
            pos1.Comments.Add(c1);
            pos1.Comments.Add(c2);

            Console.WriteLine(pos1);
        }
    }
}
