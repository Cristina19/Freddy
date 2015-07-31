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
    public partial class Form3 : Form
    {
        int intreb,inc=3,x=10,y=0,s=123,pr,nr=1,k,q=-1,f,w=0;
        Label[] l=new Label[42];
        Image Image = Properties.Resources.sare;
        SoundPlayer player1=new SoundPlayer("CA.wav");
        /*String[] judet ={"Alba", "Arad", "Argeș", "Bacău", "Bihor", "Bistrița-Năsăud", "Botoșani", 
                        "Brașov", "Brăila", "Buzău", "Caraș-Severin", "Călărași", "Cluj", "Constanța",
                        "Covasna", "Dâmbovița", "Dolj", "Galați", "Giurgiu", "Gorj", "Harghita", "Hunedoara", 
                        "Ialomița", "Iași", "Ilfov", "Maramureș", "Mehedinți", "Mureș", "Neamț", "Olt", "Prahova", 
                        "Satu Mare", "Sălaj","Sibiu", "Suceava", "Teleorman", "Timiș", "Tulcea", "Vaslui", 
                        "Vâlcea", "Vrancea"};*/
        String[] judet ={"Bihor","Cluj","Bistrița-Năsăud","Sălaj","Maramureș","Satu Mare","Arad","Timiș","Caraș-Severin",
                         "Hunedoara","Mehedinți","Gorj","Vâlcea","Dolj","Olt","Argeș","Dâmbovița","Prahova","Teleorman",
                         "Giurgiu","Ilfov","Călărași","Ialomița","Buzău","Vrancea","Galați","Brăila","Constanța","Tulcea",
                         "Suceava","Botoșani","Neamț","Iași","Bacău","Vaslui","Alba","Sibiu","Brașov","Covasna","Harghita",
                         "Mureș"};
        Button[] bt=new Button[42];
        Random random = new Random();
        String rez, zona, nume;
        bool test_apasat = false;
        int[] v = new int[42];
        public Form3()
        {
            InitializeComponent();
            ascunde();
            label8.Location=new Point(292, 480);
            label8.Font = new Font("Segoe Print", 8);
            label8.Anchor = (AnchorStyles.None);
            using (StreamReader reader = new StreamReader("nume.txt"))
            {
                nume = reader.ReadToEnd();
                reader.Close();
            }
            label8.ForeColor = Color.Black;
        }
        void ascunde()
        {
            button1.Enabled = false;
        }
        void initV()
        {
            bt[6] = button3;//
            bt[7] = button37;//
            bt[8] = button11;//
            bt[9] = button22;//
        }
        void initSV()
        {
            bt[10] = button27;//
            bt[11] = button20;//
            bt[12] = button40;//
            bt[13] = button17;//
            bt[14] = button30;//
        }
        void initS()
        {
            bt[15] = button4;//
            bt[16] = button16;//
            bt[17] = button31;//
            bt[18] = button36;//
            bt[19] = button19;//
            bt[20] = button25;//
            bt[21] = button12;//
            bt[22] = button23;//
        }
        void initSE()
        {
            bt[23] = button10;//
            bt[24] = button41;//
            bt[25] = button18;//
            bt[26] = button9;//
            bt[27] = button14;//
            bt[28] = button38;//
        }
        void initNE()
        {
            bt[29] = button35;//
            bt[30] = button7;//
            bt[31] = button29;//
            bt[32] = button24;//
            bt[33] = button5;//
            bt[34] = button39;//
        }
        void initC()
        {
            bt[35] = button2;//
            bt[36] = button34;//
            bt[37] = button8;//
            bt[38] = button15;//
            bt[39] = button21;//
            bt[40] = button28;//
        }
        void initNV()
        {
            bt[0] = button6;//
            bt[1] = button13;//
            bt[2] = button42;//
            bt[3] = button33;//
            bt[4] = button26;//
            bt[5] = button32;//
        }
        private void CleanForm(Control ctrl)
        {
            int i;
            for (i = k; i <= q; i++)
            {
                bt[i].BackColor = Color.WhiteSmoke;
                bt[i].Text = "";
                bt[i].Enabled = true;
            }
        }
        void sterge()
        {
            int i;
            for(i=k;i<=q;i++)
            {
                bt[i].Visible = false;
                bt[i].Enabled = false;
            }
        }
        void Contrl(String rasp,Button b)
        {

            b.Font = new Font("Microsoft Sans Serif", 5);
            b.ForeColor = Color.Navy;
            b.Text = Convert.ToString(nr);
            b.Enabled = false;
            l[nr] = new Label();
            if (nr == 22)
            {
                x = x + 100;
                y = 15;
            }
            else
                y = y + 15;
            l[nr].Location = new Point(x, y);
            l[nr].Width = 100;
            l[nr].Height=15;
            l[nr].BringToFront();
            timer1.Stop();
            pictureBox2.Image = Properties.Resources.Fredy4s;
            if (inc == 0)
            {
                player1 = new SoundPlayer(Properties.Resources.FA);
                player1.Play();
                timer1.Start();
                pictureBox2.Image = Properties.Resources.Fredy;
                b.BackColor = Color.OrangeRed;
                l[nr].ForeColor = Color.OrangeRed;
                l[nr].Font = new Font("Comic Sans MS", 7);
            }
            else
            {
                player1 = new SoundPlayer(Properties.Resources.CA);
                    player1.Play();
                b.BackColor = Color.DeepSkyBlue;
                l[nr].Font = new Font("Comic Sans MS", 7);
                l[nr].ForeColor = Color.Navy;
            }
            l[nr].Text = Convert.ToString(nr)+"- "+rasp;
            panel1.Controls.Add(l[nr]);
        }
        void inlocuire()
        {
            using (StreamReader reader = new StreamReader("judete.txt"))
            {
                rez = reader.ReadToEnd();
                reader.Close();
            }
            if (Convert.ToInt32(rez) < pr)
            {
                using (StreamWriter writer = new StreamWriter("judete.txt"))
                {
                    writer.Write(Convert.ToString(pr));
                    writer.Close();
                }
            }
        }
        void aleator(int a, int b)
        {
            int i;
            bool sw = false;
            for (i = a; i <= b; i++)
                if (v[i] == 0)
                    sw = true;
            if (sw == true)
            {
                intreb = random.Next(a, b+1);
                while (v[intreb] == 1)
                    intreb = random.Next(a, b+1);
                label3.Text = "Ajută-l pe Freddy să localizeze pe hartă județul " + judet[intreb];
                v[intreb] = 1;
            }
            else
            {
                timer1.Stop();
                pictureBox2.Image = Image;
                pictureBox3.Visible = true;
                pr = s * 100 / f;
                label2.Visible = true;
                label2.BringToFront();
                if (test_apasat == true)
                {
                    label3.Text = "Felicitări, ai terminat jocul!";
                    inlocuire(); 
                    if (pr == 100)
                        label2.Text = "Felicitări, " + nume + ". Ai ajuns la finalul jocului și sunt extrem de mândru de tine! Nu oricine reușește să obțină scorul de 100%. Bravo!";
                    else
                        label2.Text = "Felicitări, " + nume + ". Ai ajuns la finalul jocului. Scorul tău este de " + Convert.ToString(pr) + "%, însă eu te sfătuiesc să continui să te joci până obții 100%.";
                }
                else
                {
                    if(pr==100)
                    {
                        if(w==1)
                            label2.Text = "Felicitări "+nume+" din câte am văzut cunoști zona "+ zona+ " ca pe propriul tău buzunar! Acum poți să treci la o altă regiune dacă dorești.";
                        else
                            label2.Text = "Felicitări " + nume + " din câte am văzut cunoști zona de " + zona + " ca pe propriul tău buzunar! Acum poți să treci la o altă regiune dacă dorești.";
                    }
                    else
                        label2.Text="Bravo, "+nume+" te-ai descurcat bine, însă eu zic să mai exersăm pe această regiune până nu mai faci nicio greșeală.";
                    if(w==1)
                    label3.Text = "Felicitări, ai terminat regiunea "+zona+'!';
                    else
                        label3.Text = "Felicitări, ai terminat regiunea de " + zona + '!';
                }

            }
        }
       void IdeeNoua(int i, String jud, Button btn)
        {
                Contrl(jud, btn);
                inc = 3;
                label8.Text="Încercări rămase: "+ Convert.ToString(inc);
                aleator(k,q);
                nr++;
        }
        void incercari()
        {
            inc--;
            s--;
            label8.Text = "Încercări rămase: " + Convert.ToString(inc);
            if (inc == 0)
                IdeeNoua(intreb, judet[intreb], bt[intreb]);
            else
            {
                    timer1.Stop();
                    pictureBox2.Image = Properties.Resources.Fredy4s;
                    player1 = new SoundPlayer(Properties.Resources.TA);
                    player1.Play();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (intreb == 35)
                IdeeNoua(35, judet[35], bt[35]);
            else
                incercari();
        }

      private void button3_Click(object sender, EventArgs e)
        {
            if (intreb == 6)
                IdeeNoua(6, judet[6], bt[6]);
            else
                incercari();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (intreb == 15)
                IdeeNoua(15, judet[15], bt[15]);
            else
                incercari();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (intreb == 33)
                IdeeNoua(33, judet[33], bt[33]);
            else
                incercari();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (intreb == 0)
                IdeeNoua(0, judet[0], bt[0]);
            else
                incercari();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (intreb == 2)
                IdeeNoua(2, judet[2], bt[2]);
            else
                incercari();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (intreb == 30)
                IdeeNoua(30, judet[30], bt[30]);
            else
                incercari();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (intreb == 37)
                IdeeNoua(37, judet[37], bt[37]);
            else
                incercari();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (intreb == 26)
                IdeeNoua(26, judet[26], bt[26]);
            else
                incercari();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (intreb == 23)
                IdeeNoua(23, judet[23], bt[23]);
            else
                incercari();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (intreb == 8)
                IdeeNoua(8, judet[8], bt[8]);
            else
                incercari();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (intreb == 21)
                IdeeNoua(21, judet[21], bt[21]);
            else
                incercari();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (intreb == 1)
                IdeeNoua(1, judet[1], bt[1]);
            else
                incercari();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (intreb == 27)
                IdeeNoua(27, judet[27], bt[27]);
            else
                incercari();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (intreb == 38)
                IdeeNoua(38, judet[38], bt[38]);
            else
                incercari();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (intreb == 16)
                IdeeNoua(16, judet[16], bt[16]);
            else
                incercari();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (intreb == 13)
                IdeeNoua(13, judet[13], bt[13]);
            else
                incercari();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (intreb == 25)
                IdeeNoua(25, judet[25], bt[25]);
            else
                incercari();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (intreb == 19)
                IdeeNoua(19, judet[19], bt[19]);
            else
                incercari();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (intreb == 11)
                IdeeNoua(11, judet[11], bt[11]);
            else
                incercari();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (intreb == 39)
                IdeeNoua(39, judet[39], bt[39]);
            else
                incercari();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (intreb == 9)
                IdeeNoua(9, judet[9], bt[9]);
            else
                incercari();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (intreb == 22)
                IdeeNoua(22, judet[22], bt[22]);
            else
                incercari();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (intreb == 32)
                IdeeNoua(32, judet[32], bt[32]);
            else
                incercari();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (intreb == 20)
                IdeeNoua(20, judet[20], bt[20]);
            else
                incercari();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (intreb == 4)
                IdeeNoua(4, judet[4], bt[4]);
            else
                incercari();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (intreb == 10)
                IdeeNoua(10, judet[10], bt[10]);
            else
                incercari();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (intreb == 40)
                IdeeNoua(40, judet[40], bt[40]);
            else
                incercari();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (intreb == 31)
                IdeeNoua(31, judet[31], bt[31]);
            else
                incercari();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (intreb == 14)
                IdeeNoua(14, judet[14], bt[14]);
            else
                incercari();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (intreb == 17)
                IdeeNoua(17, judet[17], bt[17]);
            else
                incercari();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (intreb == 5)
                IdeeNoua(5, judet[5], bt[5]);
            else
                incercari();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (intreb == 3)
                IdeeNoua(3, judet[3], bt[3]);
            else
                incercari();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (intreb == 36)
                IdeeNoua(36, judet[36], bt[36]);
            else
                incercari();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (intreb == 29)
                IdeeNoua(29, judet[29], bt[29]);
            else
                incercari();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (intreb == 18)
                IdeeNoua(18, judet[18], bt[18]);
            else
                incercari();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (intreb == 7)
                IdeeNoua(7, judet[7], bt[7]);
            else
                incercari();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (intreb == 28)
                IdeeNoua(28, judet[28], bt[28]);
            else
                incercari();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (intreb == 34)
                IdeeNoua(34, judet[34], bt[34]);
            else
                incercari();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (intreb == 12)
                IdeeNoua(12, judet[12], bt[12]);
            else
                incercari();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (intreb == 24)
                IdeeNoua(24, judet[24], bt[24]);
            else
                incercari();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            inc = 3; x = 10; y = 0; s = f; nr = 1;
            timer1.Stop();
            player1.Stop();
            label8.Text = "Încercări rămase: " + Convert.ToString(inc);
            pictureBox2.Image = Properties.Resources.Fredy4s;
            pictureBox3.Visible = false;
            CleanForm(this);
            label2.Text = "";
            panel1.Controls.Clear();
            for (i = k; i <= q; i++)
                v[i] = 0;
            aleator(k,q);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void regulileJoculuiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 Form6 = new Form6();
            Form6.Show();
        }

        private void regiuneaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //S-E
            int i;
            w = 0;
            sterge();
            player1.Stop();
            initSE();
            timer1.Stop();
            for (i = 23; i <= 28; i++)
            {
                v[i] = 0;
                bt[i].Visible = true;
                bt[i].Enabled = true;
            }
            k = 23; q = 28;
            inc = 3; x = 10; y = 0; s = 18; nr = 1; f = s;
            label8.Text = "Încercări rămase: " + Convert.ToString(inc);
            pictureBox2.Image = Properties.Resources.Fredy4s;
            pictureBox3.Visible = false;
            CleanForm(this);
            panel1.Controls.Clear();
            label2.Text = "";
            for (i = k; i <= q; i++)
                v[i] = 0;
            aleator(k, q);
            button1.Enabled = true;
            test_apasat = false;
            zona = "sud-est";
        }

        private void regiuneaDeNordVestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //N-V
            int i;
            w = 0;
            sterge();
            initNV();
            timer1.Stop();
            player1.Stop();
            for (i = 0; i <= 5; i++)
            {
                v[i] = 0;
                bt[i].Visible = true;
                bt[i].Enabled = true;
            }
            k = 0;  q= 5;
            inc = 3; x = 10; y = 0; s = 18; nr = 1; f = s;
            label8.Text = "Încercări rămase: " + Convert.ToString(inc);
            pictureBox2.Image = Properties.Resources.Fredy4s;
            pictureBox3.Visible = false;
            CleanForm(this);
            panel1.Controls.Clear();
            label2.Text = "";
            for (i = k; i <= q; i++)
                v[i] = 0;
            aleator(k,q);
            button1.Enabled = true;
            test_apasat = false;
            zona = "nord-vest";
        }

        private void testeazățiCunoștințeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            test_apasat = true;
            int i;
            w = 0;
            sterge();
            initNV();
            initV();
            initSV();
            player1.Stop();
            initS();
            initSE();
            initNE();
            timer1.Stop();
            initC();
            for (i = 0; i <= 40; i++)
            {
                v[i] = 0;
                bt[i].Visible = true;
                bt[i].Enabled = true;
            }
            k = 0; q = 40;
            inc = 3; x = 10; y = 0; s = 123; nr = 1; f = s;
            label8.Text = "Încercări rămase: " + Convert.ToString(inc);
            pictureBox2.Image = Properties.Resources.Fredy4s;
            pictureBox3.Visible = false;
            CleanForm(this);
            panel1.Controls.Clear();
            label2.Text = "";
            for (i = k; i <= q; i++)
                v[i] = 0;
            aleator(k, q);
            button1.Enabled = true;
        }

        private void regiuneaDeVestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //V
            int i;
            w = 0;
            sterge();
            initV();
            player1.Stop();
            timer1.Stop();
            for (i = 6; i <= 9; i++)
            {
                v[i] = 0;
                bt[i].Visible = true;
                bt[i].Enabled = true;
            }
            k = 6; q = 9;
            inc = 3; x = 10; y = 0; s = 12; nr = 1; f = s;
            label8.Text = "Încercări rămase: " + Convert.ToString(inc);
            pictureBox2.Image = Properties.Resources.Fredy4s;
            pictureBox3.Visible = false;
            CleanForm(this);
            panel1.Controls.Clear();
            label2.Text = "";
            aleator(k, q);
            button1.Enabled = true;
            test_apasat = false;
            zona = "vest";
        }

        private void regiuneaDeSudVestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //S-V
            int i;
            w = 0;
            sterge();
            timer1.Stop();
            player1.Stop();
            initSV();
            for (i = 10; i <= 14; i++)
            {
                v[i] = 0;
                bt[i].Visible = true;
                bt[i].Enabled = true;
            }
            k = 10; q = 14;
            inc = 3; x = 10; y = 0; s = 15; nr = 1; f = s;
            label8.Text = "Încercări rămase: " + Convert.ToString(inc);
            pictureBox2.Image = Properties.Resources.Fredy4s;
            pictureBox3.Visible = false;
            CleanForm(this);
            panel1.Controls.Clear();
            label2.Text = "";
            aleator(k, q);
            button1.Enabled = true;
            test_apasat = false;
            zona = "sud-vest";
        }

        private void regiuneaDeSudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //S
            int i;
            w = 0;
            sterge();
            initS();
            timer1.Stop();
            player1.Stop();
            for (i = 15; i <= 22; i++)
            {
                v[i] = 0;
                bt[i].Visible = true;
                bt[i].Enabled = true;
            }
            k = 15; q = 22;
            inc = 3; x = 10; y = 0; s = 24; nr = 1; f = s;
            label8.Text = "Încercări rămase: " + Convert.ToString(inc);
            pictureBox2.Image = Properties.Resources.Fredy4s;
            pictureBox3.Visible = false;
            CleanForm(this);
            panel1.Controls.Clear();
            label2.Text = "";
            aleator(k, q);
            button1.Enabled = true;
            test_apasat = false;
            zona = "sud";
        }

        private void regiuneaDeNordEstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //N-E
            int i;
            w = 0;
            sterge();
            initNE();
            player1.Stop();
            timer1.Stop();
            for (i = 29; i <= 34; i++)
            {
                v[i] = 0;
                bt[i].Visible = true;
                bt[i].Enabled = true;
            }
            k = 29; q = 34;
            inc = 3; x = 10; y = 0; s = 18; nr = 1; f = s;
            label8.Text = "Încercări rămase: " + Convert.ToString(inc);
            pictureBox2.Image = Properties.Resources.Fredy4s;
            pictureBox3.Visible = false;
            CleanForm(this);
            panel1.Controls.Clear();
            label2.Text = "";
            aleator(k, q);
            button1.Enabled = true;
            test_apasat = false;
            zona = "nord-est";
        }

        private void centruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //C
            int i;
            w = 1;
            sterge();
            initC();
            timer1.Stop();
            player1.Stop();
            for (i = 35; i <= 40; i++)
            {
                v[i] = 0;
                bt[i].Visible = true;
                bt[i].Enabled = true;
            }
            k = 35; q = 40;
            inc = 3; x = 10; y = 0; s = 18; nr = 1; f = s;
            label8.Text = "Încercări rămase: " + Convert.ToString(inc);
            pictureBox2.Image = Properties.Resources.Fredy4s;
            pictureBox3.Visible = false;
            CleanForm(this);
            panel1.Controls.Clear();
            label2.Text = "";
            aleator(k, q);
            button1.Enabled = true;
            test_apasat = false;
            zona = "centrală";
        }

        private void panel2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            pictureBox2.Image = Properties.Resources.Fredy4s;
        }

    }
}
