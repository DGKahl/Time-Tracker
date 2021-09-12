using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SQLite;


namespace Time_Tracker
{
    class sqladapter
    {
        //ConnectionString
        private string LoadConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["default"].ConnectionString;
        }

        //Zeit vom Tracker zurückschreiben
        public void savetime()
        {
            //using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            //{
            //    SQLiteCommand com = new SQLiteCommand();
            //    com.Connection = cnn;
            //    com.CommandText = "INSERT INTO tim (vorname,name,rolle,arbeitsplatz) VALUES ('" + name + "', '" + vorname + "', '" + rolle + "', '" + arbeitsplatz + "')";
            //    cnn.Open();
            //    com.ExecuteNonQuery();
            //    cnn.Close();
            //}
        }

    }
}
