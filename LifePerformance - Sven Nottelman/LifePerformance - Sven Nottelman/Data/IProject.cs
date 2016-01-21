using LifePerformance___Sven_Nottelman.Models;
using System.Collections.Generic;

namespace LifePerformance___Sven_Nottelman.Data
{
    public interface IProject
    {
        /// <summary>
        /// Deze methode haalt alle projecten op die open staan
        /// </summary>
        /// <param name="projecten">Lijst met alle teruggekomen projecten</param>
        /// <param name="error">Een error string, gevuld als er een error is opgetreden</param>
        /// <returns>Geeft true terug als alles succesvol is</returns>
        bool HaalProjectenOp(out List<Project> projecten, out string error);
    }
}
