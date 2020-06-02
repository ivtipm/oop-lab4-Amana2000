using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_Books_test1
{
    public partial class MainForm : Form
    {
        public DataBaseMethods data = new DataBaseMethods();
        public string oldValue = "";
        public string filename = "";

        public string BookID;
        public string BookTitle;        
        public string BookAuthor;
        public string BookGenre;
        public string BookPages;
        public string YearPublication;

        public MainForm()
        {
            InitializeComponent();

            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            InitializeTimers();

            //Всплывающие подсказки для кнопок
            ToolTip t = new ToolTip();
            t.SetToolTip(button_OpenFile, "Открыть файл (Ctrl+O)");
            t.SetToolTip(button_SaveFile, "Сохранить файл (Ctrl+S)");
            t.SetToolTip(button_Search, "Поиск данных");
            t.SetToolTip(button_Add, "Добавление новых данных");
            t.SetToolTip(button_Sort, "Сортировать книги по году публикации");
        }

        private void InitializeTimers()
        {
            // Таймер для автосохранения данных в файл раз в 1 минуту
            timer1.Interval = 60000;
            timer1.Tick += new EventHandler(timer1_Tick);

            // Таймер для отображения надписи, свидетельствующей о сохранении файла
            // длительностью 3 сек
            timer2.Interval = 3000;
            timer2.Tick += new EventHandler(timer2_Tick);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            data.SaveToFile(filename);
            labelAutoSave.Visible = true;
            timer2.Enabled = true;
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (labelAutoSave.Visible)
            {
                labelAutoSave.Visible = false;
            }
            else
            {
                labelSave.Visible = false;
            }
            timer2.Enabled = false;
            timer2.Stop();
        }

        //Создаёт порядковый ID
        public ushort generateID()
        {
            int id = data.BooksFile.Count + 1;

            for (int i = 0; i < data.BooksFile.Count; i++)
            {
                Book book = (Book)data.BooksFile[i];
                if (book.BookID == id)
                {
                    i = 0;
                    id++;
                }
            }
            return (ushort)id;
        }

        //Запрет редактирования последней строки
        public void BanChangeColumn(int index)
        {
            dataGrid.Rows[index].Cells[0].ReadOnly = true;
        }


        //Добавить запись в базу
        //private void button_AddRow_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        BookID = textBox_ID.Text = generateID().ToString();

        //        BookTitle = textBox_Title.Text;
        //        BookAuthor = textBox_Author.Text;
        //        BookGenre = comboBox_Genre.Text;
        //        BookPages = textBox_Pages.Text;
        //        YearPublication = textBox_Year.Text;

        //        Book book = new Book
        //            (
        //            (ushort)Convert.ToInt32(textBox_ID.Text),
        //            textBox_Title.Text,
        //            textBox_Author.Text,
        //            comboBox_Genre.Text,
        //            textBox_Pages.Text,
        //            (ushort)Convert.ToInt32(textBox_Year.Text)
        //            );

        //        data.AddRow(book);
        //        int n = data.BooksFile.Count;

        //        Book book1 = (Book)data.BooksFile[n - 1];
        //        dataGrid.Rows.Add
        //            (
        //            book1.BookID,
        //            textBox_Title.Text,
        //            textBox_Author.Text,
        //            comboBox_Genre.Text,
        //            textBox_Pages.Text,
        //            textBox_Year.Text                    
        //            );

        //        BanChangeColumn(n - 1);

        //        TextBoxsClear();

        //        if ((!timer1.Enabled) && (filename != ""))
        //        {
        //            timer1.Enabled = true;
        //            timer1.Start();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Ошибка: {ex.Message}");
        //    }
        //}

        //Полностью очистить базу
        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            if (data.BooksFile.Count != 0)
            {
                DialogResult dialogResult = MessageBox.Show
                    ("Уверены," +
                    "что хотите удалить все элементы?",
                    "Подтверждение", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    data.DeleteAllRows();
                    dataGrid.Rows.Clear();
                }
            }
        }

        //Сохранить базу в файл
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (filename == "")
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                        return;
                    filename = saveFileDialog1.FileName;
                    this.Text = filename + " - База данных книг";
                }
                // Если сохранение произошло первый раз, то запускаем 
                // таймер для автосохранения
                if (!timer1.Enabled)
                {
                    timer1.Enabled = true;
                    timer1.Start();
                }
                // При каждом сохранении будет появляться надпись "Сохранение..."
                labelSave.Visible = true;
                timer2.Enabled = true;
                timer2.Start();

                data.SaveToFile(filename);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        //Записать базу в таблицу
        private void WriteToDataGrid()
        {
            try
            {
                for (int i = 0; i < data.BooksFile.Count; i++)
                {
                    Book film = (Book)data.BooksFile[i];
                    dataGrid.Rows.Add(
                        film.BookID,
                        film.BookTitle,
                        film.BookAuthor,
                        film.BookGenre,
                        film.BookPages,    
                        film.YearPublication);

                    BanChangeColumn(i);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        //Очистить все поля
        public void TextBoxsClear()
        {
            //textBox_ID.Text = "";
            //textBox_Title.Text = "";
            //textBox_Author.Text = "";
            //comboBox_Genre.Text = "";
            //textBox_Pages.Text = "";
            //textBox_Year.Text = "";
        }

        //Открывает файл и считывает от туда базу
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }

                filename = openFileDialog1.FileName;
                this.Text = filename + " - База данных книг";
                dataGrid.Rows.Clear();
                data.OpenFile(filename);
                WriteToDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        //"Создать новый файл"
        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((data.BooksFile.Count != 0) || (filename != ""))
            {
                DialogResult dialogResult = MessageBox.Show
                    ("Уверены," +
                    "что хотите создать новый файл?" + "\r\n" +
                    "Изменения в текущем не сохранятся!",
                    "Подтверждение", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    this.Text = "База данных книг";
                    filename = "";
                    data.DeleteAllRows();
                    dataGrid.Rows.Clear();
                    timer1.Stop();
                    timer1.Enabled = false;
                    timer2.Stop();
                    timer2.Enabled = false;
                    TextBoxsClear();
                }
            }
        }

        //Сортировка по году публикации 
        private void button_Sort_Click(object sender, EventArgs e)
        {
            if (data.BooksFile.Count != 0)
            {
                dataGrid.Rows.Clear();
                if (comboBoxChoiceSort.SelectedIndex == 0)
                {
                    data.Sort(SortDirection.Ascending);
                }
                else
                {
                    data.Sort(SortDirection.Descending);
                }
                WriteToDataGrid();
            }
        }

        //Открыть форму со справкой
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Info = "База данных книг, версия 0.85 Demo" + "\n\n" +
                          "Powered by Visual Studio 2017, C#" + "\n\n" +
                          "2020 г.";
            MessageBox.Show(Info, "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_OpenFile_Click(object sender, EventArgs e)
        {
            открытьToolStripMenuItem_Click(открытьToolStripMenuItem, null);
        }

        private void button_SaveFile_Click(object sender, EventArgs e)
        {
            сохранитьToolStripMenuItem_Click(сохранитьToolStripMenuItem, null);
        }

        private void button_NewFile_Click(object sender, EventArgs e)
        {
            создатьToolStripMenuItem_Click(создатьToolStripMenuItem, null);
        }

        private void удалитьВсёToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonDeleteAll_Click(buttonDeleteAll, null);
        }

        //Пользователь заканчивает редактирование ячейки
        private void dataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indRow = dataGrid.Rows[e.RowIndex].Index;
                int indColumn = dataGrid.Columns[e.ColumnIndex].Index;
                object value = dataGrid.Rows[indRow].Cells[indColumn].Value;

                // Если значение не было введено, то оставляем старое
                if (value is null)
                {
                    MessageBox.Show("Вы не ввели значение.");
                    dataGrid.Rows[indRow].Cells[indColumn].Value = oldValue;
                    return;
                }

                if (indColumn == 1)
                {
                    data.EditBookTitle((string)value, indRow);
                }

                else
                if (indColumn == 2)
                {
                    data.EditAuthor((string)value, indRow);
                }

                else
                if (indColumn == 3)
                {
                    data.EditGenre((string)value, indRow);
                }

                else
                if (indColumn == 4)
                {
                    data.EditPages((string)value, indRow);
                }

                else
                if (indColumn == 5)
                {
                    try
                    {
                        data.EditYearPublication((ushort)Convert.ToInt32(value), indRow);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show($"Ошибка: {exception.Message}");
                        dataGrid.Rows[indRow].Cells[indColumn].Value = oldValue;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        //Пользователь начинает редактирование ячейки
        //На всякий случай сохраняется "старое" значение ячейки
        private void dataGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                oldValue = ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }

        //Удаление записи из таблицы и базы
        private void dataGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                object ObjID = e.Row.Cells[0].Value;
                ushort ID = (ushort)ObjID;
                Book book;

                for (int i = 0; i < data.BooksFile.Count; i++)
                {
                    book = (Book)data.BooksFile[i];

                    if (book.BookID == ID)
                    {
                        data.DeleteRow(i);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            AddForm af = new AddForm();
            af.Owner = this;
            af.ShowDialog();
        }

        //Открыть форму для поиска по базе
        private void button_Search_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm();
            sf.Owner = this;
            sf.ShowDialog();
        }

        //При закрытии формы сказать про несохранённые данные
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((data.BooksFile.Count != 0) || (filename != ""))
            {
                DialogResult dialogResult = MessageBox.Show
                    ("Уверены," +
                    "что хотите выйти из программы?" + "\r\n" +
                    "Изменения ещё не сохранены!",
                    "Подтверждение", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    this.Text = "База данных книг";
                    filename = "";
                    data.DeleteAllRows();
                    dataGrid.Rows.Clear();
                    timer1.Stop();
                    timer1.Enabled = false;
                    timer2.Stop();
                    timer2.Enabled = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
