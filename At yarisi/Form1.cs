using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace At_yarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinciatinsoluzaklik, ikinciatinsoluzaklik, ucuncuatinsoluzaklik, dorduncuatinsoluzaklik, besinciatincoluzaklik, altinciatinsoluzaklik;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            lblbaslangic.Visible = false;
            lblekran.Text = "Yaris basladi!!!";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int derece = Convert.ToInt32(zaman.Text);
            derece++;          
            zaman.Text = derece.ToString();
            int birinciatingenisligi = at1.Width;
            int ikinciatingenisligi = at2.Width;
            int ucuncuatingenisligi = at3.Width;
            int dorduncuatingenisligi = at4.Width;
            int besinciatingenisligi = at5.Width;
            int altinciatingenisligi = at6.Width;

            int bitisuzakligi = lblbitis.Left;

            at1.Left += rastgele.Next(5, 15);
            at2.Left += rastgele.Next(5, 15);
            at3.Left += rastgele.Next(5, 15);
            at4.Left += rastgele.Next(5, 15);
            at5.Left += rastgele.Next(5, 15);
            at6.Left += rastgele.Next(5, 15);

            if(at1.Left>at2.Left+5&& at1.Left > at3.Left + 5 && at1.Left > at4.Left + 5 && at1.Left > at5.Left + 5 && at1.Left > at6.Left + 5 )
            {
                lblekran.Text = "1. at liderligi ele gecirdi";
            }
            if (at2.Left > at1.Left + 5 && at2.Left > at3.Left + 5 && at2.Left > at4.Left + 5 && at2.Left > at5.Left + 5 && at2.Left > at6.Left + 5)
            {
                lblekran.Text = "2. at liderligi ele gecirdi";
            }
            if (at3.Left > at1.Left + 5 && at3.Left > at2.Left + 5 && at3.Left > at4.Left + 5 && at3.Left > at5.Left + 5 && at3.Left > at6.Left + 5)
            {
                lblekran.Text = "3. at liderligi ele gecirdi";
            }
            if (at4.Left > at1.Left + 5 && at4.Left > at2.Left + 5 && at4.Left > at3.Left + 5 && at4.Left > at5.Left + 5 && at4.Left > at6.Left + 5)
            {
                lblekran.Text = "4. at liderligi ele gecirdi";
            }
            if (at5.Left > at1.Left + 5 && at5.Left > at2.Left + 5 && at5.Left > at3.Left + 5 && at5.Left > at4.Left + 5 && at5.Left > at6.Left + 5)
            {
                lblekran.Text = "5. at liderligi ele gecirdi";
            }
            if (at6.Left > at1.Left + 5 && at6.Left > at2.Left + 5 && at6.Left > at3.Left + 5 && at6.Left > at4.Left + 5 && at6.Left > at5.Left + 5)
            {
                lblekran.Text = "6. at liderligi ele gecirdi";
            }


            if (birinciatingenisligi + at1.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                lblekran.Text = ("1 Numaralari at yarisi kazandi!!!");                
            }
            if (ikinciatingenisligi + at2.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                lblekran.Text = ("2 Numaralari at yarisi kazandi!!!");
            }
            if (ucuncuatingenisligi + at3.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                lblekran.Text = ("3 Numaralari at yarisi kazandi!!!");
            }
            if (dorduncuatingenisligi + at4.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                lblekran.Text = ("4 Numaralari at yarisi kazandi!!!");
            }
            if (besinciatingenisligi + at5.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                lblekran.Text = ("5 Numaralari at yarisi kazandi!!!");
            }
            if (altinciatingenisligi + at6.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                lblekran.Text = ("6 Numaralari at yarisi kazandi!!!");
            }

        }

        Random rastgele = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatinsoluzaklik = at1.Left;
            ikinciatinsoluzaklik = at2.Left;
            ucuncuatinsoluzaklik = at3.Left;
            dorduncuatinsoluzaklik = at4.Left;
            besinciatincoluzaklik = at5.Left;
            altinciatinsoluzaklik = at6.Left;

        }
    }
}
