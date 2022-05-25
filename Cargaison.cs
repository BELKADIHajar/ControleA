using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleA
{
    class Cargaison
    {
        private int reference;
        private static int cpt = 0;
        private M distp;
        private Kg poids;
        private MC volume;

        public Cargaison(M distp, Kg poids, MC volume)
        {
            Cargaison.cpt++;
            this.reference = Cargaison.cpt;
            this.distp = distp;
            this.poids = poids;
            this.volume = volume;

        }
        public virtual MAD Cout()
        {
            MAD m1 = new MAD(3); 
            return m1;
        }
        public bool E_val(MC v)
        {
            if (this.volume < v)
                return true;
            else 
                return false; 
        }
        public MAD calcul(int x)
        {
            MAD m1, m2;
            m1 = this.distp * this.poids;
            m2 = x * m1;
            return m2;
        }

    }
}
