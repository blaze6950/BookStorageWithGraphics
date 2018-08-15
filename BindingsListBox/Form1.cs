using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BindingsListBox
{
    public partial class Form1 : Form
    {
        private BindingList<Book> _books = new BindingList<Book>();
        private OKMode _okModeFunc;
        private StatisticForm _statisticForm;

        public Form1()
        {
            InitializeComponent();
            ListBooks.DataSource = _books;
            for (var i = 1800; i < 2018; i++)
                BookYear.Items.Add(i);
            _statisticForm = new StatisticForm(_books);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Add.Enabled = false;
            Del.Enabled = false;
            Edit.Enabled = false;
            FilmInfo.Enabled = true;
            _okModeFunc = OKAdd;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            FilmInfo.Enabled = false;
            Add.Enabled = true;
            BookDescr.Text = "";
            BookName.Text = "";
            BookAuthor.Text = "";
            costTextBox.Text = "";
            BookYear.SelectedIndex = -1;
            if (ListBooks.SelectedIndex != -1)
            {
                Edit.Enabled = true;
                Del.Enabled = true;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            _okModeFunc();
        }
        private void Del_Click(object sender, EventArgs e)
        {
            var index = ListBooks.SelectedIndex;
            _books.Remove(_books[index]);
            button4_Click(sender, e);
            if (ListBooks.SelectedIndex != -1)
            {
                Del.Enabled = true;
                Edit.Enabled = true;
            }
            else
            {
                Del.Enabled = false;
                Edit.Enabled = false;
            }
        }
        private void Edit_Click(object sender, EventArgs e)
        {
            _okModeFunc = OKEdit;
            Add.Enabled = false;
            Del.Enabled = false;
            Edit.Enabled = false;
            FilmInfo.Enabled = true;
            var index = ListBooks.SelectedIndex;
            BookDescr.Text = _books[index].Description;
            BookName.Text = _books[index].Name;
            BookAuthor.Text = _books[index].Author;
            costTextBox.Text = _books[index].Cost.ToString();
            BookYear.SelectedItem = _books[index].Year;
        }
        private void OKAdd()
        {
            var book = new Book();
            book.Description = BookDescr.Text;
            book.Name = BookName.Text;
            book.Author = BookAuthor.Text;
            book.Year = int.Parse(BookYear.Text);
            book.Cost = int.Parse(costTextBox.Text);
            _books.Add(book);
            button4_Click(null, null);
            Del.Enabled = true;
            Edit.Enabled = true;
        }
        private void OKEdit()
        {
            var book = new Book();
            book.Description = BookDescr.Text;
            book.Name = BookName.Text;
            book.Author = BookAuthor.Text;
            book.Year = int.Parse(BookYear.Text);
            book.Cost = int.Parse(costTextBox.Text);
            _books[ListBooks.SelectedIndex] = book;
            button4_Click(null, null);
            Del.Enabled = true;
            Edit.Enabled = true;
        }

        private delegate void OKMode();

        private void graphicForm_Click(object sender, EventArgs e)
        {
            _statisticForm.Show();
        }
    }
}