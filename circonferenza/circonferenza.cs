using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circonferenza
{
    internal class circonferenza
    {
        public float raggio { get; set; }

       public float perimetro { get; set; }

        public float area { get; set; }
        public float calcolaperimetro (float perimetro )
        {
            perimetro = (float)(raggio * Math.PI * 2);

            return perimetro;
        }

        public float calcoloarea (float area)
        {
            area = (float)(raggio * Math.PI * Math.PI);

            return area;
        }
    }
}
