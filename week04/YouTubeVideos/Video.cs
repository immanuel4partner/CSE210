public class Video
{
    // Public fields (since there are no getters/setters)
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();


    // Method to add a comment
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Method to get number of comments
    public int GetCommentCount()
    {
        return _comments.Count;
    }

    // Method to display video details and comments
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of Comments: {GetCommentCount()}");
        Console.WriteLine("Comments:");

        foreach (var comment in _comments)
        {
            Console.WriteLine($"- {comment._name}: {comment._text}");
        }
        Console.WriteLine();
    }
}