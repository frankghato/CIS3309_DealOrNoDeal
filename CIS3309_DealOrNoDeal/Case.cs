using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS3309_DealOrNoDeal
{
    class Case
    {
        private int id;
        private double value;
        public Case(int id, double value)
        {
            this.id = id;
            this.value = value;
        }

        public double Value
        {
            get { return this.value; }
        }

        public int ID
        {
            get { return this.id; }
        }

    }
}
