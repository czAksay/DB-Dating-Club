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
    public partial class AdminPanel : Form
    {
        String curr_user, role, role_pass;
        int y;
        public AdminPanel(String _curr_user, String _role, String _role_pass)
        {
            curr_user = _curr_user;
            role = _role;
            role_pass = _role_pass;
            InitializeComponent();
            ShowAllUsers();
            this.Text += " (" + curr_user + ")";
        }

        private void AdminPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            PgSql.ConnectToDatingClubDB(role, role_pass);
        }

        private void ClearUserButtons()
        {
            pnlUsers.Controls.Clear();
        }

        private void CreateUsersButtons(String login, String role)
        {
            Panel pn = new Panel();
            pnlUsers.Controls.Add(pn);

            pn.BorderStyle = BorderStyle.FixedSingle;
            pn.Location = new Point(20, y);
            pn.Size = (Size)new Point(this.Size.Width - 60, 35);
            y += pn.Size.Height + 12;

            Label lb = new Label();
            lb.Text = login;
            lb.Font = new Font("Microsoft Sans Serif", 11);
            pn.Controls.Add(lb);
            lb.Location = new Point(5, 5);

            ComboBox cb = new ComboBox();
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
            cb.FlatStyle = FlatStyle.Popup;
            cb.Items.Add("Финансист");
            cb.Items.Add("Менеджер");
            cb.Items.Add("Работник анкет");
            cb.Items.Add("Админ");
            cb.Size = (Size)new Point(175, 30);
            cb.Location = new Point(340, 5);
            cb.Text = StringHelper.RoleToText(role);
            pn.Controls.Add(cb);
            Button btA = new Button();
            btA.Text = "A";
            tTipApply.SetToolTip(btA, "Принять");
            btA.Location = new Point(520, 2);
            btA.Size = (Size)new Point(30, 30);
            Button btD = new Button();
            btD.Text = "D";
            tTipApply.SetToolTip(btD, "Удалить");
            btD.Location = new Point(550, 2);
            btD.Size = (Size)new Point(30, 30);
            btD.Click += new EventHandler(delegate { DropUser((Panel)btD.Parent); });
            btA.Click += new EventHandler(delegate { ApplyUser((Panel)btA.Parent); });
            pn.Controls.Add(btA);
            pn.Controls.Add(btD);
        }

        private void ShowAllUsers()
        {
            y = 10;
            ClearUserButtons();
            try
            {
                PgSql.ConnectToUsersDB(role, role_pass);
                NpgsqlDataReader dataReader = PgSql.SelectFrom("login,role", "users");
                while(dataReader.Read())
                {
                    CreateUsersButtons(dataReader[0].ToString(), dataReader[1].ToString());
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                lblNoUsers.Visible = true;
                btnRegistrate.Enabled = false;
            }
        }

        private void AdminPanel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                ShowAllUsers();
        }

        private void btnRegistrate_Click(object sender, EventArgs e)
        {
            RegisterForm rf = new RegisterForm(this, role, role_pass);
            rf.ShowDialog();
            ShowAllUsers();
        }

        private void DropUser(Panel users_panel)
        {
            String user, role2 = "";
            user = ((Label)(users_panel.Controls[0])).Text;
            if (user == "hoba")
            {
                MessageBox.Show("Невозможно удалить учетную запись гл. администратора.");
                return;
            }
            try
            {
                NpgsqlDataReader dataReader = PgSql.SelectFromWhere("role", "users", "login", user.ToString());
                if (dataReader.Read())
                    role2 = dataReader[0].ToString();
                else
                    throw new Exception("error...");
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if (StringHelper.TextToRole(role2) == "admin" && StringHelper.TextToRole(role) != "admin")
            {
                MessageBox.Show("Администратора может удалить только администратор.");
                return;
            }
            var res = DialogResult.OK;
            if (user == curr_user)
            {
                res = MessageBox.Show(String.Format("Вы уверены, что хотите удалить из базы данных себя (\"{0}\")?\nЭто действие приведет к выходу программы к окну авторизации.", user), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else
            {
                res = MessageBox.Show(String.Format("Вы уверены, что хотите удалить пользователя \"{0}\" с ролью \"{1}\" из Базы Данных?", user, StringHelper.RoleToText(role2)), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            if (res == DialogResult.Yes)
            {
                try
                {
                    PgSql.DeleteFromTable("users", "login", user);
                    ShowAllUsers();
                    MessageBox.Show(String.Format("Пользователь {0} успешно удален",user));
                    if (user == curr_user)
                    {
                        this.DialogResult = DialogResult.Retry;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                return;
        }

        private void ApplyUser(Panel users_panel)
        {
            String user, role2 = "", new_role = "";
            new_role = ((ComboBox)(users_panel.Controls[1])).Text;
            user = ((Label)(users_panel.Controls[0])).Text;
            if (user == "hoba")
            {
                MessageBox.Show("Невозможно изменить учетную запись гл. администратора.");
                return;
            }
            
            //узнаем настоящую роль пользователя
            try
            {
                NpgsqlDataReader dataReader = PgSql.SelectFromWhere("role", "users", "login", user);
                if (dataReader.Read())
                    role2 = dataReader[0].ToString();
                else
                    throw new Exception("error...");
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            
            if (StringHelper.TextToRole(role2) == StringHelper.TextToRole(new_role))
            {
                MessageBox.Show("Если Вы хотите сменить роль пользователя, выберите в выпадающем списке роль, отличную от текущей.");
                return;
            }
            if (StringHelper.TextToRole(role) != "admin" && StringHelper.TextToRole(new_role) == "admin")
            {
                MessageBox.Show("Администратора может назначить только администратор.");
                return;
            }
            if (StringHelper.TextToRole(role2) == "admin" && StringHelper.TextToRole(role) != "admin")
            {
                MessageBox.Show("Администратора может переназначить только администратор.");
                return;
            }
            DialogResult res;
            if (user == curr_user)
            {
                res = MessageBox.Show(String.Format("Вы уверены, что хотите сменить свою роль с \"{1}\" на \"{2}\"? Это приведет к вашему выходу из системы.", user, StringHelper.RoleToText(role2), new_role), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else
            {
                res = MessageBox.Show(String.Format("Вы уверены, что хотите сменить роль пользователя \"{0}\" с \"{1}\" на \"{2}\"?", user, StringHelper.RoleToText(role2), new_role), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            if (res == DialogResult.Yes)
            {
                try
                {
                    PgSql.UpdateSet("users", "role", String.Format("('{0}') WHERE login = '{1}'", StringHelper.TextToRole(new_role), user));
                    ShowAllUsers();
                    MessageBox.Show(String.Format("Роль изменена успешно.", user));
                    if (user == curr_user)
                    {
                        this.DialogResult = DialogResult.Retry;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                return;
        }
    }
}
