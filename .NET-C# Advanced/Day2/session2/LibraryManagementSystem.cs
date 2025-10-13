using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//    Task 1: Library Management System
//Create a class Book with fields: bookId, title, author, isIssued.
//Implement:

//Parameterized constructor to initialize book details.
//Methods: IssueBook(), ReturnBook(), DisplayBookDetails().


//Create multiple book objects and simulate issuing and returning books.
namespace session2
{
    internal class LibraryManagementSystem(int id, string title, string author)
    {
        public int bookId = id;
        public string title = title;
        public string author = author;
        public bool isIssued;
        public void IssueBook()
        {
            isIssued = true;
            Console.WriteLine($"The {this.title} book has been issued!");
        }
        public void ReturnBook(int id)
        {
            if (bookId == id && isIssued == true)
            {
                isIssued = false;
                Console.WriteLine("You have successfully returned the book!");
            }
            else
            {
                Console.WriteLine("Enter valid BookId");
            }
        }
        public void DisplayBookDetails()
        {
            Console.WriteLine(this.bookId);
            Console.WriteLine(this.title);
            Console.WriteLine(this.author);
        }
    }
}
