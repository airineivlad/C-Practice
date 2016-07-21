using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComandaProdus
{
    public partial class Form1 : Form
    {
        public List<Comanda> cs;
        int selectat;
        public Form1()
        {
            InitializeComponent();
            cs = new List<Comanda>();
            Produs p = new Produs("P", 12, 13);
            cs.Add(new Comanda(1, DateTime.Now, "Jhon ", false, 5, 15));
            cs.Add(new Comanda(2, DateTime.Now, "Snow ", false, 15, 115));
            cs.Add(new Comanda(3, DateTime.Now, "Inca ", false, 25, 215));
            cs.Add(new Comanda(4, DateTime.Now, "Traieste ", false, 35, 315));

            cs[1] += p;
            cs[2] += p;
            cs[2] += p;
            cs[2] += p;
            cs[3] += p;
            cs[3] += p;
            cs[3] += p;
            cs[3] += p;
            loadView();
        }

        public void loadView()
        {
            listView1.Items.Clear();
            foreach (Comanda it in cs)
            {
                ListViewItem itm= new ListViewItem(it.Nr.ToString());
                itm.SubItems.Add(it.Date.ToShortDateString());
                itm.SubItems.Add(it.DenumireClient);

                string pr=null;
                foreach(Produs p in it.Lis){
                    pr = pr + " " + p.ToString();
                }
                itm.SubItems.Add(pr);
                itm.SubItems.Add(it.Livrata.ToString());
                itm.SubItems.Add(it.NumarProduse.ToString());
                itm.SubItems.Add(it.ValoareTotala1.ToString());

                listView1.Items.Add(itm);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produs p = new Produs("P", 12, 13);
            
            Comanda c = new Comanda(1, DateTime.Now, "Comanda 1 ", false, 5, 15);
            c += p;
            c += p;
            
            MessageBox.Show(c.Lis[0].ToString() + " " +c.Lis[1].ToString());
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            int ind = listView1.SelectedIndices[0];
            selectat = ind;
            Comanda c = cs[ind];

            tbNume.Text = c.DenumireClient.ToString();
            tbData.Text = c.Date.ToShortDateString();
            tbNumar.Text = c.Nr.ToString();
            tbLivrata.Text = c.Livrata.ToString();

            statusStrip1.Items.Clear();
            statusStrip1.Items.Add("Numar Produse: " + c.NumarProduse);
            statusStrip1.Items.Add("Valoare totala: " + c.ValoareTotala1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cs[selectat].Nr = Int32.Parse(tbNumar.Text);
            cs[selectat].DenumireClient = tbNume.Text;
            cs[selectat].Livrata = bool.Parse(tbLivrata.Text);
            cs[selectat].Date = DateTime.Parse(tbData.Text);
            statusStrip1.Items.Add("Modified...");

            loadView();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 add = new Form2();
            add.ShowDialog();

            int ok = 1;

            while (ok == 1)
            {
                if (add.IsDisposed)
                {
                    if (add.DialogResult == DialogResult.OK)
                    {
                        cs[selectat] += add.p;
                        loadView();
                        ok = 0;
                    }

                    if (add.DialogResult == DialogResult.Cancel)
                    {
                        ok = 0;
                    }
                }
            }
        }

        private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void deserializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void serializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("serializate.dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(fs, cs);
            fs.Close();
        }

        private void deserializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("serializate.dat", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            cs = (List<Comanda>)(bf.Deserialize(fs));
            fs.Close();
            loadView();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Show();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            g.DrawString("Raport comenzi: ", Font, new SolidBrush(Color.Blue), 10, 10);

            int dist = 25;
            foreach (Comanda c in cs)
            {
                g.DrawString("Comanda : " + c.ToString(), Font, new SolidBrush(Color.Blue), 10, 10 + dist);
                g.DrawString("Produse" , Font, new SolidBrush(Color.Blue), 10, 10 + dist+20);
                Rectangle line = new Rectangle(10, 10 + dist + 35, 350, 5);
                g.FillRectangle(new SolidBrush(Color.Blue), line);
                int d = 50;
                foreach (Produs p in c.Lis)
                {
                    g.DrawString(p.ToString(), Font, new SolidBrush(Color.Blue), 10, 10 + dist + d);
                    Rectangle line1 = new Rectangle(10, 10 + dist + d + 15, 350, 5);
                    g.FillRectangle(new SolidBrush(Color.Blue), line1);

                    d = d + 30;
                }

                dist = dist + d + 40;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "Text Files (*.txt)|*.txt";
            sv.Title = "Salvare fisier";
            sv.ShowDialog();

            if (sv.FileName != null)
            {
                FileStream f = (FileStream)sv.OpenFile();

                string s="";

                foreach(Comanda c in cs){
                    s += c.ToString() + Environment.NewLine;
                }

                byte[] info = new UTF8Encoding(true).GetBytes(s);
                f.Write(info, 0, info.Length);
                f.Close();


            }
            
        }


    }
}
