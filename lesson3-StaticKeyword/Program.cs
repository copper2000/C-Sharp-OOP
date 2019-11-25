using System;

namespace lesson3_StaticKeyword
{
    /*
        Feature of static member:
        1. Initialize only once when compiling program
        2. Can be used for all objects
        3. Called by class-name. use: class_name.static_members
        4. Canceled when the program ends

        Static members
        1. static variable
        2. static method
        3. static class
        4. static constructor
    */
    public class Book 
    {
        private double price;
        private string cover_type;

        public double Price{get; set;}
        public string Cover_type {get; set;}
        
        // Đề bài: Khai báo 1 biến static lên Count để chứa số lượng sách hiện tại
        // Mỗi lần có 1 đối tượng được tạo ra thì Count sẽ tăng lên 1.

        public static int Count = 0; // static variable
        public Book(double pr, string ct)
        {
            Price = pr;
            Cover_type = ct;
            // Vì constructor chỉ được gọi khi có đối tượng được tạo ra nên ta sẽ tăng Count ở đây
            Count ++;
        }
    }
    public class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers of original book: " + Book.Count); 

            Book thePragmaticProgrammer = new Book(30.55, "hardcover");
            Console.WriteLine("Number of current books: {0}, price is {1} and cover is {2}", Book.Count, thePragmaticProgrammer.Price, thePragmaticProgrammer.Cover_type);
            BookUtilities.PrintNumberOfCurrentBook(Book.Count);
            

            Book codeComplete = new Book(28.99, "paperback");
            Console.WriteLine("Number of current books: {0}, price is {1} and cover is {2}", Book.Count, codeComplete.Price, codeComplete.Cover_type);
            Color.showColor("red");

            Console.WriteLine("Main color: " + Color.cover_color);
        }    
    }
}
