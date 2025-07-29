using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        // Create videos
        Video video1 = new Video();
        video1._title = "How to bake a cake from scratch";
        video1._author = "Immanuel Grant";
        video1._length = 600; // 10 minutes

        Video video2 = new Video();
        video2._title = "Easy ways to learn programming";
        video2._author = "Trevor Cox";
        video2._length = 900; // 15 minutes

        Video video3 = new Video();
        video3._title = "How to make pizza from scratch";
        video3._author = "Rita Smith";
        video3._length = 750; // 12.5 minutes

        // Create comments for video1
        Comment comment1 = new Comment();
        comment1._name = "Maria";
        comment1._text = "Great video! Very informative.";

        Comment comment2 = new Comment();
        comment2._name = "Ellison";
        comment2._text = "I loved this content, keep it up!";

        Comment comment3 = new Comment();
        comment3._name = "Jerry";
        comment3._text = "The explanation was so clear!";

        // Add comments to video1
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        // Create comments for video2
        Comment comment4 = new Comment();
        comment4._name = "David";
        comment4._text = "Wow! I finally understand this.";

        Comment comment5 = new Comment();
        comment5._name = "Rita";
        comment5._text = "Thanks for this breakdown.";

        // Add comments to video2
        video2.AddComment(comment4);
        video2.AddComment(comment5);

        // Create comments for video3
        Comment comment6 = new Comment();
        comment6._name = "Kelly";
        comment6._text = "Makes so much sense now!";

        Comment comment7 = new Comment();
        comment7._name = "Grace";
        comment7._text = "Great teaching style!";

        // Add comments to video3
        video3.AddComment(comment6);
        video3.AddComment(comment7);

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display video details
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
