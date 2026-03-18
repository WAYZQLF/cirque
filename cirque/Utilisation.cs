using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moncirque
{
    public class Utilisation
    {
 
        private Personnel personnel;
        private Accessoire accessoire;
        public Utilisation(Personnel P, Accessoire A) 
        {
            this.personnel = P;
            this.accessoire = A;  
        }
        public override string ToString()
        {
            return ($"{personnel.ToString()} pour l'accessoire {accessoire.ToString()}");
        }
    }
}
