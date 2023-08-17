using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poshta2._0
{
    public partial class EmployerSalaryForm : Form
    {
        public EmployerSalaryForm()
        {
            InitializeComponent();
        }

        public DataTable dataTable = new DataTable("EmployerSalary");
        public void Suma()
        {
            object Sum;
            object SumIKP;
            SumIKP = Math.Round((double)dataTable.Compute("Sum(Оклад_КРІ)", string.Empty), 2);
            Sum = dataTable.Compute("Sum(Оклад)", string.Empty);
            TSuma.Text = Sum.ToString();
            TSumaIKP.Text = SumIKP.ToString();
        }
        public static void WriteDataToFile(DataTable submittedDataTable, string submittedFilePath)
        {

            int i = 0;
            StreamWriter sw = null;
            sw = new StreamWriter(submittedFilePath, false);

            for (i = 0; i < submittedDataTable.Columns.Count - 1; i++)
            {

                sw.Write(submittedDataTable.Columns[i].ColumnName + ";");

            }
            sw.Write(submittedDataTable.Columns[i].ColumnName);
            sw.WriteLine();

            foreach (DataRow row in submittedDataTable.Rows)
            {
                object[] array = row.ItemArray;

                for (i = 0; i < array.Length - 1; i++)
                {
                    sw.Write(array[i].ToString() + ";");
                }
                sw.Write(array[i].ToString());
                sw.WriteLine();

            }

            sw.Close();
        }
        private void Back_Click(object sender, EventArgs e)
        {
            Main_Form main_Form = new Main_Form();
            main_Form.Show();
            Dispose();
            Close();
        }
        private void PrintFile_Click(object sender, EventArgs e)
        {
            dataTable.DefaultView.Sort = "Посада DESC";
            string path = "files.txt";
            WriteDataToFile(dataTable, path);
        }

        private void EmployerSalaryForm_Load_1(object sender, EventArgs e)
        {
            dataTable = ProjectAdapter.SumGridEmployer();
            GridEmployer.DataSource = dataTable;
            Suma();
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            ShowFile showFile = new ShowFile();
            Hide();
            showFile.Show();
        }
    }
}
