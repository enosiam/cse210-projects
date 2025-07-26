using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Learn C# in 10 Minutes", "CodeAcademy", 600);
        video1.AddComment(new Comment("Alice", "This was super helpful!"));
        video1.AddComment(new Comment("Bob", "Thanks for the clear explanation."));
        video1.AddComment(new Comment("Charlie", "Loved it, very concise."));

        Video video2 = new Video("Top 10 Programming Languages", "TechTalk", 480);
        video2.AddComment(new Comment("Diana", "Python forever!"));
        video2.AddComment(new Comment("Evan", "Where is Rust?"));
        video2.AddComment(new Comment("Fiona", "Great breakdown."));

        Video video3 = new Video("Funny Cat Compilation", "CatsDaily", 300);
        video3.AddComment(new Comment("George", "I laughed so hard!"));
        video3.AddComment(new Comment("Hannah", "Cats are the best."));
        video3.AddComment(new Comment("Isaac", "I'm watching this again!"));

        Video video4 = new Video("How to Cook Jollof Rice", "NaijaChef", 720);
        video4.AddComment(new Comment("Jennifer", "My jollof turned out perfect!"));
        video4.AddComment(new Comment("Kelvin", "Thanks for the tips."));
        video4.AddComment(new Comment("Lola", "Now I’m hungry 😋"));

        // Add videos to list
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        // Display each video and its comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length (seconds): {video.LengthInSeconds}");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.CommenterName}: {comment.CommentText}");
            }
            Console.WriteLine(new string('-', 40)); // Separator
        }
    }
}
