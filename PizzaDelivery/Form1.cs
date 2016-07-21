using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ComenziPizza
{
    public partial class Form1 : Form

    {

        List<ComandaPizza> comandaList = new List<ComandaPizza>();
        public Form1()
        {
            InitializeComponent();
        }

        public void loadDatabase()
        {
            List<Topping> listaTopping = new List<Topping>();
            const string stringSql = "Select * from Topping";
            SQLiteConnection dbConnection = new SQLiteConnection("Data Source=database.db");
            dbConnection.Open();
            SQLiteCommand command = new SQLiteCommand(stringSql, dbConnection);
            SQLiteDataReader sqlReader = command.ExecuteReader();

            while (sqlReader.Read())
            {
                listaTopping.Add(new Topping((string)sqlReader["Denumire"], float.Parse(sqlReader["Pret"].ToString()), int.Parse(sqlReader["Cod"].ToString())));


            }
            dbConnection.Close();
            foreach (Topping tp in listaTopping)
            {
                checkedList.Items.Add(tp.denumire + "," + tp.pret + "," + tp.cod);

            }
        }



        private void addTreeView(ComandaPizza comanda)
        {


            if (comanda.blat.Equals("Pufos"))
                treeView.Nodes[0].Nodes.Add(comanda.nume);
            else if (comanda.blat.Equals("Crocant"))
                treeView.Nodes[1].Nodes.Add(comanda.nume);
            else if (comanda.blat.Equals("Clasic"))
                treeView.Nodes[2].Nodes.Add(comanda.nume);
            else
                treeView.Nodes[3].Nodes.Add(comanda.nume);
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void openFormularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean isValide = true;
            ComandaPizza comanda = null;
            String nume = null;
            String blat = null; ;
            int durata = 0;
            Topping[] topping = null;
            try
            {
                if (string.IsNullOrWhiteSpace(tbNume.Text))
                    isValide = false;
                else {
                    nume = tbNume.Text;
                }

                if (tbBlat.SelectedIndex == -1)
                    isValide = false;
                else {
                    blat = tbBlat.SelectedItem.ToString();
                }

                if (tbDurata.Value == 0)
                    isValide = false;
                else {
                    durata = decimal.ToInt32(tbDurata.Value);
                }

                if (string.IsNullOrWhiteSpace(tbTopping.Text))
                {
                    isValide = false;
                }
                else {
                    String[] args = tbTopping.Text.ToString().Split(',');
                    topping = new Topping[args.Length];
                    int j = 0;
                    for (int i = 0; i < args.Length - 2; i += 3)
                    {
                        String numeTop = args[i];
                        float pret = float.Parse(args[i + 1]);
                        int cod = int.Parse(args[i + 2]);
                        Topping top = new Topping(numeTop, pret, cod);
                        topping[j] = top;
                        j++;
                    }
                }
                if (isValide == false)
                    throw new Exception();
                else {
                    comanda = new ComandaPizza(nume, blat, durata, topping);
                    comandaList.Add(comanda);
                    addTreeView(comanda);
                }
            }
            catch (Exception ev)
            {
                MessageBox.Show("The form contain errors!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<ComandaPizza>));
            using (StreamWriter writer = new StreamWriter("SerialiazedXML.xml"))
            {
                serializer.Serialize(writer, comandaList);
            }
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView.Nodes[0].Nodes.Clear();
            treeView.Nodes[1].Nodes.Clear();
            treeView.Nodes[2].Nodes.Clear();
            treeView.Nodes[3].Nodes.Clear();
            XmlSerializer serializer = new XmlSerializer(typeof(List<ComandaPizza>));
            using (StreamReader reader = new StreamReader("SerialiazedXML.xml"))
            {
                comandaList = (List<ComandaPizza>)serializer.Deserialize(reader);
            }
            foreach (ComandaPizza comanda in comandaList)
                addTreeView(comanda);
        }

        private void getDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkedList.Visible = true;
            loadDatabase();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            ComandaPizza c = null;
            foreach (ComandaPizza comanda in comandaList)
                if (comanda.nume.Equals(treeView.SelectedNode.Text))
                {
                    c = comanda;
                    String[] args = checkedList.SelectedItem.ToString().Split(',');
                    Topping top = new Topping(args[0], float.Parse(args[1]), int.Parse(args[2]));
                    c = c + top;
                }
            foreach (ComandaPizza comanda in comandaList)
                Console.WriteLine(comanda);
        }
    }
}