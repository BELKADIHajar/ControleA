using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleA
{
    class M
    {
        private float val;
        public M(float val)
        {
            this.val = val;
        }
        public float castM()
        {
            return this.val;
        }
        public static MAD operator*(M  V1, Kg v2)
        {
            float a =V1.castM();
            float b =v2.castKg();
            MAD m = new MAD(a*b);
            return m;
        }
        
    }
}
