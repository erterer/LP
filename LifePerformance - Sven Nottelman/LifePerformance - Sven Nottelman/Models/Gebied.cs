using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifePerformance___Sven_Nottelman.Models
{
    public class Gebied
    {
        //Naam van een gebied
        public string Naam { get; set; }

        /// <summary>
        /// Zetten van de naam van een gebied
        /// </summary>
        /// <param name="naam">Naam van een gebied</param>
        public Gebied(string naam)
        {
            Naam = naam;
        }

        /// <summary>
        /// Deze methode print voor iedere diersoort het aantal waargenomen broedparen
        /// </summary>
        /// <param name="dier">Het object dier met alle gegevens</param>
        /// <returns>Geeft true terug als de methode succesvol is uitgevoerd</returns>
        public bool PrintBroedparen(Dier dier)
        {
            throw new NotImplementedException();
        }
    }
}
