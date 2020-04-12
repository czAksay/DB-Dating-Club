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
    public partial class DepartmentAction : Form
    {
        ActionType at;
        int id;
        public DepartmentAction(ActionType _at, int _id)
        {
            InitializeComponent();
            at = _at;
            id = _id;
            lbltitle.Text = _at.ToString();
            btnAction.Text = _at.ToString() + "!";
            if (at == ActionType.Update)
            {
                tbId.Text = id.ToString();
                FillFields();
            }
        }


        private void FillFields()
        {
            NpgsqlDataReader dataReader = PgSql.SelectFromWhere("*", "dating_club_department", "id", id.ToString());
            dataReader.Read();
            for (int i = 1; i < dataReader.FieldCount; i++)
            {
                String str = dataReader[i].ToString();
                switch (i)
                {
                    case 1:
                        tbName.Text = str;
                        break;
                    case 2:
                        str = str.Remove(0, 1);
                        str = str.Remove(str.Length-1, 1);
                        String[] tmp = str.Split(',');
                        StringHelper.Scorlupa(tmp, '\"');
                        tbCountry.Text = tmp[0];
                        tbCity.Text = tmp[1];
                        tbStreet.Text = tmp[2];
                        numHouse.Value = Int32.Parse(tmp[3]);
                        numHouse2.Value = Int32.Parse(tmp[4]);
                        break;
                    case 3:
                        numPayment.Value = Int32.Parse(str);
                        break;
                }
            }
            dataReader.Close();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            try
            {
                switch (at)
                {
                    case ActionType.Insert:
                        PgSql.InsertIntoValues("dating_club_department", String.Format("DEFAULT, '{0}', ('{1}', '{2}', '{3}', {4}, {5}), {6}", tbName.Text, tbCountry.Text, tbCity.Text, tbStreet.Text, numHouse.Value.ToString(), numHouse2.Value.ToString(), numPayment.Value.ToString()));
                        break;
                    case ActionType.Update:
                        PgSql.UpdateSet("dating_club_department", "name, address, rent_cost", String.Format("('{0}', ('{1}', '{2}', '{3}', {4}, {5}), {6}) WHERE dating_club_department.id = {7}", tbName.Text, tbCountry.Text, tbCity.Text, tbStreet.Text, numHouse.Value.ToString(), numHouse2.Value.ToString(), numPayment.Value.ToString(), id));
                        break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show(String.Format("Success.", at.ToString()));
            this.Close();
        }
    }
}
