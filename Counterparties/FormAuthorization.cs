using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counterparties
{
    public struct Users
    {
        public string login;
        public string password;
        public string type;
    }
    public partial class FormAuthorization : Form
    {
        public static Users users = new Users();

        public FormAuthorization()
        {
            InitializeComponent();
            comboBoxType.SelectedIndex = 0;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" && textBoxPassword.Text == "")
            {
                MessageBox.Show("Введите данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool key = false;
                foreach (User user in Program.аптека.User)
                {
                    if (textBoxLogin.Text == user.Login && textBoxPassword.Text == user.Password)
                    {
                        key = true;
                        users.type = user.Type;
                        users.login = user.Login;
                        users.login = user.Password;
                    }
                }
                if (!key)
                {
                    MessageBox.Show("Данные введены неверно", "Пользователь не найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxLogin.Text = "";
                    textBoxPassword.Text = "";
                }
                else
                {
                    MessageBox.Show("Данные введены верно", "Пользователь найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormMedicine mediine = new FormMedicine();
                    mediine.Show();
                    this.Hide();
                }
            }
        }
    }
}
