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
    public partial class EmployeeAction : Form
    {
        ActionType at;
        int position_id;
        int id;
        public EmployeeAction(ActionType _at, int _id)
        {
            InitializeComponent();
            at = _at;
            id = _id;
            lbltitle.Text = _at.ToString();
            btnAction.Text = _at.ToString() + "!";
            SetComboBoxes();
            if (at == ActionType.Update)
            {
                tbId.Text = id.ToString();
                FillFields();
            }
        }

        private void FillFields()
        {
            try
            {
                NpgsqlDataReader dataReader = PgSql.SelectFromWhere("*", "employee", "id", id.ToString());
                dataReader.Read();
                for (int i = 1; i < dataReader.FieldCount; i++)
                {
                    String str = dataReader[i].ToString();
                    StringHelper.Scorlupa(ref str, '\"');
                    StringHelper.Scorlupa(ref str, '{');
                    StringHelper.Scorlupa(ref str, '}');
                    StringHelper.Scorlupa(ref str, ' ');
                    StringHelper.Scorlupa(ref str, '(');
                    StringHelper.Scorlupa(ref str, ')');
                    switch (i)
                    {
                        case 2:
                            tbSur.Text = str;
                            break;
                        case 3:
                            tbName.Text = str;
                            break;
                        case 4:
                            tbPatr.Text = str;
                            break;
                        case 1:
                            numClub.Value = Int32.Parse(str);
                            break;
                        case 5:
                            cbPosition.SelectedIndex = Int32.Parse(str) - 1;
                            break;
                        case 6:
                            numTerm.Value = Int32.Parse(str);
                            break;
                        case 7:
                            numSurcharge.Value = Int32.Parse(str);
                            break;
                        case 8:
                            int val;
                            if (!Int32.TryParse(str, out val))
                                val = -1;
                            numOrgDates.Value = val;
                            break;
                        case 9:
                            int val2;
                            if (!Int32.TryParse(str, out val2))
                                val2 = -1;
                            numOrgContracts.Value = val2;
                            break;
                    }
                }
                dataReader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void SetComboBoxes()
        {
            try
            {
                NpgsqlDataReader dataReader = PgSql.SelectFrom("name", "WorkPosition");
                while (dataReader.Read())
                {
                    cbPosition.Items.Add(dataReader[0].ToString());
                }
                dataReader.Close();
                cbPosition.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private bool GetInfoFromPanelControls()
        {
            try
            {
                NpgsqlDataReader dataReader = PgSql.SelectFromWhere("id", "WorkPosition", "name", cbPosition.Text);
                dataReader.Read();
                position_id = Int32.Parse(dataReader[0].ToString());
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            try
            {
                switch (at)
                {
                    case ActionType.Insert:
                        if (!GetInfoFromPanelControls())
                            return;
                        PgSql.InsertIntoValues("Employee", String.Format("DEFAULT, {0}, '{1}', '{2}', '{3}', {4}, {5}, {6}, {7}, {8}", numClub.Value.ToString(), tbSur.Text, tbName.Text, tbPatr.Text, position_id, numTerm.Value.ToString(), numSurcharge.Value.ToString(), (numOrgDates.Value == -1) ? "NULL" : numOrgDates.Value.ToString(), (numOrgContracts.Value == -1) ? "NULL" : numOrgContracts.Value.ToString()));
                        break;
                    case ActionType.Update:
                        if (!GetInfoFromPanelControls())
                            return;
                        PgSql.UpdateSet("employee", "club_department_id, surname, name, patronymic, position, term_of_work, surcharge, num_of_organized_visits, num_of_contracts", String.Format("( {0}, '{1}', '{2}', '{3}', {4}, {5}, {6}, {7}, {8}) WHERE id = {9}", numClub.Value.ToString(), tbSur.Text, tbName.Text, tbPatr.Text, position_id, numTerm.Value.ToString(), numSurcharge.Value.ToString(), (numOrgDates.Value == -1) ? "NULL" : numOrgDates.Value.ToString(), (numOrgContracts.Value == -1) ? "NULL" : numOrgContracts.Value.ToString(), id));
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show(String.Format("Success.", at.ToString()));
            this.Close();
        }
    }
}
