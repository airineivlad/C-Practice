using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComenziPizza
{   [Serializable]
    public class Topping
    {
        public String denumire { get; set; }
        public float pret { get; set; }
        public readonly int cod;

        public Topping(String denumire, float pret, int cod) {

            this.denumire = denumire;
            this.pret = pret;
            this.cod = cod;
        }

        public Topping() {
        }

        public override String ToString() {

            return String.Format("{0}, {1}, {2}; ", this.denumire, this.pret, this.cod);
        }
    }
}
