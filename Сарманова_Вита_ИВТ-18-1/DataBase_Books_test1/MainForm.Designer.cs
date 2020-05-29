namespace DataBase_Books_test1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавлениеСтрокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискСтрокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВсёToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Column_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Pages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelTitle = new System.Windows.Forms.Label();
            this.comboBoxChoiceSort = new System.Windows.Forms.ComboBox();
            this.button_Sort = new System.Windows.Forms.Button();
            this.button_Search = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_SaveFile = new System.Windows.Forms.Button();
            this.button_OpenFile = new System.Windows.Forms.Button();
            this.button_NewFile = new System.Windows.Forms.Button();
            this.buttonDeleteAll = new System.Windows.Forms.Button();
            this.labelSave = new System.Windows.Forms.Label();
            this.labelAutoSave = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.менюToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(735, 24);
            this.menuStrip.TabIndex = 13;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавлениеСтрокToolStripMenuItem,
            this.поискСтрокToolStripMenuItem,
            this.удалитьВсёToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.менюToolStripMenuItem.Text = "Команды";
            // 
            // добавлениеСтрокToolStripMenuItem
            // 
            this.добавлениеСтрокToolStripMenuItem.Name = "добавлениеСтрокToolStripMenuItem";
            this.добавлениеСтрокToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.добавлениеСтрокToolStripMenuItem.Text = "Добавление строк";
            // 
            // поискСтрокToolStripMenuItem
            // 
            this.поискСтрокToolStripMenuItem.Name = "поискСтрокToolStripMenuItem";
            this.поискСтрокToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поискСтрокToolStripMenuItem.Text = "Поиск строк";
            // 
            // удалитьВсёToolStripMenuItem
            // 
            this.удалитьВсёToolStripMenuItem.Name = "удалитьВсёToolStripMenuItem";
            this.удалитьВсёToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьВсёToolStripMenuItem.Text = "Удалить всё";
            this.удалитьВсёToolStripMenuItem.Click += new System.EventHandler(this.удалитьВсёToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_ID,
            this.Column_Title,
            this.Column_Author,
            this.Column_Genre,
            this.Column_Pages,
            this.Column_Year});
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGrid.Location = new System.Drawing.Point(0, 240);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(735, 289);
            this.dataGrid.TabIndex = 117;
            this.dataGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGrid_CellBeginEdit);
            this.dataGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellEndEdit);
            this.dataGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGrid_UserDeletingRow);
            // 
            // Column_ID
            // 
            this.Column_ID.FillWeight = 2.281052F;
            this.Column_ID.HeaderText = "ID";
            this.Column_ID.Name = "Column_ID";
            this.Column_ID.ReadOnly = true;
            this.Column_ID.Width = 30;
            // 
            // Column_Title
            // 
            this.Column_Title.FillWeight = 93.9032F;
            this.Column_Title.HeaderText = "Название";
            this.Column_Title.Name = "Column_Title";
            this.Column_Title.Width = 300;
            // 
            // Column_Author
            // 
            this.Column_Author.FillWeight = 147.2734F;
            this.Column_Author.HeaderText = "Автор";
            this.Column_Author.Name = "Column_Author";
            this.Column_Author.Width = 115;
            // 
            // Column_Genre
            // 
            this.Column_Genre.FillWeight = 350.2538F;
            this.Column_Genre.HeaderText = "Жанр";
            this.Column_Genre.Name = "Column_Genre";
            this.Column_Genre.Width = 115;
            // 
            // Column_Pages
            // 
            this.Column_Pages.FillWeight = 4.108705F;
            this.Column_Pages.HeaderText = "Страниц";
            this.Column_Pages.Name = "Column_Pages";
            this.Column_Pages.Width = 70;
            // 
            // Column_Year
            // 
            this.Column_Year.FillWeight = 2.179828F;
            this.Column_Year.HeaderText = "Год";
            this.Column_Year.Name = "Column_Year";
            this.Column_Year.Width = 50;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTitle.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.OldLace;
            this.labelTitle.Location = new System.Drawing.Point(259, 28);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(246, 76);
            this.labelTitle.TabIndex = 118;
            this.labelTitle.Text = "База книг";
            // 
            // comboBoxChoiceSort
            // 
            this.comboBoxChoiceSort.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.comboBoxChoiceSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChoiceSort.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxChoiceSort.FormattingEnabled = true;
            this.comboBoxChoiceSort.Items.AddRange(new object[] {
            "по возрастанию",
            "по убыванию"});
            this.comboBoxChoiceSort.Location = new System.Drawing.Point(465, 198);
            this.comboBoxChoiceSort.Name = "comboBoxChoiceSort";
            this.comboBoxChoiceSort.Size = new System.Drawing.Size(123, 26);
            this.comboBoxChoiceSort.TabIndex = 124;
            // 
            // button_Sort
            // 
            this.button_Sort.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Sort.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Sort.Location = new System.Drawing.Point(363, 195);
            this.button_Sort.Name = "button_Sort";
            this.button_Sort.Size = new System.Drawing.Size(96, 31);
            this.button_Sort.TabIndex = 123;
            this.button_Sort.Text = "Сортировать";
            this.button_Sort.UseVisualStyleBackColor = false;
            this.button_Sort.Click += new System.EventHandler(this.button_Sort_Click);
            // 
            // button_Search
            // 
            this.button_Search.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Search.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Search.Location = new System.Drawing.Point(375, 153);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(213, 32);
            this.button_Search.TabIndex = 122;
            this.button_Search.Text = "Поиск записей";
            this.button_Search.UseVisualStyleBackColor = false;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Add.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Add.Location = new System.Drawing.Point(155, 153);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(214, 32);
            this.button_Add.TabIndex = 121;
            this.button_Add.Text = "Добавление данных";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_SaveFile
            // 
            this.button_SaveFile.BackColor = System.Drawing.Color.SteelBlue;
            this.button_SaveFile.Font = new System.Drawing.Font("Magneto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SaveFile.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_SaveFile.Location = new System.Drawing.Point(296, 107);
            this.button_SaveFile.Name = "button_SaveFile";
            this.button_SaveFile.Size = new System.Drawing.Size(145, 40);
            this.button_SaveFile.TabIndex = 120;
            this.button_SaveFile.Text = "Сохранить файл";
            this.button_SaveFile.UseVisualStyleBackColor = false;
            this.button_SaveFile.Click += new System.EventHandler(this.button_SaveFile_Click);
            // 
            // button_OpenFile
            // 
            this.button_OpenFile.BackColor = System.Drawing.Color.Orange;
            this.button_OpenFile.Font = new System.Drawing.Font("Magneto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OpenFile.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_OpenFile.Location = new System.Drawing.Point(155, 107);
            this.button_OpenFile.Name = "button_OpenFile";
            this.button_OpenFile.Size = new System.Drawing.Size(135, 40);
            this.button_OpenFile.TabIndex = 119;
            this.button_OpenFile.Text = "Открыть файл";
            this.button_OpenFile.UseVisualStyleBackColor = false;
            this.button_OpenFile.Click += new System.EventHandler(this.button_OpenFile_Click);
            // 
            // button_NewFile
            // 
            this.button_NewFile.BackColor = System.Drawing.Color.SeaGreen;
            this.button_NewFile.Font = new System.Drawing.Font("Magneto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_NewFile.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_NewFile.Location = new System.Drawing.Point(447, 107);
            this.button_NewFile.Name = "button_NewFile";
            this.button_NewFile.Size = new System.Drawing.Size(141, 40);
            this.button_NewFile.TabIndex = 125;
            this.button_NewFile.Text = "Новый файл";
            this.button_NewFile.UseVisualStyleBackColor = false;
            this.button_NewFile.Click += new System.EventHandler(this.button_NewFile_Click);
            // 
            // buttonDeleteAll
            // 
            this.buttonDeleteAll.BackColor = System.Drawing.Color.Crimson;
            this.buttonDeleteAll.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteAll.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonDeleteAll.Location = new System.Drawing.Point(155, 190);
            this.buttonDeleteAll.Name = "buttonDeleteAll";
            this.buttonDeleteAll.Size = new System.Drawing.Size(202, 40);
            this.buttonDeleteAll.TabIndex = 126;
            this.buttonDeleteAll.Text = "Очистить базу данных";
            this.buttonDeleteAll.UseVisualStyleBackColor = false;
            this.buttonDeleteAll.Click += new System.EventHandler(this.buttonDeleteAll_Click);
            // 
            // labelSave
            // 
            this.labelSave.AutoSize = true;
            this.labelSave.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelSave.Location = new System.Drawing.Point(441, 0);
            this.labelSave.Name = "labelSave";
            this.labelSave.Size = new System.Drawing.Size(114, 23);
            this.labelSave.TabIndex = 128;
            this.labelSave.Text = "Cохранение...";
            this.labelSave.Visible = false;
            // 
            // labelAutoSave
            // 
            this.labelAutoSave.AutoSize = true;
            this.labelAutoSave.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAutoSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelAutoSave.Location = new System.Drawing.Point(574, 0);
            this.labelAutoSave.Name = "labelAutoSave";
            this.labelAutoSave.Size = new System.Drawing.Size(149, 23);
            this.labelAutoSave.TabIndex = 129;
            this.labelAutoSave.Text = "Автосохранение...";
            this.labelAutoSave.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(735, 529);
            this.Controls.Add(this.labelAutoSave);
            this.Controls.Add(this.labelSave);
            this.Controls.Add(this.buttonDeleteAll);
            this.Controls.Add(this.button_NewFile);
            this.Controls.Add(this.comboBoxChoiceSort);
            this.Controls.Add(this.button_Sort);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_SaveFile);
            this.Controls.Add(this.button_OpenFile);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.menuStrip);
            this.Name = "MainForm";
            this.Text = "База данных книг";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавлениеСтрокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискСтрокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВсёToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Timer timer2;
        public System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Pages;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Year;
        private System.Windows.Forms.ComboBox comboBoxChoiceSort;
        private System.Windows.Forms.Button button_Sort;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_SaveFile;
        private System.Windows.Forms.Button button_OpenFile;
        private System.Windows.Forms.Button button_NewFile;
        private System.Windows.Forms.Button buttonDeleteAll;
        private System.Windows.Forms.Label labelSave;
        private System.Windows.Forms.Label labelAutoSave;
    }
}

