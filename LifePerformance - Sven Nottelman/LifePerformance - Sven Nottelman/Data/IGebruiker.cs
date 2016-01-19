using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifePerformance___Sven_Nottelman.Data
{
    public interface IGebruiker
    {
        bool Login(string username, string password, out string error);
    }
}
