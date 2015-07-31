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
using System.Media;

namespace Freddy
{
    public partial class Form9 : Form
    {
        String rez1, rez2, rez3,juc,des,pac;
        SoundPlayer player1;
        int a, b, c, final;
        public Form9()
        {
            InitializeComponent();
            init();
        }
        void init()
        {
            label10.Visible = false;
            using (StreamReader reader = new StreamReader("judete.txt"))
            {
                rez1 = reader.ReadToEnd();
                reader.Close();
                a = Convert.ToInt32(rez1);
            }
            using (StreamReader reader = new StreamReader("obiective.txt"))
            {
                rez2 = reader.ReadToEnd();
                reader.Close();
                b = Convert.ToInt32(rez2);
            }
            using (StreamReader reader = new StreamReader("explorator.txt"))
            {
                rez3 = reader.ReadToEnd();
                reader.Close();
                c = Convert.ToInt32(rez3);
            }
            final = (a + b + c) / 3;
            label5.Text = Convert.ToString(final) + "%";
            using (StreamReader reader = new StreamReader("sex.txt"))
            {
                if (reader.ReadToEnd() == "Băiat")
                {
                    juc = "jucătorului";
                    des = "descurajat";
                }
                else
                {
                    juc = "jucătoarei";
                    des = "descurajată";
                }

            }
            using (StreamReader reader = new StreamReader("nume.txt"))
            {
                rez3 = reader.ReadToEnd();
                label3.Text = juc+" "+ rez3;
                label7.Text = "Felicitări, " + rez3+"!";
                reader.Close();
            } 
            using (StreamReader reader = new StreamReader("pacaleala.txt"))
            {
                pac = reader.ReadToEnd();
                if(pac!="-1")
                {
                    label10.Visible = true;
                    using (StreamWriter writer = new StreamWriter("explorator.txt"))
                    {
                        writer.Write("-1");
                        writer.Close();
                    }
                    using (StreamWriter writer = new StreamWriter("judete.txt"))
                    {
                        writer.Write("-1");
                        writer.Close();
                    } using (StreamWriter writer = new StreamWriter("obiective.txt"))
                    {
                        writer.Write("-1");
                        writer.Close();
                    }
                }
                reader.Close();
            }
            using (StreamWriter writer = new StreamWriter("pacaleala.txt"))
            {
                writer.Write("-1");
                writer.Close();
            }
            if(final<70&&final>49)
            {
                label2.Text = "EXPLORATOR";
                label8.Text = "Deși nu ai reușit să obții un punctaj mai mare de 70%, te-ai straduit să ajungi până aici, lucru care este de apreciat! Continuă să explorezi si... cine știe? Poate că într-o zi vei primi râvnitul titlu de mare explorator!";
            }
            else
                if(final>69)
                {
                    label2.Text = "MARE EXPLORATOR";
                    label8.Text = "Este o onoare pentru mine să mă aflu în prezența unui asemenea explorator măreț! Călătoria cu tine a fost incredibilă și sper să repetăm această experiență cât mai curând. Până atunci, rămâi cu bine camarade!";
                }
                else
                {
                    label2.Text = "CERCETAȘ";
                    label8.Font = new Font("Segoe Print", 8);
                    label8.Text = "Ai ajuns la finalul jocului. Mai ai multe de învățat despre lumea în care trăim, însă nu te lăsa "+des+"! Un adevărat explorator nu renunță niciodată. Tot ceea ce-ți trebuie este puțină ambiție și poftă de aventură și vei primi titlul de mare exploator cât ai zice pește!";
                }
            player1 = new SoundPlayer(Properties.Resources.adevaratulfinal);
            player1.Play();
        }
        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void Form9_FormClosed(object sender, FormClosedEventArgs e)
        {
            player1.Stop();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
        
    }
}
