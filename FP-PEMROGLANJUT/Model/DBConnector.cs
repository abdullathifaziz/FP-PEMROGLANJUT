using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace FP_PEMROGLANJUT.Model
{
    class DBConnector
    {
        private static SqlConnection connector;
        private SqlConnection command;

        public static SqlConnection GetConnection()
        {
            // Ganti Data Source dadi Jneng Server e dewe-dewe
            connector = new SqlConnection();
            connector.ConnectionString = "Data Source = GARDENS;" +
                                         "Initial Catalog = ppob;" +
                                         "Integrated Security = True";
            return connector;
        }

        public void dbChecker()
        {
            GetConnection();

            try
            {
                connector.Open();
                MessageBox.Show("Success");
            }
            catch(SqlException se)
            {
                MessageBox.Show("Fail" + se);
            }
        }
    }
}
