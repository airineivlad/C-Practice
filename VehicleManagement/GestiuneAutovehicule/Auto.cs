using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiuneAutovehicule
{
    [Serializable]
    public class Auto:Vehicul
    {
        private float putere;

        public float Putere
        {
            get { return putere; }
            set { putere = value; }
        }

        public Auto(int id, string marca, float putere):base(id,marca)
        {
            this.putere = putere;
        }


        public static bool operator <(Auto a1, Auto a2)
        {
            return a1.Putere<a2.Putere;
        }

        public static bool operator >(Auto a1, Auto a2)
        {
            return a1.Putere > a2.Putere;
        }

        public static float operator +(Auto a1, Auto a2)
        {
            return a1.Putere + a2.Putere;
        }

        public string ToString()
        {
            return this.Id + " " + this.Marca + " " + this.Putere;
        }
    }
}
