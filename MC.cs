using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleA
{
    class MC
    {
        private float val;
        public MC(float val)
        {
            this.val = val;
        }
        public static bool operator <(MC V1, MC v2)
        {
            if (V1.val < v2.val)
            {
                return true;
            }
            else return false;

        }
        public static bool operator >(MC V1, MC v2)
        {
            return !(V1 < v2);
        }

        public static bool operator <=(MC V1, MC v2)
        {
            if (V1.val <= v2.val)
            {
                return true;
            }
            else return false;

        }
        public static bool operator >=(MC V1, MC v2)
        {
            return !(V1 <= v2);
        }
    }
}
