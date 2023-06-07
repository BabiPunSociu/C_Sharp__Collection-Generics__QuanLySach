using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_sach
{
    internal class Book
    {
        int id;
        string title, author, publisher;    // Tên sách, Tác giả, Nhà xuất bản
        int year;
        public double price;
        public Book(int id, string title, string author, string publisher, int year, double price)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.year = year;
            this.price = price;
        }

        public void display()
        {
            Console.WriteLine("Mã sách: " + id);
            Console.WriteLine("Tên sách: " + title);
            Console.WriteLine("Tên tác giả: " + author);
            Console.WriteLine("Nhà xuất bản: " + publisher);
            Console.WriteLine("Năm xuất bản: " + year);
            Console.WriteLine("Giá bán: " + price);
            Console.WriteLine("---------------------------------------");
        }
    }
}
