using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb;
            DialogResult result = saveFileDialog1.ShowDialog();
            using (StreamWriter writer = new StreamWriter(saveFileDialog1.OpenFile()))
            {
                
                    foreach (ListViewItem lvi in listView.Items)
                    {

                        sb = new StringBuilder();
                        foreach (ListViewItem.ListViewSubItem listViewSubItem in lvi.SubItems)
                        {
                            sb.Append(string.Format("{0}\t", listViewSubItem.Text));
                        }
                        writer.WriteLine(sb.ToString());
                    }
                    writer.WriteLine();


               
            }
        }
    }
}
