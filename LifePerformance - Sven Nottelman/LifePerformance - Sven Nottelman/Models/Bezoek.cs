using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifePerformance___Sven_Nottelman.Models
{
    public class Bezoek
    {
        //Lijst met waarnemingen
        public List<Waarneming> waarnemingen { get; set; }
        //Datum van het bezoek
        public DateTime Datum { get; set; }

        //Aanvangst van het bezoek, starttijd
        public DateTime StartTijd { get; set; }

        //Einddtijd van het bezoek
        public DateTime EindTijd { get; set; }

        /// <summary>
        /// Zetten van de tijden van het bezoek
        /// </summary>
        /// <param name="datum">Datum van het bezoek</param>
        /// <param name="startTijd">Aanvangst van het bezoek</param>
        /// <param name="eindTijd">Eindtijd van het bezoek</param>
        public Bezoek(DateTime datum, DateTime startTijd, DateTime eindTijd)
        {
            Datum = datum;
            StartTijd = startTijd;
            EindTijd = eindTijd;
            waarnemingen = new List<Waarneming>();
        }

        /// <summary>
        /// Opslaan van de waarnemingen van een bezoek in een .xml file
        /// </summary>
        /// <param name="bezoek">Het bezoek dat moet worden opgeslagen</param>
        /// <returns>Geeft true terug als de methode succesvol is uitgevoerd</returns>
        public bool SaveToXML(Bezoek bezoek)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Ophalen van de eerder opgeslagen .xml file met de waarnemingen en opslaan in de database
        /// </summary>
        /// <param name="bezoek">Het bezoek wat moet worden opgeslagen</param>
        /// <returns>Geeft true terug als de methode succesvol is uitgevoerd</returns>
        public bool SaveToDatabase(Bezoek bezoek)
        {
            throw new NotImplementedException();
        }
    }
}
