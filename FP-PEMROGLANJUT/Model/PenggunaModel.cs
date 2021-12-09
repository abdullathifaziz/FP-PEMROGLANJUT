using System;
using System.Collections.Generic;
using System.Text;

namespace FP_PEMROGLANJUT.Model
{
    class PenggunaModel
    {
        DBConnector temp;

        public string namadpn { get; set; }
        public string namablkg { get; set; }
        public string email { get; set; }
        public string notelp { get; set; }
        public string pass { get; set; }
        public string confpass { get; set; }

        public PenggunaModel()
        {
            temp = new DBConnector();
        }

        
    }
}
