using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifePerformance___Sven_Nottelman.Models
{
    public class Project
    {
        //Naam van een project
        public string Naam { get; set; }

        /// <summary>
        /// Zetten van de naam van een project
        /// </summary>
        /// <param name="naam">Naam van een project</param>
        public Project(string naam)
        {
            Naam = naam;
        }

        /// <summary>
        /// Deze methode zorgt ervoor dat het project wordt afgesloten als de resultaten zijn ingestuurd
        /// </summary>
        /// <returns>Er wordt een bool terug gegeven als het project succesvol is gesloten</returns>
        public bool ProjectSluiten()
        {
            throw new NotImplementedException();
        }
    }
}
