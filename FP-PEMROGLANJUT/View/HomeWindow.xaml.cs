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
    /// Interaction logic for HomeWindow.xaml
    /// </summary>
    public partial class HomeWindow : Window
    {
        public HomeWindow()
        {
            InitializeComponent();
        }

        private void menuBeranda_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new View.HomePage());
        }

        private void menuIsiUlang_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new View.IsiUlangPage());
        }

        private void menuTagihan_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new View.TagihanPage());
        }

        private void menuHiburan_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new View.HiburanPage());
        }

        private void menuPengaturan_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new View.PengaturanPage());
        }
    }
}
