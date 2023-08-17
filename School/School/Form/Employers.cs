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
    public partial class Employer : DevExpress.XtraEditors.XtraForm
    {
        public Employer()
        {
            InitializeComponent();
        }
        private string[] data;
        string[] FildName = new string[]
                    {
                        "ID",
                        "FName",
                        "MName",
                        "LName",
                        "Address",
                        "Salary",
                        "KPI",
                        "Post",
                        "Department"
                    };
        private void EmployerGrid_Load(object sender, EventArgs e)
        {
            EmployerGrid.DataSource = Connection.LoadData("[proc.dbo.Employes@GetData]");
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            Int32 selectedCellCount = gridView1.Columns.Count;
            ID.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Код").ToString();
            FName.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Ім'я").ToString();
            MName.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Прізвище").ToString();
            LName.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "По батькові").ToString();
            Address.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Адрес").ToString();
            Salary.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Оклад").ToString();
            KPI.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "КРІ").ToString();
            Post.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Посада").ToString();
            Department.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Департамент").ToString();
            data = new string[selectedCellCount - 1];
            if (selectedCellCount > 0)
            {
                    for (int i = 1; i < selectedCellCount; i++)
                    {
                    data[i - 1] = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[i].FieldName).ToString();
                    }
               
            }
        }

        private void IBInfoEmployer_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (data != null)
            {
                IfnoEmployerForm form = new IfnoEmployerForm();
                form.EditDatas(data);
                form.Show();
            }
            else
            {
                MessageBox.Show("Для початку виберіть данні для відображення");
            }
        }

        private void Add_Employer_Click(object sender, EventArgs e)
        {
            Hide();
            EmployerForm form = new EmployerForm();
            form.Show();
        }

        private void Update_Employer_Click(object sender, EventArgs e)
        {
            if (data != null)
            {
                Hide();
                EmployerForm form = new EmployerForm();
                form.EditDatas(data);
                form.Show();
            }
        }

        private void Delete_Employer_Click(object sender, EventArgs e)
        {
            if (ID.Text != "")
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
                    Connection.EditData("[proc.dbo.Employes@DeleteData]", paramets);
                    EmployerGrid.DataSource = Connection.LoadData("[proc.dbo.Employes@GetData]");
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
        private void Back_Click(object sender, EventArgs e)
        {

        }
    }
}

//var listBoxControl1 = new ListBoxControl();
//listBoxControl1.Items.Add("Components");
//foreach (object component in this.components.Components)
//    listBoxControl1.Items.Add(component.GetType().Name);
//listBoxControl1.Items.Add("Controls");

////foreach (Control control in Controls)
////        IterateThrough(control);

////var list = this.infoEmployer.Items;
////for (int i = 0; i < list.Count; i++)
////{
////    list[i].
////}

////    if (value is TextEdit)
////    {
////        paramets.Rows.Add(new object[] { (value as TextEdit).Name.ToString(), (value as TextEdit).Text.ToString() });
////    }
////    if (value is ComboBox)
////    {
////        paramets.Rows.Add(new object[] { (value as ComboBox).Name.ToString(), (value as ComboBox).SelectedValue.ToString() });
////    }