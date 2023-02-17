using System;

class Program
{
    static void Main(string[] args)
    {        
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine();
        Console.WriteLine("Welcome to the Youtube Video Monitoring App!");
        Console.WriteLine();
//first video
        Video video1 = new Video();
        video1._author = "ESPN";
        video1._length = 50;
        video1._title = "Curry Makes 10 3's!";

        Comment comment11= new Comment();
        comment11._name = "Lebron James";
        comment11._commment = "I wish I was that good.";
        video1.comments.Add(comment11);

        Comment comment12 = new Comment();
        comment12._name = "Michael Jordan";
        comment12._commment = "Good job Curry!";
        video1.comments.Add(comment12);

        Comment comment13 = new Comment();
        comment13._name = "Jessica Facer";
        comment13._commment = "What is a three?";
        video1.comments.Add(comment13);

//second video
        Video video2 = new Video();
        video2._author = "Braxton Facer";
        video2._length = 100;
        video2._title = "How to Make Millions";

        Comment comment21= new Comment();
        comment21._name = "Grant Cardone";
        comment21._commment = "You got it all wrong.";
        video2.comments.Add(comment21);

        Comment comment22 = new Comment();
        comment22._name = "Drew Traue";
        comment22._commment = "This really could work.";
        video2.comments.Add(comment22);

        Comment comment23 = new Comment();
        comment23._name = "Brent Smith";
        comment23._commment = "I totally agree this is a great video.";
        video2.comments.Add(comment23);

        Comment comment24 = new Comment();
        comment24._name = "Dave Green";
        comment24._commment = "Wish that everyone say this.";
        video2.comments.Add(comment24);

//third video
        Video video3 = new Video();
        video3._author = "Brittney Dennert";
        video3._length = 150;
        video3._title = "Having Kids in Today's World";

        Comment comment31= new Comment();
        comment31._name = "President Nelson";
        comment31._commment = "This is so important.";
        video3.comments.Add(comment31);

        Comment comment32 = new Comment();
        comment32._name = "Lori Almond";
        comment32._commment = "My family brings me so much joy!";
        video3.comments.Add(comment32);

        Comment comment33 = new Comment();
        comment33._name = "Lottie Lee";
        comment33._commment = "I can not wait to have kids of my own one day.";
        video3.comments.Add(comment33);

//creating the list
        List<Video> videos = new List<Video>()
        {
            video1, video2, video3
        };
        foreach (Video video in videos)
        {
            video.Clip();
            int interaction = video.Interaction();
            Console.Write($"{interaction} ");
            video.Save();
            Console.WriteLine();
        }
        

    }
}
// Here is the foundation1 project
