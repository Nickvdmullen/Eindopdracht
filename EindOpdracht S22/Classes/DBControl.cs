namespace EindOpdracht_S22.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Data.OleDb;

    public class DBControl
    {
        private OleDbConnection connection;

        public DBControl()
        {
            string pad;
            string provider;
            string applicatiepad;
            string accesconnectionstring;

            provider = "Provider=Microsoft.ACE.OLED.12.0";

            applicatiepad = HttpContext.Current.Request.PhysicalApplicationPath.Substring(0, HttpContext.Current.Request.PhysicalApplicationPath.LastIndexOf("\\"));

            pad = "Data Source=" + applicatiepad + "/DataBase11.accdb";

            accesconnectionstring = provider + ";" + pad;

            connection = new OleDbConnection(accesconnectionstring);
        }

        public void Open()
        {
            try
            {
                connection.Open();
            }
            catch(Exception exception)
            {
                Console.WriteLine("Could not connect Database: " + exception.Message);
            }

        }

        public void Close()
        {
            try
            {
                connection.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Could not close Database: " + exception.Message);
            }
        }

        public List<string> GetBuilds()
        {
            Open();
            string sql = "SELECT BuildName FROM [Build]";
            OleDbCommand Command = new OleDbCommand(sql, connection);
            List<string> ReceivedBuilds = new List<string>();
            try
            {
                OleDbDataReader Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    string buildName = Convert.ToString(Reader["BuildName"]);

                    ReceivedBuilds.Add(buildName);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Could not execute reader: " + exception);
            }
            Close();
            return ReceivedBuilds;
        }

        public List<string> GetBuild(string BuildName)
        {
            Open();
            string sql = "SELECT ClassName,Specname,Spellname From [Build]";
            OleDbCommand Command = new OleDbCommand(sql, connection);
            List<string> ReceivedBuild = new List<string>();

            try
            {
                OleDbDataReader Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    string className = Convert.ToString(Reader["ClassName"]);
                    string specName = Convert.ToString(Reader["SpecName"]);
                    string spellname = Convert.ToString(Reader["spellname"]);
                    ReceivedBuild.Add(className);
                    ReceivedBuild.Add(specName);
                    ReceivedBuild.Add(spellname);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Could not execute reader: " + exception.Message);
            }
            Close();
            return ReceivedBuild;
        }


        public List<string> GetToolTips(Class Class)
        {
            Open();

            string sql = "SELECT TOOLTIP FROM SPECIALIZATION WHERE CLASSNAME =" + Class.Name;
            OleDbCommand Command = new OleDbCommand(sql, connection);
            List<string> mytooltips = new List<string>();

            try
            {
                OleDbDataReader Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    mytooltips.Add(Convert.ToString(Reader["TOOLTIP"]));
                }
            }
            catch
            {

            }
            return mytooltips;
        }

        public string GetToolTip(Class Class)
        {
            Open();
            string sql = "SELECT TOOLTIP FROM CLASS WHERE CLASSNAME = " + Class.Name;
            OleDbCommand Command = new OleDbCommand(sql, connection);
            string Tooltip = "";

            try
            {
                OleDbDataReader Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    Tooltip = Reader["TOOLTIP"].ToString();
                }
            }
            catch
            {

            }
            return Tooltip;
        }

        public string[] GetSpecialization(Class Class)
        {
            Open();

            string sql = "SELECT TOOLTIP FROM SPECIALIZATION WHERE CLASSNAME =" + Class.Name;
            OleDbCommand Command = new OleDbCommand(sql, connection);
            string[] mySpecs = new string[3];

            try
            {
                OleDbDataReader Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    if (mySpecs[0] == null)
                    {
                       mySpecs[0] = (Convert.ToString(Reader["TOOLTIP"]));
                    }
                    else if (mySpecs[1] == null)
                    {
                        mySpecs[1] = (Convert.ToString(Reader["TOOLTIP"]));
                    }
                    else if (mySpecs[2] == null)
                    {
                        mySpecs[3] = (Convert.ToString(Reader["TOOLTIP"]));
                    }
                }
            }
            catch
            {

            }
            return mySpecs;
        }

        public void SaveBuild(Build build)
        {
            Open();
            string Buildname = build.BuildName;
            string Author = build.Author;
            string Class = build.SelectedClass;
            string Spec = build.SelectedSpec;
            List<string> spells = build.SelectedSpells;

           try
            {
                OleDbCommand Command = new OleDbCommand();
                Command.Parameters.Add("@BuildName",Buildname);
                Command.Parameters.Add("@BuildAuthor", Author);
                
            }
            catch
            {

            }
            Close();
        }
    }
}