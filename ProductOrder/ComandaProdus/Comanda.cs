using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComandaProdus
{
    [Serializable]
    public class Comanda
    {
        private int nr;

        public int Nr
        {
            get { return nr; }
            set { if(livrata==false) nr = value; }
        }
        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { if (livrata == false) date = value; }
        }

        private string denumireClient;

        public string DenumireClient
        {
            get { return denumireClient; }
            set { if (livrata == false) denumireClient = value; }
        }

        private List<Produs> lis;

        public List<Produs> Lis
        {
            get { return lis; }
            set { if (livrata == false) lis = value; }
        }

        private bool livrata;

        public bool Livrata
        {
            get { return livrata; }
            set { livrata = value; }
        }


        private int numarProduse;

        public int NumarProduse
        {
            get { return numarProduse; }
        }

        private decimal ValoareTotala;

        public decimal ValoareTotala1
        {
            get { return ValoareTotala; }
            set { if (livrata == false) ValoareTotala = value; }
        }

        public Comanda()
        {

        }



        public Produs this[int index]
        {
            get
            {
                return lis[index];
            }
        }

        
        public static Comanda operator +(Comanda c, Produs p){
            
            c.lis.Add(p);
            c.numarProduse++;
            c.ValoareTotala = c.ValoareTotala + p.Pret * p.Cantitate;
            return c;
        }

        public String ToString()
        {
            return this.nr + " " + this.date.ToShortDateString() + " " + this.denumireClient + " " + livrata + " " + NumarProduse + " " + ValoareTotala;
            
        }

        public Comanda(int nr, DateTime date, string denumire, bool livrata, int numarProduse, decimal valoareTotala)
        {
            this.nr = nr;
            this.date = date;
            this.denumireClient = denumire;
            this.livrata = livrata;
            this.numarProduse = numarProduse;
            this.ValoareTotala = valoareTotala;
            this.lis = new List<Produs>();

        }
    }
}
