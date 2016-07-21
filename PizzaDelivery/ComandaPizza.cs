using System;
using System.Xml.Serialization;

namespace ComenziPizza
{
    [Serializable]
    public class ComandaPizza : ICustomizabil, ICloneable
    {
        public String nume { get; set; }
        public String blat { get; set; }
        public int durataRealizare { get; set; }

        [XmlIgnore]     
        public Topping[] topping;

        public static readonly float costBaza=10;

        public Topping this[int i]{
            get {
                return topping[i];
            }

            set {

                topping[i] = value;
            }


        }

     

        public ComandaPizza(string Nume, string Blat, int DurataRealizare, Topping[] Topping)
        {
            this.nume = Nume;
            this.blat = Blat;
            this.durataRealizare = DurataRealizare;
            this.topping = Topping;

        }


        public ComandaPizza()
        {

        }


        public float calculCostPizza()
        {
            float costTotal = 0;
            foreach (Topping tp in topping) {
                costTotal += tp.pret;
            }
            return costTotal + costBaza;
        }

        public static Boolean operator >(ComandaPizza pizza1, ComandaPizza pizza2) {

            if (pizza1.calculCostPizza() >= pizza2.calculCostPizza())
                return true;
            else return false;

        }

        public static Boolean operator <(ComandaPizza pizza1, ComandaPizza pizza2)
        {

            if (pizza1.calculCostPizza() < pizza2.calculCostPizza())
                return true;
            else return false;

        }


        public object Clone()
        {
            ComandaPizza tmp = null;
            tmp = new ComandaPizza(this.nume, this.blat, this.durataRealizare, (Topping[])this.topping.Clone());
            return tmp;

        }

        public override String ToString() {

            return String.Format("Nume:{0}, Blat:{1}, Durata:{2}, Topping:{3}",this.nume, this.blat, this.durataRealizare, string.Join<Topping>(",", this.topping));
        }

        public static ComandaPizza operator +(ComandaPizza comanda, Topping tp)
        {
            Topping[] toppinguri = new Topping[comanda.topping.Length + 1];
            for (int i = 0; i < comanda.topping.Length; i++)
            {
                toppinguri[i] = comanda[i];
            }
            toppinguri[comanda.topping.Length] = tp;
            comanda.topping = toppinguri;

            return comanda;


        }
    }
}
