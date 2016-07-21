using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiuneAutovehicule
{
    public partial class Form1 : Form
    {
        List<Auto> ls;
        int selectat;

        SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            ls = new List<Auto>();
            ls.Add(new Auto(1, "Dacia", 199));
            ls.Add(new Auto(2, "BeMeWeu", 169));
            ls.Add(new Auto(3, "Trabi", 666));
            ls.Add(new Auto(4, "Olcit", 250));
            selectat = 0;

            setTB(selectat);

            deseneazaBare();

            refreshCombo();
        }

        public void setTB(int sel)
        {
            tbId.Text = ls[sel].Id.ToString();
            tbMarca.Text = ls[sel].Marca;
            tbPutere.Text = ls[sel].Putere.ToString();
            refreshOrdineLabel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Auto a1 = new Auto(1, "Dacia", 199);
            Auto a2 = new Auto(2, "BeMeWeu", 169);

            MessageBox.Show(a1.ToString() + "\n" + a2.ToString());
            MessageBox.Show((a1<a2).ToString());
            MessageBox.Show((a1 + a2).ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectat--;

            if (selectat < 0)
            {
                selectat = ls.Count - 1;
            }

            setTB(selectat);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectat++;

            if (selectat == ls.Count )
            {
                selectat = 0;
            }

            setTB(selectat);
            
        }

        public void refreshOrdineLabel()
        {
            ordineLabel.Text = "Inregistrarea " + (selectat + 1) + " din " + ls.Count.ToString();
        }

        private void tbId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                button2_Click(this, new EventArgs());
            }

            if (e.KeyCode == Keys.Down)
            {
                button3_Click(this, new EventArgs());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ls[selectat].Id = Int32.Parse(tbId.Text);
            ls[selectat].Marca = tbMarca.Text;
            ls[selectat].Putere = float.Parse(tbPutere.Text);

            MessageBox.Show("Inregistrarea s-a modificat...");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='D:\ASE\Anul 2\PAW\Examen\GestiuneAutovehicule\GestiuneAutovehicule\Database1.mdf';Integrated Security=True");
            conn.Open();

            //if(conn!=null){
            //    MessageBox.Show("conectat");
            //}
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Auto";

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string marca = reader.GetString(1);
                string putere = reader.GetString(2);

                Auto tmp = new Auto(id, marca, float.Parse(putere));
                MessageBox.Show("Se adauga in lista elementul " + tmp.ToString());
                ls.Add(tmp);
            }

            deseneazaBare();
            refreshCombo();
            conn.Close();
        }
        public void deseneazaBare()
        {
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
            panel1.Invalidate();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.DrawString("Puterile automobilelor:", Font, new SolidBrush(Color.Black), 10, 10);
            Rectangle zona = new Rectangle(10, 25, 410, 230);

            //g.FillRectangle(new SolidBrush(Color.Blue), zona);
            int x = zona.X;
            int y = zona.Y;
            int h = zona.Height;
            int w = zona.Width;

            float putereMaxima = putereMax();
            int dist = 0;
            int hei = (h - 50) / ls.Count; 
            foreach (Auto it in ls)
            {
                int wid = (int)(w * (it.Putere / putereMaxima));
                //int hei = 20;
                Rectangle pt = new Rectangle(x, y + dist, wid, hei);
                g.FillRectangle(new SolidBrush(Color.Blue), pt);
                g.DrawString(it.Marca + it.Id, Font, new SolidBrush(Color.White), x + 2, y + dist + 3);

                dist += hei+10;
            }
            
        }

        public float putereMax()
        {
            float max = -1;
            foreach (Auto it in ls)
            {
                if (it.Putere > max)
                {
                    max = it.Putere;

                }
            }
            return max;
        }

        public float putereMedie()
        {
            
            Auto m = new Auto(0, "Medie", 0);
            foreach (Auto it in ls)
            {
                m.Putere = m + it;
            }

            m.Putere = m.Putere / ls.Count;

            return m.Putere;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Putere medie este " + putereMedie().ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBox1.SelectedItem.ToString() + " " + comboBox1.SelectedIndex.ToString());
            selectat = comboBox1.SelectedIndex;
            setTB(selectat);
        }

        public void refreshCombo()
        {
            comboBox1.Items.Clear();
            foreach (Auto it in ls)
            {
               comboBox1.Items.Add(it.Marca);
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string s = System.Windows.Forms.Clipboard.GetData(DataFormats.Text).ToString();
            string[] elems = s.Split(';');

            int id = Int32.Parse(elems[0]);
            string marca = elems[1];
            float putere = float.Parse(elems[2]);

            Auto tmp = new Auto(id, marca, putere);
            ls.Add(tmp);
            refreshCombo();
            deseneazaBare();
            MessageBox.Show("Se adauga elementul " + tmp.ToString());
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
