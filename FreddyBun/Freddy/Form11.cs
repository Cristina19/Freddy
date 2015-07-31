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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
            this.AcceptButton = button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || comboBox1.Text == "")
                label1.Text = "Te rog să completezi toate rubricile!";
            else
            {
                using (StreamWriter writer = new StreamWriter("nume.txt"))
                {
                    writer.Write(textBox1.Text);
                    writer.Close();
                }
                using (StreamWriter writer = new StreamWriter("sex.txt"))
                {
                    writer.Write(comboBox1.Text);
                    writer.Close();
                }
                label1.Text = textBox1.Text + ", îmi pare bine de cunoștință! Închide te rog această fereastră și să înceapă aventura!";
                using (StreamWriter writer = new StreamWriter("judete.txt"))
                {
                    writer.Write("-1");
                    writer.Close();
                }
                using (StreamWriter writer = new StreamWriter("obiective.txt"))
                {
                    writer.Write("-1");
                    writer.Close();
                }
                using (StreamWriter writer = new StreamWriter("explorator.txt"))
                {
                    writer.Write("-1");
                    writer.Close();
                }
                using (StreamWriter writer = new StreamWriter("pacaleala.txt"))
                {
                    writer.Write("-1");
                    writer.Close();
                }
            }
        }
    }
}
