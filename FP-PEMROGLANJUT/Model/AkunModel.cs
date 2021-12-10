using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace FP_PEMROGLANJUT.Model
{
    class AkunModel
    {
        DBConnector temp;

        public string username { get; set; }
        public string passwd { get; set; }
        public string email { get; set; }

        public AkunModel()
        {
            temp = new DBConnector();
        }

        public bool CekLogin()
        {
            bool result = false;
            DataSet ds = new DataSet();
            ds = temp.Select("akun", "usrname = '" + username + "' AND passwd = '" + passwd + "'");
            if(ds.Tables[0].Rows.Count > 0)
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
