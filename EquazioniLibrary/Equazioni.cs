using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public class Equazioni
    {
        public static bool IsDeterminated(double a)
        {
            if (a == 0)
                return false;
            else
                return true;
            
        }

        public static bool IsInconsisted(double a, double b)
        {
            if (a == 0 && b != 0)
                return true;
            else
                return false;
        }

        public static bool IsDegree2(double a)
        {
            if (a == 0)
                return false;
            else
                return true;

        }
    }
}
