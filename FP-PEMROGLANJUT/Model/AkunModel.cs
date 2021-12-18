using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace FP_PEMROGLANJUT.Model
{
    class AkunModel
    {
        DBConnector temp;

        public string usrname { get; set; }
        public string passwd { get; set; }
        public string nama_depan { get; set; }
        public string nama_belakang { get; set; }

        public AkunModel()
        {
            temp = new DBConnector();
        }

        public bool CekLogin()
        {
            bool result = false;
            DataSet ds = new DataSet();
            ds = temp.Select("akun", "usrname = '" + usrname + "' AND passwd = '" + passwd + "'");
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

        public bool InsertAkun()
        {
            string data = "'" + usrname + "','" + passwd + "','" + nama_depan + "','" + nama_belakang + "',null,null";
            return temp.Insert("akun", data);
        }
        
    }
}
