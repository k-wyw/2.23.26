using System;
using System.Collections.Generic;
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

namespace WpfApp2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

     
        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            MessageText.Text = "нажмите на кнопку 2";
        }

     
        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            MessageText.Text = "поставьте нам 2 плюса пожалуйста";
        }
    }
}