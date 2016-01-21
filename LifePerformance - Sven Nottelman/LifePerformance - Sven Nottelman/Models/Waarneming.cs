using System;
using System.Runtime.Serialization;

namespace LifePerformance___Sven_Nottelman.Models
{
    [DataContract(Namespace = "")]
    public class Waarneming
    {
        //Naam van de waarneming
        [DataMember]
        public string Naam { get; set; }

        //Type waarneming
        [DataMember]
        public SoortWaarneming Soort { get; set; }

        //Tijdstip van de waarneming
        [DataMember]
        public DateTime Tijdstip { get; set; }

        //Aantal punten wat wordt gegeven voor de waarneming
        [DataMember]
        public int Punten { get; set; }

        //Het dier dat is waargenomen
        [DataMember]
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
