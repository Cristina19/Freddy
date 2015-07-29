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
    public partial class Form8 : Form
    {
        String cuv;
        public Form8()
        {
            InitializeComponent();
            using (StreamReader reader = new StreamReader("sex.txt"))
            {
                if (reader.ReadToEnd() == "Băiat")
                    cuv = "rapid";
                else
                    cuv = "rapidă";

            }
            using (StreamReader reader = new StreamReader("nume.txt"))
            {
                label2.Text ="    "+reader.ReadToEnd() + ", te-ai uitat vreodată la „Vrei să fii miliardar?” ? Dacă răspunsul este da, atunci uită de acea emisiune pentru că jocul acesta nu are foarte multe lucruri în comun cu ea. Aici nu poți să schimbi întrebarea (poți doar să o amâni), să suni un prieten (trebuie să fii extrem de "+cuv+"), să întrebi publicul (teoretic nu ar trebui să ai așa ceva), sau să elimini 2 variante (în acest joc vei avea doar două variante, deci dacă le vei elimina nu vei mai avea niciuna). Singurele lucruri asemănătoare sunt titlul promițător și melodiile extrem de inspirate.";
                reader.Close();
            }
            
        }
        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
