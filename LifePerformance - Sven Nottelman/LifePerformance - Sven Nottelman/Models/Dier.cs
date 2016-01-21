using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifePerformance___Sven_Nottelman.Models
{
    public abstract class Dier
    {
        //Naam van een dier
        public string Naam { get; set; }

        //Afkorting van een dier
        public string Afkorting { get; set; }

        /// <summary>
        /// Zetten van de basisgegevens van een dier
        /// </summary>
        /// <param name="naam">Naam van een dier</param>
        /// <param name="afkorting">Afkorting van een dier</param>
        public Dier(string naam, string afkorting)
        {
            Naam = naam;
            Afkorting = afkorting;
        }
    }
}
