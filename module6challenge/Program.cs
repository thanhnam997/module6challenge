using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new library with the name "Central Library"
        Library library = new Library("Central Library");

        // Create two members: Alice with ID 1 and Bob with ID 2
        Member member1 = new Member("Alice", 1);
        Member member2 = new Member("Bob", 2);

        // Add books to the library's collection
        library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565"));
        library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "9780446310789"));
        library.AddBook(new Book("1984", "George Orwell", "9780451524935"));

        // Display all available books in the library
        library.DisplayAvailableBooks();

        Console.WriteLine("\nBorrowing books:");
        // Alice borrows "The Great Gatsby" by ISBN
        member1.BorrowBook(library, "9780743273565");
        // Bob borrows "To Kill a Mockingbird" by ISBN
        member2.BorrowBook(library, "9780446310789");

        // Display available books after Alice and Bob have borrowed some
        library.DisplayAvailableBooks();

        // Display the books borrowed by each member
        member1.DisplayBorrowedBooks();
        member2.DisplayBorrowedBooks();

        Console.WriteLine("\nReturning a book:");
        // Alice returns "The Great Gatsby" by ISBN
        member1.ReturnBook(library, "9780743273565");

        // Final display of available books in the library after the return
        library.DisplayAvailableBooks();
    }
}
