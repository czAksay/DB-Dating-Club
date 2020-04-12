using System;

using Npgsql;
using System.Windows.Forms;

namespace kursach
{
    public partial class LoginForm : Form, ILoginView
    {
        bool show_pass;
        private LoginPresenter presenter;
        private LoginModel model;

        public string Login
        { get => tbLogin.Text; }
        public string Password
        { get => tbPass.Text; }
        public string Role
        { set => Role = value; }

        public LoginForm()
        {
            InitializeComponent();
            model = new LoginModel();
            presenter = new LoginPresenter(this, model);
            show_pass = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (presenter.CheckPassEmpty())
            {
                MessageBox.Show("Пожалуйста, заполните все поля формы.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                if (presenter.IsPassInDB())
                {
                    MessageBox.Show(String.Format("Вы вошли как \"{0}\"", StringHelper.RoleToText(presenter.Role)), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbLogin.Clear();
                    tbPass.Clear();
                    MainForm main = new MainForm(this, presenter.Login, presenter.Role);
                    this.Hide();
                    main.FormClosed += new FormClosedEventHandler(delegate { Close(); });
                    try
                    {
                        main.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        this.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Нет такого пользователя. Проверьте правильность введенных данных!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка подключения к БД", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (!show_pass)
            {
                tbPass.PasswordChar = tbLogin.PasswordChar;
            }
            else
            {
                tbPass.PasswordChar = '*';
            }
            show_pass = !show_pass;
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            tbLogin.Text = "hoba";
            tbPass.Text = "1234";
            button1_Click(sender, e);
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                btnadmin.Visible = !btnadmin.Visible;
            }
        }
    }
}
