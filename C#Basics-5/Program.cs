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