using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms; //TODO nur TEMPRORÄR, zum TESTEN


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
                com.CommandText = "INSERT INTO times (Start, End, Zeit, TimerID) VALUES ('" + starttime + "', '" + endtime + "', '" + duration + "', '" + id + "')";
                cnn.Open();
                com.ExecuteNonQuery();
                cnn.Close();
            }
        }

        //Manuelle Zeiteingabe speichern
        public void savetime(string timername, DateTime datum, DateTime start, DateTime datumende, DateTime ende)
        {
            int id = sqladapter.getTimerID(timername);
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                //(1) Build strings
                string starttime = datum.ToShortDateString() + " " + start.ToString(@"HH\:mm\:ss");
                string endtime = datumende.Date.ToShortDateString() + " " + ende.ToString(@"HH\:mm\:ss");
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

        //Vorhandene Zeit editieren
        public void edittime(string timername, DateTime new_datum, DateTime new_start, DateTime new_datumende, DateTime new_ende, string timesid)
        {
            int id = sqladapter.getTimerID(timername);
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                //(1) Build new strings
                string new_starttime = new_datum.ToShortDateString() + " " + new_start.ToString(@"HH\:mm\:ss");
                string new_endtime = new_datumende.Date.ToShortDateString() + " " + new_ende.ToString(@"HH\:mm\:ss");
                string new_duration = (DateTime.Parse(new_endtime) - DateTime.Parse(new_starttime)).ToString();
                
                    
                    //new_ende.Subtract(new_start).ToString(@"hh\:mm\:ss");




                //(1) Insert strings
                SQLiteCommand com = new SQLiteCommand();
                com.Connection = cnn;
                com.CommandText = "UPDATE times SET Start = '" + new_starttime + "', End = '" + new_endtime + "', Zeit = '" + new_duration + "', TimerID = '" + id + "' WHERE ID = '" + timesid + "'";
                cnn.Open();
                com.ExecuteNonQuery();
                cnn.Close();
            }
        }

        //Vorhandene Zeit wieder löschen
        public void deletetime(string timesid)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                SQLiteCommand com = new SQLiteCommand();
                com.Connection = cnn;
                com.CommandText = "DELETE FROM Times WHERE ID = '" + timesid + "'";
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

                com.CommandText = "SELECT Timer.id as id, Timer.Name AS name, Timer.Beschreibung AS descr, Timer.parallel AS parallel, Timer.quickslot AS quickslot, Timer.Color AS color FROM Timer where id='" + i + "'";
                SQLiteDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    currenttimer.setID(Int32.Parse(reader["id"].ToString()));
                    currenttimer.setName(reader["name"].ToString());
                    currenttimer.setDescr(reader["descr"].ToString());
                    currenttimer.setParallel(Boolean.Parse(reader["parallel"].ToString()));
                    currenttimer.setQuickslot(Int32.Parse(reader["quickslot"].ToString()));
                    currenttimer.setColor(Int32.Parse(reader["color"].ToString()));
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
        public void AddTimer(string name, string beschreibung, bool parallel, int color)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                SQLiteCommand com = new SQLiteCommand();
                com.Connection = cnn;
                com.CommandText = "INSERT INTO Timer (name, beschreibung, parallel, color) VALUES ('" + name + "', '" + beschreibung + "', '" + parallel + "', '" + color + "')";
                cnn.Open();
                com.ExecuteNonQuery();
                cnn.Close();
            }
        }

        //Timer editieren
        public void EditTimer(string name, string beschreibung, bool parallel, int color)
        {
            int id = sqladapter.getTimerID(name);

            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                SQLiteCommand com = new SQLiteCommand();
                com.Connection = cnn;
                com.CommandText = "UPDATE Timer SET name = '" + name + "', beschreibung = '" + beschreibung + "', parallel = '" + parallel + "', color = '" + color + "' WHERE Timer.ID = " + id;
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

        public bool CheckExistingTime(DateTime startdate, DateTime starttime, DateTime enddate, DateTime endtime)
        {
            //build correct times from dates and times
            ////(1) Get correct Date and time for start and end
            DateTime startvalue = startdate.Date + starttime.TimeOfDay;
            DateTime endvalue = enddate.Date + endtime.TimeOfDay;
            //string startvalue = startdate.ToShortDateString() + " " + starttime.ToString(@"HH\:mm\:ss");
            //string endvalue = enddate.ToShortDateString() + " " + endtime.ToString(@"HH\:mm\:ss");

            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                ////(1) Build strings

                SQLiteCommand com = new SQLiteCommand();
                com.Connection = cnn;
                //com.CommandText = "SELECT * FROM TIMES WHERE ('" + startvalue + "' BETWEEN TIMES.Start AND TIMES.End OR '" + endvalue + "' BETWEEN TIMES.Start AND TIMES.End)";
                com.CommandText = "SELECT * FROM Timer LEFT JOIN Times ON Times.TimerID = Timer.ID WHERE (('" + startvalue.ToString() + "' BETWEEN Times.Start AND Times.End) OR ('" + endvalue.ToString() + "' BETWEEN Times.Start AND Times.End) OR (Times.Start BETWEEN '" + startvalue.ToString() + "' AND '" + endvalue.ToString() + "') OR (Times.End BETWEEN '" + startvalue.ToString() + "' AND '" + endvalue.ToString() + "')) AND (Timer.parallel = 'false')";
                cnn.Open();
                SQLiteDataReader reader = com.ExecuteReader();

                //Test - Ermitteln, ob reader überhaupt irgendeine Zeile hat:
                if (reader.HasRows == false)
                {
                    reader.Close();
                    cnn.Close();
                    return false;
                } else
                {
                    reader.Read();
                    //Ausgabe der ersten Zeile
                    string message_output = "Timer: \n(ID) " + reader["ID"].ToString() + "\n"
                        + "(Name) " + reader["Name"].ToString() + "\n"
                        + "(Typ) " + reader["parallel"].ToString() + "\n"
                        + "(Start) " + reader["Start"].ToString() + "\n"
                        + "(End) " + reader["End"].ToString();
                    MessageBox.Show(message_output, "Gefundener Eintrag", MessageBoxButtons.OK);

                    reader.Close();
                    cnn.Close();
                    return true;
                }

                //ALTES, für den Test deaktiviert:
                //while (reader.Read())   //TODO Punkt 2
                //{
                //    if (reader.HasRows == true)
                //    {
                //        //TODO TEMPORÄR - NUR ZUM TESTEN
                //        string message_output = "Timer: \n(ID) " + reader["ID"].ToString() + "\n" 
                //        + "(Name) " + reader["Name"].ToString() + "\n"
                //        + "(Typ) " + reader["parallel"].ToString() + "\n"
                //        + "(Start) " + reader["Start"].ToString() + "\n" 
                //        + "(End) " + reader["End"].ToString();
                //        MessageBox.Show(message_output, "Gefundener Eintrag", MessageBoxButtons.OK);
                //        //TEMPORÄR - NUR ZUM TESTEN

                //        reader.Close();
                //        cnn.Close();
                //        return true;
                //    }
                //    else
                //    {
                //        reader.Close();
                //        cnn.Close();
                //        return false;
                //    }
                //}
                ////hier sollte man eigentlich nie ankommen...
                //MessageBox.Show("Unerreichbaren Code erreicht.", "Weird...?", MessageBoxButtons.OK);
                //return false;
            }
        }

        //Datagridview mit aktuellen Timerzeiten füllen --> Tabelle mit Daten für gewählten Timer anlegen und befüllen
        public DataTable GetTimerData(string timername, DateTime starttime, DateTime endtime)
        {
            DataTable Tabelle = new DataTable();
            //Tabelle.Columns.Add("Name");
            Tabelle.Columns.Add("Startdatum");
            Tabelle.Columns.Add("Startzeit");
            Tabelle.Columns.Add("Enddatum");
            Tabelle.Columns.Add("Endzeit");
            Tabelle.Columns.Add("Dauer");
            Tabelle.Columns.Add("TimesID");

            SQLiteCommand command = new SQLiteCommand();

            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();
                SQLiteDataReader LiesReihe;
                //command.CommandText = "SELECT * FROM Timer LEFT JOIN Times ON Times.TimerID = Timer.ID WHERE Timer.Name = '" + timername + "'";
                command.CommandText = "SELECT * FROM Timer LEFT JOIN Times ON Times.TimerID = Timer.ID WHERE Timer.Name = '" + timername + "' AND Start >= '" + starttime + "' AND END <= '" + endtime + "'";
                command.CommandType = CommandType.Text;
                command.Connection = cnn;
                LiesReihe = command.ExecuteReader();
                while (LiesReihe.Read())
                {
                    if (LiesReihe["Zeit"].ToString() != "") {

                        string[] new_row = new string[6];

                        //Name holen
                        //string nameoftimer = LiesReihe["Name"].ToString();
                        //new_row[0] = nameoftimer;

                        //Startzeit und -dauer holen
                        string StartTime = LiesReihe.GetString(7);
                        string[] start_splitted = StartTime.Split(' ');
                        new_row[0] = start_splitted[0];
                        new_row[1] = start_splitted[1];

                        //Endzeit und -dauer holen
                        string EndTime = LiesReihe.GetString(8);
                        string[] end_splitted = EndTime.Split(' ');
                        new_row[2] = end_splitted[0];
                        new_row[3] = end_splitted[1];


                        //Dauer holen (Datum wird verworfen)
                        string duration = LiesReihe.GetString(9);
                        new_row[4] = duration;

                        //TimesID holen (für Edit später)
                        int timesid = LiesReihe.GetInt32(6);
                        new_row[5] = timesid.ToString();

                        Tabelle.LoadDataRow(new_row, true);
                    } else
                    {
                        //string[] temp = new string[1];
                        //temp[0] = null;
                        //Tabelle.LoadDataRow(temp, true);
                    }
                }

                //Tabelle.Load(LiesReihe);
                LiesReihe.Close();
                cnn.Close();
            }
            return Tabelle;
        }

        //Logging-Daten für Settings-Form einlesen
        public List<string> GetCurrentLogSettings() 
        {
            List<string> list = new List<string>();

            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                SQLiteCommand com = new SQLiteCommand();
                com.Connection = cnn;
                cnn.Open();
                com.CommandText = "SELECT Settings.Tracking AS status, Settings.Trackinginterval as interval, Settings.savedlogs AS savedlogs FROM Settings WHERE ID=1";
                SQLiteDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    list.Add((string)reader[0]);
                    list.Add((string)reader[1]);
                    list.Add(reader[2].ToString());
                }
                reader.Close();

                cnn.Close();
                return list;
            }
        }

        //Logging-Daten in Settings aktualisieren
        public void updateLoggingSettings(bool status, string interval, int logcount)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                SQLiteCommand com = new SQLiteCommand();
                com.Connection = cnn;
                com.CommandText = "UPDATE Settings SET Tracking = '" + status + "', Trackinginterval = '" + interval + "', savedlogs = '" + logcount + "' WHERE Settings.ID='1'";
                cnn.Open();
                com.ExecuteNonQuery();
                cnn.Close();
            }
        }
    }
}
