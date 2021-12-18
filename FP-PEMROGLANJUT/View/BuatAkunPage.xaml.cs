using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FP_PEMROGLANJUT.View
{
    /// <summary>
    /// Interaction logic for BuatAkunPage.xaml
    /// </summary>
    public partial class BuatAkunPage : Window
    {
        Controller.AkunController akun;
        public BuatAkunPage()
        {
            InitializeComponent();
            akun = new Controller.AkunController(this);
        }

        private void btnDaftar_Click(object sender, RoutedEventArgs e)
        {
            akun.Register();
        }
    }
}
