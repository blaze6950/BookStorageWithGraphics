using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BindingsListBox
{
    public partial class StatisticForm : Form
    {
        private BindingList<Book> _source;
        private int _maxValue = -1;
        private int _minValue = -1;
        SolidBrush solBrush = new SolidBrush(Color.Black);
        Font f = new Font("Arial", 9, FontStyle.Regular);
        Image im = new Bitmap(609, 370);
        public StatisticForm(BindingList<Book> source)
        {
            _source = source;
            InitializeComponent();
            _source.ListChanged += SourceChanged;
            SourceChanged(null, null);
            this.Hide();
        }

        public void SourceChanged(object sender, EventArgs e)
        {
            foreach (var item in _source)
            {
                if (_minValue == -1)
                {
                    _minValue = item.Cost;
                }
                if (item.Cost > _maxValue)
                {
                    _maxValue = item.Cost;
                }
                else if (item.Cost < _minValue)
                {
                    _minValue = item.Cost;
                }
            }
            StatisticForm_Paint(null, null);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string s0 = saveFileDialog1.FileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string s = saveFileDialog1.FileName;
                // .NET не даст сохранить изображение в тот же файл, из которого загружали
                if (s.ToUpper() == s0.ToUpper())// если пытаемся сохранять изображение в тот же файл, из которого загружали
                {
                    // сохраним изображение во временный файл
                    s0 = Path.GetDirectoryName(s0) + "\\($$##$$)";
                    pictureBox.Image.Save(s0);
                    // разрушим объект Bitmap, связанный с данным изображением 
                    pictureBox.Image.Dispose();
                    // удалим исходный файл
                    File.Delete(s);
                    // имя временного файла заменим на имя исходного файла
                    File.Move(s0, s);
                    // загрузим на PictureBox новый вариант файла
                    pictureBox.Image = new Bitmap(s);
                }
                else
                    // сохраним изображение в файл
                if (pictureBox.Image != null)
                    pictureBox.Image.Save(s);
                Text = "Image Editor - " + s;
            }
        }

        private void StatisticForm_Paint(object sender, PaintEventArgs e)
        {
            var g = Graphics.FromImage(im);
            g.Clear(Color.White);

            for (int i = 0; i < _source.Count; i++)
            {
                DrawColumn(i, g);
            }
            g.DrawLine(new Pen(Color.Black), x1: 30, y1: 10, x2: 30, y2: 320);
            g.DrawLine(new Pen(Color.Black), x1: 10, y1: 300, x2: pictureBox.Width - 10, y2: 300);
            g.DrawString("0", new Font("FrankRuehl", 8), solBrush, 15, 305);
            g.DrawString(_maxValue.ToString(), new Font("FrankRuehl", 8), solBrush, 1, 10);
            pictureBox.Image = im;
            g.Dispose();
        }

        private void DrawColumn(int count, Graphics g)
        {
            if (_source.Count > 0)
            {
                Brush brush = new SolidBrush(Color.Brown);
                var percent = _maxValue / 100.0;
                var percentsOfCurrentValue = _source[count].Cost / percent;
                var height = 290.0 / 100.0 * percentsOfCurrentValue;
                g.FillRectangle(brush, x: count * GetWidth() + GetSpace(count), y: (int)(300 - height + 0.5), width: GetWidth(), height: (int)(height + 0.5));

                g.RotateTransform(90);
                g.DrawString(_source[count].GetName(), f, solBrush, 300, (count * GetWidth() + GetSpace(count) + 15) * (-1));
                g.ResetTransform();
            }
        }

        private int GetWidth()
        {
            return (pictureBox.Width - 40 - _source.Count * 5) / _source.Count;
        }

        private int GetSpace(int count)
        {
            if (count == 0)
            {
                return 35;
            }
            else
            {
                return count * 5 + 35;
            }
        }

        private void StatisticForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
