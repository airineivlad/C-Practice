using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public  ArrayList listClienti = new ArrayList();
        Form2 form = new Form2();
        public Form1()
        {
            InitializeComponent();
            float[] vectorPlati = { 3.5f, 3.6f, 3.7f };
            float[] vectorPlati2 = { 1.2f, 1.5f, 2.3f };
            float[] vectorPlati3 = { 10.2f, 15.3f, 9.6f };
            ClientRauPlatnic client1 = new ClientRauPlatnic(1, "Dina", "Voinesti", "PF", 12000, vectorPlati);
            ClientRauPlatnic client2 = new ClientRauPlatnic(2, "Sebi", "Bucuresti", "PF", 2000, vectorPlati2);
            ClientRauPlatnic client3 = new ClientRauPlatnic(3, "Chihaia", "Bucuresti", "PF", 5000, vectorPlati3);
            listClienti.Add(client1);
            listClienti.Add(client2);
            listClienti.Add(client3);
          


        }

        public void displayClienti() {
            form.listView.Items.Clear();
            foreach (ClientRauPlatnic cl in listClienti) {
                ListViewItem lv = new ListViewItem(cl.getCod().ToString());
                lv.SubItems.Add(cl.getNume());
                lv.SubItems.Add(cl.getSumaPlata().ToString());
                form.listView.Items.Add(lv);
                    }
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            int cod = 0;
            String nume = null;
            String adresa = null;
            String tip = null;
            float sumaPlata = 0;
            float[] vectorPlati = null;
            Boolean isValide = true;
            try
            {
                if (string.IsNullOrWhiteSpace(tbCod.Text))
                {
                    throw new Exception("Cod should not be empty");
                }
                else {
                    cod = int.Parse(tbCod.Text);
                }

                if (string.IsNullOrWhiteSpace(tbNume.Text))
                {
                    throw new Exception("Nume should not be empty");
                }
                else {

                    nume = tbNume.Text;
                }

                if (string.IsNullOrWhiteSpace(tbAdresa.Text))
                {

                    throw new Exception("Adresa should not pe empty");
                }
                else {

                    adresa = tbAdresa.Text;
                }

                if (string.IsNullOrWhiteSpace(tbTip.Text))
                {

                    throw new Exception("Tip should not be empty");
                }
                else {
                    tip = tbTip.Text;
                }

                if (string.IsNullOrWhiteSpace(tbSuma.Text))
                {
                    throw new Exception("Suma should not be empty");
                }
                else {
                    sumaPlata = float.Parse(tbSuma.Text);

                }
                if (string.IsNullOrWhiteSpace(tbPlati.Text))
                {
                    throw new Exception("Plati should not be empty");
                }
                else {

                    String[] args = tbPlati.Text.Split(',');
                    vectorPlati = new float[args.Length];
                    for (int i = 0; i < args.Length; i++)
                        vectorPlati[i] = float.Parse(args[i]);
                }

               

                    ClientRauPlatnic client = new ClientRauPlatnic(cod, nume, adresa, tip, sumaPlata, vectorPlati);
                    listClienti.Add(client);

                
            }
            catch (Exception et) {

                MessageBox.Show(et.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            listClienti.Sort(new DescComparer());
            
           

        }

        private void showListviewToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
            displayClienti();
            form.ShowDialog();
        }

        private void tbCod_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbCod.Clear();
        }

        private void refreshToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            tbCod.Clear();
        }
    }
}
