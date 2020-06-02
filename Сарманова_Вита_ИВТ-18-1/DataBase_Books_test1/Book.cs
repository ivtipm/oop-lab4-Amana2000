using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase_Books_test1
{
    public class Book
    {
        public Book
            (
            ushort bookID,
            string bookTitle,
            string bookAuthor,
            string bookGenre,
            string bookPages,
            ushort yearPublication
            )
        {
            if((bookTitle == "") || (bookAuthor == "") || (bookGenre == "") || (bookPages ==""))
            {
                throw new Exception("Проверьте, всё ли вы заполнили. Все поля должны быть заполнены");
            }
            BookID = bookID;
            BookTitle = bookTitle;
            BookAuthor = bookAuthor;
            BookGenre = bookGenre;
            BookPages = bookPages;
            YearPublication = yearPublication;

            if ((yearPublication < 1500) || (yearPublication > (DateTime.Now.Year + 10)))
            {
                throw new Exception("Год публикации должен быть не раньше 1500 и не позднее 2030");
            }
            YearPublication = yearPublication;
            BookID = bookID;
        }

        // Свойства для полей
        public ushort BookID           { get; set; } // | ID записи в таблице
        public string BookTitle        { get; set; } // | Название книги
        public string BookAuthor       { get; set; } // | Автор книги
        public string BookGenre        { get; set; } // | Жанр книги
        public string BookPages        { get; set; } // | Кол-во страниц
        public ushort YearPublication  { get; set; } // | Год публикации

        public override string ToString()
        {
            return BookID + " | " + BookTitle + " | " + BookAuthor + " | " + BookGenre + " | " + BookPages + " | " + YearPublication + " | ";
        }
    }
}
