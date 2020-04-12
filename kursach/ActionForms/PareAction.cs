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
    public partial class PareAction : Form
    {
        ActionType at;
        int id1, id2;
        public PareAction(ActionType _at, int _id1, int _id2)
        {
            InitializeComponent();
            at = _at;
            id1 = _id1;
            id2 = _id2;
            lbltitle.Text = _at.ToString();
            btnAction.Text = _at.ToString() + "!";
            if (at == ActionType.Update)
            {
                FillFields();
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            try
            {
                switch (at)
                {
                    case ActionType.Insert:
                        PgSql.InsertIntoValues("Pare", String.Format("{0}, {1}", numClientID.Value, numClient2Id.Value));
                        break;
                    case ActionType.Update:
                        PgSql.UpdateSet("Pare", "client1_id, client2_id", String.Format("({0}, {1}) WHERE client1_id = {2} AND client2_id = {3}", numClientID.Value, numClient2Id.Value, id1, id2));
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

        private void FillFields()
        {
            try
            {
                NpgsqlDataReader dataReader = PgSql.SelectFromWhere2("*", "pare", "client1_id", id1.ToString(), "client2_id", id2.ToString());
                dataReader.Read();
                numClientID.Text = dataReader[0].ToString();
                numClient2Id.Text = dataReader[1].ToString();
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }
    }
}
