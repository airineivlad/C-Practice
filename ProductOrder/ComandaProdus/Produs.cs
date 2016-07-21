using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComandaProdus
{
    [Serializable]
    public class Produs
    {
        readonly string denumire;

        public string Denumire
        {
            get { return denumire; }
           
        }
        readonly decimal pret;

        public decimal Pret
        {
            get { return pret; }
        }



        readonly decimal cantitate;
        public decimal Cantitate
        {
            get { return cantitate; }
            
        }

        public Produs(string denumire, decimal pret, decimal cantitate)
        {
            this.denumire = denumire;
            if (pret > 0)
            {
                this.pret = pret;
            }

            if (cantitate > 0)
            {
                this.cantitate = cantitate;
            }

        }

        public String ToString()
        {
            return this.denumire + " " + this.pret + " " + this.cantitate;
        }
    }
}
