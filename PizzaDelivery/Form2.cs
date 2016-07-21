using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComenziPizza
{
    public partial class Form2 : Form
    {
        List<Topping> listaTopping = new List<Topping>();
        public void loadDatabase() {

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
            foreach(Topping tp in listaTopping) {
                checkedList.Items.Add(tp.denumire + " " + tp.pret + " " + tp.cod);

            }            
        }

        public Form2()
        {
            InitializeComponent();
            loadDatabase();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
