using System;

namespace FoundationAbstraction
{
class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("The Wonders of Nature", "Alice Smith", 300);
        video1.AddComment(new Comment("Bob Dilan", "Amazing video!"));
        video1.AddComment(new Comment("Grace Mcnellin", "Loved the scenery."));
        video1.AddComment(new Comment("Ryan Hill", "Inspiring!"));
        videos.Add(video1);

        Video video2 = new Video("Tech Innovations 2024", "John Reynolds", 450);
        video2.AddComment(new Comment("Sara Lee", "Very informative."));
        video2.AddComment(new Comment("Tom Hanks", "Great insights into future tech."));
        video2.AddComment(new Comment("Linda Park", "Well presented."));
        videos.Add(video2);

        Video video3 = new Video("History of Art", "Emily Johnson", 600);
        video3.AddComment(new Comment("Michael Brown", "Fascinating journey through art history."));
        video3.AddComment(new Comment("Sophia Davis", "I love your insights and perspective! Keep it up!"));
        video3.AddComment(new Comment("Dane Jackson", "I did not know the details about Renaissance art. Thanks for sharing!"));
        videos.Add(video3);

        Video video4 = new Video("Culinary Arts 101", "Chef Gordon", 350);
        video4.AddComment(new Comment("Rachel Green", "Delicious recipes!"));
        video4.AddComment(new Comment("Monica Geller", "Can't wait to try these at home."));
        video4.AddComment(new Comment("Chandler Bing", "Love how he can be so intense yet so instructing!"));
        videos.Add(video4);

        foreach (Video video in videos)
            {
            Console.WriteLine();
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
                {
                    Console.WriteLine($" - {comment.GetName()}: {comment.GetText()}");

                }
            Console.WriteLine();
            }



    }
}

}