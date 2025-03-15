namespace Task8.Classes
{
    public class Book
    {
        public string Title { get; }
        public string Author { get; }

        public Book() : this("Untitled", "Unknown") { }
        public Book(string title) : this(title, "Unknown") { }
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }
}
