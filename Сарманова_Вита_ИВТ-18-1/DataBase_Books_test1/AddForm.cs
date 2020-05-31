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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void button_AddRow_Click(object sender, EventArgs e)
        {
            MainForm f = Owner as MainForm;

            try
            {
                f.BookID = textBox_ID.Text = f.generateID().ToString();

                f.BookTitle = textBox_Title.Text;
                f.BookAuthor = textBox_Author.Text;
                f.BookGenre = comboBox_Genre.Text;
                f.BookPages = textBox_Pages.Text;
                f.YearPublication = textBox_Year.Text;

                Book book = new Book
                    (
                    (ushort)Convert.ToInt32(textBox_ID.Text),
                    textBox_Title.Text,
                    textBox_Author.Text,
                    comboBox_Genre.Text,
                    textBox_Pages.Text,
                    (ushort)Convert.ToInt32(textBox_Year.Text)
                    );

                f.data.AddRow(book);
                int n = f.data.BooksFile.Count;

                Book book1 = (Book)f.data.BooksFile[n - 1];
                f.dataGrid.Rows.Add
                    (
                    book1.BookID,
                    textBox_Title.Text,
                    textBox_Author.Text,
                    comboBox_Genre.Text,
                    textBox_Pages.Text,
                    textBox_Year.Text
                    );

                f.BanChangeColumn(n - 1);

                f.TextBoxsClear();

                if ((!f.timer1.Enabled) && (f.filename != ""))
                {
                    f.timer1.Enabled = true;
                    f.timer1.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}
