using System;
using System.Collections.Generic;
using System.Linq;

// This is the Library class
public class Library
{
    // Property for the library's name
    public string Name { get; set; }

    // A list to store the books in the library, this is private so it can't be accessed directly from outside the class
    private List<Book> Books { get; set; }

    // Constructor to create a Library object with the given name
    public Library(string name)
    {
        Name = name;  // Set the name of the library
        Books = new List<Book>();  // Initialize the list of books as empty
    }

    // Method to add a book to the library
    public void AddBook(Book book)
    {
        Books.Add(book);  // Add the book to the list of books
        Console.WriteLine($"Added: {book}");  // Print a message saying the book was added
    }

    // Method to remove a book by its ISBN number
    public bool RemoveBook(string isbn)
    {
        // Look for the book in the list that has the matching ISBN
        Book bookToRemove = Books.FirstOrDefault(b => b.ISBN == isbn);

        // If the book is found, remove it from the list
        if (bookToRemove != null)
        {
            Books.Remove(bookToRemove);  // Remove the book
            Console.WriteLine($"Removed: {bookToRemove}");  // Print a message saying the book was removed
            return true;  // Return true to show the removal was successful
        }

        // If the book is not found, print a message and return false
        Console.WriteLine("Book not found.");
        return false;
    }

    // Method to display all the books in the library
    public void DisplayAvailableBooks()
    {
        Console.WriteLine("Available Books:");  // Print a header message
        foreach (var book in Books)  // Go through each book in the list
        {
            Console.WriteLine(book);  // Print the details of the book
        }
    }

    // Method to get a book from the library by its ISBN
    public Book GetBook(string isbn)
    {
        // Return the book with the matching ISBN, or null if it's not found
        return Books.FirstOrDefault(b => b.ISBN == isbn);
    }
}
