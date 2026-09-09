// Question 1

class Book
{
    private string password = "secret";
}

class Program
{
    static void Main()
    {
        Book book = new Book();

       
    }
}



// Question 2
 using System;

class Book
{
    internal int copiesInStock = 5;
}

class Program
{
    static void Main()
    {
        Book book = new Book();

        Console.WriteLine(book.copiesInStock);
    }
}


// Question 3
using System;

class Book
{
    public string Title;
}

class Program
{
    static void Main()
    {
        Book book = new Book();

        book.Title = "C# Basics";
        Console.WriteLine(book.Title);
    }
}


// Question 4
using System;

enum Genre
{
    Fiction,
    NonFiction,
    Science
}

class Book
{
    public Genre BookGenre { get; set; }
}

class Program
{
    static void Main()
    {
        Book book = new Book();

        book.BookGenre = Genre.Science;

        Console.WriteLine(book.BookGenre);
    }
}

// Question 5

using System;

enum Genre
{
    Fiction,
    NonFiction,
    Science
}

class Program
{
    static void Main()
    {
        Console.WriteLine((int)Genre.Fiction);
        Console.WriteLine((int)Genre.NonFiction);
        Console.WriteLine((int)Genre.Science);
    }
}

// Question 6
using System;

enum Genre
{
    Fiction,
    NonFiction,
    Science
}

class Program
{
    static void Main()
    {
        int genreNumber = 1;

        Genre genre = (Genre)genreNumber;

        Console.WriteLine(genre);
    }
}

