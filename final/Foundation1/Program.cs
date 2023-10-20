using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videoList = new List<Video>();
        Video video1 = new Video("Crazy Cats", "CatFan45", 10.25);
        _videoList.Add(video1);
        Comment comment1 = new Comment("MicMac", "That was stupid. I want the last 10 minutes of my life back.");
        video1._comments.Add(comment1);
        Comment comment2 = new Comment("Donna123", "They are sooooo cute! totally adorbs!!!!");
        video1._comments.Add(comment2);
        Comment comment3 = new Comment("JakJak23", "I have never seen cats do that.");
        video1._comments.Add(comment3);

        Video video2 = new Video("Crazy Cats 2", "CatFan45", 10.0);
        _videoList.Add(video2);
        Comment comment4 = new Comment("MicMac", "Another dumb cat video!");
        video2._comments.Add(comment4);
        Comment comment5 = new Comment("CatFan45", "you know You don't have to watch the videos.");
        video2._comments.Add(comment5);
        Comment comment6 = new Comment("MicMac", "Oh but I do have to watch.");
        video2._comments.Add(comment6);

        Video video3 = new Video("Rowdy Rotts", "KingBowWow", 12.5);
        _videoList.Add(video3);
        Comment comment7 = new Comment("Bobsnob", "Those are some beautiful dogs. I love watching them.");
        video3._comments.Add(comment7);
        Comment comment8 = new Comment("CatFan45", "My daughter loves this video! so funny!");
        video3._comments.Add(comment8);
        Comment comment9 = new Comment("KingBowWow", "Thanks CatFan. They are real characters aren't they.");
        video3._comments.Add(comment9);


        foreach (Video clip in _videoList)
        {
            Console.WriteLine($"Title: {clip.GetTitle()} Author: {clip.GetAuthor()} Duratoion: {clip.GetLength()} min. Number of Comments: {clip.CommentCount()}");
            foreach (Comment item in clip._comments)
            {
                Console.WriteLine($"{item.GetText()} -{item.GetCommentor()}");
            }
        }
    }
}