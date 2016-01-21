using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifePerformance___Sven_Nottelman.Models
{
    public class Vogel : Dier
    {
        //Startdatum van de broedperiode
        public DateTime BroedStart { get; set; }

        //Einddatum van de broedperiode
        public DateTime BroedEind { get; set; }

        //Aantal punten
        public int AantalPunten { get; set; }

        /// <summary>
        /// Zetten van een vogel
        /// </summary>
        /// <param name="naam">Naam van de vogel</param>
        /// <param name="afkorting">Afkorting van de vogel</param>
        /// <param name="broedStart">Broedstart periode</param>
        /// <param name="broedEind">Broedeind periode</param>
        public Vogel(string naam, string afkorting, DateTime broedStart, DateTime broedEind)
            : base(naam, afkorting)
        {
            BroedStart = broedStart;
            BroedEind = broedEind;
        }

        /// <summary>
        /// Zetten van een vogel zonder broedperiode
        /// </summary>
        /// <param name="naam">Naam van de vogel</param>
        /// <param name="afkorting">Afkorting van de vogel</param>
        public Vogel(string naam, string afkorting)
            : base(naam, afkorting)
        {
            //Als de persoon niet weet wat de broedperiode is
        }
    }
}
