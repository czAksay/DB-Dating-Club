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
    public partial class MeetingPlaceAction : Form
    {
        ActionType at;
        int id;
        int place_type_id;
        int place_theme_id;

        public MeetingPlaceAction(ActionType _at, int _id)
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

        private void SetComboBoxes()
        {
            try
            {
                NpgsqlDataReader dataReader = PgSql.SelectFrom("name", "placetype");
                cbPlaceTheme.Items.Clear();
                cbPlaceType.Items.Clear();
                while (dataReader.Read())
                {
                    String s = dataReader[0].ToString();
                    cbPlaceType.Items.Add(s);
                    //MessageBox.Show(dataReader[0].ToString());
                }
                dataReader.Close();

                dataReader = PgSql.SelectFrom("name", "placetheme");
                while (dataReader.Read())
                {
                    this.cbPlaceTheme.Items.Add(dataReader[0].ToString());
                    //MessageBox.Show(dataReader[0].ToString());
                }
                dataReader.Close();

                foreach (Control c in this.Controls.OfType<ComboBox>())
                {
                    ((ComboBox)(c)).SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void FillFields()
        {
            NpgsqlDataReader dataReader = PgSql.SelectFromWhere("*", "meeting_place", "id", id.ToString());
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
                    case 1:
                        String[] tmp2 = str.Split(',');
                        StringHelper.Scorlupa(tmp2, '\"');
                        tbCountry.Text = tmp2[0];
                        tbCity.Text = tmp2[1];
                        tbStreet.Text = tmp2[2];
                        numHouse.Value = Int32.Parse(tmp2[3]);
                        numHouse2.Value = Int32.Parse(tmp2[4]);
                        break;
                    case 2:
                        cbPlaceType.SelectedIndex = Int32.Parse(str) - 1;
                        break;
                    case 3:
                        cbPlaceTheme.SelectedIndex = Int32.Parse(str) - 1;
                        break;
                    case 4:
                        cbPrice.Text = str;
                        break;
                    case 5:
                        numRent.Value = Int32.Parse(str);
                        break;
                }
            }
            dataReader.Close();
        }

        private bool GetInfoFromPanelControls()
        {
            try
            {
                NpgsqlDataReader dataReader = PgSql.SelectFromWhere("id", "PlaceTheme", "name", cbPlaceTheme.Text);
                dataReader.Read();
                place_theme_id = Int32.Parse(dataReader[0].ToString());
                dataReader = PgSql.SelectFromWhere("id", "PlaceType", "name", cbPlaceType.Text);
                dataReader.Read();
                place_type_id = Int32.Parse(dataReader[0].ToString());
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
            if (!GetInfoFromPanelControls())
                return;

            try
            {
                switch (at)
                {
                    case ActionType.Insert:
                        if (!GetInfoFromPanelControls())
                            return;
                        PgSql.InsertIntoValues("meeting_place", String.Format("DEFAULT, ('{0}', '{1}', '{2}', {3}, {4}), {5}, {6}, '{7}', {8}", tbCountry.Text, tbCity.Text, tbStreet.Text, numHouse.Value, numHouse2.Value, place_type_id, place_theme_id, cbPrice.Text, numRent.Value));
                        break;
                    case ActionType.Update:
                        if (!GetInfoFromPanelControls())
                            return;
                        PgSql.UpdateSet("meeting_place", "address, place_type, place_theme, price_policy,rent_cost", String.Format("(('{0}', '{1}', '{2}', {3}, {4}), {5}, {6}, '{7}', {8}) WHERE id = {9}", tbCountry.Text, tbCity.Text, tbStreet.Text, numHouse.Value, numHouse2.Value, place_type_id, place_theme_id, cbPrice.Text, numRent.Value, id));
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
