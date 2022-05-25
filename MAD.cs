using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleA
{
    class MAD
    {
        private float val;
        public MAD(float val)
        {
            this.val = val;
        }
        public float castMAD()
        {
            return this.val;
        }
        public static MAD operator *(int V1, MAD v2)
        {
            float a = v2.castMAD();
            MAD m = new MAD(V1 * a);
            return m;
        }
    }
}
