using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubComenzi
{
    public partial class Form1 : Form
    {
        OleDbConnection conn = new OleDbConnection();
        Dictionary<int, string> Clienti;
        List<Comanda> comenzi;
        int idSelectat;
        public Form1()
        {
            InitializeComponent();

            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\ASE\Anul 2\PAW\Examen\SubComenzi\Comenzi.accdb;
Persist Security Info=False;";
            conn.Open();

            Clienti = new Dictionary<int, string>();
            comenzi = new List<Comanda>();
            idSelectat = -1;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommand cmdClienti = new OleDbCommand();
            cmdClienti.Connection = conn;
            cmdClienti.CommandText = "select * from Clienti";
            OleDbDataReader r1 = cmdClienti.ExecuteReader();

            while (r1.Read())
            {
                var id = r1.GetInt32(0);
                int codClient = r1.GetInt32(1);
                string numeClient = r1.GetString(2);

                if (!Clienti.ContainsKey(codClient))
                {

                    Clienti.Add(codClient, numeClient);
                }
            }

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;

            cmd.CommandText = "select * from Comenzi";

            OleDbDataReader reader = cmd.ExecuteReader();
          
            while (reader.Read())
            {
                
                var id = reader.GetInt32(0);
                var codClient = reader.GetInt32(1);
                var codComanda = reader.GetInt32(2);
                var valoare = reader.GetInt32(3);

                //consola.AppendText(id + " " + codClient + " " + codComanda + " " + Clienti[codClient] + " " + valoare + "\n");

                Comanda c1 = new Comanda(codClient, codComanda, Clienti[codClient], valoare, 0);
                addElemListView(c1);

                comenzi.Add(c1);
            }

            foreach (Comanda it in comenzi)
            {
                
                consola.AppendText("Se incarca comanda " + it.ToString() + " \n");
            }

            


            reader.Close();

        }

        public void addElemListView(Comanda c)
        {
            ListViewItem i = new ListViewItem(c.CodClient.ToString());
            i.SubItems.Add(c.CodComanda.ToString());
            i.SubItems.Add(c.NumeClient);
            i.SubItems.Add(c.Valoare.ToString());
            i.SubItems.Add(c.ValoareAchitata.ToString());

            listView1.Items.Add(i);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int distance = 50;
            g.DrawString("List View: ", Font, new SolidBrush(Color.Blue), 10, 10);
            foreach (Comanda it in comenzi)
            {

                g.DrawString(it.ToString(), Font, new SolidBrush(Color.Blue), 10, 10 + distance);
                distance = distance + 50;
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var ind = listView1.SelectedIndices;
            ListViewItem it = listView1.Items[ind[0]];
            int codClient = Int32.Parse(it.Text);
            int codComanda = Int32.Parse(it.SubItems[1].Text);
            string nume = it.SubItems[2].Text;
            double valoare = Double.Parse(it.SubItems[3].Text);
            double valoareAchitata = Double.Parse(it.SubItems[4].Text);
            //MessageBox.Show(codClient + " " + codComanda);

            Editare edit = new Editare(new Comanda(codClient, codComanda, nume, valoare, valoareAchitata));
            edit.ShowDialog();

            int ok = 1;

            while (ok == 1)
            {
                if (edit.IsDisposed)
                {
                    ok = 0;
                    if (edit.DialogResult == DialogResult.OK)
                    {
                        listView1.Items[ind[0]].SubItems[4].Text = edit.c.ValoareAchitata.ToString();

                    }

                    if (edit.DialogResult == DialogResult.Cancel)
                    {
                        ok = 0;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Editare edit = new Editare(new Comanda(123, 123, "Nume", 12, 13));
            edit.Show();
            int oki = 0;

            //while (Application.OpenForms.Count != 1)
            //{
            //    MessageBox.Show("editeaza valoarea");
            //}

            //if (edit.DialogResult == DialogResult.OK)
            //{
            //    MessageBox.Show("OK");
            //}


        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyData == (Keys.Control | Keys.S))
            {
                MessageBox.Show("Se salveaza datele...");
                int i;

                for (i = 0; i < listView1.Items.Count; i++)
                {
                    ListViewItem it = listView1.Items[i];
                    consola.AppendText("Se face update la comanda clientului " + it.Text + " cu codul " + it.SubItems[1].Text + " cu valoarea " + (Double.Parse(it.SubItems[3].Text) - Double.Parse(it.SubItems[4].Text)) + "\n");
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "update Comenzi set valoare=" + (Double.Parse(it.SubItems[3].Text) - Double.Parse(it.SubItems[4].Text)) + " where codComanda=" + it.SubItems[1].Text;
                    cmd.ExecuteNonQuery();

                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //MessageBox.Show(idSelectat);
            if (idSelectat!=-1)
            {
                g.DrawString("Comanda " + listView1.Items[idSelectat].SubItems[1].Text, Font, new SolidBrush(Color.Blue), 10, 10);
                double valoare = Double.Parse(listView1.Items[idSelectat].SubItems[3].Text);
                double valoareAchitata = Double.Parse(listView1.Items[idSelectat].SubItems[4].Text);
                int x = panel1.ClientRectangle.X;
                int y = panel1.ClientRectangle.Y;
                int h = panel1.ClientRectangle.Height;
                int w = panel1.ClientRectangle.Width;
                Rectangle zona = new Rectangle(x + (h / 2) -10, y + 30, 70, h - 30);
                g.FillRectangle(new SolidBrush(Color.Blue), zona);
                g.DrawString(valoare.ToString(), Font, new SolidBrush(Color.White), x + (h / 2) + 23, y + 30);

                double procent = (double)(valoareAchitata / valoare);
                //MessageBox.Show((procent * 100).ToString());

                int inaltime = (int)((h - 30) * procent);
                int diferenta = (int)((h - 30) * (1-procent));

                Rectangle pr = new Rectangle(x + (h / 2) -10d , y + 30 + diferenta , 70, inaltime+5);
                g.FillRectangle(new SolidBrush(Color.SkyBlue), pr);
                g.DrawString((procent * 100).ToString() + "%", Font, new SolidBrush(Color.White), x + (h / 2) + 20, y + 30 + diferenta);

                if (valoareAchitata == 0)
                {
                    g.DrawString("0%", Font, new SolidBrush(Color.White), x + (h / 2) + 20, y + h - 15);

                }
            }
           
        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            idSelectat = listView1.SelectedIndices[0];

            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
            panel1.Invalidate();
        }

        
   }

} 

