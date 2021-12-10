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

        // Instance
        public AkunController(View.LoginPage login)
        {
            akun = new Model.AkunModel();
            this.login = login;
        }

        public void Login()
        {
            akun.username = login.txtUsername.Text;
            akun.passwd = login.txtPassword.Password;
            bool result = akun.CekLogin();

            if (result)
            {
                // Ganti Main Menu nek wis dadi
                MessageBox.Show("ID Password Benar");

                // View.MainMenu main = new View.MainMenu();
                // main.Show();
                // login.Close();
            }
            else
            {
                MessageBox.Show("ID Password Salah");
                login.txtUsername.Text = "";
                login.txtPassword.Password = "";
                login.txtUsername.Focus();
            }
        }
    }
}
