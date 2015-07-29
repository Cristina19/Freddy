using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace Freddy
{
    public partial class Form1 : Form
    {
        bool button1_apasat = false, sw=false;
        PictureBox picturebox3 = new PictureBox();
        PictureBox picturebox4 = new PictureBox();
        Button button2 = new Button();
        Button button3 = new Button();
        Button button4 = new Button();
        Button button5 = new Button();
        Button button6 = new Button();
        Label label10 = new Label();
        Label label3 = new Label();
        String rez1, rez2, rez3, nume;
        void init()
        {
            if (!File.Exists("judete.txt"))
                File.Create("judete.txt").Dispose();
            using (StreamWriter writer = new StreamWriter("judete.txt"))
            {
                writer.Write("-1");
                writer.Close();
            }
            if (!File.Exists("obiective.txt"))
                File.Create("obiective.txt").Dispose();
            using (StreamWriter writer = new StreamWriter("obiective.txt"))
            {
                writer.Write("-1");
                writer.Close();
            }
            if (!File.Exists("explorator.txt"))
                File.Create("explorator.txt").Dispose();
            using (StreamWriter writer = new StreamWriter("explorator.txt"))
            {
                writer.Write("-1");
                writer.Close();
            }
            if (!File.Exists("pacaleala.txt"))
                File.Create("pacaleala.txt").Dispose();
            using (StreamWriter writer = new StreamWriter("pacaleala.txt"))
            {
                writer.Write("-1");
                writer.Close();
            }
            timer1.Start();
            radioButton1.Visible = false;
            radioButton2.Visible = false;
        }
        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = button1;
            init();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text!="")
            {
                button1_apasat = true;
                nume = textBox1.Text;
                label1.Text = "   " + textBox1.Text + ", ce nume frumos! Îmi pare bine de cunoștință. Spune-mi te rog, ești fată sau băiat?";
                if (!File.Exists("nume.txt"))
                    File.Create("nume.txt").Dispose();
                using (StreamWriter writer=new StreamWriter("nume.txt"))
                {
                    writer.Write(textBox1.Text);
                    writer.Close();
                }
                Controls.Remove(textBox1);
                Controls.Remove(label2);
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                Controls.Remove(button1);
            }
            else
                label1.Text = "Te rog, prima dată să-ți scrii numele!";
        }
        void sterge()
        {
            label1.Visible = false;
            pictureBox1.Visible = false;
            pictureBox1.Enabled = false;
            pictureBox2.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            textBox1.Enabled = false;
            button1.Visible = false;
            button1.Enabled = false;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (button1_apasat == true && sw==true)
            {
                sterge();
                păcăleștelPeFreddyToolStripMenuItem.Enabled = true;
                this.BackgroundImage = new Bitmap("Background3.jpg");
                picturebox3.Location = new Point(60,441);
                picturebox3.Size = new System.Drawing.Size(128,121);
                picturebox3.SizeMode = PictureBoxSizeMode.StretchImage;
                picturebox3.Image = new Bitmap("Fredy4s.gif");
                picturebox3.BackColor = Color.Transparent;
                Controls.Add(picturebox3);
                picturebox4.Location = new Point(75,293);
                picturebox4.Size = new System.Drawing.Size(361,227);
                picturebox4.SizeMode = PictureBoxSizeMode.StretchImage;
                picturebox4.Image = new Bitmap("bubble3.png");
                picturebox4.BackColor = Color.Transparent;
                picturebox4.BringToFront();
                picturebox4.SendToBack();
                Controls.Add(picturebox4);
                label10.Location = new Point(140, 346);
                label10.BackColor = Color.White;
                label10.ForeColor = Color.Black;
                label10.Font = new Font("Segoe Print", 8);
                label10.Size = new System.Drawing.Size(228,77);
                Controls.Add(label10);
                label10.BringToFront();
                button2.Location = new Point(60,60);
                button2.Size = new System.Drawing.Size(200,40);
                button2.BackColor = Color.White;
                button2.Text = "Județele României";
                button2.Font = new Font("Segoe Print", 8);
                button2.ForeColor = Color.Black;
                this.Controls.Add(button2);
                button3.Location = new Point(450, 60);
                button3.Size = new System.Drawing.Size(300, 180);
                button3.BackColor = Color.White;
                button3.Text = "Surpriză!";
                button3.Font = new Font("Segoe Print", 40);
                button3.ForeColor = Color.Black;
                button3.Visible = false;
                button3.Enabled = false;
                this.Controls.Add(button3);
                button3.Click += new System.EventHandler(button3_Click);
                button2.Click += new System.EventHandler(button2_Click);
                button4.Location = new Point(60, 130);
                button4.Size = new System.Drawing.Size(200, 40);
                button4.BackColor = Color.White;
                button4.Text = "Obiective Turistice";
                button4.Font = new Font("Segoe Print", 8);
                button4.ForeColor = Color.Black;
                button4.Click += new System.EventHandler(button4_Click);
                this.Controls.Add(button4);
                button5.Location = new Point(60, 200);
                button5.Size = new System.Drawing.Size(200, 40);
                button5.BackColor = Color.White;
                button5.Text = "Joc de cultură generală";
                button5.Font = new Font("Segoe Print", 8);
                button5.ForeColor = Color.Black;
                this.Controls.Add(button5);
                button5.Click += new System.EventHandler(button5_Click);
                button6.Location = new Point(200, 520);
                button6.Size = new System.Drawing.Size(200, 40);
                button6.BackColor = Color.White;
                button6.Text = "Schimbă jucătorul";
                button6.Font = new Font("Segoe Print", 8);
                button6.ForeColor = Color.Black;
                button6.BringToFront();
                this.Controls.Add(button6);
                button6.Click += new System.EventHandler(button6_Click);
                Controls.Remove(radioButton1);
                Controls.Remove(radioButton2);
            }
            else
                if (button1_apasat == false && sw == false)
                    label1.Text = "Te rog, prima dată spune-mi numele tău!";
                else
                {
                    label3.Visible = false;
                    label1.Visible = true;
                    label1.Text = "Te rog sa-mi spui dacă esti fată sau băiat!";
                }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form2 Form2= new Form2();
            Form2.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Form7 Form7 = new Form7();
            Form7.Show();
            
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Form11 Form11 = new Form11();
            Form11.Show();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form9 Form9 = new Form9();
            Form9.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("judete.txt"))
            {
                rez1 = reader.ReadToEnd();
                reader.Close();
            }
            using (StreamReader reader = new StreamReader("obiective.txt"))
            {
                rez2 = reader.ReadToEnd();
                reader.Close();
            }
            using (StreamReader reader = new StreamReader("explorator.txt"))
            {
                rez3 = reader.ReadToEnd();
                reader.Close();
            }
            using (StreamReader reader=new StreamReader("nume.txt"))
            {
                label10.Text = "   " + reader.ReadToEnd() + ", haide să vedem câte jocuri putem juca astăzi împreună! Dacă le vei trece cu bine pe toate, vei primi o recompensă.";
                reader.Close();
            }
            if(Convert.ToInt32(rez1)!=-1&&Convert.ToInt32(rez2)!=-1&&Convert.ToInt32(rez3)!=-1)
            {
                button3.Visible = true;
                button3.Enabled = true;
            }
            else
            {
                button3.Visible = false;
                button3.Enabled = false;
            }
        }

        private void păcăleștelPeFreddyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 Form10 = new Form10();
            Form10.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            sw = true;
            if (!File.Exists("sex.txt"))
                File.Create("sex.txt").Dispose();
            using (StreamWriter writer = new StreamWriter("sex.txt"))
            {
                writer.Write("Băiat");
                writer.Close();
            }
            label1.Text = "   " + nume + ", a venit momentul să începem aventura! Ești pregătit? Dacă da, dă click pe mine!";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            sw = true;
            if (!File.Exists("sex.txt"))
                File.Create("sex.txt").Dispose();
            using (StreamWriter writer = new StreamWriter("sex.txt"))
            {
                writer.Write("Fată");
                writer.Close();
            }
            label1.Text = "   " + nume + ", a venit momentul să începem aventura! Ești pregătită? Dacă da, dă click pe mine!";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
