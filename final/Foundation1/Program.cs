using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to the Youtube Videos Monitoring App!");
        Console.WriteLine();

        Video video1 = new Video();
        video1._author = "ESPN";
        video1._length = 50;
        video1._title = "Curry Makes 10 3's!";

        Comment video1C1= new Comment();
        video1C1._name = "Lebron James";
        video1C1._commment = "I wish I was that good.";
        video1.comments.Add(video1C1);

        Comment video1C2 = new Comment();
        video1C2._name = "Michael Jordan";
        video1C2._commment = "Good job Curry!";
        video1.comments.Add(video1C2);

        Comment video1C3 = new Comment();
        video1C3._name = "Jessica Facer";
        video1C3._commment = "What is a three?";
        video1.comments.Add(video1C3);


        Video video2 = new Video();
        video2._author = "Braxton Facer";
        video2._length = 100;
        video2._title = "How to Make Millions";

        Comment video2C1= new Comment();
        video2C1._name = "Grant Cardone";
        video2C1._commment = "You got it all wrong.";
        video2.comments.Add(video2C1);

        Comment video2C2 = new Comment();
        video2C2._name = "Drew Traue";
        video2C2._commment = "This really could work.";
        video2.comments.Add(video2C2);

        Comment video2C3 = new Comment();
        video2C3._name = "Brent Smith";
        video2C3._commment = "I totally agree this is a great video.";
        video2.comments.Add(video2C3);

        Comment video2C4 = new Comment();
        video2C4._name = "Dave Green";
        video2C4._commment = "Wish that everyone say this.";
        video2.comments.Add(video2C4);


        Video video3 = new Video();
        video3._author = "Brittney Dennert";
        video3._length = 150;
        video3._title = "Having Kids in Today's World";

        Comment video3C1= new Comment();
        video3C1._name = "President Nelson";
        video3C1._commment = "This is so important.";
        video3.comments.Add(video3C1);

        Comment video3C2 = new Comment();
        video3C2._name = "Lori Almond";
        video3C2._commment = "My family brings me so much joy!";
        video3.comments.Add(video3C2);

        Comment video3C3 = new Comment();
        video3C3._name = "Lottie Lee";
        video3C3._commment = "I can not wait to have kids of my own one day.";
        video3.comments.Add(video3C3);


        List<Video> videos = new List<Video>()
        {
            video1, video2, video3
        };
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
            int videoNumberComments = video.NumberComments();
            Console.Write($"{videoNumberComments} ");
            video.StoreComments();
            Console.WriteLine();
        }
        

    }
}