using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifePerformance___Sven_Nottelman.Data;
using LifePerformance___Sven_Nottelman.Models;

namespace LifePerformance___Sven_Nottelman.Logic
{
    public class DierenRepository
    {
        //De interface waar alle methodes in staan die moeten worden gebruikt
        private IDieren context;

        //De lijst waar alle projecten tijdelijk in worden opgeslagen
        public List<Dier> Dieren;

        //Error string
        public string Error;

        /// <summary>
        /// Aanmaken van de interface en de lijst
        /// </summary>
        /// <param name="context"></param>
        public DierenRepository(IDieren context)
        {
            this.context = context;
            Dieren = new List<Dier>();
        }

        /// <summary>
        /// Deze methode haalt alle dieren op uit de database
        /// </summary>
        /// <param name="dieren">Lijst met alle dieren</param>
        /// <param name="error">Wordt weergegeven als er een error is</param>
        /// <returns>True wordt teruggegeven als alles is gelukt</returns>
        public bool HaalDierenOp()
        {
            return context.HaalAlleDierenOp(out Dieren, out Error);
        }
    }
}
