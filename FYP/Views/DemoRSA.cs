using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYP
{
    public partial class DemoRSA : UserControl
    {
        int seconds = 0, seconds1 = 0, count = 0, count1 = 0, count2 = 0,count3 = 0,count4=0,count5 = 0,dum_Count=0;
        public int cal_d =0,ed;

        int p = 11;
        int q = 3;
        public int n,e_value;
        public int theta_n,get_gcd;
        int value_Gcd;
        public string dumy,dumy1;
        public string txt, txt1, txt2, txt3, txt4,txt5;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Resume.Visible = true;
            pause.Visible = false;
            stop.Visible = false;
            if(seconds1 >=1)
            {
          
                timer2.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            seconds1++;
            if (seconds1 >= 15 && count4 <= 17)
            {
                count4++;                
                formula_D.Text = txt4.Substring(0, count4);
                
            }
            if (seconds1 >= 45)
            {
                left4.Visible = true;
            }
            if (seconds1 >= 60)
            {
                //extr.Text = "";
                extr.Text = String.Concat(dumy.ToString(), " * ", cal_d, " mod ", theta_n.ToString(), " = ");
            }
            if (seconds1 >= 75)
            {
                extra.Visible = true;
            }
            if(seconds1 >= 90 && count5 <= 17)
            {
                count5++;
                e_formula.Text = txt5.Substring(0, count5);
            }

            if(seconds1 >= 120)
            {
                left5.Visible = true;
            }
            if(seconds1 >= 135)
            {
                formulaED.Visible = true;
            }
            if(seconds1 >= 150)
            {
                cal.Visible = true;
            }

            if(seconds1 >= 185)
            {
                timer1.Stop();
                timer2.Stop();
                timer1.Dispose();
                timer2.Dispose();
                dumy = Value_e.Text;
                DemoRSA_1_ demoRSA = new DemoRSA_1_(this);
                demoRSA.Dock = DockStyle.Fill;
                MainForm.Instance.panelContain.Controls.Add(demoRSA);
                MainForm.Instance.panelContain.Controls["DemoRSA_1_"].BringToFront();
            }
        }

        private void Resume_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Resume.Visible = false;
            pause.Visible = true;
            stop.Visible = false;
            if(seconds1 >= 1)
            {
                timer2.Start();
            }
        }

        public DemoRSA()
        {
            InitializeComponent();
            //set visbilty false on start
            
            pictureALEX.Visible = false;
            down1.Visible = false;
            //nformula.Visible = false;
            left1.Visible = false;
            n_formula.Visible = false;
            value_n.Visible = false;
            left2.Visible = false;
            //piformula.Visible = false;
            Left3.Visible = false;
            SetphiN.Visible = false;
            valuePhi.Visible = false;
            Value_e.Visible = false;
            stop.Visible = false;
            extr.Text = "";
            extra.Visible = false;
            left4.Visible = false;
            left5.Visible = false;
            formulaED.Visible = false;
            cal.Visible = false;

            txt = userr.Text;
            userr.Text = "";

            txt1 = nformula.Text;
            nformula.Text = "";

            txt2 = piformula.Text;
            piformula.Text = "";

            txt3 = Chose_E.Text;
            Chose_E.Text = "";

            txt4 = formula_D.Text;
            formula_D.Text = "";

            txt5 = e_formula.Text;
            e_formula.Text = "";

            p_number.Text = p.ToString();
            q_number.Text = q.ToString();
            n = p * q;
            theta_n=(p-1)*(q-1);

            n_formula.Text = "";
            n_formula.Text = String.Concat(p.ToString(), " * ", q.ToString(), " = ");
            

            value_n.Text = n.ToString();
            SetphiN.Text = "";
            SetphiN.Text = String.Concat("(", p.ToString(), " - ", "1", ")", " * ", "(", q.ToString(), " - ", "1", ")"," = ");
            valuePhi.Text = "";
            valuePhi.Text = theta_n.ToString();
            
        }

        private void DemoRSA_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Resume.Visible = true;
            pause.Visible = false;
            stop.Visible = false;
            if (seconds1 >= 1)
            {

                timer2.Stop();
            }
            MessageBox.Show("RSA (Rivest–Shamir–Adleman) is an algorithm used by modern computers to encrypt and decrypt messages. It is an asymmetric cryptographic algorithm. Asymmetric means that there are two different keys. This is also called public key cryptography, because one of the keys can be given to anyone." +
                "Choose two different large random prime numbers " +
                "\n\n Calculate  n=pq" +
                "\n\n n is the modulus for the public key and the private keys" +
                "\n\n Calculate the φ(n) = (p-1)(q-1)" +
                "\n\n Choose an integer e such that 1 < e < φ(n)" +
                "\n\n Calculate d=(1+ x φ(n))/e"
                );
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AsymmetricAlgoCategories uc_demoRSA = new AsymmetricAlgoCategories();
            uc_demoRSA.Dock = DockStyle.Fill;
            MainForm.Instance.panelContain.Controls.Add(uc_demoRSA);
            MainForm.Instance.panelContain.Controls["AsymmetricAlgoCategories"].BringToFront();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            try
            {
                dumy = Value_e.Text;
                e_value = Convert.ToInt32(dumy);
                if (1 < e_value && e_value < theta_n)
                {
                    get_gcd = gcd(theta_n, e_value);

                    if (get_gcd == 1)
                    {

                        pause.Visible = true;
                        d(e_value, theta_n);
                        stop.Visible = false;
                        timer2.Start();

                    }
                    else
                    {
                        timer1.Stop();
                        MessageBox.Show("Please Choose the Value for E\n It must be greater than 1 and it must be Prime Number\n And it Must be less than φ(n) \n GCD of E is always be 1 ");
                    }
                }
                else
                {
                    MessageBox.Show("Please Choose the Value for E\n It must be greater than 1 and it must be Prime Number\n And it Must be less than φ(n) \n GCD of E is always be 1 ");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Choose the Value for E\n It must be greater than 1 and it must be Prime Number\n And it Must be less than φ(n) \n GCD of E is always be 1 ");
            }


        }

        private void cal_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            if(seconds >= 15 && count<=3)
            {
                count++;
                userr.Text = txt.Substring(0, count);
            }
            if(seconds >= 30)
            {
                pictureALEX.Visible = true;
            }

            if(seconds >= 45)
            {
                down1.Visible = true;

            }
            if (seconds >= 60 && count1 <= 8)
            {
                count1++;
                nformula.Text = txt1.Substring(0, count1);
            }
            if(seconds >= 80)
            {
                left1.Visible = true;
            }
            if (seconds >= 95)
            {
                n_formula.Visible = true;
            }
            if(seconds >= 110)
            {
                value_n.Visible = true;
            }
            if(seconds >= 125)
            {
                left2.Visible = true;
            }
            if(seconds >= 140 && count2 <=19)
            {
                count2++;
                piformula.Text = txt2.Substring(0, count2);
            }

            if(seconds >= 177)
            {
                Left3.Visible = true;
            }
            if(seconds >= 192)
            {
                SetphiN.Visible = true;
            }
            if(seconds >= 205)
            {
                valuePhi.Visible = true;
            }
            if(seconds >= 220 && count3 <= 18)
            {
                count3++;
                Chose_E.Text = txt3.Substring(0, count3);
            }
            if(seconds >= 255)
            {
                timer1.Stop();
                timer1.Dispose();
                Value_e.Visible = true;                
                stop.Visible = true;
                Resume.Visible = true;
                button2.Visible = false;

                if (dum_Count == 0)
                {
                    MessageBox.Show("Please Choose the Value for E\n It must be greater than 1 and it must be Prime Number\n GCD of E is always be 1 ");
                    dum_Count++;
                }
            }

           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            stop.Visible = false;
            button2.Visible = false;
            Resume.Visible = false;
            pause.Visible = true;
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public int gcd(int theta,int e)
        {
            for (int i = 1; i <= theta && i <= e; i++)
            {
                // Checks if i is factor of both integers
                if (theta % i == 0 && e % i == 0)
                {
                    value_Gcd = i;
                }
            }
            return value_Gcd;
        }

        public void d(int e,int theta)
        {
            
            for (int i=1; i<=theta; i++)
            {
                if(e * i % theta == 1 && i != e)
                {
                    cal_d = i;
                }
            }
            //cal_d = (1.0 / e) % theta;
            extra.Text = "";
            extra.Text = cal_d.ToString();

            formulaED.Text = "";
            formulaED.Text = String.Concat(e.ToString(), " * ", cal_d.ToString(), " mod ", theta.ToString(), " = ");

            ed = (e * cal_d) % theta;
            cal.Text = "";
            cal.Text = ed.ToString();

        }
    }
}
