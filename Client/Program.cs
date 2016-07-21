using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    
    class Program
    {
        [STAThreadAttribute]
        static void Main(string[] args)
        {
            Application.Run(new Form1());
            float[] vectorPlati = { 3.5f, 3.6f, 3.7f };
            float[] vectorPlati2 = { 1.2f, 1.5f, 2.3f };
            ClientRauPlatnic client1 = new ClientRauPlatnic(1, "Dina", "Voinesti", "PF", 1200, vectorPlati);
            ClientRauPlatnic client2 = (ClientRauPlatnic)client1.Clone();
            client1.setVectorPlati(vectorPlati2);
            Console.WriteLine(client1);
            Console.WriteLine(client2);
            Console.WriteLine(client1.CompareTo(client2));
            Console.WriteLine((double)client1);
            client1 = client1 + 3.6f;
            Console.WriteLine(client1);
        }
    }
}
