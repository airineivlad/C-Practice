using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class ClientRauPlatnic: Client, ICloneable, IComparable<ClientRauPlatnic>, IMedia
    {
        private String tipClient;
        private float sumaPlata;
        private float[] vectorPlati;

        public ClientRauPlatnic() {
        }

        public ClientRauPlatnic(int cod, String nume, String adresa, String tipClient, float sumaPlata, float[] vectorPlati):base(cod, nume, adresa) {
            this.tipClient = tipClient;
            this.sumaPlata = sumaPlata;
            this.vectorPlati = vectorPlati;
        }

        public String getTipClient() {
            return this.tipClient;
        }

        public void setTipClient(String value) {
            this.tipClient = value;
        }

        public float getSumaPlata() {
            return this.sumaPlata;
        }

        public void setSumaPlata(float value) {
            this.sumaPlata = value;

        }

        public float[] getVectorPlati() {
            return this.vectorPlati;
        }

        public void setVectorPlati(float [] vector) {
            this.vectorPlati = vector;
        }

        public object Clone()
        {
            ClientRauPlatnic tmp = null;
            tmp = new ClientRauPlatnic(this.getCod(), this.getNume(), this.getAdresa(), this.getTipClient(), this.getSumaPlata(), (float[])this.vectorPlati.Clone());
            return tmp;
        }

        public int CompareTo(ClientRauPlatnic other)
        {
            var tipOrder = this.tipClient.CompareTo(other.tipClient);
            if (tipOrder == 0)
                return this.sumaPlata.CompareTo(other.sumaPlata);
            return tipOrder;
        }

        public static ClientRauPlatnic operator +(ClientRauPlatnic client, float valoare) {
            float[] copie = new float[client.vectorPlati.Length+1];
            for (int i = 0; i < client.vectorPlati.Length; i++)
                copie[i] = client.vectorPlati[i];
            copie[client.vectorPlati.Length] = valoare;
            client.vectorPlati = copie;
            return client;
        }

        public static explicit operator double(ClientRauPlatnic client) {

            return client.vectorPlati.Sum() / client.vectorPlati.Length;
        }

        public override string ToString()
        {
            return String.Format("Cod:{0}, Nume:{1}, Adresa:{2}, Tip:{3}, Suma:{4}, Vector:{5} ", this.getCod(), this.getNume(), this.getAdresa(), this.getTipClient(), this.getSumaPlata(), String.Join(",", this.vectorPlati));
        }

        public double calculeazValoareMediePlatita()
        {
            return this.vectorPlati.Sum() / this.vectorPlati.Length;
        }

        public int Compare(ClientRauPlatnic x, ClientRauPlatnic y)
        {
            if (x.sumaPlata > y.sumaPlata)
                return -1;
            else
                if (x.sumaPlata < y.sumaPlata)
                return 1;
            else return 0;
        }
    }
}
