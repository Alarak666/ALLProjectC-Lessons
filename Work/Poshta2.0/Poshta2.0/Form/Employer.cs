using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Poshta2._0
{
    public partial class Employer : Form
    {
        public Employer()
        {
            InitializeComponent();
            Adapter_Employer();
        }
     
        string []data;
        private void EmployerGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    ID.Text = EmployerGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                    FirstName.Text = EmployerGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                    MiddleName.Text = EmployerGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                    LastName.Text = EmployerGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                    Address.Text = EmployerGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
                    Salary.Text = EmployerGrid.Rows[e.RowIndex].Cells[6].Value.ToString();
                    KPI.Text = EmployerGrid.Rows[e.RowIndex].Cells[7].Value.ToString();
                    _Post.Text = EmployerGrid.Rows[e.RowIndex].Cells[8].Value.ToString();
                    _Departament.Text = EmployerGrid.Rows[e.RowIndex].Cells[9].Value.ToString();

                    Int32 selectedCellCount = EmployerGrid.GetCellCount(DataGridViewElementStates.Selected);

                    data = new string[selectedCellCount - 1];
                    if (selectedCellCount > 0)
                    {
                        if (EmployerGrid.AreAllCellsSelected(true))
                        {
                            MessageBox.Show("All cells are selected", "Selected Cells");
                        }
                        else
                        {
                            for (int i = 1; i < selectedCellCount; i++)
                            {
                                data[i - 1] = EmployerGrid.Rows[e.RowIndex].Cells[i].Value.ToString();
                            }
                        }
                    }
                    if (EmployerGrid.Columns[e.ColumnIndex].Name == "InfoEmployer")
                    {
                        if (data != null)
                        {
                            InfoEmployerFrom form = new InfoEmployerFrom();
                            form.EditDatas(data);
                            form.Show();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Adapter_Employer()
        {
          Post.DataSource = ProjectAdapter.AdapterPost();
          Department.DataSource = ProjectAdapter.AdapterDepartment();
        }
        private void Emplyer_Load(object sender, EventArgs e)
        {
            EmployerGrid.DataSource = ProjectAdapter.GridEmployer();
        }

        private void LoadData_Click(object sender, EventArgs e)
        {
            EmployerGrid.DataSource = ProjectAdapter.GridEmployer();
        }

        private void Add_Department_Click(object sender, EventArgs e)
        {
            Hide();
            FormEmployeer form = new FormEmployeer();
            form.Show();
        }

        private void Update_Department_Click(object sender, EventArgs e)
        {
            if (data != null)
            {
                Hide();
                FormEmployeer form = new FormEmployeer();
                form.EditDatas(data);
                form.Show();
            }
        }

        private void Delete_Department_Click(object sender, EventArgs e)
        {
            try
            {
                ProjectAdapter.DeleteEmployer(ParameterTable());
                EmployerGrid.DataSource = ProjectAdapter.GridEmployer();
                MessageBox.Show("Видалено співробітника");
                foreach (Control c in Controls)
                    if (c is TextBox)
                        ((TextBox)c).Text = null;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private DataTable ParameterTable()
        {
            try
            {
                DataTable paramets = new DataTable();
                paramets.Rows.Add();
                DataRow dataRow = paramets.NewRow();
                int row = 0;
                foreach (var value in this.groupBox1.Controls)
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
                        dataRow.SetField(row, (value as ComboBox).SelectedValue.ToString());
                        row++;
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
        private DataTable ParameterTables()
        {
            try
            {
                DataTable paramets = new DataTable();
                paramets.Rows.Add();
                DataRow dataRow = paramets.NewRow();
                int row = 0;
                foreach (var value in this.panel2.Controls)
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
                        dataRow.SetField(row, (value as ComboBox).SelectedValue.ToString());
                        row++;
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

        private void Filter_Click(object sender, EventArgs e)
        { 
            int i = 0;
            i = (PostCheck.Checked == true) ? 2
            : (DepartmentCheck.Checked == true) ? 1 : 0;
            EmployerGrid.DataSource = ProjectAdapter.FilterGrid(i, ParameterTables());
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Main_Form main_Form = new Main_Form();
            Hide();
            main_Form.Show();
        }
    }
}
