using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows;

namespace FP_PEMROGLANJUT.Controller
{
    class RegisterController
    {
        Model.RegisterModel register;
        View.BuatAkunPage buat;

        public RegisterController(View.BuatAkunPage buat)
        {
            register = new Model.RegisterModel();
            this.buat = buat;
        }

        public void Buat()
        {
            register.namadpn = buat.txtNamaDepan.Text;
            register.namablkg = buat.txtNamaBelakang.Text;
            register.email = buat.txtEmail.Text;
            register.telp = buat.txtNomorTelephon.Text;

            /*
            bool result = buat.InsertRegister();
            if (result)
            {
                MessageBox.Show("Akun berhasil dibuat, " +
                    "silahkan buat password");
                View.LoginPage login = new View.LoginPage();
                login.Show();
                buat.Close();
            }
            else
            {
                MessageBox.Show("Maaf, registrasi akun gagal, " +
                    "periksa dan lengkapi data anda");
            }
            */
        }
    
    }
}
