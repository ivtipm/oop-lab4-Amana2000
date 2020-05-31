namespace DataBase_Books_test1
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_AddRow = new System.Windows.Forms.Button();
            this.textBox_Year = new System.Windows.Forms.TextBox();
            this.label_Year = new System.Windows.Forms.Label();
            this.label_Author = new System.Windows.Forms.Label();
            this.textBox_Pages = new System.Windows.Forms.TextBox();
            this.textBox_Author = new System.Windows.Forms.TextBox();
            this.label_Pages = new System.Windows.Forms.Label();
            this.comboBox_Genre = new System.Windows.Forms.ComboBox();
            this.label_Genre = new System.Windows.Forms.Label();
            this.textBox_Title = new System.Windows.Forms.TextBox();
            this.label_TitleFilm = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.Label_ID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_AddRow
            // 
            this.button_AddRow.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_AddRow.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_AddRow.Location = new System.Drawing.Point(9, 172);
            this.button_AddRow.Name = "button_AddRow";
            this.button_AddRow.Size = new System.Drawing.Size(292, 30);
            this.button_AddRow.TabIndex = 126;
            this.button_AddRow.Text = "Добавить запись";
            this.button_AddRow.UseVisualStyleBackColor = false;
            this.button_AddRow.Click += new System.EventHandler(this.button_AddRow_Click);
            // 
            // textBox_Year
            // 
            this.textBox_Year.Location = new System.Drawing.Point(111, 146);
            this.textBox_Year.Name = "textBox_Year";
            this.textBox_Year.Size = new System.Drawing.Size(77, 20);
            this.textBox_Year.TabIndex = 125;
            // 
            // label_Year
            // 
            this.label_Year.AutoSize = true;
            this.label_Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Year.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Year.Location = new System.Drawing.Point(24, 146);
            this.label_Year.Name = "label_Year";
            this.label_Year.Size = new System.Drawing.Size(34, 16);
            this.label_Year.TabIndex = 124;
            this.label_Year.Text = "Год";
            // 
            // label_Author
            // 
            this.label_Author.AutoSize = true;
            this.label_Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Author.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Author.Location = new System.Drawing.Point(23, 94);
            this.label_Author.Name = "label_Author";
            this.label_Author.Size = new System.Drawing.Size(53, 16);
            this.label_Author.TabIndex = 120;
            this.label_Author.Text = "Автор";
            // 
            // textBox_Pages
            // 
            this.textBox_Pages.Location = new System.Drawing.Point(111, 119);
            this.textBox_Pages.Name = "textBox_Pages";
            this.textBox_Pages.Size = new System.Drawing.Size(77, 20);
            this.textBox_Pages.TabIndex = 123;
            // 
            // textBox_Author
            // 
            this.textBox_Author.Location = new System.Drawing.Point(111, 93);
            this.textBox_Author.Name = "textBox_Author";
            this.textBox_Author.Size = new System.Drawing.Size(190, 20);
            this.textBox_Author.TabIndex = 121;
            // 
            // label_Pages
            // 
            this.label_Pages.AutoSize = true;
            this.label_Pages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Pages.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Pages.Location = new System.Drawing.Point(22, 120);
            this.label_Pages.Name = "label_Pages";
            this.label_Pages.Size = new System.Drawing.Size(81, 16);
            this.label_Pages.TabIndex = 122;
            this.label_Pages.Text = "Страницы";
            // 
            // comboBox_Genre
            // 
            this.comboBox_Genre.FormattingEnabled = true;
            this.comboBox_Genre.Items.AddRange(new object[] {
            "Фэнтези",
            "Современная зарубежная проза",
            "Современные западные детективы",
            "Традиционная научная фантастика",
            "Современная отечественная проза",
            "Зарубежная классика",
            "Мистика, ужасы, готика",
            "Российские боевики и детективы",
            "Сетевая литература"});
            this.comboBox_Genre.Location = new System.Drawing.Point(111, 66);
            this.comboBox_Genre.Name = "comboBox_Genre";
            this.comboBox_Genre.Size = new System.Drawing.Size(190, 21);
            this.comboBox_Genre.TabIndex = 119;
            // 
            // label_Genre
            // 
            this.label_Genre.AutoSize = true;
            this.label_Genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Genre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Genre.Location = new System.Drawing.Point(23, 67);
            this.label_Genre.Name = "label_Genre";
            this.label_Genre.Size = new System.Drawing.Size(49, 16);
            this.label_Genre.TabIndex = 118;
            this.label_Genre.Text = "Жанр";
            // 
            // textBox_Title
            // 
            this.textBox_Title.Location = new System.Drawing.Point(111, 40);
            this.textBox_Title.Name = "textBox_Title";
            this.textBox_Title.Size = new System.Drawing.Size(190, 20);
            this.textBox_Title.TabIndex = 117;
            // 
            // label_TitleFilm
            // 
            this.label_TitleFilm.AutoSize = true;
            this.label_TitleFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TitleFilm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_TitleFilm.Location = new System.Drawing.Point(23, 41);
            this.label_TitleFilm.Name = "label_TitleFilm";
            this.label_TitleFilm.Size = new System.Drawing.Size(82, 16);
            this.label_TitleFilm.TabIndex = 116;
            this.label_TitleFilm.Text = "Название";
            // 
            // textBox_ID
            // 
            this.textBox_ID.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_ID.Location = new System.Drawing.Point(52, 8);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.ReadOnly = true;
            this.textBox_ID.Size = new System.Drawing.Size(53, 20);
            this.textBox_ID.TabIndex = 127;
            this.textBox_ID.TabStop = false;
            // 
            // Label_ID
            // 
            this.Label_ID.AutoSize = true;
            this.Label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_ID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label_ID.Location = new System.Drawing.Point(23, 9);
            this.Label_ID.Name = "Label_ID";
            this.Label_ID.Size = new System.Drawing.Size(23, 16);
            this.Label_ID.TabIndex = 115;
            this.Label_ID.Text = "ID";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(317, 221);
            this.Controls.Add(this.button_AddRow);
            this.Controls.Add(this.textBox_Year);
            this.Controls.Add(this.label_Year);
            this.Controls.Add(this.label_Author);
            this.Controls.Add(this.textBox_Pages);
            this.Controls.Add(this.textBox_Author);
            this.Controls.Add(this.label_Pages);
            this.Controls.Add(this.comboBox_Genre);
            this.Controls.Add(this.label_Genre);
            this.Controls.Add(this.textBox_Title);
            this.Controls.Add(this.label_TitleFilm);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.Label_ID);
            this.Name = "AddForm";
            this.Text = "Добавление записей";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_AddRow;
        public System.Windows.Forms.TextBox textBox_Year;
        private System.Windows.Forms.Label label_Year;
        private System.Windows.Forms.Label label_Author;
        public System.Windows.Forms.TextBox textBox_Pages;
        public System.Windows.Forms.TextBox textBox_Author;
        private System.Windows.Forms.Label label_Pages;
        public System.Windows.Forms.ComboBox comboBox_Genre;
        private System.Windows.Forms.Label label_Genre;
        public System.Windows.Forms.TextBox textBox_Title;
        private System.Windows.Forms.Label label_TitleFilm;
        public System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label Label_ID;
    }
}