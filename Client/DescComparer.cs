using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class DescComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (((ClientRauPlatnic)x).getSumaPlata() < ((ClientRauPlatnic)y).getSumaPlata())
                return -1;
            else if (((ClientRauPlatnic)x).getSumaPlata() > ((ClientRauPlatnic)y).getSumaPlata())
                return 1;
            else return 0;

        }
    }
}
