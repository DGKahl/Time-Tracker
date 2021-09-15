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

        //Übersicht: Quickslot-Buttons mit richtigem Timer "belegen"

        // ---------> check entry on stackoverflow!!!!! <-------------------------- ####################################

        public List<string> SetQuickslots()
        {
            List<string> list = new List<string>();

            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                SQLiteCommand com = new SQLiteCommand();
                com.Connection = cnn;
                cnn.Open();
                for (int i = 1; i <= 3; i++)
                {
                    com.CommandText = "SELECT Timer.name AS name, Timer.quickslot as slot FROM Timer WHERE slot=" + i;
                    SQLiteDataReader reader = com.ExecuteReader();
                    
                        while (reader.Read())
                        {
                        list.Add((string)reader[0]);
                        }
                    reader.Close();
                }
                cnn.Close();
                return list;
            }
        }

     

        //Timer: Zeit vom Tracker speichern
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
