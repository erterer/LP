﻿using System;
using System.Collections.Generic;

namespace LifePerformance___Sven_Nottelman.Models
{
    public class Project
    {
        public List<Bezoek> bezoeken { get; set; }
        //Naam van een project
        public string Naam { get; set; }

        /// <summary>
        /// Zetten van de naam van een project
        /// </summary>
        /// <param name="naam">Naam van een project</param>
        public Project(string naam)
        {
            Naam = naam;
            bezoeken = new List<Bezoek>();
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
