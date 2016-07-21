using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubComenzi
{
    public partial class Editare : Form
    {
        public Comanda c;
        public bool open=true;

        public Editare(Comanda i)
        {
            
            InitializeComponent();
            open = true;

            codClient.Text = i.CodClient.ToString();
            codComanda.Text = i.CodComanda.ToString();
            numeClient.Text = i.NumeClient;
            valoare.Text = i.Valoare.ToString();
            valoareAchitata.Text = i.ValoareAchitata.ToString();
            c = i;
        }

        public void ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            c.ValoareAchitata = Double.Parse(valoareAchitata.Text);
            open = false;
            this.Dispose();
        }

        public void cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            open = false;
            this.Dispose();
        }
    }
}
