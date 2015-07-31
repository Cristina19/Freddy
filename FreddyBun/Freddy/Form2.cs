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
        SoundPlayer player1=new SoundPlayer(Properties.Resources.CA);
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
            im[0] = Properties.Resources._1;
            im[1] = Properties.Resources._2;
            im[2] = Properties.Resources._3;
            im[3] = Properties.Resources._4;
            im[4] = Properties.Resources._5;
            im[5] = Properties.Resources._6;
            im[6] = Properties.Resources._7;
            im[7] = Properties.Resources._8;
            im[8] = Properties.Resources._9;
            im[9] = Properties.Resources._10;
            im[10] = Properties.Resources._11;
            im[11] = Properties.Resources._12;
            im[12] = Properties.Resources._13;
            im[13] = Properties.Resources._14;
            im[14] = Properties.Resources._15;
            im[15] = Properties.Resources._16;
            im[16] = Properties.Resources._17;
            im[17] = Properties.Resources._18;
            im[18] = Properties.Resources._19;
            im[19] = Properties.Resources._20;
            im[20] = Properties.Resources._21;
            im[21] = Properties.Resources._22;
            im[22] = Properties.Resources._23;
            im[23] = Properties.Resources._24;
            im[24] = Properties.Resources._25;
            im[25] = Properties.Resources._26;
            im[26] = Properties.Resources._27;
            im[27] = Properties.Resources._28;
            im[28] = Properties.Resources._29;
            im[29] = Properties.Resources._30;
            im[30] = Properties.Resources._31;
            im[31] = Properties.Resources._32;
            im[32] = Properties.Resources._33;
            im[33] = Properties.Resources._34;
            im[34] = Properties.Resources._35;
            im[35] = Properties.Resources._36;
            im[36] = Properties.Resources._37;
            im[37] = Properties.Resources._38;
            im[38] = Properties.Resources._39;
            im[39] = Properties.Resources._40;
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
                    pictureBox5.Image = Properties.Resources.corect;
                    pictureBox6.Image = Properties.Resources.corect;
                    player1 = new SoundPlayer(Properties.Resources.CA);
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
                        player1 = new SoundPlayer(Properties.Resources.TA);
                        player1.Play();
                        if (String.Compare(comboBox2.Text, loc[intreb]) == 0)
                        {
                            label1.Text = "Bine, " + nume + "! Obiectivul din imagine se află în " + loc[intreb] + ", dar oare cum se numește?";
                            pictureBox5.Image = Properties.Resources.delete1;
                            pictureBox6.Image = Properties.Resources.corect;
                        }
                        else
                            if (String.Compare(comboBox1.Text, obiect[intreb]) == 0)
                            {
                                label1.Text = "Bine, " + nume + "! În imagine se poate observa " + obiect[intreb] + ". Acum haide să descoperim și locul în care se află.";
                                pictureBox5.Image = Properties.Resources.corect;
                                pictureBox6.Image = Properties.Resources.delete1;
                            }
                            else
                            {
                                label1.Text = "Nu ai reușt să descoperi nici denumirea și nici locația obiectivului din imagine, însă nu te descuraja. Mai încearcă!";
                                pictureBox5.Image = Properties.Resources.delete1;
                                pictureBox6.Image = Properties.Resources.delete1;
                            }
                        if (inc == 2)
                            label4.Text = "Mai ai 2 încercări!";
                        else
                            label4.Text = "Mai ai o încercare!";
                    }
                    else
                    {
                        player1 = new SoundPlayer(Properties.Resources.FA);
                        timer1.Start();
                        pictureBox1.Image = Properties.Resources.Fredy;
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
            pictureBox1.Image = Properties.Resources.Fredy4s;
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
            if (nr<=20)
                pictureBox1.Image = Properties.Resources.Fredy4s;
            else
                pictureBox1.Image = Properties.Resources.sare;
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
            pictureBox1.Image = Properties.Resources.Fredy4s;
        }
    }
}
