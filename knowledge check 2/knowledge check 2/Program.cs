using System;

namespace knowledge_check_2
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());

            var recordList = new List<Book>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var book = new Book();
                Console.WriteLine("Enter the value for Title");
                book.Title = Console.ReadLine();
                Console.WriteLine("Enter the value for Genre");
                book.Genre = Console.ReadLine();
                Console.WriteLine("Enter the value for Author");
                book.Author = Console.ReadLine();
                Console.WriteLine("Enter the value for Pages");
                book.Pages = int.Parse(Console.ReadLine());
                recordList.Add(book);
                Console.WriteLine("Media Added");
                Console.WriteLine(book.ToString());
            }
        }
    }
}
