using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseteVideo
{
    
    public partial class Form1 : Form
    {
        public List<casetaVideo> caseteVideoList;
        public int idDesenat;
        public Form1()
        {
            InitializeComponent();
            caseteVideoList = new List<casetaVideo>();

            add5casete();

            actualizeazaView();

            initDesen();
        }

        void initDesen()
        {
            idDesenat = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            panel1.Invalidate();
        }

        void add5casete()
        {
            float[] f1={5.3f,10.0f,7.3f};
            casetaVideo c1= new casetaVideo(3,"Goodfellas",DateTime.Today,125.53f,17.99f,false,5,f1);
            float[] f2 = { 9.0f, 9.7f, 9.4f };
            casetaVideo c2 = new casetaVideo(1, "Godfather I", DateTime.Today, 185.53f, 29.99f, true, 6, f2);
            float[] f3 = { 6.3f, 3.3f, 8.8f, 9.9f };
            casetaVideo c3 = new casetaVideo(2, "Se7en", DateTime.ParseExact("1995-06-13 13:26", "yyyy-MM-dd HH:mm", CultureInfo.CurrentCulture), 97.53f, 13.99f, false, 8, f3);
            float[] f4 = { 7.3f, 5.8f, 10.0f };
            casetaVideo c4 = new casetaVideo(7, "Casino", DateTime.ParseExact("2001-02-13 00:00", "yyyy-MM-dd HH:mm", CultureInfo.CurrentCulture), 97.53f, 13.99f, false, 2, f4);
            float[] f5 = { 5.5f,2.3f, 1.8f, 9.9f };
            casetaVideo c5 = new casetaVideo(5, "Kill Bill", DateTime.ParseExact("1998-06-13 13:26", "yyyy-MM-dd HH:mm", CultureInfo.CurrentCulture), 97.53f, 13.99f, false, 8, f5);
            
            caseteVideoList.Add(c1);
            caseteVideoList.Add(c2);
            caseteVideoList.Add(c3);
            caseteVideoList.Add(c4);
            caseteVideoList.Add(c5);
        }

        void actualizeazaView()
        {
            foreach (casetaVideo it in caseteVideoList)
            {
                addElementView(it);
            }

        }

        private void Adauga_Click(object sender, EventArgs e)
        {
            Form2 macheta = new Form2();
            macheta.ShowDialog();

            int ok = 1;

            while (ok==1)
            {
                if (macheta.IsDisposed)
                {
                    ok = 0;
                    if (macheta.DialogResult == DialogResult.OK) { 
                    caseteVideoList.Add(macheta.cas);
                    addElementView(macheta.cas);
                    }
                }

                if (macheta.DialogResult == DialogResult.Cancel)
                {
                    ok = 0;
                }
            }
        }

        public void addElementView(casetaVideo it)
        {
            ListViewItem itm = new ListViewItem(it.Id.ToString());
            itm.SubItems.Add(it.Titlu);
            itm.SubItems.Add(it.DataAparitie.ToShortDateString());
            itm.SubItems.Add(it.Durata.ToString());
            itm.SubItems.Add(it.Pret.ToString());
            itm.SubItems.Add(it.Inchiriata.ToString());
            itm.SubItems.Add(it.NrZileInchiriere.ToString());
            string s = "";
            foreach (float i in it.NoteCritici)
            {
                s += i + ", ";
            }
            itm.SubItems.Add(s);

            listView1.Items.Add(itm);
        }

        void sortList()
        {
            caseteVideoList.Sort();
        }

        private void sortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortList();
            listView1.Items.Clear();
            actualizeazaView();
        }

        private void btnInchiriaza_Click(object sender, EventArgs e)
        {
            Inchiriaza inc = new Inchiriaza(caseteVideoList);
            inc.ShowDialog();

            int ok = 1;

            while (ok == 1)
            {
                if (inc.IsDisposed)
                {
                    ok = 0;

                    if (inc.DialogResult == DialogResult.OK)
                    {
                        caseteVideoList = inc.caseteVideoList;
                        listView1.Items.Clear();
                        actualizeazaView();
                    }
                }

                if (inc.DialogResult == DialogResult.Cancel)
                {
                    ok = 0;
                }
            }
        }

        private void btnSalveazaFisier_Click(object sender, EventArgs e)
        {
            SaveFileDialog stf = new SaveFileDialog();
            stf.Filter = "Text Filest (*.txt)|*.txt|All files (*.*)|*.*";
            stf.Title = "Salvare fisier text";
            stf.ShowDialog();

            if (stf.FileName != null)
            {
                System.IO.FileStream f = (System.IO.FileStream)stf.OpenFile();
                string s = "";

                foreach (casetaVideo it in caseteVideoList)
                {
                    s += it.ToString() + Environment.NewLine;
                }

                byte[] info = new UTF8Encoding(true).GetBytes(s);
                f.Write(info, 0, info.Length);
                f.Close();
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("CaseteVideo.dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, caseteVideoList);
            fs.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("CaseteVideo.dat", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();

            caseteVideoList = (List<casetaVideo>)bf.Deserialize(fs);
            fs.Close();

            actualizeazaView();
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            Graphics g = e.Graphics;

            g.DrawString("Lista casete video:", Font, new SolidBrush(Color.BlueViolet), new Point(10, 10));

            int distanta = 0;
            int x = 10;
            
            foreach (var it in caseteVideoList){
                

                Rectangle zona = new Rectangle(x, distanta, 150, 200);
                
                int vl = zona.Left, vr = zona.Right, vt = zona.Top, vb = zona.Bottom;
                float max = 10;
                float rapDistLat = (float)0.2;
                int n = it.NoteCritici.Length;
                int lat = (int)((vr - vl) / (n + (n + 1) * rapDistLat));
                int dist = (int)(rapDistLat * lat);
                Rectangle rCrt;

                for (int i = 0; i < it.NoteCritici.Length; i++)
                {
                    rCrt = new Rectangle(
                        vl + dist + i * (lat + dist), vb - (int)((it.NoteCritici[i] * (vr - vl)) / max),
                        lat, (int)((int)((it.NoteCritici[i] * (vr - vl)) / max))
                        );

                    g.FillRectangle(new SolidBrush(Color.DarkBlue), rCrt);
                    g.DrawString(it.NoteCritici[i].ToString(), Font, new SolidBrush(Color.White), new Point(vl + dist + i * (lat + dist) + ((lat - 15) / 2), vb - (int)((it.NoteCritici[i] * (vr - vl)) / max)));
                    
                }

                g.DrawString(it.ToString(), Font, new SolidBrush(Color.BlueViolet), new Point(x, distanta+220));
                distanta += 210;

                if (distanta > e.PageSettings.PrintableArea.Height)
                {
                    
                    distanta = 0;
                    x = (int)(e.PageSettings.PrintableArea.Width/2+30);
                }
                
            }
        
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void adaugaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Adauga_Click(this, new EventArgs());
        }

        private void inchiriazaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnInchiriaza_Click(this, new EventArgs());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Returneaza inc = new Returneaza(caseteVideoList);
            inc.ShowDialog();

            int ok = 1;

            while (ok == 1)
            {
                if (inc.IsDisposed)
                {
                    ok = 0;

                    if (inc.DialogResult == DialogResult.OK)
                    {
                        caseteVideoList = inc.caseteVideoList;
                        listView1.Items.Clear();
                        actualizeazaView();
                    }
                }

                if (inc.DialogResult == DialogResult.Cancel)
                {
                    ok = 0;
                }
            }
        }

        private void returneazaCasetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(this, new EventArgs());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sortToolStripMenuItem_Click(this, new EventArgs());
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            if (idDesenat != 0)
            {
                casetaVideo c = null;
                foreach(var it in caseteVideoList){
                    if (it.Id == idDesenat)
                    {
                        c = it;

                    }
                }

                g.DrawString("Note critici " + c.Titlu, Font, new SolidBrush(Color.DarkBlue), new Point(10, 10));

                RectangleF R = panel1.ClientRectangle;

                Rectangle zona = new Rectangle((int)(R.X) + 30, (int)(R.Y) +60, (int)(R.Width) - 60, (int)(R.Height) - 60);
                //g.DrawRectangle(new Pen(Color.Black, 3), zona);
                int vl = zona.Left, vr = zona.Right, vt = zona.Top, vb = zona.Bottom;
                float max = 10;
                float rapDistLat = (float)0.2;
                int n = c.NoteCritici.Length;
                int lat = (int)((vr - vl) / (n + (n + 1) * rapDistLat));
                int dist = (int)(rapDistLat * lat);
                Rectangle rCrt;

                for (int i = 0; i < c.NoteCritici.Length; i++)
                {
                    rCrt = new Rectangle(
                        vl + dist + i * (lat + dist), vb - (int)((c.NoteCritici[i] * (vr - vl)) / max),
                        lat, (int)((int)((c.NoteCritici[i] * (vr - vl)) / max) )
                        );

                    g.FillRectangle(new SolidBrush(Color.DarkBlue), rCrt);
                    g.DrawString(c.NoteCritici[i].ToString(), Font, new SolidBrush(Color.White), new Point(vl + dist + i * (lat + dist) +((lat-15)/2), vb - (int)((c.NoteCritici[i] * (vr - vl)) / max)));
                }
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            var indices = listView1.SelectedIndices;

            ListViewItem itm = listView1.Items[indices[0]];
            int id = Int32.Parse(itm.Text);
            idDesenat = id;
            //MessageBox.Show(id.ToString());

            this.panel1.Paint -= new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);

            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);


            panel1.Invalidate();//forteaza sa se faca desenul
        }

        private void incarcaDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\ASE\Anul 2\PAW\Proiect - Airinei Vlad - Grupa 1032\Airinei Vlad - 1032 - Inchiriere Casete Video\CaseteVideo.accdb;
Persist Security Info=False;";

                conn.Open();
                

                foreach (casetaVideo it in caseteVideoList)
                {
                    OleDbCommand comanda = new OleDbCommand();
                    comanda.Connection = conn;
                    comanda.CommandText = "insert into Casete (Titlu,DataAparitie,Durata,Pret,Inchiriata,NumarZile,NoteCritici) values (?,?,?,?,?,?,?)";

                    comanda.Parameters.Add("Titlu", OleDbType.Char, 100).Value = it.Titlu;
                    comanda.Parameters.Add("DataAparitie", OleDbType.Char, 100).Value = it.DataAparitie.ToShortDateString();
                    comanda.Parameters.Add("Durata", OleDbType.Numeric, 100).Value = it.Durata;
                    comanda.Parameters.Add("Pret", OleDbType.Numeric, 100).Value = it.Pret;
                    comanda.Parameters.Add("Inchiriata", OleDbType.Char, 100).Value = it.Inchiriata.ToString();
                    comanda.Parameters.Add("NumarZile", OleDbType.Numeric, 2).Value = it.NrZileInchiriere;
                    String sirNoteCritici=" ";
                    foreach (var i in it.NoteCritici)
                    {
                        sirNoteCritici += i + ",";
                    }
                    comanda.Parameters.Add("NoteCritici", OleDbType.Char, 100).Value = sirNoteCritici;
                    MessageBox.Show("Se insereaza elementul \n" +it.ToString());
                    comanda.ExecuteNonQuery();
                }


                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            
            
        }


    }
}
