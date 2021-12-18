using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace FP_PEMROGLANJUT.Controller
{
    class AkunController
    {
        // Object
        Model.AkunModel akun;
        View.LoginPage login;
        View.BuatAkunPage register;

        // Instance
        public AkunController(View.LoginPage login)
        {
            akun = new Model.AkunModel();
            this.login = login;
        }

        public AkunController(View.BuatAkunPage register)
        {
            akun = new Model.AkunModel();
            this.register = register;
        }

        public void Login()
        {
            akun.usrname = login.txtUsername.Text;
            akun.passwd = login.txtPassword.Password;
            bool result = akun.CekLogin();

            if (result)
            {
                View.HomeWindow homeWindow = new View.HomeWindow();
                homeWindow.Show();
                login.Close();
            }
            else
            {
                MessageBox.Show("ID Password Salah");
                login.txtUsername.Text = "";
                login.txtPassword.Password = "";
                login.txtUsername.Focus();
            }
        }

        public void Register()
        {
            if (register.checkboxSDK.IsChecked ?? false)
            {
                akun.nama_depan = register.txtNamaDepan.Text;
                akun.nama_belakang = register.txtNamaBelakang.Text;
                akun.usrname = register.txtUsername.Text;
                akun.passwd = register.txtPassword.Password;

                bool result = akun.InsertAkun();

                if (result)
                {
                    MessageBox.Show("Pembuatan Akun Berhasil");
                    View.LoginPage login = new View.LoginPage();
                    login.Show();
                    register.Close();
                }
                else
                {
                    MessageBox.Show("Pembuatan Akun Gagal");
                    View.BuatAkunPage register = new View.BuatAkunPage();
                    register.Show();
                    register.Close();
                }
            }
            else
            {
                MessageBox.Show("Mohon checklist Syarat dan Ketentuan");
            }
        }
    }
}
