using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubComenzi
{
    public class Comanda
    {
        int codClient;

        public int CodClient
        {
            get { return codClient; }
            set { codClient = value; }
        }
        int codComanda;

        public int CodComanda
        {
            get { return codComanda; }
            set { codComanda = value; }
        }
        string numeClient;

        public string NumeClient
        {
            get { return numeClient; }
            set { numeClient = value; }
        }
        double valoare;

        public double Valoare
        {
            get { return valoare; }
            set { valoare = value; }
        }
        double valoareAchitata;

        public double ValoareAchitata
        {
            get { return valoareAchitata; }
            set { valoareAchitata = value; }
        }

        public Comanda(int codClient, int codComanda, string numeClient, double valoare, double valoareAchitata)
        {
            this.codClient = codClient;
            this.codComanda = codComanda;
            this.numeClient = numeClient;
            this.valoare = valoare;
            this.valoareAchitata = valoareAchitata;
        }

        public String ToString()
        {
            return codClient + " " + codComanda + " " + numeClient + " " + valoare + " " + valoareAchitata;
        }

    }
}
