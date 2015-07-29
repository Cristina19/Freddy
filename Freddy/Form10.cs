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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
            this.AcceptButton = button1;
        }
        void verif()
        {
             using (StreamWriter writer = new StreamWriter("judete.txt"))
                {
                    writer.Write(textBox1.Text);
                    writer.Close();
                }
                using (StreamWriter writer = new StreamWriter("obiective.txt"))
                {
                    writer.Write(textBox2.Text);
                    writer.Close();
                }
                using (StreamWriter writer = new StreamWriter("explorator.txt"))
                {
                    writer.Write(textBox3.Text);
                    writer.Close();
                }
                timer1.Stop();
                MessageBox.Show("Modificări efectuate cu succes.");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
        }
        bool sw1, sw2, sw3;
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (String.Compare(textBox4.Text, "FernandoMagellan02") == 0)
                sw2 = true;
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                sw3 = true;
                if (Convert.ToInt32(textBox1.Text) <= 100 && Convert.ToInt32(textBox2.Text) <= 100 && Convert.ToInt32(textBox3.Text) <=100)
                    sw1 = true;
            }
            if (sw1 && sw2 && sw3)
            {
                verif();
                using (StreamWriter writer = new StreamWriter("pacaleala.txt"))
                {
                    writer.Write("1");
                    writer.Close();
                }
            }
            else
            {
                timer1.Start();
                if (textBox1.Text == "" || Convert.ToInt32(textBox1.Text) > 100)
                {
                    label3.ForeColor = Color.Red;
                    textBox1.Text = "";
                }
                if (textBox2.Text == "" || Convert.ToInt32(textBox2.Text) > 100)
                {
                    label4.ForeColor = Color.Red;
                    textBox2.Text = "";
                }
                if (textBox3.Text == "" || Convert.ToInt32(textBox3.Text) > 100)
                {
                    label5.ForeColor = Color.Red;
                    textBox3.Text = "";
                }
                if (String.Compare(textBox4.Text, "FernandoMagellan02") != 0)
                {
                    label6.ForeColor = Color.Red;
                    textBox4.Text = "";
                }
                MessageBox.Show("Parola nu este corectă, nu ai completat toate câmpurile sau ai introdus o valoare mai mare ca 100 la punctaje!");
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                label3.ForeColor = Color.DimGray;
            if (textBox2.Text != "")
                label4.ForeColor = Color.DimGray;
            if (textBox3.Text != "")
                label5.ForeColor = Color.DimGray;
            if (textBox4.Text != "")
                label6.ForeColor = Color.DimGray;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
                e.Handled = e.KeyChar != (char)Keys.Back;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
                e.Handled = e.KeyChar != (char)Keys.Back;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
                e.Handled = e.KeyChar != (char)Keys.Back;
        }
    }
}
