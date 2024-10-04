using System;
using System.Collections.Generic;
using System.Linq;

// This is the Member class
public class Member
{
    // Properties for the member's name and ID
    public string Name { get; set; }
    public int ID { get; set; }

    // A list to keep track of the books the member has borrowed, private so it can't be accessed from outside
    private List<Book> BorrowedBooks { get; set; }

    // Constructor to create a Member object with a name and ID
    public Member(string name, int id)
    {
        Name = name;  // Set the name of the member
        ID = id;      // Set the ID of the member
        BorrowedBooks = new List<Book>();  // Initialize the borrowed books list as empty
    }

    // Method for borrowing a book from the library
    public void BorrowBook(Library library, string isbn)
    {
        // Find the book in the library by its ISBN
        Book book = library.GetBook(isbn);

        // If the book exists in the library
        if (book != null)
        {
            BorrowedBooks.Add(book);   // Add the book to the member's borrowed books list
            library.RemoveBook(isbn);  // Remove the book from the library
            Console.WriteLine($"{Name} borrowed: {book}");  // Print a message saying the member borrowed the book
        }
        else
        {
            Console.WriteLine("Book not available.");  // If the book isn't found, print a message
        }
    }

    // Method for returning a borrowed book to the library
    public void ReturnBook(Library library, string isbn)
    {
        // Find the book in the member's borrowed books list by ISBN
        Book book = BorrowedBooks.FirstOrDefault(b => b.ISBN == isbn);

        // If the book is found in the borrowed list
        if (book != null)
        {
            BorrowedBooks.Remove(book);  // Remove the book from the member's borrowed books list
            library.AddBook(book);       // Add the book back to the library
            Console.WriteLine($"{Name} returned: {book}");  // Print a message saying the member returned the book
        }
        else
        {
            Console.WriteLine("Book not found in borrowed list.");  // If the book isn't in the borrowed list, print a message
        }
    }

    // Method to display all the books the member has borrowed
    public void DisplayBorrowedBooks()
    {
        Console.WriteLine($"{Name}'s Borrowed Books:");  // Print a header with the member's name
        foreach (var book in BorrowedBooks)  // Go through each borrowed book
        {
            Console.WriteLine(book);  // Print the details of each borrowed book
        }
    }
}
