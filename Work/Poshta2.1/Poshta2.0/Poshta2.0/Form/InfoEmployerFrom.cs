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
    public partial class InfoEmployerFrom : Form
    {
        public InfoEmployerFrom()
        {
            InitializeComponent();
        }
        public void EditDatas(string[] data)
        {
            ID.Text = data[0].ToString();
            FName.Text = data[1].ToString();
            MName.Text = data[2].ToString();
            LName.Text = data[3].ToString();
            Address.Text = data[4].ToString();
            Salary.Text = Math.Round(Convert.ToDouble(data[5].ToString()), 2).ToString();
            KPI.Text = data[6].ToString();
            _Post.Text = data[7].ToString();
            _Departament.Text = data[8].ToString();
        }
    }
}
