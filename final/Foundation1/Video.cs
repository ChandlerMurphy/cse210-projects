using System.Globalization;

public class Video 
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> comments = new List<Comment>();

    public Video (string title, string author, int length) 
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public int GetNumberOfComments()
    {
        int numberOfComments = comments.Count();
        return numberOfComments;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLength()
    {
        return _length;
    }

    public void AddComment(Comment comment) 
    {
        comments.Add(comment);
    }

    public void ListComments()
    {
        foreach (Comment comment in comments)
        {
            Console.WriteLine($"Name: {comment.GetName()}");
            Console.WriteLine($"Comment: {comment.GetText()}\n");
        }
    }
}