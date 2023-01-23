using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Best_Application
{
    public partial class FormReg : Form
    {
        public FormReg()
        {
            InitializeComponent();
        }

        private void FormRegistration_Load(object sender, EventArgs e)
        {

        }


        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxLogin.Text) && String.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Пустые логин и пароль");
                return;
            }

            if (new Database("Data Source=dataBase.db;Version=3;").ValidUser_1(textBoxLogin.Text))
            {
                MessageBox.Show("Такой пользователь уже есть");
                return;
            }
      


            string stLog = Convert.ToString(textBoxLogin.Text);
            int lenLog = stLog.Length;
            string stPass = Convert.ToString(textBoxPassword.Text);
            int lenPass = stPass.Length;

            if ((lenLog < 8) && (lenPass < 8) && (lenLog > 0) && (lenPass > 0))
            {
                MessageBox.Show("Короткие логин и пароль");
                return;
            }

            if ((lenLog < 8) && (lenPass >= 8) && (lenLog > 0) && (lenPass > 0))
            {
                MessageBox.Show("Короткий логин");
                return;
            }

            if ((lenLog >= 8) && (lenPass < 8) && (lenLog > 0) && (lenPass > 0))
            {
                MessageBox.Show("Короткий пароль");
                return;
            }

            if (String.IsNullOrWhiteSpace(textBoxLogin.Text))
            {
                MessageBox.Show("Пустой логин");
                return;
            }

            if (String.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Пустой пароль");
                return;
            }

            

            if (new Database("Data Source=dataBase.db;Version=3;").createUser(textBoxLogin.Text, textBoxPassword.Text))
            {
                MessageBox.Show("Регистрация прошла успешно");
                Close();
            }
            else
            {
                MessageBox.Show("Не удалось зарегистрироваться");
            }

        }


        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
