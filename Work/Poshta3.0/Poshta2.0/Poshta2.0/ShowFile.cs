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
    public partial class ShowFile : Form
    {
        public ShowFile()
        {
            InitializeComponent();
            OpenFile();
        }
        OpenFileDialog openFileDialog = new OpenFileDialog();
        
        private void OpenFile()
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string path = Directory.GetCurrentDirectory();
            openFileDialog.InitialDirectory = path;
            // получаем выбранный файл
            string filename = openFileDialog.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);
            textBox1.Text = fileText;
            MessageBox.Show("Файл открыт");
        }
        private void SaveText_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, textBox1.Text);
            MessageBox.Show("Файл сохранен");
        }

        private void Back_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }
    }
}
