using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseteVideo
{
    public partial class Form2 : Form
    {
        public casetaVideo cas;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            checkNull();

            int id = Int32.Parse(tbId.Text);
            String titlu = tbTitlu.Text;
            DateTime dataAparitie = DateTime.ParseExact(tbDataAparitie.Text, "yyyy-MM-dd HH:mm", CultureInfo.CurrentCulture);
            float durata = float.Parse(tbDurata.Text);
            float pret =float.Parse(tbPret.Text);
            Boolean inc=false;
            if (tbInchiriat.Text == "1")
            {
                inc = true;
            }
            int zile = Int32.Parse(tbZileInchiriat.Text);

            float[] noteCritici;
            string aux = tbNoteCritici.Text;
            string[] s = aux.Split(',');

            noteCritici = new float[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                noteCritici[i] = float.Parse(s[i]);
            }

            casetaVideo tmp = new casetaVideo(id, titlu, dataAparitie, durata, pret, inc, zile, noteCritici);

            cas = tmp;
            this.DialogResult = DialogResult.OK;
            this.Dispose();
            MessageBox.Show("S-a adaugat  \n" + cas.ToString());

        }

        public void checkNull()
        {
            if (tbId.Text == "")
            {
                errorProvider1.SetError(tbId, "Introdu ID");
            }
            else if (tbTitlu.Text == "")
            {
                errorProvider1.SetError(tbTitlu, "Introdu titlu");
            }
            else if (tbDataAparitie.Text == "")
            {
                errorProvider1.SetError(tbDataAparitie, "Introdu Data");
            }
            else if (tbDurata.Text == "")
            {
                errorProvider1.SetError(tbDurata, "Introdu Durata");
            }
            else if (tbPret.Text == "")
            {
                errorProvider1.SetError(tbPret, "Introdu Pret");
            }
            else if (tbInchiriat.Text == "")
            {
                errorProvider1.SetError(tbInchiriat, "IntroduInchiriat");
            }
            else  if (tbZileInchiriat.Text == "")
            {
                errorProvider1.SetError(tbZileInchiriat, "Introdu Zile Inchiriat");
            }
            else if (tbNoteCritici.Text == "")
            {
                errorProvider1.SetError(tbNoteCritici, "Introdu NoteCritici");
            }
            else
            {
                errorProvider1.Clear();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }

        void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            var form = sender as Form2;

            form.FormClosed -= Form2_FormClosed;
            this.DialogResult = DialogResult.Cancel;

            this.Dispose();
        }
    }
}
