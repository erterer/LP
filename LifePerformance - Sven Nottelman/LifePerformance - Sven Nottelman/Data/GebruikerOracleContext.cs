using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifePerformance___Sven_Nottelman.Logic;
using Oracle.ManagedDataAccess.Client;

namespace LifePerformance___Sven_Nottelman.Data
{
    public class GebruikerOracleContext : IGebruiker
    {
        private Database database;

        public GebruikerOracleContext()
        {
            database = new Database();
        }
        public bool Login(string username, string password, out string error)
        {
            error = string.Empty;
            username = username.ToLower();

            try
            {
                string query = "SELECT * FROM TEST WHERE lower(USERNAME) = :username and PASSWORD = :password";
                OracleCommand cmd = database.CreateOracleCommand(query);
                cmd.Parameters.Add("username", username);
                cmd.Parameters.Add("password", password);
                OracleDataReader reader = database.ExecuteQuery(cmd);
                while (reader.Read())
                {
                    if (reader["USERNAME"] != System.DBNull.Value)
                    {
                        string dbUsername = Convert.ToString(reader["USERNAME"]);
                        string dbPassword = Convert.ToString(reader["PASSWORD"]);

                        if(dbUsername.ToLower() == username && dbPassword == password)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
            catch (Exception e)
            {
                error = e.ToString();
                return false;
            }
            finally
            {
                database.CloseConnection();
            }
        }
    }
}
