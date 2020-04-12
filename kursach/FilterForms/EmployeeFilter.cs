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
    public partial class EmployeeFilter : Form
    {
        int work_pos_id;
        private String filter;
        public String Filter { get { return filter; } }

        public EmployeeFilter()
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
                NpgsqlDataReader dataReader = PgSql.SelectFromWhere("id", "WorkPosition", "name", cbPosition.Text);
                dataReader.Read();
                work_pos_id = Int32.Parse(dataReader[0].ToString());
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
                NpgsqlDataReader dataReader = PgSql.SelectFrom("name", "workposition");
                while (dataReader.Read())
                {
                    cbPosition.Items.Add(dataReader[0].ToString());
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
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
            if (chkPosition.Checked)
            {
                l_filt.Add(String.Format(" work_position = '{0}' ", cbPosition.Text));
            }
            if (chkTerm.Checked)
            {
                l_filt.Add(String.Format(" term_of_work {0} {1} ", cbSignTerm.Text, numTerm.Text));
            }
            if (chkSurcharge.Checked)
            {
                l_filt.Add(String.Format(" surcharge {0} {1} ", cbSignSurcharge.Text, numSurcharge.Text));
            }
            if (chkOrgDates.Checked)
            {
                l_filt.Add(String.Format(" num_of_organized_visits {0} {1} ",cbSignOrgDates.Text, numOrgDates.Text));
            }
            if (chkOrgContracts.Checked)
            {
                l_filt.Add(String.Format(" num_of_contracts {0} {1} ", cbSignOrgContracts.Text, numOrgContracts.Text));
            }

            for (int i = 0; i < l_filt.Count; i++)
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
