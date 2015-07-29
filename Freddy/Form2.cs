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
    public partial class Form2 : Form
    {
        Image [] im=new Image[40];
        int[] v = new int[40];
        int intreb,inc=3,s=60,p,nr=0;
        String rez,nume;
        SoundPlayer player1=new SoundPlayer("CA.wav");
        String[] obiect = {"Turnul Eiffel","Acropolis","Colosseumul","Tower Bridge","Castelul Edinburgh","Palatul Buckingham",
                           "Big Ben","Sagrada Familia","Catedrala Notre-Dame","Cetatea Alhambra","Catedrala Sfântul Vasile",
                           "Catedrala Sfânta Sofia","Manneken Pis (Băiatul care face pipi)","Castelul Bran","Castelul Neuschwanstein",
                           "Poarta Brandenburg","Bazilica Sfântul Petru","Turnul înclinat din Pisa",
                           "Domul din Köln","Palatul Schönbrunn","Catedrala Sfântul Ștefan","Madame Tussauds","Podul cu Lanțuri",
                           "Casa lui Einstein","Castelul din Praga","Catedrala din Milano","Teatro alla Scala","Galleria Vittorio Emanuele II",
                           "Palatul Apostolic","Palatul Versailles","Piața San Marco","Castelul Peleș","Castelul Hunedoarei",
                           "Muzeul Prado","Stonehenge","Casa Anne Frank","Reichstag","Muzeul Luvru","Castelul Chambord","Arcul de Triumf de pe Bulevardul Champs-Élysées"};
        String[] loc = {"Paris, Franța","Atena, Grecia","Roma, Italia","Londra, Anglia","Edinburgh, Scoția","Londra, Anglia",
                        "Londra, Anglia","Barcelona, Spania","Paris, Franța","Granada, Spania","Moscova, Rusia","Istambul, Turcia",
                        "Bruxelles, Belgia","Brașov, România","Füssen, Germania","Berlin, Germania","Vatican, Vatican","Pisa, Italia",
                        "Köln, Germania","Viena, Austria","Viena, Austria","Londra, Anglia","Budapesta, Ungaria",
                        "Berna, Elveția","Praga, Cehia","Milano, Italia","Milano, Italia","Milano, Italia","Vatican, Vatican",
                        "Versailles, Franța","Veneția, Italia","Sinaia, Romania","Hunedoara, România",
                        "Madrid, Spania","Wiltshire, Anglia","Amsterdam, Olanda","Berlin, Germania","Paris, Franța","Blois, Franța",
                        "Paris, Franța"};
        public Form2()
        {
            InitializeComponent();
            init();
            sfarsit();
        }
        void inlocuire()
        {
            using (StreamReader reader = new StreamReader("obiective.txt"))
            {
                rez = reader.ReadToEnd();
                reader.Close();
            }
            if (Convert.ToInt32(rez) < p)
            {
                using (StreamWriter writer = new StreamWriter("obiective.txt"))
                {
                    writer.Write(Convert.ToString(p));
                    writer.Close();
                }
            }
        }
        void init()
        {
            this.AcceptButton = button2;
            im[0] = Image.FromFile("1.jpg");
            im[1] = Image.FromFile("2.jpg");
            im[2] = Image.FromFile("3.jpg");
            im[3] = Image.FromFile("4.jpg");
            im[4] = Image.FromFile("5.jpg");
            im[5] = Image.FromFile("6.jpg");
            im[6] = Image.FromFile("7.jpg");
            im[7] = Image.FromFile("8.jpg");
            im[8] = Image.FromFile("9.jpg");
            im[9] = Image.FromFile("10.jpg");
            im[10] = Image.FromFile("11.jpg");
            im[11] = Image.FromFile("12.jpg");
            im[12] = Image.FromFile("13.jpg");
            im[13] = Image.FromFile("14.jpg");
            im[14] = Image.FromFile("15.jpg");
            im[15] = Image.FromFile("16.jpg");
            im[16] = Image.FromFile("17.jpg");
            im[17] = Image.FromFile("18.jpg");
            im[18] = Image.FromFile("19.jpg");
            im[19] = Image.FromFile("20.jpg");
            im[20] = Image.FromFile("21.jpg");
            im[21] = Image.FromFile("22.jpg");
            im[22] = Image.FromFile("23.jpg");
            im[23] = Image.FromFile("24.jpg");
            im[24] = Image.FromFile("25.jpg");
            im[25] = Image.FromFile("26.jpg");
            im[26] = Image.FromFile("27.jpg");
            im[27] = Image.FromFile("28.jpg");
            im[28] = Image.FromFile("29.jpg");
            im[29] = Image.FromFile("30.jpg");
            im[30] = Image.FromFile("31.jpg");
            im[31] = Image.FromFile("32.jpg");
            im[32] = Image.FromFile("33.jpg");
            im[33] = Image.FromFile("34.jpg");
            im[34] = Image.FromFile("35.jpg");
            im[35] = Image.FromFile("36.jpg");
            im[36] = Image.FromFile("37.jpg");
            im[37] = Image.FromFile("38.jpg");
            im[38] = Image.FromFile("39.jpg");
            im[39] = Image.FromFile("40.jpg");
        }
        void inceput()
        {
            int i;
            using (StreamReader reader = new StreamReader("nume.txt"))
            {
                nume = reader.ReadToEnd();
                reader.Close();
            }
            for (i = 0; i <= 39; i++)
                v[i] = 0;
            pictureBox3.Visible = true;
            label2.Visible = true;
            comboBox1.Visible = true;
            comboBox1.Enabled = true;
            button2.Visible = true;
            button2.Enabled = true;
            label4.Visible = true;
            comboBox2.Visible = true;
            comboBox2.Enabled = true;
            label5.Visible = true;
        }
        void sfarsit()
        {
            pictureBox3.Visible = false;
            label5.Visible = false;
            comboBox2.Visible = false;
            comboBox2.Enabled = false;
            label2.Visible = false;
            comboBox1.Visible = false;
            comboBox1.Enabled = false;
            button2.Visible = false;
            button2.Enabled = false;
            pictureBox4.Visible = false;
            pictureBox4.Enabled = false;
            label4.Visible = false;
        }
        void aleator()
        {
            Random random=new Random();
            inc = 3;
            nr++;
            label2.Text = Convert.ToString(nr) + ". Obiectivul turistic din imagine este ...";
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            comboBox1.Text = "Alege din lista de mai jos:";
            comboBox2.Text = "Alege din lista de mai jos:";
            if(nr<=20)
            {
                intreb = random.Next(0, 40);
                while (v[intreb] == 1)
                    intreb = random.Next(0, 40);
                pictureBox3.Image = im[intreb];
                label1.Text = "Ce oviectiv turistic se observă în imagine și unde se află acesta?";
                v[intreb] = 1;
            }
            else
            {
                p = s * 100 / 60;
                if (p == 100)
                    label1.Text = "Felicitări, " + nume + ". Ai ajuns la finalul jocului și sunt extrem de mândru de tine! Nu oricine reușește să obțină scorul de 100%. Bravo!";
                else
                    label1.Text = "Felicitări, " + nume + ". Ai ajuns la finalul jocului. Scorul tău este de " + Convert.ToString(p) + "%, însă eu te sfătuiesc să continui să te joci până obții 100%.";
                button1.Visible = true;
                button1.Enabled = true;
                button1.Text = "Vreau să reîncep jocul!";
                sfarsit();
                label3.Visible = true;
                inlocuire();
            }
        }
        private void obiectiveleTuristiceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "Alege din lista de mai jos:" && comboBox2.Text != "Alege din lista de mai jos:")
            {
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                if (String.Compare(comboBox2.Text, loc[intreb]) == 0 && String.Compare(comboBox1.Text, obiect[intreb]) == 0)
                {
                    pictureBox5.Image = Image.FromFile("check-157822_640.png");
                    pictureBox6.Image = Image.FromFile("check-157822_640.png");
                    player1 = new SoundPlayer("CA.wav");
                    player1.Play();
                    label1.Text = "Corect! Obiectivul turistic din imagine este " + obiect[intreb] + " și se află în " + loc[intreb] + '.';
                    pictureBox4.Enabled = true;
                    pictureBox4.Visible = true;
                    button2.Enabled = false;
                    if (nr < 20)
                        label4.Text = "Să trecem la următoarea întrebare! Apasă pe săgeata din dreapta.";
                    else
                        label4.Text = "Hai să vedem ce punctaj ai obținut! Apasă pe săgeata din dreapta.";
                }
                else
                {
                    inc--;
                    s--;
                    if (inc == 2 || inc == 1)
                    {
                        player1 = new SoundPlayer("TA.wav");
                        player1.Play();
                        if (String.Compare(comboBox2.Text, loc[intreb]) == 0)
                        {
                            label1.Text = "Bine, " + nume + "! Obiectivul din imagine se află în " + loc[intreb] + ", dar oare cum se numește?";
                            pictureBox5.Image = Image.FromFile("delete1.png");
                            pictureBox6.Image = Image.FromFile("check-157822_640.png");
                        }
                        else
                            if (String.Compare(comboBox1.Text, obiect[intreb]) == 0)
                            {
                                label1.Text = "Bine, " + nume + "! În imagine se poate observa " + obiect[intreb] + ". Acum haide să descoperim și locul în care se află.";
                                pictureBox5.Image = Image.FromFile("check-157822_640.png");
                                pictureBox6.Image = Image.FromFile("delete1.png");
                            }
                            else
                            {
                                label1.Text = "Nu ai reușt să descoperi nici denumirea și nici locația obiectivului din imagine, însă nu te descuraja. Mai încearcă!";
                                pictureBox5.Image = Image.FromFile("delete1.png");
                                pictureBox6.Image = Image.FromFile("delete1.png");
                            }
                        if (inc == 2)
                            label4.Text = "Mai ai 2 încercări!";
                        else
                            label4.Text = "Mai ai o încercare!";
                    }
                    else
                    {
                        player1 = new SoundPlayer("FA.wav");
                        timer1.Start();
                        pictureBox1.Image = Image.FromFile("Fredy.gif");
                        player1.Play();
                        label1.Text = "Se pare că au expirat toate încercările... Obiectivul din imagine este " + obiect[intreb] + " și se află în " + loc[intreb] + '.';
                        if (nr < 20)
                            label4.Text = "Să trecem la următoarea întrebare! Apasă pe săgeata din dreapta.";
                        else
                            label4.Text = "Hai să vedem ce punctaj ai obținut! Apasă pe săgeata din dreapta.";
                        button2.Enabled = false;
                        comboBox2.Text = loc[intreb];
                        comboBox1.Text = obiect[intreb];
                        pictureBox4.Enabled = true;
                        pictureBox4.Visible = true;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inceput();
            s =60; nr = 0;
            aleator();
            label3.Visible = false;
            button1.Visible = false;
            button1.Enabled = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            player1.Stop();
            aleator();
            pictureBox4.Enabled = false;
            pictureBox4.Visible = false;
            button2.Enabled = true;
            label4.Text = "Ai 3 încercări!";
            timer1.Stop();
            pictureBox1.Image = Image.FromFile("Fredy4s.gif");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private void regulileJoculuiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 Form5 = new Form5();
            Form5.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            pictureBox1.Image = Image.FromFile("Fredy4s.gif");
        }
    }
}
