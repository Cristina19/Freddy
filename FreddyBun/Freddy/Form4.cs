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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            using (StreamReader reader = new StreamReader("nume.txt"))
            {
                label1.Text = "    Hey " + reader.ReadToEnd()+", în acest joc scrierea corectă a denumirilor țărilor este foarte importantă. De aceea nu uita să folosești diacritice și denumirile de mai jos dacă dorești să obții punctajul maxim!";
                reader.Close();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
