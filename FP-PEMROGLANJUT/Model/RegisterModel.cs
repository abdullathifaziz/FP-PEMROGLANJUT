using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace FP_PEMROGLANJUT.Model
{
    class RegisterModel
    {
        DBConnector temp;

        public string namadpn { get; set; }
        public string namablkg { get; set; }
        public string email { get; set; }
        public string telp { get; set; } 


        public RegisterModel()
        {
            temp = new DBConnector();
        }

        // tak nonaktifke sikek ben ra eror
        /*
    public bool CekRegister()
    {

        bool result = false;
        DataSet ds = new DataSet();
        ds = temp.Select("nama depan", "nama belakang", "mail = '" + namablkg + email + "' AND telp = '" + telp + "'");
        if (ds.Tables[0].Rows.Count > 0)
        {
            result = true;
        }
        else
        {
            result = false;
        }
        return result;

    }
        */

        public bool InsertRegister()
        {
            string data = "'" + namadpn + "','" + namablkg + "','" + email + "','" + telp + "'";
            return temp.Insert("register", data);
        }
    }
}
