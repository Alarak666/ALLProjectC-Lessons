using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lesson_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            foreach (UIElement item in MainGrid.Children)
            {
                if (item is Button)
                {
                    ((Button)item).Click += Button_Click;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
            //    string str = (string)((Button)e.OriginalSource).Content;
            //    if (str == "AC")
            //    {
            //        Total.Text = "0";
            //    }
            //    else if (Total.Text == "0")
            //    {
            //        Total.Text = "";
            //        Total.Text += str;
            //    }
            //    else if (str == "C")
            //    {
            //        Total.Text = Total.Text.Remove(Total.Text.Length - 1, 1);
            //    }
            //    else if (str == "=")
            //    {
            //        TotalExpression.Text = Total.Text;
            //        string value = new DataTable().Compute(Total.Text, null).ToString();
            //        Total.Text = value;
            //    }
            //    else
            //        Total.Text += str;

            //}
            //catch (ArgumentOutOfRangeException exx) { }
            //catch (SyntaxErrorException exx) { Total.Text = "0"; }
            //catch (Exception exx)
            //{
            //    MessageBox.Show(exx.Message.ToString());
            //}
           
        }
    }
}
