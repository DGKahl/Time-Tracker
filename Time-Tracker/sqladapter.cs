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
        private static string LoadConnectionString()
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
        public static int getTimerID(string name)
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
                    id = Int32.Parse(reader["ID"].ToString());
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

        // Parallel-Status für alle(!) vorhandenen Timer auslesen --> Speichern in Dictionary
        public IDictionary<string, bool> AllTimersParallelStatus()
        {
            IDictionary<string, bool> alltimers = new Dictionary<string, bool>();

            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                SQLiteCommand com = new SQLiteCommand();
                com.Connection = cnn;
                cnn.Open();

                com.CommandText = "SELECT Timer.name AS name, Timer.parallel AS parallel FROM Timer";
                SQLiteDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    alltimers.Add(reader["name"].ToString(), Boolean.Parse(reader["parallel"].ToString()));
                    //list.Add(reader["name"].ToString());
                }
                reader.Close();
                cnn.Close();
            }
            return alltimers;
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
            int id = sqladapter.getTimerID(timername);
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                //(1) Build strings
                string starttime = t.getStart().ToString();
                string endtime = t.getEnd().ToString();
                string duration = t.getEnd().Subtract(t.getStart()).ToString(@"hh\:mm\:ss");

                //(2) Zeit einfügen
                SQLiteCommand com = new SQLiteCommand();
                com.Connection = cnn;
                com.CommandText = "INSERT INTO times (Start, End, Zeit, TimerID) VALUES ('" + starttime + "', '" + endtime + "', '" + duration +  "', '" + id + "')";
                cnn.Open();
                com.ExecuteNonQuery();
                cnn.Close();
            }
        }

        //Manuelle Zeiteingabe speichern
        public void savetime(string timername, DateTime datum, DateTime start, DateTime ende)
        {
            int id = sqladapter.getTimerID(timername);
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                //(1) Build strings
                string starttime = datum.ToShortDateString() + " " + start.ToString(@"HH\:mm\:ss");
                string endtime = datum.Date.ToShortDateString() + " " + ende.ToString(@"HH\:mm\:ss");
                string duration = ende.Subtract(start).ToString(@"hh\:mm\:ss");

                //(1) Insert strings
                SQLiteCommand com = new SQLiteCommand();
                com.Connection = cnn;
                com.CommandText = "INSERT INTO times (Start, End, Zeit, TimerID) VALUES ('" + starttime + "', '" + endtime + "', '" + duration + "', '" + id + "')";
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

        //"Parallel" Status eines bestimmten Timers auf Basis des Namens holen
        public bool getParallelStatus(string name)
        {
            bool status = false;

            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                SQLiteCommand com = new SQLiteCommand();
                com.Connection = cnn;
                cnn.Open();

                com.CommandText = "SELECT Timer.name AS name, Timer.parallel AS parallel FROM Timer where name='" + name + "'";
                SQLiteDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    status = Boolean.Parse(reader["parallel"].ToString());
                }
                reader.Close();
                cnn.Close();
            }
            return status;
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
            int id = sqladapter.getTimerID(name);

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
            int id = sqladapter.getTimerID(name);

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
            int id = sqladapter.getTimerID(name);

            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                //(1) Löschen aller Zeiten
                SQLiteCommand com = new SQLiteCommand();
                com.Connection = cnn;
                com.CommandText = "DELETE FROM Times WHERE TimerID=" + id;
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

        //Ermittlung, ob ein manueller Eintrag (Timer, Datum, Start, Ende) von einem Single-Timer bereits belegt ist
        //(Idee: Single-Timer dürfen nur alleine laufen, nicht parallel zu anderen Timern)

        public bool CheckExistingTime(string datum, string start, string ende)
        {
            //build string from date and times
            string startvalue = datum + " " + start;
            string endvalue = datum + " " + ende;

            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                SQLiteCommand com = new SQLiteCommand();
                com.Connection = cnn;
                //com.CommandText = "SELECT * FROM TIMES WHERE ('" + startvalue + "' BETWEEN TIMES.Start AND TIMES.End OR '" + endvalue + "' BETWEEN TIMES.Start AND TIMES.End)";
                com.CommandText = "SELECT * FROM Timer LEFT JOIN Times ON Times.TimerID = Timer.ID WHERE \n" +
                    "('" + startvalue + "' BETWEEN Times.Start AND Times.End) OR \n" +
                    "('" + endvalue + "' BETWEEN Times.Start AND Times.End) OR \n" +
                    "(Times.Start BETWEEN '" + startvalue + "' AND '" + endvalue + "') OR \n" +
                    "(Times.End BETWEEN '" + startvalue + "' AND '" + endvalue + "')";
                cnn.Open();
                SQLiteDataReader reader = com.ExecuteReader();

                if (reader.HasRows == true)
                {
                    reader.Close();
                    cnn.Close();
                    return true;
                } else
                {
                    reader.Close();
                    cnn.Close();
                    return false;
                }
            }
        }
    }
}
