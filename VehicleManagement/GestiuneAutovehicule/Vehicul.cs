using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiuneAutovehicule
{
    [Serializable]
    public class Vehicul
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string marca;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public Vehicul(int id, string marca)
        {
            this.id = id;
            this.marca = marca;

        }


    }
}
