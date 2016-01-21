namespace LifePerformance___Sven_Nottelman.Models
{
    public class Gebied
    {
        //Projectinstantie voor het ophalen van de lijst met bezoeken en waarnemingen
        private Project Project { get; set; }

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
            foreach(var p in Project.bezoeken)
            {

            }
            return true;
        }
    }
}
