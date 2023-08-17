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
    public partial class EmployerForm : DevExpress.XtraEditors.XtraForm
    {
        public EmployerForm()
        {
            InitializeComponent();
            AdapterData();
            ID_TextChanged();
        }
        string[] data;
        string[] FildName = new string[]
        {
            "ID",
            "FName",
            "MName",
            "LName",
            "Address",
            "KPI",
            "Post",
            "Department"
        };
        void AdapterData()
        {
            KPI.Properties.DataSource = Connection.Adapter("[proc.dbo.KPI@GetData]");
            Post.Properties.DataSource = Connection.Adapter("[proc.dbo.Post@GetData]");
            Department.Properties.DataSource = Connection.Adapter("[proc.dbo.Department@GetData]");
        }
        private void ID_TextChanged()
        {
            if (ID.Text == "")
                Add_Employer.Enabled = true;
            else Add_Employer.Enabled = false;
        }
        public void EditDatas(string[] data)
        {
            ID.Text = data[0].ToString();
            FName.Text = data[1].ToString();
            MName.Text = data[2].ToString();
            LName.Text = data[3].ToString();
            Address.Text = data[4].ToString();
            KPI.Text = data[6].ToString();
            Post.Text = data[7].ToString();
            Department.Text = data[8].ToString();
        }

        private void Add_Employer_Click(object sender, EventArgs e)
        {
            if(data!= null)
                Array.Clear(data, 0, data.Length);
            data = new string[8]
            {
                ID.Text,
                FName.Text,
                MName.Text,
                LName.Text,
                Address.Text,
                KPI.EditValue.ToString(),
                Post.EditValue.ToString(),
                Department.EditValue.ToString()
            };
            if (FName.Text != "")
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
                    Connection.EditData("[proc.dbo.Employes@InsertData]", paramets);
                    XtraMessageBox.Show($"Додано\n Ім'я {FName.Text};\n Прізвище { MName.Text}\n По батькові {LName.Text};\n Адреса {Address.Text};\n KPI {KPI.Properties.DisplayMember};\n Посада {Post.Properties.DisplayMember};\n Департамент {Department.Properties.DisplayMember};");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Заповніть дані");
            }
        }

        private void Update_Employer_Click(object sender, EventArgs e)
        {
            if (data != null)
                Array.Clear(data, 0, data.Length);
            data = new string[8]
            {
                ID.Text,
                FName.Text,
                MName.Text,
                LName.Text,
                Address.Text,
                KPI.EditValue.ToString(),
                Post.EditValue.ToString(),
                Department.EditValue.ToString()
            };
            if (FName.Text != "")
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
                    Connection.EditData("[proc.dbo.Employes@UpdateData]", paramets);
                    XtraMessageBox.Show($"Оновлено\n Код {ID.Text};Ім'я {FName.Text};\n Прізвище { MName.Text}\n По батькові {LName.Text};\n Адреса {Address.Text};\n KPI {KPI.Properties.DisplayMember};\n Посада {Post.Properties.DisplayMember};\n Департамент {Department.Properties.DisplayMember};");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Заповніть дані");
            }

        }
    }
}