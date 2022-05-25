using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleA
{
    
    class Aerienne : Cargaison
    {
        public Aerienne(M distp, Kg poids, MC volume)
            : base(distp, poids, volume)
        {

        }
        public override MAD Cout()
        {
            MC m = new MC(80000);
            if (this.E_val(m))
            {
                return this.calcul(10);
            }
            return this.calcul(12);
        }
    }
}
