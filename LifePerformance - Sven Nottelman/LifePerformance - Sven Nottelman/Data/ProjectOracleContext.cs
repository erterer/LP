using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifePerformance___Sven_Nottelman.Models;
using Oracle.ManagedDataAccess.Client;

namespace LifePerformance___Sven_Nottelman.Data
{
    public class ProjectOracleContext : IProject
    {
        //Database instantie
        public Database Database { get; }

        /// <summary>
        /// Aanmaken van een connectie naar de database
        /// </summary>
        public ProjectOracleContext()
        {
            Database = new Database();
        }

        /// <summary>
        /// Deze methode haalt alle projecten op die open staan
        /// </summary>
        /// <param name="projecten">Lijst met alle teruggekomen projecten</param>
        /// <param name="error">Een error string, gevuld als er een error is opgetreden</param>
        /// <returns>Geeft true terug als alles succesvol is</returns>
        public bool HaalProjectenOp(out List<Project> projecten, out string error)
        {
            projecten = new List<Project>();
            error = string.Empty;
            try
            {
                string query = "SELECT NAAM FROM PROJECT";
                OracleCommand command = Database.CreateOracleCommand(query);
                OracleDataReader datareader = Database.ExecuteQuery(command);
                while (datareader.Read())
                {
                    string naam = Convert.ToString(datareader["NAAM"]);
                    projecten.Add(new Project(naam));
                }
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                Database.CloseConnection();
            }
        }
    }
}
