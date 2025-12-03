using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video musik = new Video("Big Drums", "Mr. Silencer", 6);
        Comment comment1 = new Comment("jimbo", "anyone still listening in 2026?");
        musik.AddComment(comment1);
        Comment comment2 = new Comment("john", "I remember when this came out when I was -5 years old");
        musik.AddComment(comment2);
        Comment comment3 = new Comment("jack", "please like this so I get a notification to come back and listen to this");
        musik.AddComment(comment3);
        videos.Add(musik);

        Video tutorial = new Video("How to Live", "Not a Serial Killer", 45);
        Comment tcomment1 = new Comment("smoker", "This isn't possible!");
        tutorial.AddComment(tcomment1);
        Comment tcomment2 = new Comment("nerd", "wow, So insighful");
        tutorial.AddComment(tcomment2);
        Comment tcomment3 = new Comment("dummy", "This makes no sense!");
        tutorial.AddComment(tcomment3);
        
        videos.Add(tutorial);

        Video meme = new Video("The Funny Days", "Laughy", 15);
        Comment mcomment1 = new Comment("jokester", "Yooo");
        meme.AddComment(mcomment1);
        Comment mcomment2 = new Comment("casual", "I found 13 so funny");
        meme.AddComment(mcomment2);
        Comment mcomment3 = new Comment("Rascer", "HAHA, I need more!");
        meme.AddComment(mcomment3);
        videos.Add(meme);
        
        foreach (Video vid in videos)
        {
            vid.Display();
            Console.WriteLine($"Number of Comments: {vid.NumberOfComments()}");
            vid.DisplayComment();
        }

    }
}