using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifePerformance___Sven_Nottelman.Models;
using LifePerformance___Sven_Nottelman.Logic;

namespace LifePerformance___Sven_Nottelman.Data
{
    public interface IDieren
    {
        /// <summary>
        /// Deze methode haalt alle dieren op uit de database
        /// </summary>
        /// <param name="dieren">Lijst met alle dieren</param>
        /// <param name="error">Wordt weergegeven als er een error is</param>
        /// <returns>True wordt teruggegeven als alles is gelukt</returns>
        bool HaalAlleDierenOp(out List<Dier> dieren, out string error);
    }
}
