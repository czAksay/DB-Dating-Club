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
    public partial class DepartmentFilter : Form
    {
        private String filter;
        public String Filter { get { return filter; } }
        public DepartmentFilter()
        {
            filter = "";
            InitializeComponent();
            cbSign.SelectedIndex = 1;
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (chkRent.Checked)
            {
                filter += String.Format("rent_cost {0} {1}", cbSign.Text, numSum.Value.ToString());
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
