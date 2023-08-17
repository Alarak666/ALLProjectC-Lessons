using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class Department : DevExpress.XtraEditors.XtraForm
    {
        public Department()
        {
            InitializeComponent();
        }
        string [] data;
        string[] FildName = new string[]
                  {
                        "ID_Department",
                        "Name_Department"
                  };
        private void DepartmentGrid_Load(object sender, EventArgs e)
        {
            DepartmentGrid.DataSource = Connection.LoadData("[proc.dbo.Department@GetData]");
        }

        private void gridView2_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            ID_Department.Text = Grid.GetRowCellValue(Grid.FocusedRowHandle, Grid.Columns[0].FieldName).ToString();
            Name_Department.Text = Grid.GetRowCellValue(Grid.FocusedRowHandle, Grid.Columns[1].FieldName).ToString();
        }

        private void Add_Department_Click(object sender, EventArgs e)
        {
            Int32 selectedCellCount = Grid.Columns.Count;
            data = new string[]
            {
                ID_Department.Text,
                Name_Department.Text
            };
            if (ID_Department.Text != "" || Name_Department.Text != "")
            {
                try
                {
                    DataTable paramets = new DataTable();
                    paramets.Columns.Add("Name_Field", Type.GetType("System.String"));
                    paramets.Columns.Add("Data_Value", Type.GetType("System.String"));

                    for (int i = 0; i < data.Length; i++)
                    {
                        paramets.Rows.Add(new object[] { FildName[i].ToString(), data[i].ToString() });
                    }
                    Connection.EditData("[proc.dbo.Department@InsertData]", paramets);
                    DepartmentGrid.DataSource = Connection.LoadData("[proc.dbo.Department@GetData]");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Не всі поля введені");
            }
        }

        private void Update_Department_Click(object sender, EventArgs e)
        {
            Int32 selectedCellCount = Grid.Columns.Count;
            data = new string[]
            {
                ID_Department.Text,
                Name_Department.Text
            };
            if (ID_Department.Text != "")
            {
                try
                {
                    DataTable paramets = new DataTable();
                    paramets.Columns.Add("Name_Field", Type.GetType("System.String"));
                    paramets.Columns.Add("Data_Value", Type.GetType("System.String"));

                    for (int i = 0; i < data.Length; i++)
                    {
                        paramets.Rows.Add(new object[] { FildName[i].ToString(), data[i].ToString() });
                    }
                    Connection.EditData("[proc.dbo.Department@UpdateData]", paramets);
                    DepartmentGrid.DataSource = Connection.LoadData("[proc.dbo.Department@GetData]");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Виберыть дані в Grid");
            }
        }

        private void Delete_Department_Click(object sender, EventArgs e)
        {
            Int32 selectedCellCount = Grid.Columns.Count;
            data = new string[]
            {
                ID_Department.Text,
                Name_Department.Text
            };
            if (ID_Department.Text != "")
            {
                try
                {
                    DataTable paramets = new DataTable();
                    paramets.Columns.Add("Name_Field", Type.GetType("System.String"));
                    paramets.Columns.Add("Data_Value", Type.GetType("System.String"));

                    for (int i = 0; i < data.Length; i++)
                    {
                        paramets.Rows.Add(new object[] { FildName[i].ToString(), data[i].ToString() });
                    }
                    Connection.EditData("[proc.dbo.Department@DeleteData]", paramets);
                    DepartmentGrid.DataSource = Connection.LoadData("[proc.dbo.Department@GetData]");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Виберыть дані в Grid");
            }
        }
    }
}