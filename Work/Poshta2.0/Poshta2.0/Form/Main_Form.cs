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
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void BDepartment_Click(object sender, EventArgs e)
        {
            Department department = new Department();
            Hide();
            department.Show();
        }

        private void BEmployee_Click(object sender, EventArgs e)
        {
            Employer employers = new Employer();
            Hide();
            employers.Show();
        }

        private void BPost_Click(object sender, EventArgs e)
        {
            PostEmployer postEmployerForm = new PostEmployer();
            Hide();
            postEmployerForm.Show();

        }

        private void EmployerPrice_Click(object sender, EventArgs e)
        {
            EmployerSalaryForm employerSalaryForm = new EmployerSalaryForm();
            Hide();
            employerSalaryForm.Show();
        }
    }
}
