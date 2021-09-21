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

        //ID zu einem ausgewählten Timer finden
        public int getTimerID(string name)
        {
            int id = 0;

            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                SQLiteCommand com = new SQLiteCommand();
                com.Connection = cnn;
                com.CommandText = "SELECT Timer.ID AS id FROM Timer WHERE Timer.name = '" + name + "'";
                cnn.Open();
                SQLiteDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    id = Int32.Parse(reader["id"].ToString());
                }
                reader.Close();
                cnn.Close();
            }
            return id;
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
                com1.CommandText = "UPDATE Timer SET quickslot = '1' WHERE Timer.name='" + one + "'";

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
        public List<string> GetAllTimers()
        {

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
        public void savetime(timeobject t, string timername)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                //(1) Zeit einfügen
                SQLiteCommand com = new SQLiteCommand();
                com.Connection = cnn;
                com.CommandText = "INSERT INTO times (Start, End, Zeit) VALUES ('" + t.getStart().ToString() + "', '" + t.getEnd().ToString() + "', '" + t.getElapsed().Hours + ":" + t.getElapsed().Minutes + ":" + t.getElapsed().Seconds + "')";
                cnn.Open();
                com.ExecuteNonQuery();
                cnn.Close();

                //(2) m:n link einfügen:
                int m = 0, n = 0;

                //(2.1) ID für m finden:
                com.CommandText = "SELECT Timer.ID AS id FROM Timer WHERE Timer.name = '" + timername + "'";
                cnn.Open();
                SQLiteDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    m = Int32.Parse(reader["id"].ToString());
                }
                reader.Close();
                cnn.Close();

                //(2.2) ID für n finden: 
                com.CommandText = "SELECT Times.ID AS id FROM Times WHERE id=(SELECT max(id) FROM Times)";
                cnn.Open();
                SQLiteDataReader reader2 = com.ExecuteReader();

                while (reader2.Read())
                {
                    n = Int32.Parse(reader2["id"].ToString());
                }
                reader2.Close();
                cnn.Close();

                //(2.3) Neue Daten in m:n Tabelle schreiben:
                com.CommandText = "INSERT INTO timertimes (timerid, timesid) VALUES ('" + m + "', '" + n + "')";
                cnn.Open();
                com.ExecuteNonQuery();
                cnn.Close();
            }
        }

        //Daten eines bestimmten Timers von db holen (relevant bei Auswahl in Combobox)
        public timeobject mytimer(int i)
        {
            timeobject currenttimer = new timeobject();

            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                SQLiteCommand com = new SQLiteCommand();
                com.Connection = cnn;
                cnn.Open();

                com.CommandText = "SELECT Timer.id as id, Timer.Name AS name, Timer.Beschreibung AS descr, Timer.parallel AS parallel, Timer.quickslot AS quickslot FROM Timer where id='" + i + "'";
                SQLiteDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    currenttimer.setID(Int32.Parse(reader["id"].ToString()));
                    currenttimer.setName(reader["name"].ToString());
                    currenttimer.setDescr(reader["descr"].ToString());
                    currenttimer.setParallel(Boolean.Parse(reader["parallel"].ToString()));
                    currenttimer.setQuickslot(Int32.Parse(reader["quickslot"].ToString()));
                }
                reader.Close();
                cnn.Close();
            }
            return currenttimer;
        }

        //neuen Timer hinzufügen
        public void AddTimer(string name, string beschreibung, bool parallel)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                SQLiteCommand com = new SQLiteCommand();
                com.Connection = cnn;
                com.CommandText = "INSERT INTO Timer (name, beschreibung, parallel) VALUES ('" + name + "', '" + beschreibung + "', '" + parallel + "')";
                cnn.Open();
                com.ExecuteNonQuery();
                cnn.Close();
            }
        }

        //Timer editieren
        public void EditTimer(string name, string beschreibung, bool parallel)
        {
            int id = this.getTimerID(name);

            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                SQLiteCommand com = new SQLiteCommand();
                com.Connection = cnn;
                com.CommandText = "UPDATE Timer SET name = '" + name + "', beschreibung = '" + beschreibung + "', parallel = '" + parallel + "' WHERE Timer.ID = " + id;
                cnn.Open();
                com.ExecuteNonQuery();
                cnn.Close();
            }
        }

        //Timer archivieren
        public void ArchiveTimer(string name)
        {
            int id = this.getTimerID(name);

            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                SQLiteCommand com = new SQLiteCommand();
                com.Connection = cnn;
                com.CommandText = "UPDATE Timer (archived) VALUES ('true') WHERE Timer.ID = " + id;
                cnn.Open();
                com.ExecuteNonQuery();
                cnn.Close();
            }
        }

        //Timer löschen (inklusive Zeiten)
        public void DeleteTimer(string name)
        {
            int id = this.getTimerID(name);

            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                //(1) Löschen aller Zeiten in m:n Tabelle
                SQLiteCommand com = new SQLiteCommand();
                com.Connection = cnn;
                com.CommandText = "DELETE FROM TimerTimes WHERE TimerTimes.TimerID=" + id;
                cnn.Open();
                com.ExecuteNonQuery();
                cnn.Close();

                //(2) Löschen des Timers
                com.Connection = cnn;
                com.CommandText = "DELETE FROM Timer WHERE ID=" + id;
                cnn.Open();
                com.ExecuteNonQuery();
                cnn.Close();
            }
        }
    }
}
