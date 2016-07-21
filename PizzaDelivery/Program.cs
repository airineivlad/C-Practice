using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComenziPizza
{
    class Program
    { 
        public static void createDb()
        { 
        SQLiteConnection dbConnection;
        SQLiteConnection.CreateFile("database.db");
        dbConnection = new SQLiteConnection("Data Source=database.db");
        dbConnection.Open();
        string sql = "create table Topping(DENUMIRE TEXT NOT NULL, PRET INTEGER NOT NULL, COD INTEGER PRIMARY KEY);";
        SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
        command.ExecuteNonQuery();
        }


    
        static void Main(string[] args)
        {
            //createDb();
            Application.Run(new Form1());
            Topping topping1 = new Topping("cascaval", 15, 1);
            Topping topping2 = new Topping("ceapa", 12, 2);
            Topping[] topping = new Topping[2];
            topping[0] = topping1;
            topping[1] = topping2;
            ComandaPizza comanda1 = new ComandaPizza("comanda1", "pufos", 120, topping);
            ComandaPizza comanda2 = (ComandaPizza)comanda1.Clone();
            comanda1[0] = new Topping("usturoi", 25, 3);
            Console.WriteLine(comanda1.ToString());
            Console.WriteLine(comanda2.ToString());
        }
    }
}
