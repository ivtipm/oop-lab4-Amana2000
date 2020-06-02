namespace DataBase_Books_test1
{
    partial class SearchForm
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
            this.label_Search2 = new System.Windows.Forms.Label();
            this.button_SearchOK = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.label_Search = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Search2
            // 
            this.label_Search2.AutoSize = true;
            this.label_Search2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Search2.Location = new System.Drawing.Point(14, 47);
            this.label_Search2.Name = "label_Search2";
            this.label_Search2.Size = new System.Drawing.Size(297, 32);
            this.label_Search2.TabIndex = 103;
            this.label_Search2.Text = "Введите любое слово, которое хотите \r\nнайти в базе";
            this.label_Search2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_SearchOK
            // 
            this.button_SearchOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button_SearchOK.Location = new System.Drawing.Point(17, 110);
            this.button_SearchOK.Name = "button_SearchOK";
            this.button_SearchOK.Size = new System.Drawing.Size(294, 27);
            this.button_SearchOK.TabIndex = 102;
            this.button_SearchOK.Text = "Найти";
            this.button_SearchOK.UseVisualStyleBackColor = true;
            this.button_SearchOK.Click += new System.EventHandler(this.button_SearchOK_Click);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(17, 84);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(294, 20);
            this.textBox_Search.TabIndex = 101;
            // 
            // label_Search
            // 
            this.label_Search.AutoSize = true;
            this.label_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Search.Location = new System.Drawing.Point(113, 19);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(78, 25);
            this.label_Search.TabIndex = 100;
            this.label_Search.Text = "Поиск";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 153);
            this.Controls.Add(this.label_Search2);
            this.Controls.Add(this.button_SearchOK);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.label_Search);
            this.Name = "SearchForm";
            this.Text = "Поиск по базе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_Search2;
        private System.Windows.Forms.Button button_SearchOK;
        public System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Label label_Search;
    }
}