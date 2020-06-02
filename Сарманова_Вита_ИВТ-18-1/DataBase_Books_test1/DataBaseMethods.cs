using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase_Books_test1
{
    public class DataBaseMethods
    {
        // массив из записей с данными о книгах
        public ArrayList BooksFile { get; } = new ArrayList();

        // Добавить новую строку в файл
        public void AddRow(Book bookRow)
        {
            BooksFile.Add(bookRow);
        }

        // Удалить определённую строку из массива
        public void DeleteRow(int number)
        {
            BooksFile.RemoveAt(number);
        }

        // Удалить все строки из массива
        public void DeleteAllRows()
        {
            BooksFile.Clear();
        }

        // Изменить название книги
        public void EditBookTitle(string title, int index)
        {
            Book book = (Book)BooksFile[index];
            book.BookTitle = title;
        }

        // Изменить автора книги
        public void EditAuthor(string author, int index)
        {
            Book book = (Book)BooksFile[index];
            book.BookAuthor = author;
        }

        // Изменить жанр книги
        public void EditGenre(string genre, int index)
        {
            Book book = (Book)BooksFile[index];
            book.BookGenre = genre;
        }

        // Изменить кол-во страниц в книге
        public void EditPages(string pages, int index)
        {
            Book book = (Book)BooksFile[index];
            book.BookPages = pages;
        }

        // Изменить год публикации книги
        public void EditYearPublication(ushort year, int index)
        {
            Book book = (Book)BooksFile[index];
            if ((year < 1500) || (year > (DateTime.Now.Year + 10)))
            {
                throw new Exception("Год публикации должен быть не раньше 1500 и не позднее 2030");
            }
            book.YearPublication = year;
        }

        // Сохранить массив в файл
        public void SaveToFile(string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename, false, System.Text.Encoding.Unicode))
            {
                foreach (Book s in BooksFile)
                {
                    sw.WriteLine(s.ToString());
                }
            }
        }

        // Загрузить массив из файла
        public void OpenFile(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new Exception("Файл не существует");
            }

            if (BooksFile.Count != 0)
            {
                DeleteAllRows();
            }

            using (StreamReader sw = new StreamReader(filename))
            {
                while (!sw.EndOfStream)
                {
                    string str = sw.ReadLine();
                    string[] dataFromFile = str.Split(new String[] { "|" }, StringSplitOptions.RemoveEmptyEntries);

                    ushort id = (ushort)Convert.ToInt32(dataFromFile[0]);
                    string title = dataFromFile[1];
                    string author = dataFromFile[2];
                    string genre = dataFromFile[3];
                    string pages = dataFromFile[4];
                    ushort year = (ushort)Convert.ToInt32(dataFromFile[5]);

                    Book book = new Book(id, title, author, genre, pages, year);
                    AddRow(book);
                }
            }
        }

        // Поиск совпадений по базе, и получение ID всех найденных записей        
        // Возвращает -1, если совпадений не найдено
        public List<int> SearchRows(string query)
        {
            List<int> count = new List<int>();

            //Проверяются ID и год публикации
            if (ushort.TryParse(query, out ushort num_query))
            {
                for (int i = 0; i < BooksFile.Count; i++)
                {
                    Book book = (Book)BooksFile[i];

                    if (book.BookID == num_query)
                    {
                        count.Add(i);
                        break; // Если нашли запись по уникальному ID, то закончить поиск
                    }
                    else
                    {
                        if (book.YearPublication == num_query)
                        {
                            count.Add(i);
                        }
                    }
                }

                if (count.Count == 0)
                {
                    count.Add(-1);
                }
                return count;
            }

            // Поиск по текстовым полям записи
            query = query.ToLower(); // перевод в нижний регистр
            query = query.Replace(" ", "");

            for (int i = 0; i < BooksFile.Count; i++)
            {
                Book book = (Book)BooksFile[i];

                if (book.BookTitle.ToLower().Replace(" ", "").Contains(query))
                {
                    count.Add(i);
                }

                else
                if (book.BookAuthor.ToLower().Replace(" ", "").Contains(query))
                {
                    count.Add(i);
                }

                else
                if (book.BookGenre.ToLower().Replace(" ", "").Contains(query))
                {
                    count.Add(i);
                }

                else
                if (book.BookPages.ToLower().Replace(" ", "").Contains(query))
                {
                    count.Add(i);
                }
            }

            if (count.Count == 0)
            {
                count.Add(-1);
            }
            return count;
        }

        // Сортировка по году публикации
        public void Sort(SortDirection direction)
        {
            BooksFile.Sort(new YearComparer(direction));
        }
    }

    // Сортировка по возрастанию/убыванию
    public enum SortDirection
    {
        Ascending, // возрастание
        Descending // убывание
    }

    public class YearComparer : IComparer
    {
        private SortDirection m_direction = SortDirection.Ascending;

        public YearComparer() : base() { }

        public YearComparer(SortDirection direction)
        {
            m_direction = direction;
        }

        int IComparer.Compare(object x, object y)
        {
            Book book1 = (Book)x;
            Book book2 = (Book)y;

            return (m_direction == SortDirection.Ascending) ?
                book1.YearPublication.CompareTo(book2.YearPublication) :
                book2.YearPublication.CompareTo(book1.YearPublication);
        }
    }
}
