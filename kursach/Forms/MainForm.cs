using System;
using System.Windows.Forms;
using Npgsql;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;
using System.Windows;


namespace kursach
{
    public partial class MainForm : Form, IMainView
    {
        LoginForm lf;
        int chosenId;
        CurrentTable currTable = CurrentTable.None;
        String currTableStringName;
        String filterString;
        NpgsqlConnection connection;
        String login, role, role_password;

        private void SetCurrentTable(CurrentTable _ct)
        {
            currTable = _ct;
            filterString = "";
            switch (_ct)
            {
                case CurrentTable.None:
                    currTableStringName = "";
                    break;
                case CurrentTable.Clients:
                    currTableStringName = "client";
                    break;
                case CurrentTable.Employees:
                    currTableStringName = "employee";
                    break;
                case CurrentTable.Departments:
                    currTableStringName = "dating_club_department";
                    break;
                case CurrentTable.Contracts:
                    currTableStringName = "contract";
                    break;
                case CurrentTable.Meeting:
                    currTableStringName = "meeting";
                    break;
                case CurrentTable.MeetingPlace:
                    currTableStringName = "meeting_place";
                    break;
                case CurrentTable.Pare:
                    currTableStringName = "pare";
                    break;
                case CurrentTable.ClientList:
                    currTableStringName = "client_list";
                    break;
            }
        }

        private void StartWork()
        {
            lblYouEntered.Text = String.Format("Вы вошли как {0} ({1})", login, StringHelper.RoleToText(role));
            role_password = PassContainer.GetRolePasswordByRoleName(role);
            try
            {
                PgSql.ConnectToDatingClubDB(role, role_password);
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
                this.Close();
            }

            filterString = "";

            int y = 15;
            //здесь надо вызывать ф-цию GetPermissions которая будет доставать из БД
            //действия доступные пользователю. Записать их в массив

            Button bt = CreateButton("Отделения", ref y);
            bt.Click += new EventHandler(delegate { ShowDepartments(); });

            bt = CreateButton("Работники", ref y);
            bt.Click += new EventHandler(delegate { ShowEmployees(); });

            bt = CreateButton("Клиенты", ref y);
            bt.Click += new EventHandler(delegate { ShowClients(); });

            bt = CreateButton("Контракты", ref y);
            bt.Click += new EventHandler(delegate { ShowContracts(); });

            bt = CreateButton("Свидания", ref y);
            bt.Click += new EventHandler(delegate { ShowMeetings(); });

            bt = CreateButton("Места встреч", ref y);
            bt.Click += new EventHandler(delegate { ShowMeetingPlaces(); });

            bt = CreateButton("Пары", ref y);
            bt.Click += new EventHandler(delegate { ShowPares(); });

            bt = CreateButton("Подобрать пару клиенту", ref y);
            bt.Click += new EventHandler(delegate { GetPare(); });

            bt = CreateButton("Показать клиенту список", ref y);
            bt.Click += new EventHandler(delegate { GetClientList(); });

            bt = CreateButton("Отчет по договорам", ref y);
            bt.Click += new EventHandler(delegate { GetContractReport(); });

            bt = CreateButton("Администрирование", ref y);
            bt.Click += new EventHandler(delegate { ShowAdminPanel(); });

            bt = CreateButton("О программе", ref y);
            bt.Click += new EventHandler(delegate { ShowHelp(); });


            AnchorAllButtons();
            gbActionButtons.Text += "("+pnlActionButtons.Controls.Count + ") ";
        }

        public MainForm(LoginForm _lf, String _login, String _role)
        {
            InitializeComponent();
            role = _role;
            login = _login;
            lf = _lf;
            StartWork();
        }

        private void AnchorAllButtons()
        {
            foreach(Button c in pnlActionButtons.Controls)
            {
                try
                {
                    c.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                }
                catch { }
            }
        }

        private Button CreateButton(String Text, ref int y)
        {
            Button bt = new Button();
            bt.Text = Text;
            pnlActionButtons.Controls.Add(bt);
            bt.Size = (Size)new Point(260, 40);
            bt.Location = new Point((pnlActionButtons.Size.Width - bt.Size.Width) / 2, y);
            bt.MouseEnter += new EventHandler(delegate { ShowButtonDescription(bt.Text); });
            bt.MouseLeave += new EventHandler(delegate { HideButtonDescription(); });
            y += 50;
            return bt;
        }

