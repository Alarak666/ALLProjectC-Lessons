using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poshta2._0
{
    public partial class KPI : Form
    {
        public KPI()
        {
            InitializeComponent();
            Load();
        }
        private void Load() {
            KPI_Grid.DataSource = ProjectAdapter.GridKPI();
        }
        private void Update_KPI_Click(object sender, EventArgs e)
        {
            ProjectAdapter.UpdateKPI(ParameterTable());
            KPI_Grid.DataSource = ProjectAdapter.GridKPI();

        }

        private void Delete_KPI_Click(object sender, EventArgs e)
        {
            ProjectAdapter.DeleteKPI(ParameterTable());
            KPI_Grid.DataSource = ProjectAdapter.GridKPI();
        }

        private void Add_KPI_Click(object sender, EventArgs e)
        {
            ProjectAdapter.InsertKPI(ParameterTable());
            KPI_Grid.DataSource = ProjectAdapter.GridKPI();
         }

        private void Back_Click(object sender, EventArgs e)
        {
            Main_Form main_Form = new Main_Form();
            main_Form.Show();
            this.Hide();
        }
        private DataTable ParameterTable()
        {
            try
            {
                DataTable paramets = new DataTable();
                paramets.Rows.Add();
                DataRow dataRow = paramets.NewRow();
                int row = 0;
                foreach (var value in this.panel1.Controls)
                {
                    if (value is TextBox)
                    {
                        paramets.Columns.Add((value as TextBox).Name.ToString());
                        dataRow.SetField(row, (value as TextBox).Text.Replace(',','.'));
                        row++;
                    }
                    if (value is ComboBox)
                    {
                        paramets.Columns.Add((value as ComboBox).Name.ToString());
                        dataRow.SetField(row, (value as ComboBox).Text.ToString());
                    }
                }
                paramets.Rows.Add(dataRow);
                return paramets;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return null;
        }

        private void KPI_Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Name.Text = KPI_Grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                Percent.Text = KPI_Grid.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
    }
}
