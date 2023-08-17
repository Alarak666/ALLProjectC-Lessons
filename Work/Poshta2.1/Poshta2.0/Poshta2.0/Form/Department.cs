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
    public partial class Department : Form
    {
        public Department()
        {
            InitializeComponent();
            Adapter_Department();
        }
        private void Adapter_Department()
        {
            Department_Grid.DataSource = ProjectAdapter.GridDepartment();
        }
        private void Department_Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ID_Department.Text = Department_Grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                Name_Department.Text = Department_Grid.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void Add_Department_Click(object sender, EventArgs e)
        {
            ProjectAdapter.InsertDepartment(ParameterTable());
            Department_Grid.DataSource = ProjectAdapter.GridDepartment();
        }

        private void Delete_Department_Click(object sender, EventArgs e)
        {
            if (ID_Department.Text != "")
            {
                try
                {
                    ProjectAdapter.DeleteDepartment(ParameterTable());
                    Department_Grid.DataSource = ProjectAdapter.GridDepartment();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Виберіть кого видаляти в Grid");
            }
        }
        
        private void Update_Department_Click(object sender, EventArgs e)
        {
            ProjectAdapter.UpdateDepartment(ParameterTable());
            Department_Grid.DataSource = ProjectAdapter.GridDepartment();
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
                        dataRow.SetField(row, (value as TextBox).Text.ToString());
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
    }
}
