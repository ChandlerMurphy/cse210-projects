using System;
using System.Security.Cryptography.X509Certificates;

// I have completed the first two Foundation 4 projects to their fullest extent following the principles of Abstraction and Encapsulation. 
// Methods are used for getting or setting variables and also determining other variables.

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation1 World!");

        List<Video> videos = new List<Video>();

        Video video1 = new Video("Funny Cat Fails", "CatFan6000", 340);
        Comment comment1_1 = new Comment("Max", "I love this video! Reminds me of my most recent litter of Kittens!");
        video1.AddComment(comment1_1);
        Comment comment1_2 = new Comment("Steve", "My cats act the same way lol");
        video1.AddComment(comment1_2);
        Comment comment1_3 = new Comment("Lauren", "What kind of cat is the orange one I saw about 2 minutes in?");
        video1.AddComment(comment1_3);
        Comment comment1_4 = new Comment("CatFan6000", "It's the same kind as Garfield.");
        video1.AddComment(comment1_4);
        videos.Add(video1);

        Video video2 = new Video("DYI Home Hacks", "Austin", 60);
        Comment comment2_1 = new Comment("Mr Goo", "I didn't know you could do that");
        video2.AddComment(comment2_1);
        Comment comment2_2 = new Comment("Mark#1", "I will be using these from now on");
        video2.AddComment(comment2_2);
        Comment comment2_3 = new Comment("Steven", "Are you sure these work? I tried a few and I couldn't actually get them to work.");
        video2.AddComment(comment2_3);
        Comment comment2_4 = new Comment("BigMikeLots", "Fake");
        video2.AddComment(comment2_4);
        videos.Add(video2);

        Video video3 = new Video("Safari Tour Demo", "Sir Outdoors", 510);
        Comment comment3_1 = new Comment("Tiffany", "First!");
        video3.AddComment(comment3_1);
        Comment comment3_2 = new Comment("Loopster#45", "This looks so fun!");
        video3.AddComment(comment3_2);
        Comment comment3_3 = new Comment("Carl", "I've never been!");
        video3.AddComment(comment3_3);
        Comment comment3_4 = new Comment("BigCatz", "This is a whole new world");
        video3.AddComment(comment3_4);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"\nVideo: {video.GetTitle()} \nAuthor: {video.GetAuthor()} \nVideo Length: {video.GetLength()} \nNumber of Comments: {video.GetNumberOfComments()}");
            video.ListComments();
        }





    }
}