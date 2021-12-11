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


        public RegisterModel()
        {
            temp = new DBConnector();
        }

        public bool CekRegister()
        {
            bool result = false;
            DataSet ds = new DataSet();
            ds = temp.Select("nama depan", "nama belakang = '" + namadpn + namablkg + "' AND email = '" + email + "'");
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
    }
}
