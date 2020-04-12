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
    public partial class ContractFilter : Form
    {
        private String filter;
        public String Filter { get { return filter; } }

        public ContractFilter()
        {
            filter = "";
            InitializeComponent();
            SetComboBoxes();
        }

        private void SetComboBoxes()
        {
            //cbState.SelectedIndex = 1;
            foreach (Control c in this.Controls)
            {
                if (c.GetType().Equals(new ComboBox().GetType()))
                {
                    ((ComboBox)(c)).SelectedIndex = 1;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<String> l_filt = new List<string>();
            if (chkTerm.Checked)
            {
                l_filt.Add(String.Format(" contract_term {0} {1} ",cbSignTerm.Text, numTerm.Text));
            }
            if (chkState.Checked)
            {
                l_filt.Add(String.Format(" state = '{0}' ", cbState.Text));
            }
            if (chkSum.Checked)
            {
                l_filt.Add(String.Format(" price {0} {1} ", cbSignSum.Text, numSum.Text));
            }
            if (chkDate.Checked)
            {
                l_filt.Add(String.Format("'{0}.{1}.{2}' - date_of_registration < {3}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, numDate.Text));
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
