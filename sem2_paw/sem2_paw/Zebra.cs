using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem2_paw
{
    class Zebra: Animal
    {
        private bool areDungiNegre;
        private int nrPui;

        public Zebra()
            : base()
        {
            areDungiNegre = true;
            nrPui = 0;
        }

        public Zebra(int v, string n, float g, bool are, int nr)
            : base(v, n, g)
        {
            areDungiNegre = are;
            nrPui = nr;
        }

        public override string ToString()
        {
            return base.ToString()+" si are dungi negre "+areDungiNegre+
                " si are "+nrPui+" pui";
        }
    }
}
