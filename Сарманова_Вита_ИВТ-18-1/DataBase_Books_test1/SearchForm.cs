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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void button_SearchOK_Click(object sender, EventArgs e)
        {
            MainForm f = Owner as MainForm;

            if ((f.data.BooksFile.Count == 0) || (textBox_Search.Text == ""))
                return;

            f.dataGrid.ClearSelection();
            List<int> foundElements = f.data.SearchRows(textBox_Search.Text);

            if (foundElements[0] == -1)
            {
                MessageBox.Show("Ничего не удалось найти!");
                return;
            }

            f.dataGrid.CurrentCell = f.dataGrid[0, foundElements[0]];
            for (int i = 0; i < foundElements.Count; i++)
            {
                f.dataGrid.Rows[foundElements[i]].Selected = true;
            }
        }
    }
}
