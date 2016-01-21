using LifePerformance___Sven_Nottelman.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;

namespace LifePerformance___Sven_Nottelman.Data
{
    public class DierenOracleContext : IDieren
    {
        //Database instantie
        public Database Database { get; }

        /// <summary>
        /// Aanmaken van een connectie naar de database
        /// </summary>
        public DierenOracleContext()
        {
            Database = new Database();
        }

        /// <summary>
        /// Deze methode haalt alle dieren op uit de database
        /// </summary>
        /// <param name="dieren">Lijst met alle dieren</param>
        /// <param name="error">Wordt weergegeven als er een error is</param>
        /// <returns>True wordt teruggegeven als alles is gelukt</returns>
        public bool HaalAlleDierenOp(out List<Dier> dieren, out string error)
        {
            dieren = new List<Dier>();
            error = string.Empty;
            try
            {
                string query = "SELECT NAAM, AFKORTING FROM DIER";
                OracleCommand command = Database.CreateOracleCommand(query);
                OracleDataReader datareader = Database.ExecuteQuery(command);
                while (datareader.Read())
                {
                    string naam = Convert.ToString(datareader["NAAM"]);
                    string afkorting = Convert.ToString(datareader["AFKORTING"]);
                    dieren.Add(new Vogel(naam, afkorting));
                }
                return true;
            }
            catch (Exception e)
            {
                error = e.ToString();
                return false;
            }
            finally
            {
                Database.CloseConnection();
            }
        }
    }
}
