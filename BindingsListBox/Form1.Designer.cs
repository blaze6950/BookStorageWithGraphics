namespace BindingsListBox
{
    partial class Form1
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
            this.ListBooks = new System.Windows.Forms.ListBox();
            this.Del = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.FilmInfo = new System.Windows.Forms.GroupBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.BookYear = new System.Windows.Forms.ComboBox();
            this.BookDescr = new System.Windows.Forms.TextBox();
            this.BookAuthor = new System.Windows.Forms.TextBox();
            this.BookName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.graphicForm = new System.Windows.Forms.Button();
            this.FilmInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBooks
            // 
            this.ListBooks.FormattingEnabled = true;
            this.ListBooks.Location = new System.Drawing.Point(13, 26);
            this.ListBooks.Name = "ListBooks";
            this.ListBooks.Size = new System.Drawing.Size(451, 342);
            this.ListBooks.TabIndex = 0;
            // 
            // Del
            // 
            this.Del.Enabled = false;
            this.Del.Location = new System.Drawing.Point(647, 12);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(58, 23);
            this.Del.TabIndex = 3;
            this.Del.Text = "Удалить";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(470, 12);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(73, 23);
            this.Add.TabIndex = 1;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // Edit
            // 
            this.Edit.Enabled = false;
            this.Edit.Location = new System.Drawing.Point(549, 12);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(92, 23);
            this.Edit.TabIndex = 2;
            this.Edit.Text = "Редактировать";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // FilmInfo
            // 
            this.FilmInfo.Controls.Add(this.costTextBox);
            this.FilmInfo.Controls.Add(this.label6);
            this.FilmInfo.Controls.Add(this.label4);
            this.FilmInfo.Controls.Add(this.label3);
            this.FilmInfo.Controls.Add(this.label2);
            this.FilmInfo.Controls.Add(this.label1);
            this.FilmInfo.Controls.Add(this.button5);
            this.FilmInfo.Controls.Add(this.button4);
            this.FilmInfo.Controls.Add(this.BookYear);
            this.FilmInfo.Controls.Add(this.BookDescr);
            this.FilmInfo.Controls.Add(this.BookAuthor);
            this.FilmInfo.Controls.Add(this.BookName);
            this.FilmInfo.Enabled = false;
            this.FilmInfo.Location = new System.Drawing.Point(470, 42);
            this.FilmInfo.Name = "FilmInfo";
            this.FilmInfo.Size = new System.Drawing.Size(263, 331);
            this.FilmInfo.TabIndex = 4;
            this.FilmInfo.TabStop = false;
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(19, 166);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(238, 20);
            this.costTextBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Стоимость";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Автор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Описание";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Год";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(19, 295);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "OK";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(182, 295);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // BookYear
            // 
            this.BookYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BookYear.FormattingEnabled = true;
            this.BookYear.Location = new System.Drawing.Point(19, 71);
            this.BookYear.Name = "BookYear";
            this.BookYear.Size = new System.Drawing.Size(121, 21);
            this.BookYear.TabIndex = 2;
            // 
            // BookDescr
            // 
            this.BookDescr.Location = new System.Drawing.Point(19, 211);
            this.BookDescr.Multiline = true;
            this.BookDescr.Name = "BookDescr";
            this.BookDescr.Size = new System.Drawing.Size(238, 67);
            this.BookDescr.TabIndex = 1;
            // 
            // BookAuthor
            // 
            this.BookAuthor.Location = new System.Drawing.Point(19, 120);
            this.BookAuthor.Name = "BookAuthor";
            this.BookAuthor.Size = new System.Drawing.Size(238, 20);
            this.BookAuthor.TabIndex = 0;
            // 
            // BookName
            // 
            this.BookName.Location = new System.Drawing.Point(19, 29);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(238, 20);
            this.BookName.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Книги";
            // 
            // graphicForm
            // 
            this.graphicForm.Location = new System.Drawing.Point(711, 13);
            this.graphicForm.Name = "graphicForm";
            this.graphicForm.Size = new System.Drawing.Size(22, 23);
            this.graphicForm.TabIndex = 7;
            this.graphicForm.Text = "G";
            this.graphicForm.UseVisualStyleBackColor = true;
            this.graphicForm.Click += new System.EventHandler(this.graphicForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 383);
            this.Controls.Add(this.graphicForm);
            this.Controls.Add(this.FilmInfo);
            this.Controls.Add(this.Del);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.ListBooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Библиотека";
            this.FilmInfo.ResumeLayout(false);
            this.FilmInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBooks;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.GroupBox FilmInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox BookYear;
        private System.Windows.Forms.TextBox BookDescr;
        private System.Windows.Forms.TextBox BookName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BookAuthor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button graphicForm;
    }
}

