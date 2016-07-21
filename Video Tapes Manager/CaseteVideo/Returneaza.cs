using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseteVideo
{
    public partial class Returneaza : Form
    {
        public List<casetaVideo> caseteVideoList;
        public Returneaza(List<casetaVideo> caseteVideoList)
        {
            InitializeComponent();
            this.caseteVideoList = caseteVideoList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(tbId.Text);
            int ok = 0;

            foreach (casetaVideo it in caseteVideoList)
            {
                if (it.Id == id)
                {
                    it.Inchiriata = false;
                    it.NrZileInchiriere = 0;
                    this.DialogResult = DialogResult.OK;
                    ok = 1;

                }
            }

            if (ok == 0)
            {
                MessageBox.Show("Nu s-a gasit elementul cu id " + id);
            }

            this.Dispose();
        }

        void Returneaza_FormClosed(object sender, FormClosedEventArgs e)
        {
            var form = sender as Form2;

            form.FormClosed -= Returneaza_FormClosed;
            this.DialogResult = DialogResult.Cancel;

            this.Dispose();
        }
    }
}
