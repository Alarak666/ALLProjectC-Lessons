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
    public partial class Main_Form : DevExpress.XtraEditors.XtraForm
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Employer employer = new Employer();
            employer.Show();
           
            Hide();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Department employer = new Department();
            employer.Show();
          
            Hide();
        }
    }
}