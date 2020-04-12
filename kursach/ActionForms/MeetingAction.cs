using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace kursach
{
    public partial class MeetingAction : Form
    {
        ActionType at;
        int id;

        public MeetingAction(ActionType _at, int _id)
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
                NpgsqlDataReader dataReader = PgSql.SelectFromWhere("*", "meeting", "id", id.ToString());
                dataReader.Read();
                for (int i = 1; i < dataReader.FieldCount; i++)
                {
                    String str = dataReader[i].ToString();
                    //Shnir.Scorlupa(ref str, '\"');
                    //Shnir.Scorlupa(ref str, '{');
                    //Shnir.Scorlupa(ref str, '}');
                    StringHelper.Scorlupa(ref str, ' ');
                    //Shnir.Scorlupa(ref str, '(');
                    //Shnir.Scorlupa(ref str, ')');
                    switch (i)
                    {
                        case 1:
                            numClientID.Value = Int32.Parse(str);
                            break;
                        case 2:
                            numPlaceID.Value = Int32.Parse(str);
                            break;
                        case 3:
                            String[] tmp = str.Split('-');
                            numDay.Value = Int32.Parse(tmp[2]);
                            numMonth.Value = Int32.Parse(tmp[1]);
                            numYear.Value = Int32.Parse(tmp[0]);
                            break;
                        case 4:
                            String[] tmp2 = str.Split(':');
                            numHours.Value = Int32.Parse(tmp2[0]);
                            numMinutes.Value = Int32.Parse(tmp2[1]);
                            break;
                        case 5:
                            if (str == "")
                                numDuration.Value = -1;
                            else
                                numDuration.Value = Int32.Parse(str);
                            break;
                        case 6:
                            if (str == "")
                                cbResult.SelectedIndex = 0;
                            else
                                cbResult.Text = str;
                            break;
                        case 7:
                            numEmployeeID.Value = Int32.Parse(str);
                            break;
                    }
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void SetComboBoxes()
        {
            cbResult.SelectedIndex = 0;
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            try
            {
                switch (at)
                {
                    case ActionType.Insert:
                        PgSql.InsertIntoValues("Meeting", String.Format("DEFAULT, {0}, {1}, '{2}.{3}.{4}', '{5}:{6}', {7}, {8}, {9}", numClientID.Value, numPlaceID.Value, numDay.Value, numMonth.Value, numYear.Value, numHours.Value, numMinutes.Value, (numDuration.Value == -1) ? "NULL" : numDuration.Value.ToString(),
                            (cbResult.Text == "<NULL>") ? "NULL" : "\'" + cbResult.Text + "\'", numEmployeeID.Value));
                        break;
                    case ActionType.Update:
                        PgSql.UpdateSet("Meeting", "client_id, place_id, meeting_date, meeting_time, meeting_duration, m_result, orginized_employee_id", String.Format("({0}, {1}, '{2}.{3}.{4}', '{5}:{6}', {7}, {8}, {9}) WHERE id = {10}", numClientID.Value, numPlaceID.Value, numDay.Value, numMonth.Value, numYear.Value, numHours.Value,
                            numMinutes.Value, (numDuration.Value == -1) ? "NULL" : numDuration.Value.ToString(), (cbResult.Text == "<NULL>") ? "NULL" : "\'" + cbResult.Text + "\'", numEmployeeID.Value, id));
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
