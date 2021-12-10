using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace FP_PEMROGLANJUT.Model
{
    class PenggunaModel
    {
        DBConnector temp;

        /*
        public string namadpn { get; set; }
        public string namablkg { get; set; }
        public string email { get; set; }
        public string notelp { get; set; }
        public string pass { get; set; }
        public string confpass { get; set; }
        */

        public string username { get; set; }
        public string passwd { get; set; }
        public string email { get; set; }
        public PenggunaModel()
        {
            temp = new DBConnector();
        }

        public bool CekLogin()
        {
            bool result = false;
            DataSet ds = new DataSet();
            ds = temp.Select("pengguna", "username = '" + username + "' AND email = '" + email + "' AND passwd = '" + passwd + "'");
            if(ds.Tables[0].Rows.Count > 0)
            {
                result = true;
            } else
            {
                result = false;
            }
            return result;
        }
        
    }
}
