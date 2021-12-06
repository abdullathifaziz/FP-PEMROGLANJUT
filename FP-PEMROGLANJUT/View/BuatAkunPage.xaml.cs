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
        public BuatAkunPage()
        {
            InitializeComponent();
        }

        private void btnLanjut_Click(object sender, RoutedEventArgs e)
        {
            BuatPasswordPage buatPassword = new BuatPasswordPage();
            buatPassword.Show();
            this.Close();
        }
    }
}
