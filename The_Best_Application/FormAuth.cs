using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Best_Application
{
    public partial class FormAuth : Form
    {
        public FormAuth()
        {
            InitializeComponent();
        }


        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void buttonAuth_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(textBoxLogin.Text) && String.IsNullOrWhiteSpace(textBoxPass.Text))
            {
                MessageBox.Show("Пустые логин и пароль");
                return;
            }

            if (String.IsNullOrWhiteSpace(textBoxLogin.Text))
            {
                MessageBox.Show("Пустой логин");
                return;
            }

            if (String.IsNullOrWhiteSpace(textBoxPass.Text))
            {
                MessageBox.Show("Пустой пароль");
                return;
            }

            if (userAuthSucceess())
                this.DialogResult = DialogResult.OK;
            else
                return;
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            var regDialogResult = new FormReg().ShowDialog();
            
            if (regDialogResult == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool userAuthSucceess()
        {
            if (incorrectFiledsOnForm())
            {
                MessageBox.Show("Некорректные поля на форме");
                return false;
            }
            if (hasUser(textBoxLogin.Text, textBoxPass.Text))
                return true;
            else
            {
                MessageBox.Show("Неверный логин или пароль");
                return false;
            }
        }

        private bool incorrectFiledsOnForm()
        {
            if (isUnCorrectField(textBoxLogin.Text) || isUnCorrectField(textBoxPass.Text))
                return true;
            return false;
        }

        private bool isUnCorrectField(string field)
        {
            if (String.IsNullOrWhiteSpace(field))
                return true;
            return false;
        }

        private bool hasUser(string login, string password)
        {
            User user = new User(login, password);
            return user.IsCorrect();
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
