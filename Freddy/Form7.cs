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
    public partial class Form7 : Form
    {
        int timp=15,intreb,s=20,nr,pr,i,j=1,k=0,q=0,sound=0;
        int[] nrintr = new int[4];
        int[] intr = new int[4];
        int[] v = new int[61];
        int[] cor = new int[61];
        Image img1 = Image.FromFile("check-157822_640.png");
        Image img2 = Image.FromFile("delete1.png");
        SoundPlayer player1;
        String preg;
        bool sw = false;
        Random random = new Random();
        String[] intrebari = { "Laptele de hipopotam e roz.", "Munții Anzi formează cel mai lung lanț muntos din lume.", "Rechinii nu au branhii.", 
                               "Thailanda are graniță comună cu Nepal.", "Alaska aparține Statelor Unite ale Americii.", "Amprenta nasului unui câine este unică, precum amprenta degetului uman.",
                               "Cea mai înaltă cascadă din America este Niagara.", "Potrivit unei convenții internaționale, Polul Nord nu aparține niciunei țări.",
                               "O eclipsă de soare se produce atunci când Pământul trece între Lună și Soare, împiedicând lumina Soarelui să ajungă la Lună.",
                               "Deșertul Gobi se află în Asia.", "Vulcanul Fuji se găsește în Indonezia.", "Porcușorii de guineea provin din America de Sud.", 
                               "Andaluzia se află în Portugalia.", "Limba maternă a lui Napoleon Bonaparte era italiana.", "Uruguay are graniță comună cu Paraguay.", 
                               "Sushi este o mâncare specifică bucătăriei japoneze.", "Turnul din Pisa se află în Franța.", "Nicaragua este o republică din Africa.", 
                               "Volga este cel mai lung fluviu din Europa.", "Peștii dorm cu ochii deschiși.", "Papua Noua Guinee are graniță comună cu Malaysia.", 
                               "Helsinki este capitala Finlandei.", "Oktoberfest este organizată anual în Belgia.", "Dacă ai putea așeza planeta Saturn intr-o masă uriașă de apă, aceasta ar pluti.", 
                               " Manila este capitala Filipinelor.", "Ruinele orașului antic Persepolis se află în Iran.", "Vrabia își depune ouăle în cuiburi străine.", 
                               "America de Nord este al doilea continent ca mărime de pe Terra după Asia.", "Oceanul Pacific este cel mai întins ocean de pe Terra.", 
                               "Bambusul este considerat arbore sacru în China.", "Toronto este capitala Canadei.", "Bulgaria are graniță comună cu Grecia.", 
                               "Mercur este cea mai caldă planetă din sistemul nostru solar, această planetă fiind cea mai apropiată de Soare.", "Colombo este capitala Sri Lankăi.", 
                               "Regiunea Polului Nord este alcătuită numai din gheață.", "Paris a fost primul oraș din Europa unde s-a folosit petrolul la iluminatul străzilor.", 
                               "Oslo este capitala Suediei.", "Cel mai mare amfibian din lume, salamandra uriașă din China poate ajunge chiar și până la 1,8 metrii lungime.", 
                               "Havana este o capitală în Africa.", "În Australia sunt aproximativ de două ori mai mulți canguri decât oameni.", "Singurul loc din Europa unde mai trăiesc în libertate maimuțe este Gibraltar.", 
                               "La Polul Nord este mai rece decât la Polul Sud.", "Fluviul Tamisa străbate capitala Angliei.", "Nisipul este materialul de bază al sticlei.", 
                               "Cea mai mare insulă grecească este Creta.", "Amurul este o specie de rozătoare.", "Formațiunile de minerale de calciu dizolvate în apă care se acumulează treptat și se înalță de pe podeaua peșterilor se numesc stalactite.", 
                               "Dragonul de Komodo din Indonezia este cea mai mare șopârlă de pe Terra.", "Asunción este capitala Uruguayului.", "Puii de dalmațian sunt complet albi la naștere.", 
                               "Jupiter este a treia planetă de la Soare.", "Regatul Lesotho este complet înconjurat de Africa de Sud.", "Capitala Australiei este Sydney.", 
                               "Vechiul nume al Transilvaniei era Siebenbürgen (Șapte cetăți), nume atestat din anul 1296.", "Regiunea autonomă Tibet se găsește în India.", 
                               "Gâsca are mai multe vertebre ale gâtului decât girafa.", "Insulele Hawaii se găsesc în Oceanul Atlantic.", "Procentul de apă dulce conținut de râurile și lacurile de pe Pământ este mai puțin de 1%.", 
                               "Hawaii aparține Statelor Unite ale Americii.", "Limba girafei este de culoare neagră.", "Liliacul depune ouă."};
        String[] explicatii = { "Fals. Cascada Angel (979 metri) se găsește în America de Sud și este cea mai înaltă cascadă din lume.", "Fals. Fenomenul descris se numește eclipsă de Lună. Eclipsa de Soare se produce atunci când Luna trece între Pământ și Soare.", 
                                "Fals. Vulcanul Fuji este situat în partea centrală a insulei principale din arhipelagul Japonez.", "Fals. Andaluzia este o comunitate autonomă spaniolă.", "Turnul din Pisa se află în Italia","Fals. Nicaragua este o republică din America Centrală.", 
                                "Fals. Papua Noua Guinee se învecinează cu Indonezia.", "Fals. Oktoberfest se organizează în Germania.", "Adevărat. Saturn este o planetă gazoasă, având o densitate mai mică decât cea a apei.",
                                "Fals. Cucul este pasărea care își depune ouăle în cuiburi străine.", "Fals. America de Nord este al treilea continent ca suprafață după Asia și Africa.", "Fals. Capitala Canadei este Ottawa.", 
                                "Fals. Cu toate că Mercur se află cel mai aproape de Soare, Venus este cea mai caldă planetă din sistemul nostru solar.", "Fals. Bucureștiul a fost primul oraș unde s-a folosit petrolul la iluminatul străzilor publice.", 
                                "Fals. Capitala Suediei este Stockholm. Oslo este capitala Norvegiei.", "Fals. Havana este capitala Cubei.", "Fals. La Polul Sud este mult mai rece decât la Polul Nord, cu o temperatură medie anuală de cca. -49°C, în timp ce la Polul Nord iarna se înregistrează în jur de -34°C.", 
                                "Fals. Amurul este o specie de pește.", "Fals. Aceste formațiuni se numesc stalagmite. Stalactitele se formează pe plafonul peșterilor.", "Fals. Asunción este capitala Paraguayului.", "Fals. Pământul este a treia planetă de la Soare, Jupiter fiind a cincea.", 
                                "Fals. Capitala Australiei este Camberra.", "Fals. Tibetul se află pe teritoriul Chinei.", "Fals. Insulele Hawaii se găsesc în Oceanul Pacific.", "Fals. Liliacul este un mamifer și naște pui vii."};
        Button[] rc= new Button[100];
        String rez, nume;
        void init()
        {
            rc[0] = button2;
            rc[1] = button2;
            rc[2] = button3;
            rc[3] = button3;
            rc[4] = button2;
            rc[5] = button2;
            rc[6] = button3;//0
            rc[7] = button2;
            rc[8] = button3;//1
            rc[9] = button2;
            rc[10] = button3;//2
            rc[11] = button2;
            rc[12] = button3;//3
            rc[13] = button2;
            rc[14] = button3;
            rc[15] = button2;
            rc[16] = button3;//4
            rc[17] = button3;//5
            rc[18] = button2;
            rc[19] = button2;
            rc[20] = button3;//6
            rc[21] = button2;
            rc[22] = button3;//7
            rc[23] = button2;//8
            rc[24] = button2;
            rc[25] = button2;
            rc[26] = button3;//9
            rc[27] = button3;//10
            rc[28] = button2;
            rc[29] = button3;
            rc[30] = button3;//11
            rc[31] = button2;
            rc[32] = button3;//12
            rc[33] = button2;
            rc[34] = button2;
            rc[35] = button3;//13
            rc[36] = button3;//14
            rc[37] = button2;
            rc[38] = button3;//15
            rc[39] = button2;
            rc[40] = button2;
            rc[41] = button3;//16
            rc[42] = button2;
            rc[43] = button2;
            rc[44] = button2;
            rc[45] = button3;//17
            rc[46] = button3;//18
            rc[47] = button2;
            rc[48] = button3;//19
            rc[49] = button2;
            rc[50] = button3;//20
            rc[51] = button2;
            rc[52] = button3;//21
            rc[53] = button2;
            rc[54] = button3;//22
            rc[55] = button2;
            rc[56] = button3;//23
            rc[57] = button2;
            rc[58] = button2;
            rc[59] = button2;
            rc[60] = button3;//24
            j = 1;
            for(i=0;i<=60;i++)
                if (i==6||i==8||i==10||i==12||i==16||i==17||i==20||i==22||i==23||i==26||i==27||i==30||i==32||i==35||i==36||i==38||i==41||i==45||i==46||i==48||i==50||i==52||i==54||i==56||i==60)
                {    
                    cor[i]=j;
                    j++;
                }
        }
        public Form7()
        {
            InitializeComponent();
            pictureBox6.Visible = false;
            label2.Visible = false;
            button3.Visible = false;
            button2.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            button4.Visible = false;
            using (StreamReader reader = new StreamReader("explorator.txt"))
            {
                if(String.Compare(reader.ReadToEnd(), "Băiat") == 0)
                    preg="pregătit";
                else
                    preg="pregătită";
                reader.Close();
            }
            using (StreamReader reader = new StreamReader("explorator.txt"))
            {
                nume = reader.ReadToEnd();
                reader.Close();
            }
            label3.Text = "Haide să-ți testăm puțin și cultura generală. Apasă pe start când ești "+preg+'.';
            init();
            if (sound % 2 == 0)
            {
                player1 = new SoundPlayer("inceput.wav");
                player1.Play();
            }
        }
        void inlocuire()
        {
            using (StreamReader reader = new StreamReader("explorator.txt"))
            {
                rez = reader.ReadToEnd();
                reader.Close();
            }
            if (Convert.ToInt32(rez) < pr)
            {
                using (StreamWriter writer = new StreamWriter("explorator.txt"))
                {
                    writer.Write(Convert.ToString(pr));
                    writer.Close();
                }
            }
        }
        void aleator()
        {
            nr++;
            if(nr<=20)
            {
                timp = 10;
                label1.Text = Convert.ToString(timp);
                button2.Enabled = true;
                button3.Enabled = true;
                button3.TabStop = false;
                button2.TabStop = false;
                intreb = random.Next(0, 61);
                while (v[intreb] == 1)
                    intreb = random.Next(0, 61);
                v[intreb] = 1;
                label2.Text = Convert.ToString(nr)+". "+intrebari[intreb];
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                label3.Text = "Hmmm...Oare această afirmație este adevărată sau falsă?";
                if (sound % 2 == 0)
                {
                    player1 = new SoundPlayer("gandeste.wav");
                    player1.Play();
                }
                timer1.Start();
            }
            else
            {
                if (sw == false)
                {
                    if (sound % 2 == 0)
                    {
                        player1 = new SoundPlayer("final.wav");
                        player1.Play();
                    }
                    pr = s * 100 / 20;
                    inlocuire();
                    if (pr==100)
                    label3.Text = "Felicitări, "+nume+". Ai ajuns la finalul jocului și sunt extrem de mândru de tine! Nu oricine reușește să obțină scorul de 100%. Bravo!";
                    else
                        label3.Text = "Felicitări, " + nume + ". Ai ajuns la finalul jocului. Scorul tău este de "+Convert.ToString(pr)+"%, însă eu te sfătuiesc să continui să te joci până obții 100%.";
                    pictureBox2.Image = Image.FromFile("Copy-of-Jumping-Fredy.gif");
                    button1.Enabled = true;
                    button1.Visible = true;
                    button1.Text = "Vreau să reîncep jocul!";
                    label2.Visible = false;
                    button3.Visible = false;
                    button2.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label4.Visible = true;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    button4.Visible = false;
                    button4.Enabled = false;
                }
                else
                {
                    q++;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button3.TabStop = false;
                    button2.TabStop = false;
                    timp = 10;
                    if(q==k)
                        sw = false;
                    if (q <= k)
                    {
                        label2.Text = Convert.ToString(nrintr[q]) + ". " + intrebari[intr[q]];
                        intreb = intr[q];
                        pictureBox4.Visible = false;
                        pictureBox5.Visible = false;
                        label3.Text = "Hmmm...Oare această afirmație este adevărată sau falsă?";
                        if (sound % 2 == 0)
                        {
                            player1 = new SoundPlayer("gandeste.wav");
                            player1.Play();
                        }
                        timer1.Start();
                    }
                       
                }
            }
            pictureBox6.Visible = false;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timp > 0)
            {
                timp--;
                label1.Text = Convert.ToString(timp);
            }
            else
            {
                pictureBox6.Visible = true;
                timer1.Stop();
                timer2.Start();
                label1.Text = "0";
                if (rc[intreb] != button2)
                {
                    pictureBox4.Image = img2;
                    pictureBox5.Image = img1;
                }
                else
                    if (rc[intreb] != button3)
                    {
                        pictureBox4.Image = img1;
                        pictureBox5.Image = img2;
                    }
                s--;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                timer3.Start();
                pictureBox2.Image = Image.FromFile("Fredy.gif");
                player1 = new SoundPlayer("gresit.wav");
                player1.Play();
                button3.Enabled = false;
                button2.Enabled = false;
                if(cor[intreb]!=0)
                label3.Text=explicatii[cor[intreb]-1];
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            aleator();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled=false;
            button1.Visible=false;
            k=0;
            sw = false;
            q = 0;
            button4.Visible = true;
            button4.Enabled = true;
            for (i = 0; i <= 60; i++)
                v[i] = 0;
            s = 20; nr = 0;
            label3.Text = "Hmmm...Oare această afirmație este adevărată sau falsă?";
            button4.Visible = true;
            label2.Visible = true;
            button3.Visible = true;
            button2.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label4.Visible = false;
            pictureBox2.Image = Image.FromFile("Fredy4s.gif");
            aleator();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Start();
            button2.TabStop = false;
            pictureBox6.Visible = true;
            label1.Text = "0";
            if (rc[intreb] != button2)
            {
                s--;
                pictureBox4.Image = img2;
                pictureBox5.Image = img1;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                timer3.Start();
                player1 = new SoundPlayer("gresit.wav");
                pictureBox2.Image = Image.FromFile("Fredy.gif");
                player1.Play();
                
            }
            else
            {
                pictureBox4.Image = img1;
                pictureBox4.Visible = true;
                player1 = new SoundPlayer("corect.wav");
                player1.Play();
            }
            button3.Enabled = false;
            button2.Enabled = false;
            if(cor[intreb]!=0)
                label3.Text=explicatii[cor[intreb]-1];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Start();
            button3.TabStop = false;
            pictureBox6.Visible = true;
            label1.Text = "0";
            if (rc[intreb] != button3)
            {
                s--;
                pictureBox4.Image = img1;
                pictureBox5.Image = img2;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                timer3.Start();
                pictureBox2.Image = Image.FromFile("Fredy.gif");
                player1 = new SoundPlayer("gresit.wav");
                player1.Play();
            }
            else
            {
                pictureBox5.Image = img1;
                pictureBox5.Visible = true;
                if (sound % 2 == 0)
                {
                    player1 = new SoundPlayer("corect.wav");
                    player1.Play();
                }
            }
            button3.Enabled = false;
            button2.Enabled = false;
            if(cor[intreb]!=0)
                label3.Text=explicatii[cor[intreb]-1];
        }

        private void regulileJoculuiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 Form8=new Form8();
            Form8.Show();
        }

        private void Form7_FormClosed(object sender, FormClosedEventArgs e)
        {
            player1.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            k++;
            sw = true;
            if(k==3)
            {
                button4.Enabled = false;
                button4.Visible = false;
            }
            if (k <= 3)
            {
                nrintr[k] = nr;
                intr[k] = intreb;
                aleator();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            pictureBox6.Visible = false;
            aleator();
            timer3.Stop();
            pictureBox2.Image = Image.FromFile("Fredy4s.gif");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            pictureBox2.Image = Image.FromFile("Fredy4s.gif");
        }
    }
}
