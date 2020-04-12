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
    public partial class ClientFilter : Form
    {
        int nation_id;
        private String filter;
        public String Filter { get { return filter; } }
        public ClientFilter()
        {
            filter = "";
            InitializeComponent();
            SetComboBoxes();
            foreach (Control c in this.Controls)
            {
                if (c.GetType().Equals(new ComboBox().GetType()))
                {
                    ((ComboBox)(c)).SelectedIndex = 0;
                }
            }
        }

        private bool GetInfoFromPanelControls()
        {
            try
            {
                NpgsqlDataReader dataReader = PgSql.SelectFromWhere("id", "Nationality", "name", cbNationality.Text);
                dataReader.Read();
                nation_id = Int32.Parse(dataReader[0].ToString());
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
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
                dataReader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (!GetInfoFromPanelControls())
            {
                return;
            }
            List<String> l_filt = new List<string>();
            if (chkClub.Checked)
            {
                l_filt.Add(String.Format(" club_department_id = {0} ", numClub.Value.ToString()));
            }
            if (chkSurn.Checked)
            {
                l_filt.Add(String.Format(" surname = '{0}' ", tbSur.Text));
            }
            if (chkName.Checked)
            {
                l_filt.Add(String.Format(" name = '{0}' ", tbName.Text));
            }
            if (chkPatr.Checked)
            {
                l_filt.Add(String.Format(" patronymic = '{0}' ", tbPatr.Text));
            }
            if (chkGender.Checked)
            {
                l_filt.Add(String.Format(" gender = '{0}' ", cbGender.Text));
            }
            if (chkNation.Checked)
            {
                l_filt.Add(String.Format(" nationality = '{0}' ", cbNationality.Text));
            }
            if (chkMartial.Checked)
            {
                l_filt.Add(String.Format(" marital_status = '{0}' ", cbMartialStatus.Text));
            }
            if (chkCountry.Checked)
            {
                l_filt.Add(String.Format(" (address).country = '{0}' ", tbCountry.Text));
            }
            if (chkCity.Checked)
            {
                l_filt.Add(String.Format(" (address).city = '{0}' ", tbCity.Text));
            }
            if (chkHeight.Checked)
            {
                l_filt.Add(String.Format(" height {0} {1} ",cbSignHeight.Text, numHeight.Text));
            }
            if (chkWeight.Checked)
            {
                l_filt.Add(String.Format(" weight {0} {1} ",cbSignWeight.Text, numWeight.Text));
            }
            if (chkProsp.Checked)
            {
                l_filt.Add(String.Format(" prosperity {0} '{1}' ", cbSignProsperity.Text, cbProsperity.Text));
            }

            for (int i=0; i<l_filt.Count; i++)
            {
                filter += l_filt[i];
                if (i != l_filt.Count - 1)
                {
                    filter += " AND";
                }
            }

            if (filter != "")
            {
                filter = " WHERE " + filter;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
