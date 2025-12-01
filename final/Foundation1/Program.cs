using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        List<Comment> comments1 = new List<Comment>();
        Comment comment1 = new Comment("jimbo", "anyone still listening in 2026?");
        comments1.Add(comment1);
        Comment comment2 = new Comment("john", "I remember when this came out when I was -5 years old");
        comments1.Add(comment2);
        Comment comment3 = new Comment("jack", "please like this i so get a notification to come back and listen to this");
        comments1.Add(comment3);
        Video musik = new Video(comments1,"Big Drums", "Mr. Silencer", 6);
        videos.Add(musik);

        List<Comment> comments2 = new List<Comment>();
        Comment tcomment1 = new Comment("smoker", "This isn't possible!");
        comments2.Add(tcomment1);
        Comment tcomment2 = new Comment("nerd", "wow, So insighful");
        comments2.Add(tcomment2);
        Comment tcomment3 = new Comment("dummy", "This makes no sense!");
        comments2.Add(tcomment3);
        Video tutorial = new Video(comments2,"How to Live", "Not a Serial Killer", 45);
        videos.Add(tutorial);

        List<Comment> mcomments3 = new List<Comment>();
        Comment mcomment1 = new Comment("jokester", "Yooo");
        mcomments3.Add(mcomment1);
        Comment mcomment2 = new Comment("casual", "I found 13 so funny");
        mcomments3.Add(mcomment2);
        Comment mcomment3 = new Comment("Rascer", "HAHA, I need more!");
        mcomments3.Add(mcomment3);
        Video meme = new Video(mcomments3,"The Funny Days", "Laughy", 15);
        videos.Add(meme);
        
        foreach (Video vid in videos)
        {
            vid.Display();
            Console.WriteLine($"Number of Comments: {vid.NumberOfComments()}");
            foreach(Comment com in vid._comments)
            {
                com.Displayinfo();
            }
        }

    }
}