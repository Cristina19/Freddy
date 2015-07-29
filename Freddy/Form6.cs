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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            using (StreamReader reader = new StreamReader("nume.txt"))
            {
                label2.Text = "    Hei, " + reader.ReadToEnd() + ". În meniul „Joc” ai de ales între „Exersare” și „Testează-ți cunoștințele”. În momentul în care alegi varianta de exersare vei avea posibilitatea să exersezi pe mai multe regiuni ale României până când le vei cunoaște foarte bine. Aici nu se va calcula niciun scor iar pe parcurs vei beneficia de sfaturile lui Freddy. Atunci când dorești să îți testezi cunoștințele, tot ce trebuie să faci este să dai click pe butonul corespunzător județului menționat in partea de sus a ferestrei. Pentru fiecare județ vei avea 3 încercări, iar fiecare greșeală va fi penalizată. Pe parcurs, vei observa că răspunsurile corecte sunt afișate în partea dreaptă a ferestrei, cele date de tine colorate cu albastru iar cele pe care nu le-ai știut colorate cu portocaliu. Acest lucru te va ajuta să înveți mai ușor denumirile sau locurile în care se află județele mai puțin cunoscute de tine. Jocul se sfârșește în momentul în care ai terminat de localizat pe hartă toate județele României, iar Freddy îți va spune ce punctaj ai obținut. Dacă dorești să începi jocul de la început, trebuie doar să dai click pe butonul aflat în colțul stâng de jos al ferestrei.";
                reader.Close();
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
