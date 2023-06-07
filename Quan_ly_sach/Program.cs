using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_sach
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Book> books = new List<Book>()
            {
                new Book(1, "Lap trinh C", "Nguyen Van A", "DH GTVT", 2010, 150),
                new Book(2, "Cha giau cha ngheo", "Nguyen Van B", "Kim Dong", 2002, 250),
                new Book(3, "Dac Nhan Tam", "Dale Canagine", "Kim Dong", 2001, 300),
                new Book(4, "Hoc ve tien", "Nguoi Nhat Ban", "Kim Dong", 2009, 123),
                new Book(5, "Doi ngan dung ngu dai", "Napoleong Hill", "NXB Tre", 2015, 315),
            };
            
            // in danh sach
            foreach(Book book in books)
            {
                book.display();
            }

            // sắp xếp danh sách theo giá tăng dần:
            books = books.OrderBy(b => b.price).ToList();   //  Linq
            // in danh sach
            foreach (Book book in books)
            {
                book.display();
            }
        }
    }
}