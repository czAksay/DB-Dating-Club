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
    public partial class GetPare : Form
    {
        public GetPare()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int target_id;
            if (Int32.TryParse(tbID.Text, out target_id))
            {
                try
                {
                    NpgsqlDataReader dataReader = PgSql.GetPare(target_id);
                    dataGridView.RowCount = 0;
                    dataGridView.ColumnCount = dataReader.FieldCount;
                    int row = 0;
                    while (dataReader.Read())
                    {
                        int cell = 0;
                        dataGridView.RowCount++;
                        for (int i = 0; i < dataReader.FieldCount; i++)
                        {
                            dataGridView.Columns[i].HeaderText = StringHelper.Localize(dataReader.GetName(i), CurrentTable.Clients);
                            dataGridView.Rows[row].Cells[cell].Value = dataReader[i].ToString();
                            cell++;
                        }
                        dataGridView.Rows[row].HeaderCell.Value = (row + 1).ToString();
                        row++;
                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Введите в текстовое поле числовое значение - ID целевого клиента.");
            }
        }
    }
}
