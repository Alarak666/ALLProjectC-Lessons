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
    public partial class FormEmployeer : Form
    {
        public FormEmployeer()
        {
            InitializeComponent();
            InitializeAdapter();
            ID_TextChanged();
        }
        public void EditDatas(string[] data)
        {
            ID.Text = data[0].ToString();
            FirstName.Text = data[1].ToString();
            MiddleName.Text = data[2].ToString();
            LastName.Text = data[3].ToString();
            Address.Text = data[4].ToString();
            KPI.SelectedValue = data[6].ToString();
            ID_Post.Text = data[7].ToString();
            ID_Department.Text = data[8].ToString();
        }
        private void ID_TextChanged()
        {
            if (ID.Text == "")
                NewEmployeer.Enabled = true;
            else NewEmployeer.Enabled = false;
        }
        private void InitializeAdapter()
        {
            KPI.DataSource = ProjectAdapter.AdapterIKP();
            ID_Post.DataSource = ProjectAdapter.AdapterPost();
            ID_Department.DataSource = ProjectAdapter.AdapterDepartment();
        }

        private void SaveEmployeer_Click(object sender, EventArgs e)
        {
            try
            {
                ProjectAdapter.UpdateEmployer(ParameterTable());
                MessageBox.Show("Оновленно дані співробітника");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void NewEmployeer_Click(object sender, EventArgs e)
        {
            try
            {
                ProjectAdapter.InsertEmployer(ParameterTable());
                MessageBox.Show("Додано нового співробітника");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Employer employers = new Employer();
            employers.Show();
            Dispose();
            Close();
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
                        dataRow.SetField(row, (value as ComboBox).SelectedValue);
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
    }
}
