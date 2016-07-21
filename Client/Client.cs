using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Client
    {
        private readonly int cod;
        private String nume;
        private String adresa;

        public Client()
        {

        }

        public Client(int cod, String nume, String adresa) {
            this.cod = cod;
            this.nume = nume;
            this.adresa = adresa;

        }

        public int getCod() {

            return this.cod;
        }

        public String getNume() {

            return this.nume;
        }

        public void setNume(String value) {
            this.nume = value;
        }

        public String getAdresa() {
            return this.adresa;
        }

        public void setAdresa(String value) {
            this.adresa = value;
        }

    }
}
