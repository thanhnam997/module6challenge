
//Class Declaration
public class Book

{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
//// This is the constructor that helps create a Book object with the given title, author, and ISBN
    public Book(string title, string author, string isbn)
    {
        Title = title;// Set the title of the book
        Author = author;// Set the author of book
         ISBN = isbn;// Set the ISBN of book
    }
// This method returns the book details as a simple string when called
    public override string ToString()
    {
        return $"{Title} by {Author} (ISBN: {ISBN})";
    }
}