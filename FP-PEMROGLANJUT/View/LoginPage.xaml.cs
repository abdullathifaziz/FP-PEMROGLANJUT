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
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Window
    {
        // Object
        Controller.AkunController akunController;
        public LoginPage()
        {
            InitializeComponent();

            // Instance
            akunController = new Controller.AkunController(this);

            // Nggo ngecheck koneksi database, nek error di comment wae
            Model.DBConnector cek = new Model.DBConnector();
            cek.dbChecker();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            akunController.Login();
        }

        private void btnBuatAkun_Click(object sender, RoutedEventArgs e)
        {
            BuatAkunPage buatAkun = new BuatAkunPage();
            buatAkun.Show();
            this.Close();
        }
    }
}
