public class Video
{
    private string _title;
    private string _author;
    private int _lenght;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lenght)
    {
        _title = title;
        _author = author;
        _lenght = lenght;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public string GetCommentsNumber()
    {
        return $"The number of comments in this video is: {_comments.Count}";
    }

    public string GetVideoDetails()
    {
        return $"Video Title: {_title}, Author Name: {_author}, Lenght: {_lenght}";
    }
}