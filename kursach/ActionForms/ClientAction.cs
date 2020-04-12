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

public enum ActionType { Insert, Delete, Update};

namespace kursach
{
    public partial class ClientAction : Form
    {
        ActionType at;
        int id;
        int nation_id;
        int eyecolor_id;
        int haircolor_id;
        String interests;
        String pos_features, neg_features;
        public ClientAction(ActionType _at, int _id)
        {
            at = _at;
            id = _id;
            InitializeComponent();
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
            NpgsqlDataReader dataReader = PgSql.SelectFromWhere("*", "client", "id", id.ToString());
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
                        cbGender.Text = str;
                        break;
                    case 6:
                        cbNationality.SelectedIndex = Int32.Parse(str) - 1;
                        break;
                    case 7:
                        String[] tmp = str.Split('-');
                        numDay.Value = Int32.Parse(tmp[2]);
                        numMonth.Value = Int32.Parse(tmp[1]);
                        numYear.Value = Int32.Parse(tmp[0]);
                        break;
                    case 8:
                        String[] tmp2 = str.Split(',');
                        StringHelper.Scorlupa(tmp2, '\"');
                        tbCountry.Text = tmp2[0];
                        tbCity.Text = tmp2[1];
                        tbStreet.Text = tmp2[2];
                        numHouse.Value = Int32.Parse(tmp2[3]);
                        numHouse2.Value = Int32.Parse(tmp2[4]);
                        break;
                    case 9:
                        if (str == "")
                            tbEmail.Text = "";
                        else
                            tbEmail.Text = str;
                        break;
                    case 10:
                        tbPhone.Text = str;
                        break;
                    case 11:
                        tbPass.Text = str;
                        break;
                    case 12:
                        numHeight.Value = Int32.Parse(str);
                        break;
                    case 13:
                        numWeight.Value = Int32.Parse(str);
                        break;
                    case 14:
                        cbEyeColor.SelectedIndex = Int32.Parse(str) - 1;
                        break;
                    case 15:
                        cbHairColor.SelectedIndex = Int32.Parse(str) - 1;
                        break;
                    case 16:
                        if (str == "")
                        {
                            tbInterests.Text = "";
                        }
                        else
                        {
                            String[] tmp3 = str.Split(',');
                            StringHelper.Scorlupa(tmp3, '\"');
                            foreach (String s in tmp3)
                            {
                                tbInterests.Text += s + '\n';
                            }
                            if (tbInterests.TextLength != 0)
                                tbInterests.Text = tbInterests.Text.Remove(tbInterests.TextLength - 1, 1);
                        }
                        break;
                    case 17:
                        cbTemperament.Text = str;
                        break;
                    case 18:
                        String[] tmp4 = str.Split(',');
                        StringHelper.Scorlupa(tmp4, '\"');
                        foreach (String s in tmp4)
                        {
                            tbPosFeat.Text += s + '\n';
                        }
                        if (tbPosFeat.TextLength != 0)
                            tbPosFeat.Text = tbPosFeat.Text.Remove(tbPosFeat.TextLength - 1, 1);
                        break;
                    case 19:
                        String[] tmp5 = str.Split(',');
                        StringHelper.Scorlupa(tmp5, '\"');
                        foreach (String s in tmp5)
                        {
                            tbNegFeat.Text += s + '\n';
                        }
                        if (tbNegFeat.TextLength != 0)
                            tbNegFeat.Text = tbNegFeat.Text.Remove(tbNegFeat.TextLength - 1, 1);
                        break;
                    case 20:
                        cbMartialStatus.Text = str;
                        break;
                    case 21:
                        numChild.Value = Int32.Parse(str);
                        break;
                    case 22:
                        cbProsperity.Text = str;
                        break;
                    case 23:
                        cbPurposeofdating.Text = str;
                        break;
                }
            }
            dataReader.Close();
        }

        private void SetComboBoxes()
        {
            try
            {
                NpgsqlDataReader dataReader = PgSql.SelectFrom("name", "nationality");
                while (dataReader.Read())
                {
                    cbNationality.Items.Add(dataReader[0].ToString());
                }
                dataReader = PgSql.SelectFrom("color", "Eyecolor");
                while (dataReader.Read())
                {
                    cbEyeColor.Items.Add(dataReader[0].ToString());
                }
                dataReader = PgSql.SelectFrom("color", "Haircolor");
                while (dataReader.Read())
                {
                    cbHairColor.Items.Add(dataReader[0].ToString());
                }
                foreach (Control c in pnlControls.Controls)
                {
                    if (c.GetType().Equals(cbEyeColor.GetType()))
                    {
                        ((ComboBox)(c)).SelectedIndex = 0;
                    }
                }
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
                NpgsqlDataReader dataReader = PgSql.SelectFromWhere("id", "Nationality", "name", cbNationality.Text);
                dataReader.Read();
                nation_id = Int32.Parse(dataReader[0].ToString());
                dataReader = PgSql.SelectFromWhere("id", "Eyecolor", "color", cbEyeColor.Text);
                dataReader.Read();
                eyecolor_id = Int32.Parse(dataReader[0].ToString());
                dataReader = PgSql.SelectFromWhere("id", "Haircolor", "color", cbHairColor.Text);
                dataReader.Read();
                haircolor_id = Int32.Parse(dataReader[0].ToString());
                interests = "{";
                String[] tmp = tbInterests.Text.Split('\n');
                foreach (String a in tmp)
                {
                    interests += "\"" + a + "\", ";
                }
                interests = interests.Remove(interests.Length - 2, 2);
                interests += "}";
                pos_features = "{";
                tmp = tbPosFeat.Text.Split('\n');
                foreach (String a in tmp)
                {
                    pos_features += "\"" + a + "\", ";
                }
                pos_features = pos_features.Remove(pos_features.Length - 2, 2);
                pos_features += "}";
                neg_features = "{";
                tmp = tbNegFeat.Text.Split('\n');
                foreach (String a in tmp)
                {
                    neg_features += "\"" + a + "\", ";
                }
                neg_features = neg_features.Remove(neg_features.Length - 2, 2);
                neg_features += "}";
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
                        PgSql.InsertIntoValues("client", String.Format("DEFAULT, {0}, '{1}', '{2}', '{3}', '{4}', {5}, '{6}.{7}.{8}', ('{9}','{10}','{11}', {12}, {13}), '{14}', '{15}', '{16}', {17}, {18}, {19}, {20}, '{21}', '{22}', '{23}', '{24}', '{25}', {26}, '{27}', '{28}'",
                            numClub.Value.ToString(), tbSur.Text, tbName.Text, tbPatr.Text, cbGender.Text, nation_id, numDay.Value.ToString(), numMonth.Value.ToString(), numYear.Value.ToString(),
                            tbCountry.Text, tbCity.Text, tbStreet.Text, numHouse.Value.ToString(), numHouse2.Value.ToString(), tbEmail.Text, tbPhone.Text, tbPass.Text, numHeight.Value.ToString(),
                            numWeight.Value.ToString(), eyecolor_id, haircolor_id, interests, cbTemperament.Text, pos_features, neg_features, cbMartialStatus.Text, numChild.Value.ToString(), cbProsperity.Text, cbPurposeofdating.Text));
                        break;
                    case ActionType.Update:
                        if (!GetInfoFromPanelControls())
                            return;
                        PgSql.UpdateSet("client", "club_department_id, surname, name, patronymic, gender, nationality, date_of_birth, address, email, phone_number, passport_id, height, weight, eye_color, hair_color, interests, temperament, positive_features, negative_features, marital_status, amount_of_children, prosperity, purpose_of_dating",
                            String.Format("({0}, '{1}', '{2}', '{3}', '{4}', {5}, '{6}.{7}.{8}', ('{9}','{10}','{11}', {12}, {13}), '{14}', '{15}', '{16}', {17}, {18}, {19}, {20}, '{21}', '{22}', '{23}', '{24}', '{25}', {26}, '{27}', '{28}') WHERE client.id = {29}",
                            numClub.Value.ToString(), tbSur.Text, tbName.Text, tbPatr.Text, cbGender.Text, nation_id, numDay.Value.ToString(), numMonth.Value.ToString(), numYear.Value.ToString(),
                            tbCountry.Text, tbCity.Text, tbStreet.Text, numHouse.Value.ToString(), numHouse2.Value.ToString(), tbEmail.Text, tbPhone.Text, tbPass.Text, numHeight.Value.ToString(),
                            numWeight.Value.ToString(), eyecolor_id, haircolor_id, interests, cbTemperament.Text, pos_features, neg_features, cbMartialStatus.Text, numChild.Value.ToString(), cbProsperity.Text, cbPurposeofdating.Text, id));
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
