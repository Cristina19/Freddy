using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Freddy
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            using (StreamReader reader = new StreamReader("nume.txt"))
            {
                label2.Text = "    Jocul este foarte simplu, " + reader.ReadToEnd() + ". În colțul din stânga al ferestrei îți vor apărea poze cu diferite atracții turistice din Europa. Tu trebuie să alegi din lista dată locațiile în care se găsesc acestea, având la dispoziție 3 încercări pentru fiecare, pe care le vei verifica cu ajutorul butonului „Verifică”. La expirarea încercărilor, Freddy îți va spune care este răspunsul corect. După rezolvarea fiecărei întrebări îți va apărea o săgeată în patrea dreaptă, care este menită să te trimită la următoarea întrebare. La finalul jocului Freddy îți va dezvălui punctajul obținut. Pentru a reîncepe jocul trebuie doar să apeși pe butonul „Vreau să reîncep jocul!”."; 
                reader.Close();
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
