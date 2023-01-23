using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Best_Application
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var authDialogResult = new FormAuth().ShowDialog();
            if (authDialogResult == DialogResult.Cancel)
            {
                this.Close();
            }
        }

        int ch_1, ch_2, zn_1, zn_2, ob_zn, ob_ch;

        private void Numerator1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            GroupBox groupBox = groupBox1;
            Bitmap image = new Bitmap(groupBox.Width, groupBox.Height);
            groupBox.DrawToBitmap(image, groupBox.ClientRectangle);
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Сохранить картинку как...";
            saveDialog.OverwritePrompt = true;
            saveDialog.CheckPathExists = true;
            saveDialog.Filter = "Image Files(*.PNG)|*.PNG";
            saveDialog.ShowHelp = true;
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = saveDialog.FileName;
                    image.Save(path, ImageFormat.Png);
                }
                catch
                {
                    MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Numerator3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sub_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                MessageBox.Show("Вы выбрали " + radioButton.Text);

                if (CheckValue())
                {
                    Butterfly butterfly = new Butterfly(ch_1, zn_1, ch_2, zn_2);

                    if (!butterfly.CheckValueZero())
                    {
                        ob_ch = butterfly.GetSubNum();
                        ob_zn = butterfly.GenDen();
                    }
                }
                else
                    MessageBox.Show("Некорректные значения");
            }
        }

        private void Add_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                MessageBox.Show("Вы выбрали " + radioButton.Text);

                if (CheckValue())
                {
                    Butterfly butterfly = new Butterfly(ch_1, zn_1, ch_2, zn_2);

                    if (!butterfly.CheckValueZero())
                    {
                        ob_ch = butterfly.GetAddNum();
                        ob_zn = butterfly.GenDen();
                    }
                }
                else
                    MessageBox.Show("Некорректные значения");
            }
        }

        private void Decide_Click(object sender, EventArgs e)
        {
            var b = new Butterfly(ch_1, zn_1, ch_2, zn_2);
            if (!b.CheckValueZero())
            {
                if (!Add.Checked && !Sub.Checked)
                {
                    MessageBox.Show("Выберете операцию!");
                }
                else
                {
                    MessageBox.Show("Результат вычислений: " + ob_ch + "/" + ob_zn);

                    Numerator3.Text = Convert.ToString(ob_ch);
                    Denominator3.Text = Convert.ToString(ob_zn);
                }
            }
            else
            {
                MessageBox.Show("Некорректные значения");
                return;
            }

        }

        public bool CheckValue()
        {
            bool ch_1_correct = Int32.TryParse(Numerator1.Text, out ch_1); // Проверка, что введенные значения числовые
            bool zn_1_correct = Int32.TryParse(Denominator1.Text, out zn_1);
            bool ch_2_correct = Int32.TryParse(Numerator2.Text, out ch_2);
            bool zn_2_correct = Int32.TryParse(Denominator2.Text, out zn_2);
            if ((ch_1_correct && zn_1_correct && ch_2_correct && zn_2_correct) == true)
                return true;
            else
                return false;
        }
        
    }
}
