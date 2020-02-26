using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem2_paw
{
    class Girafa: Animal
    {
        private int inaltime;
        private int nrPete;

        public Girafa()
            : base()
        {
            inaltime = 0;
            nrPete = 0;
        }

        public Girafa(int v, string n, float g, int h, int nr)
            : base(v, n, g)
        {
            inaltime = h;
            nrPete = nr;
        }

        public override string ToString()
        {
            return base.ToString()+ " inaltimea "+inaltime+
                " si nr pete "+nrPete;
        }
    }
}
