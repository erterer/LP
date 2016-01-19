using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifePerformance___Sven_Nottelman.Data;

namespace LifePerformance___Sven_Nottelman.Logic
{
    public class GebruikerRepository
    {
        private IGebruiker context;

        public GebruikerRepository(IGebruiker context)
        {
            this.context = context;
        }

        public bool Login(string username, string password, out string error)
        {
            return context.Login(username, password, out error);
        }
    }
}
