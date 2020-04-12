using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace kursach
{
    public partial class RegisterForm : Form
    {
        bool password_hide;
        AdminPanel ap;
        String curr_role, curr_pass;
        public RegisterForm(AdminPanel _ap, String role, String pass)
        {
            password_hide = true;
            ap = _ap;
            curr_role = role;
            curr_pass = pass;
            InitializeComponent();
            cbRole.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbLogin.Text == "" || tbPass.Text == "" || tbPass2.Text == "")
            {
                MessageBox.Show("Пожалуйста, заполните все поля регистрационной формы.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (tbPass.Text != tbPass2.Text)
            {
                MessageBox.Show("Введенные вами пароли не совпадают. Проверьте правильность введенных данных.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (curr_role != "admin" && StringHelper.TextToRole(cbRole.Text) == "admin")
            {
                MessageBox.Show("Невозможно создать пользователя с ролью администратора, не будучи администратором.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                try
                {
                    PgSql.ConnectToUsersDB(curr_role, curr_pass);
                    PgSql.InsertIntoValues("users", String.Format("'{0}', '{1}', '{2}'", tbLogin.Text, Crypter.Encrypt(tbPass.Text), StringHelper.TextToRole(cbRole.Text)));
                    MessageBox.Show("Пользователь создан с правами \" "+ cbRole.Text +"\". Теперь он можете войти, используя свой логин и пароль.");
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (password_hide)
            {
                tbPass.PasswordChar = tbLogin.PasswordChar;
                tbPass2.PasswordChar = tbLogin.PasswordChar;
            }
            else
            {
                tbPass.PasswordChar = '*';
                tbPass2.PasswordChar = '*';
            }
            password_hide = !password_hide;
        }
    }
}
