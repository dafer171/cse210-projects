using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        Video video1 = new Video("David baila", "David Peña", 10);
        _videos.Add(video1);

        Comment comment1 = new Comment("Leah", "Que bien baila papa");
        video1.AddComment(comment1);

        Comment comment2 = new Comment("Azahara", "Que mal baila David");
        video1.AddComment(comment2);

        Comment comment3 = new Comment("David", "Que bien bailo");
        video1.AddComment(comment3);



        Video video2 = new Video("Azahara canta", "Azahara Soler", 15);
        _videos.Add(video2);

        Comment comment21 = new Comment("Leah", "Que bien baila mama");
        video2.AddComment(comment21);

        Comment comment22 = new Comment("Azahara", "Que bien canto");
        video2.AddComment(comment22);

        Comment comment23 = new Comment("David", "Que bien canta Azahara");
        video2.AddComment(comment23);



        Video video3 = new Video("Leah juega", "Leah Peña", 20);
        _videos.Add(video3);

        Comment comment31 = new Comment("Leah", "Me encanta jugar");
        video3.AddComment(comment31);

        Comment comment32 = new Comment("Azahara", "Que lindo verte jugar");
        video3.AddComment(comment32);

        Comment comment33 = new Comment("David", "Que lindo verte jugar");
        video3.AddComment(comment33);

        foreach (Video video in _videos)
        {
            Console.WriteLine($"{video.GetVideoDetails()}");
            Console.WriteLine($"{video.GetCommentsNumber()}");
        }
    }
}