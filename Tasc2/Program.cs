var post1=new Post();
post1.SetPost("Norak");
post1.AddLike();
post1.AddLike();
post1.AddLike();
post1.AddLike();
post1.AddLike();
post1.AddLike();
post1.AddLike();
post1.AddComment("Zur");
post1.AddComment("Behtarin");
post1.AddComment("100%");

System.Console.WriteLine(post1.GetInfo());
System.Console.WriteLine($"\nComments: {post1.Comments.Count}");
int i = 1;
foreach (var comment in post1.Comments)
{
    System.Console.WriteLine(i + "." + comment);
    i ++;
}




class Post
{
    public string Text;
    public int Likes=0;
    public List<string> Comments=new List<string>();

    public void SetPost(string text)
    {
        Text=text;
    }
    public void AddLike()
    {
        Likes++;
    }
    public void AddComment(string comment)
    {
        Comments.Add(comment);
    }
    public string GetInfo()
    {
        return $"Title: {Text} \nLikes: {Likes}";
    }
}