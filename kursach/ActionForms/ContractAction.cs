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
    public partial class ContractAction : Form
    {
        ActionType at;
        int id;
        public ContractAction(ActionType _at, int _id)
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
                NpgsqlDataReader dataReader = PgSql.SelectFromWhere("*", "contract", "id", id.ToString());
                dataReader.Read();
                for (int i = 1; i < dataReader.FieldCount; i++)
                {
                    String str = dataReader[i].ToString();
                    StringHelper.Scorlupa(ref str, ' ');
                    switch (i)
                    {
                        case 2:
                            if (str == "")
                            {
                                numFinalPartnerID.Value = -1;
                            }
                            else
                                numFinalPartnerID.Value = Int32.Parse(str);
                            break;
                        case 3:
                            numEmployeeID.Value = Int32.Parse(str);
                            break;
                        case 4:
                            numContractTerm.Value = Int32.Parse(str);
                            break;
                        case 1:
                            numClientID.Value = Int32.Parse(str);
                            break;
                        case 5:
                            cbState.Text = str;
                            break;
                        case 6:
                            String[] tmp = str.Split('-');
                            numDay.Value = Int32.Parse(tmp[2]);
                            numMonth.Value = Int32.Parse(tmp[1]);
                            numYear.Value = Int32.Parse(tmp[0]);
                            break;
                        case 7:
                            numSum.Value = Int32.Parse(str);
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
            cbState.SelectedIndex = 1;
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            try
            {
                switch (at)
                {
                    case ActionType.Insert:
                        PgSql.InsertIntoValues("Contract", String.Format("DEFAULT, {0}, {1}, {2}, {3}, '{4}', '{5}.{6}.{7}', {8}", numClientID.Value, (numFinalPartnerID.Value == -1) ? "NULL" : numFinalPartnerID.Value.ToString(), numEmployeeID.Value, numContractTerm.Value, cbState.Text, numDay.Value, numMonth.Value, numYear.Value, numSum.Value));
                        break;
                    case ActionType.Update:
                        PgSql.UpdateSet("contract", "client_id, final_partner_id, orginized_employee_id, contract_term, state, date_of_registration, price", String.Format("({0}, {1}, {2}, {3}, '{4}', '{5}.{6}.{7}', {8}) WHERE id = {9}", numClientID.Value, (numFinalPartnerID.Value == -1) ? "NULL" : numFinalPartnerID.Value.ToString(), numEmployeeID.Value, numContractTerm.Value, cbState.Text, numDay.Value, numMonth.Value, numYear.Value, numSum.Value, id));
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
