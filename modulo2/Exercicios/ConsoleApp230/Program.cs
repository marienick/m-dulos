using System;
using System.Collections.Generic;
using ConsoleApp230.Entities;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Type the data of the post:");
        Console.WriteLine("Title:");
        string title = Console.ReadLine();
        Console.WriteLine("Content:");
        string content = Console.ReadLine();
        Console.WriteLine("How many likes is in this post?");
        int likes = int.Parse(Console.ReadLine());
        Post post = new Post(DateTime.Now, title, content, likes);
        Console.Write("Do you want to type any comments?");
        string answer = Console.ReadLine().ToLower();
        if (answer == "yes" || answer == "y")
        {
            Console.WriteLine("How many?");
            int numOfComments = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfComments; i++)
            {
                Console.WriteLine($"Type the {i + 1} comment:");
                string text = Console.ReadLine();
                Comment commment = new Comment(text);
                post.Comments.Add(commment);
            }
        }
        Console.WriteLine(post);
        post.ShowComments();
    }
}