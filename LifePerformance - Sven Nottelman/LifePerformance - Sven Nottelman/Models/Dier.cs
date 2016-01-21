using System.Runtime.Serialization;

namespace LifePerformance___Sven_Nottelman.Models
{
    [DataContract(Namespace = "")]
    public abstract class Dier
    {
        //Naam van een dier
        [DataMember]
        public string Naam { get; set; }

        //Afkorting van een dier
        [DataMember]
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
