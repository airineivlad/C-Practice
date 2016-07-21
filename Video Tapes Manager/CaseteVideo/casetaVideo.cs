using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseteVideo
{
    [Serializable]
    public class casetaVideo:IComparable,ICloneable,IMedia
    {
        
        int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        String titlu;
        public String Titlu
        {
            get { return titlu; }
            set { titlu = value; }
        }

        DateTime dataAparitie;
        public DateTime DataAparitie
        {
            get { return dataAparitie; }
            set { dataAparitie = value; }
        }

        float durata;
        public float Durata
        {
            get { return durata; }
            set { durata = value; }
        }

        float[] noteCritici;
        public float[] NoteCritici
        {
            get { return noteCritici; }
            set { noteCritici = value; }
        }

        float pret;
        public float Pret
        {
            get { return pret; }
            set { pret = value; }
        }
        
        Boolean inchiriata;

        public Boolean Inchiriata
        {
            get { return inchiriata; }
            set { inchiriata = value; }
        }

        int nrZileInchiriere;

        public int NrZileInchiriere
        {
            get { return nrZileInchiriere; }
            set { nrZileInchiriere = value; }
        }

        public casetaVideo(int id, String titlu, DateTime dataAparitie, float durata, float pret, Boolean inchiriata, int nrZileInchiriere, float[] noteCritici)
        {
            this.id = id;
            this.titlu = titlu;
            this.dataAparitie = dataAparitie;
            this.durata = durata;
            this.pret = pret;
            this.inchiriata = inchiriata;
            this.nrZileInchiriere = nrZileInchiriere;
            this.noteCritici = noteCritici;
        }

        public int CompareTo(object obj)
        {
            if (obj is casetaVideo)
            {
                casetaVideo tmp = (casetaVideo)obj;

                if (this.id == tmp.id)
                {
                    return 0;
                }
                else if (this.id > tmp.id)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                throw new Exception("Nu e obiect casetaVideo");
            }
        }

        public object Clone()
        {
            casetaVideo tmp = new casetaVideo(this.id, this.titlu, this.dataAparitie, this.durata, this.pret, this.inchiriata, this.nrZileInchiriere, this.noteCritici);
            return tmp;
        }

        public String ToString()
        {
            String sir = this.Id + " - " + this.titlu + " - " + this.dataAparitie + " - " + this.durata + " - " + this.pret + " - " + this.inchiriata + " - " + this.nrZileInchiriere + " - " ;

            foreach (var i in this.noteCritici)
            {
                sir += i + ",";
            }

            return sir;
        }

        public float noteMedia()
        {
            float notaMedie=0;
            foreach(var i in this.noteCritici){
                notaMedie += i;
            }

            notaMedie = notaMedie / this.noteCritici.Length;
            return notaMedie;
        }
    }
}
