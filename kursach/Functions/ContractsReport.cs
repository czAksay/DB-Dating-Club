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
    public partial class ContractsReport : Form
    {
        public ContractsReport()
        {
            InitializeComponent();
            Search();
        }

        private void Search()
        {
            try
            {
                NpgsqlDataReader dataReader = PgSql.GetContactReport();
                dataGridView.RowCount = 0;
                dataGridView.ColumnCount = dataReader.FieldCount;
                int row = 0;
                while (dataReader.Read())
                {
                    int cell = 0;
                    dataGridView.RowCount++;
                    for (int i = 0; i < dataReader.FieldCount; i++)
                    {
                        dataGridView.Columns[i].HeaderText = dataReader.GetName(i);
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
    }
}
