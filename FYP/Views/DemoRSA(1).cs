using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace FYP
{
    public partial class DemoRSA_1_ : UserControl
    {
        public int e;
        int dum;
        int n;
        BigInteger d;
        BigInteger C;
        BigInteger mm;
        int m;
        string get;
        string txt, txt1, txt2, txt3, txt4,txt5, dumy;
        int seconds = 0, seconds1 = 0, count = 0, count1 = 0, count2 = 0, count3 = 0, count4 = 0, count5 = 0;

        private void DemoRSA_1__Load(object sender, EventArgs e)
        {

        }

        private void Reload_Click(object sender, EventArgs e)
        {
            MainForm.Instance.panelContain.Controls.Clear();

            AsymmetricAlgoCategories uc_deffie_HellmanVisualization = new AsymmetricAlgoCategories();
            uc_deffie_HellmanVisualization.Dock = DockStyle.Fill;

            MainForm.Instance.panelContain.Controls.Add(uc_deffie_HellmanVisualization);
            MainForm.Instance.panelContain.Controls["AsymmetricAlgoCategories"].BringToFront();
        }

        DemoRSA obje = new DemoRSA();

        private void powere_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            seconds1++;
            if(seconds1 >= 15)
            {
                down2.Visible = true;
            }
            if(seconds1 >= 30)
            {
                CipherText.Visible = true;
                powere1.Visible = true;
                encryptvlaue.Visible = true;
                                
            }
            if (seconds1 >= 45 && count4 <= 14)
            {
                count4++;
                Decrypt.Text = txt4.Substring(0, count4);
            }
            if (seconds1 >= 75 && count5 <= 12)
            {
                count5++;
                if (count5 == 4)
                {
                    powerd.Visible = true;
                }
                else
                {
                    formuladecrypt.Text = txt5.Substring(0, count5);
                }
            }
            if(seconds1 >= 100)
            {
                lastdown.Visible = true;
            }
            if(seconds1 >= 120)
            {
              //  calculatedecrypt.Text = "";
                mm = power(C, d);
                mm = mm % n;
                calpowerd.Text = d.ToString();
                calculatedecrypt.Text = String.Concat("M", " = ", C.ToString(), "   mod  ", n.ToString(), " = ", mm.ToString());
                calpowerd.Visible = true;
                calculatedecrypt.Visible = true;
                PlainTextt.Visible = true;

            }
            if(seconds1 >= 140)
            {
                //setcipher.Text = "";
                setcipher.Text = C.ToString();
              //  setPlain.Text = "";
                setPlain.Text = value_M.Text;
                panel1.Visible = true;
            }
            if(seconds1 >= 160)
            {
                pause.Visible = false;
                Resume.Visible = false;
                Reload.Visible = true;
                timer2.Stop();
            }
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Stop();
                if (Convert.ToInt32(value_M.Text) >= 1)
                {

                    get = value_M.Text;

                    m = Convert.ToInt32(get.ToString());
                    dum = Convert.ToInt32(dumy);

                    C = power(m, dum);
                    C = C % n;

                    powere1.Text = "";
                    encryptvlaue.Text = "";
                    powere1.Text = dum.ToString();
                    encryptvlaue.Text = String.Concat("C", " = ", m.ToString(), "   mod  ", n.ToString(), " = ", C.ToString());
                    timer2.Start();
                }
                else
                {
                    MessageBox.Show("Please Enter Numeric Value ");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Enter Numeric Value ");

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            if(seconds >= 20 && count <= 17)
            {
                count++;
                publicKey.Text = txt.Substring(0, count);
            }
            if (seconds >= 55)
            {
                left1.Visible = true;
            }
            if (seconds >= 70)
            {
                setPublic.Visible = true;
            }

            if (seconds >= 85 && count1 <= 18)
            {
                count1++;
                privateKey.Text = txt1.Substring(0, count1);                
            }
            if (seconds >= 120)
            {
                left2.Visible = true;
            }
            if (seconds >= 135)
            {
                setPrivate.Visible = true;
            }

            if(seconds >= 150 && count2 <= 14)
            {
                count2++;
                Encryp.Text = txt2.Substring(0, count2);
            }
            if (seconds >= 190 && count3 <= 12)
            {
                count3++;
                if (count3 == 4)
                {
                    powere.Visible = true;
                }
                else
                {
                    formulaencryp.Text = txt3.Substring(0, count3);
                }
            }
            if(seconds >= 215)
            {
                down1.Visible = true;
            }
            if(seconds >= 230)
            {
                enterNum.Visible = true;
            }
            if(seconds >= 245)
            {
                value_M.Visible = true;
                Calculate.Visible = true;
                pause.Visible = false;
                Resume.Visible = true;
                timer1.Stop();
            }

        }

        public DemoRSA_1_()
        {
            InitializeComponent();
        }

        public DemoRSA_1_(DemoRSA obj)
        {
            InitializeComponent();
            timer1.Start();
            //setting Visibility false
            left1.Visible = false;
            left2.Visible = false;
            setPublic.Visible = false;
            setPrivate.Visible = false;
            powere.Visible = false;
            down1.Visible = false;
            enterNum.Visible = false;
            value_M.Visible = false;
            Calculate.Visible = false;
            down2.Visible = false;
            encryptvlaue.Visible = false;
            powere1.Visible = false;
            powerd.Visible = false;
            lastdown.Visible = false;
            calpowerd.Visible = false;
            calculatedecrypt.Visible = false;
            CipherText.Visible = false;
            PlainTextt.Visible = false;
            panel1.Visible = false;


            txt = publicKey.Text;
            publicKey.Text = "";

            txt1 = privateKey.Text;
            privateKey.Text = "";

            txt2 = Encryp.Text;
            Encryp.Text = "";

            txt3 = formulaencryp.Text;
            formulaencryp.Text = "";

            txt4 = Decrypt.Text;
            Decrypt.Text = "";

            txt5 = formuladecrypt.Text;
            formuladecrypt.Text = "";

            e = Convert.ToInt32(obj.dumy.ToString());
            n = obj.n;
            d = obj.cal_d;

            setPublic.Text = "";
            setPublic.Text = String.Concat("{", e.ToString(), ",", n.ToString(), "}");

            setPrivate.Text = "";
            setPrivate.Text=String.Concat("{", d.ToString(), ",", n.ToString(), "}");

            dumy = obj.dumy; 

            this.obje = obj;

            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pause_Click(object sender, EventArgs e)
        {
            Reload.Visible = false;
            pause.Visible = false;
            Resume.Visible = true;
            timer1.Stop();
            if(seconds1 >=1)
            {
                timer2.Stop();
            }
        }

        private void Resume_Click(object sender, EventArgs e)
        {
            pause.Visible = true;
            Resume.Visible = false;
            Reload.Visible = false;
            timer1.Start();
            if (seconds1 >= 1)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DemoRSA demoRSA = new DemoRSA();
            demoRSA.Dock = DockStyle.Fill;
            MainForm.Instance.panelContain.Controls.Add(demoRSA);
            MainForm.Instance.panelContain.Controls["DemoRSA"].BringToFront();
        }
        public BigInteger power(BigInteger x, BigInteger y)
        {
            BigInteger dum = 1;
            BigInteger D;
            for (int i = 1; i <= y; i++)
            {
                dum = dum * x;
            }
            D = dum;
            dum = 1;
            return D;


        }
    }
}
