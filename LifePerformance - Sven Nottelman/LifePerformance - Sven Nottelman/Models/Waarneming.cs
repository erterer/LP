using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifePerformance___Sven_Nottelman.Models
{
    public class Waarneming
    {
        //Naam van de waarneming
        public string Naam { get; set; }

        //Type waarneming
        public SoortWaarneming Soort { get; set; }

        //Tijdstip van de waarneming
        public DateTime Tijdstip { get; set; }

        //Aantal punten wat wordt gegeven voor de waarneming
        public int Punten { get; set; }

        //Het dier dat is waargenomen
        public Dier Dier { get; set; }

        /// <summary>
        /// Zetten van de waarneming
        /// </summary>
        /// <param name="naam">Naam van de waarneming, meestal diernaam</param>
        /// <param name="soort">Type waarneming</param>
        /// <param name="tijdstip">Tijdstip van de waarneming</param>
        /// <param name="punten">Aantal gegegeven punten</param>
        /// <param name="dier">Het waargenomen dier</param>
        public Waarneming(string naam, SoortWaarneming soort, DateTime tijdstip, int punten, Dier dier)
        {
            Naam = naam;
            Soort = soort;
            Tijdstip = tijdstip;
            Punten = punten;
            Dier = dier;
        }
    }
}
