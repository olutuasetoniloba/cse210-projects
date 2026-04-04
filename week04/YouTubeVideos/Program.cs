using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("C# Basics", "John Doe", 600);
        Video video2 = new Video("OOP Explained", "Jane Smith", 800);
        Video video3 = new Video("Abstraction in C#", "CodeMaster", 750);

        // Add comments to video1
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful."));
        video1.AddComment(new Comment("Charlie", "Thanks for explaining clearly."));

        // Add comments to video2
        video2.AddComment(new Comment("David", "Awesome explanation!"));
        video2.AddComment(new Comment("Eve", "Loved this video."));
        video2.AddComment(new Comment("Frank", "Helped me understand OOP."));

        // Add comments to video3
        video3.AddComment(new Comment("Grace", "Abstraction finally makes sense."));
        video3.AddComment(new Comment("Hank", "Good examples."));
        video3.AddComment(new Comment("Ivy", "Well explained topic."));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display information
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Comments Count: {video.GetCommentCount()}");

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine("\n---------------------------\n");
        }
    }
}