        private void ShowButtonDescription(String buttonText)
        {
            String showtext = "";
            String table_to_access = "none";
            if (buttonText == "Отделения")
            {
                showtext = "Просмотр всех отделений клуба знакомств. Их название, адрес и арендная плата.";
                table_to_access = "dating_club_department";
            }
            else if (buttonText == "Клиенты")
            {
                showtext = "Просмотр данных всех клиентов.";
                table_to_access = "client";
            }
            else if (buttonText == "Контракты")
            {
                showtext = "Просмотр контрактов клиентов.";
                table_to_access = "contract";
            }
            else if (buttonText == "Работники")
            {
                showtext = "Просмотр данных всех работников отделений клуба знакомств.";
                table_to_access = "employee";
            }
            else if (buttonText == "Администрирование")
            {
                showtext = "Просмотр учетных записей всех пользователей Базы Данных, изменение их ролей.";
            }
            else if (buttonText == "Свидания")
            {
                showtext = "Просмотр всех запланированных и прошедших свиданий.";
                table_to_access = "meeting";
            }
            else if (buttonText == "Места встреч")
            {
                showtext = "Просмотр всех зарезервированных клубом мест для свиданий клиентов.";
                table_to_access = "meeting_place";
            }
            else if (buttonText == "Пары")
            {
                showtext = "Просмотр всех пар клиентов.";
                table_to_access = "pare";
            }
            else if (buttonText == "О программе")
            {
                showtext = "Раздел, содержащию информацию о программе.";
            }
            else if (buttonText == "Подобрать пару клиенту")
            {
                showtext = "Подобрать подходящие кандидатуры в пару клиенту по его ID.";
            }
            else if (buttonText == "Показать клиенту список")
            {
                showtext = "Показать клиенту список всех клиентов клуба, имеющих действительный контракт. В списке отсутствует личная информация.";
            }
            else if (buttonText == "Отчет по договорам")
            {
                showtext = "Вывести краткий отчет по оформленным договорам: всего, за последний месяц, завершенные, отмененные, активные.";
            }
            else if (buttonText == "Сменить пользователя")
            {
                showtext = "Выход к окну авторизации.";
            }
            else if (buttonText == "Закрыть программу")
            {
                showtext = "Завершение работы программы.";
            }

            if (table_to_access != "none")
            {
                try
                {
                    String[] access_check = { "SELECT", "INSERT", "UPDATE", "DELETE" };
                    String[] access_check_rus = { "чтение", "запись", "изменение", "удаление" };
                    List<String> access_mods = new List<string>();
                    for (int i = 0; i < access_check.Length; i++)
                    {
                        NpgsqlDataReader dataReader = PgSql.HasTablePrivileges(table_to_access, access_check[i]);

                        if (dataReader.Read())
                        {
                            if (dataReader[0].ToString() == "t")
                                access_mods.Add(access_check_rus[i]);
                        }
                        //dataReader.Close();
                    }

                    showtext += "\n\nДоступ: ";

                    if (access_mods.Count == 0)
                        showtext += "отсутствует.";
                    else
                        for (int i = 0; i < access_mods.Count; i++)
                        {
                            showtext += access_mods[i];
                            if (i != access_mods.Count-1)
                            {
                                showtext += ", ";
                            }
                            else
                            {
                                showtext += ".";
                            }
                        }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            lbButtonDescription.Text = showtext;
        }

        private void GetContractReport()
        {
            ContractsReport cr = new ContractsReport();
            cr.ShowDialog();
        }

        private void GetPare()
        {
            try
            {
                NpgsqlDataReader dataReader = PgSql.HasFunctionGetParePrivileges();
                if (dataReader.Read())
                {
                    if (dataReader[0].ToString() == "t")
                    {
                        dataReader.Close();
                        GetPare gp = new GetPare();
                        gp.ShowDialog();
                    }
                    else
                    {
                        dataReader.Close();
                        MessageBox.Show("Нет доступа к функции get_pare(int)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    throw new Exception("error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowHelp()
        {
            MessageBox.Show("Программа для управления базой данных \"Клуб знакомств\".\nВыполнил: Студент 3 курса специальность КИ ОНУ им. И.Мечникова, Хоба Юрий.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
        }

        private void HideButtonDescription()
        {
            lbButtonDescription.Text = "";
        }

        private void ShowAdminPanel()
        {
            try
            {
                AdminPanel ap = new AdminPanel(login, role, role_password);
                var dr = ap.ShowDialog();
                if (dr == DialogResult.Retry)
                {
                    btnChangeUser_Click(new object(), new EventArgs());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ResetOpenTable();
            }
        }

        private void ShowClients()
        {
                SetCurrentTable(CurrentTable.Clients);
                pnlActions.Hide();
                RefreshTable();
                pnlTable.Show();
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    ResetOpenTable();
            //}
        }

        private void GetClientList()
        {
            SetCurrentTable(CurrentTable.ClientList);
            pnlActions.Hide();
            RefreshTable();
            pnlTable.Show();
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    ResetOpenTable();
            //}
        }

        private void ShowContracts()
        {
            try
            {
                SetCurrentTable(CurrentTable.Contracts);
                pnlActions.Hide();
                RefreshTable();
                pnlTable.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ResetOpenTable();
            }
        }

        private void ShowMeetings()
        {
                SetCurrentTable(CurrentTable.Meeting);
                pnlActions.Hide();
                RefreshTable();
                pnlTable.Show();
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    ResetOpenTable();
            //}
        }

        private void ShowMeetingPlaces()
        {
                SetCurrentTable(CurrentTable.MeetingPlace);
                pnlActions.Hide();
                RefreshTable();
                pnlTable.Show();
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    ResetOpenTable();
            //}
        }

        private void ShowPares()
        {
                SetCurrentTable(CurrentTable.Pare);
                pnlActions.Hide();
                RefreshTable();
                pnlTable.Show();
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    ResetOpenTable();
            //}
        }

        private void ShowDepartments()
        {
            SetCurrentTable(CurrentTable.Departments);
            pnlActions.Hide();
            RefreshTable();
            pnlTable.Show();
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    ResetOpenTable();
            //}
        }

        private void ShowEmployees()
        {
            SetCurrentTable(CurrentTable.Employees);
            pnlActions.Hide();
            RefreshTable();
            pnlTable.Show();
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    ResetOpenTable();
            //}
        }

        private void btnRefreshTable_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }

        public void RefreshTable()
        {
            lblNoTable.Visible = false;
            try
            {
                chosenId = -1;
                NpgsqlDataReader dataReader = PgSql.SelectTable(currTable, currTableStringName, filterString);
                    //PgSql.SelectAllFromWhere(currTableStringName, filterString);
                dataGridView.RowCount = 0;
                dataGridView.ColumnCount = dataReader.FieldCount;
                int row = 0;
                bool collumnsLocalized = false;
                while (dataReader.Read())
                {
                    int cell = 0;
                    dataGridView.RowCount++;
                    for (int i = 0; i < dataReader.FieldCount; i++)
                    {
                        if (!collumnsLocalized)
                        {
                            dataGridView.Columns[i].HeaderText = StringHelper.Localize(dataReader.GetName(i), currTable);
                        }
                        dataGridView.Rows[row].Cells[cell].Value = dataReader[i].ToString();
                        cell++;
                    }
                    collumnsLocalized = true;
                    dataGridView.Rows[row].HeaderCell.Value = (row + 1).ToString();
                    row++;
                }
                dataGridView_SelectionChanged();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                lblNoTable.Visible = true;
                dataGridView.Rows.Clear();
                dataGridView.Refresh();
            }
        }

        private void dataGridView_SelectionChanged()
        {
            if (dataGridView.SelectedRows.Count == 1 && dataGridView.RowCount > 0 && dataGridView.Rows[dataGridView.SelectedRows[0].Index].Cells[0].Value != null)
            {
                chosenId = Int32.Parse(dataGridView.Rows[dataGridView.SelectedRows[0].Index].Cells[0].Value.ToString());
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView_SelectionChanged();
        }

        private void ResetOpenTable()
        {
            SetCurrentTable(CurrentTable.None);
            pnlTable.Hide();
            pnlActions.Show();
        }

        private void btnCloseClient_Click(object sender, EventArgs e)
        {
            ResetOpenTable();
        }

        private void btnChangeUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            lf.Show();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            switch (currTable)
            {
                case CurrentTable.Clients:
                    ClientAction ca = new ClientAction(ActionType.Insert, chosenId);
                    ca.ShowDialog();
                    break;
                case CurrentTable.Departments:
                    DepartmentAction da = new DepartmentAction(ActionType.Insert, chosenId);
                    da.ShowDialog();
                    break;
                case CurrentTable.Employees:
                    EmployeeAction ea = new EmployeeAction(ActionType.Insert, chosenId);
                    ea.ShowDialog();
                    break;
                case CurrentTable.Contracts:
                    ContractAction cta = new ContractAction(ActionType.Insert, chosenId);
                    cta.ShowDialog();
                    break;
                case CurrentTable.Meeting:
                    MeetingAction ma = new MeetingAction(ActionType.Insert, chosenId);
                    ma.ShowDialog();
                    break;
                case CurrentTable.MeetingPlace:
                    MeetingPlaceAction mpa = new MeetingPlaceAction(ActionType.Insert, chosenId);
                    mpa.ShowDialog();
                    break;
                case CurrentTable.Pare:
                    int id2 = Int32.Parse(dataGridView.Rows[dataGridView.SelectedRows[0].Index].Cells[1].Value.ToString());
                    PareAction pac = new PareAction(ActionType.Insert, chosenId, id2);
                    pac.ShowDialog();
                    break;
                case CurrentTable.ClientList:
                    MessageBox.Show("Невозможно добавить запись. Попробуйте добавить ее в меню \"Клиенты\" в главном меню.");
                    break;
            }
            RefreshTable();
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (chosenId >= 0)
            {
                if (currTable == CurrentTable.ClientList)
                {
                    MessageBox.Show("Невозможно удалить запись. Попробуйте удалить ее аналог по id в меню \"Клиенты\" в главном меню.");
                    return;
                }
                var answer = MessageBox.Show("Вы уверены что хотите удалить запись с id "+chosenId.ToString()+"?","Удалить?",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes && currTableStringName!="pare")
                {
                    try
                    {
                        PgSql.DeleteFromTableById(currTableStringName, chosenId);
                    }
                    catch (NpgsqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    catch
                    {
                        MessageBox.Show("Не удалось удалить.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    RefreshTable();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                switch (currTable)
                {
                    case CurrentTable.Clients:
                        ClientAction ca = new ClientAction(ActionType.Update, chosenId);
                        ca.ShowDialog();
                        break;
                    case CurrentTable.Departments:
                        DepartmentAction da = new DepartmentAction(ActionType.Update, chosenId);
                        da.ShowDialog();
                        break;
                    case CurrentTable.Employees:
                        EmployeeAction ea = new EmployeeAction(ActionType.Update, chosenId);
                        ea.ShowDialog();
                        break;
                    case CurrentTable.Contracts:
                        ContractAction cta = new ContractAction(ActionType.Update, chosenId);
                        cta.ShowDialog();
                        break;
                    case CurrentTable.Meeting:
                        MeetingAction ma = new MeetingAction(ActionType.Update, chosenId);
                        ma.ShowDialog();
                        break;
                    case CurrentTable.MeetingPlace:
                        MeetingPlaceAction mpa = new MeetingPlaceAction(ActionType.Update, chosenId);
                        mpa.ShowDialog();
                        break;
                    case CurrentTable.Pare:
                        int id2 = Int32.Parse(dataGridView.Rows[dataGridView.SelectedRows[0].Index].Cells[1].Value.ToString());
                        PareAction pac = new PareAction(ActionType.Update, chosenId, id2);
                        pac.ShowDialog();
                        break;
                    case CurrentTable.ClientList:
                        MessageBox.Show("Невозможно изменить запись. Попробуйте изменить ее аналог по id в меню \"Клиенты\" в главном меню.");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            RefreshTable();
        }

        private void btnResetFilters_Click(object sender, EventArgs e)
        {
            filterString = "";
            RefreshTable();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            Filterize();
        }

        private void btnChangeUser_MouseEnter(object sender, EventArgs e)
        {
            
            ShowButtonDescription(((Button)sender).Text);
        }

        private void btnCloseApp_MouseEnter(object sender, EventArgs e)
        {
            ShowButtonDescription(((Button)sender).Text);
        }

        private void btnChangeUser_MouseLeave(object sender, EventArgs e)
        {
            HideButtonDescription();
        }

        private void btnCloseApp_MouseLeave(object sender, EventArgs e)
        {
            HideButtonDescription();
        }

        private void Filterize()
        {
            switch (currTable)
            {
                case CurrentTable.Departments:
                    DepartmentFilter da = new DepartmentFilter();
                    if (da.ShowDialog() == DialogResult.OK)
                    {
                        filterString = da.Filter;
                    }
                    break;
                case CurrentTable.Clients:
                    ClientFilter cf = new ClientFilter();
                    if (cf.ShowDialog() == DialogResult.OK)
                    {
                        filterString = cf.Filter;
                    }
                    break;
                case CurrentTable.Employees:
                    EmployeeFilter ef = new EmployeeFilter();
                    if (ef.ShowDialog() == DialogResult.OK)
                    {
                        filterString = ef.Filter;
                    }
                    break;
                case CurrentTable.Contracts:
                    ContractFilter cnf = new ContractFilter();
                    if (cnf.ShowDialog() == DialogResult.OK)
                    {
                        filterString = cnf.Filter;
                    }
                    break;
                case CurrentTable.Meeting:
                    MeetingFilter mf = new MeetingFilter();
                    if (mf.ShowDialog() == DialogResult.OK)
                    {
                        filterString = mf.Filter;
                    }
                    break;
                default:
                    MessageBox.Show("Таблица "+ currTable.ToString() + " не фильтруется.");
                    break;
            }
            RefreshTable();
        }

        private void dataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView_SelectionChanged();
        }
    }
}
