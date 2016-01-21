using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifePerformance___Sven_Nottelman.Data;
using LifePerformance___Sven_Nottelman.Models;

namespace LifePerformance___Sven_Nottelman.Logic
{
    public class ProjectRepository
    {
        //De interface waar alle methodes in staan die moeten worden gebruikt
        private IProject context;

        //De lijst waar alle projecten tijdelijk in worden opgeslagen
        public List<Project> Projecten;

        //Error string
        public string Error;

        /// <summary>
        /// Aanmaken van de interface en de lijst
        /// </summary>
        /// <param name="context"></param>
        public ProjectRepository(IProject context)
        {
            this.context = context;
            Projecten = new List<Project>();
        }

        /// <summary>
        /// Deze methode haalt alle projecten op die open staan
        /// </summary>
        /// <param name="projecten">Lijst met alle teruggekomen projecten</param>
        /// <param name="error">Een error string, gevuld als er een error is opgetreden</param>
        /// <returns>Geeft true terug als alles succesvol is</returns>
        public bool HaalProjectenOp()
        {
            return context.HaalProjectenOp(out Projecten, out Error);
        }
    }
}
