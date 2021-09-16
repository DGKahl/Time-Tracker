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

        //Quickslots setzen
        public List<string> GetQuickslots()
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

        // SETTINGS: Neue Quickslots setzen (auf Basis der übergebenen strings)
        public void UpdateQuickslots(string one, string two, string three)
        {
            //(1) Alle aktuellen Quickslots löschen (Werte der Spalte in Tabelle für jede Zeile = 0)
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                SQLiteCommand com = new SQLiteCommand();
                com.Connection = cnn;
                com.CommandText = "UPDATE Timer SET quickslot = '0'";
                cnn.Open();
                com.ExecuteNonQuery();
                cnn.Close();
            }

            //(2) Neue Quickslot-Nummern gemäß der Namen in den Comboboxen vergeben
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                //Slot 1
                SQLiteCommand com1 = new SQLiteCommand();
                com1.Connection = cnn;
                com1.CommandText = "UPDATE Timer SET quickslot = '1' WHERE Timer.name='" + one +"'";

                //Slot 2
                SQLiteCommand com2 = new SQLiteCommand();
                com2.Connection = cnn;
                com2.CommandText = "UPDATE Timer SET quickslot = '2' WHERE Timer.name='" + two + "'";

                //Slot 3
                SQLiteCommand com3 = new SQLiteCommand();
                com3.Connection = cnn;
                com3.CommandText = "UPDATE Timer SET quickslot = '3' WHERE Timer.name='" + three + "'";

                //Ausführung
                cnn.Open();
                com1.ExecuteNonQuery();
                com2.ExecuteNonQuery();
                com3.ExecuteNonQuery();
                cnn.Close();
            }
        }

        // SETTINGS: Liste der Namen aller aktuellen Timer ermitteln
        public List<string> GetAllTimers() {

            List<string> list = new List<string>();

            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                SQLiteCommand com = new SQLiteCommand();
                com.Connection = cnn;
                cnn.Open();

                com.CommandText = "SELECT Timer.name AS name FROM Timer";
                SQLiteDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(reader["name"].ToString());
                }
                reader.Close();
                cnn.Close();
            }
            return list;
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
