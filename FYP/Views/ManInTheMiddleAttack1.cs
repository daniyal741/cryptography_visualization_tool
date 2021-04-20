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
    public partial class ManInTheMiddleAttack1 : UserControl
    {

        int seconds = 0, state = 0, count = 0, count1 = 0,loaddataonce=1;
        string txt,txt1;
        public int pnum;
        public int qnum;
        public int pow;
        public BigInteger calculationAlexa;
        public BigInteger calculationBob;
        public int XkeyNumber { get; set; }

        public int YkeyNumber { get; set; }

        public BigInteger setForward, setbackward;

        public ManInTheMiddleAttack1()
        {
            InitializeComponent();
            
            downarrow2.Visible = false;
            downarrow3.Visible = false;
            downarrrow4.Visible = false;
            downarrow5.Visible = false;
            B.Visible = false;
            ycal.Visible = false;
            A.Visible = false;
            man_in_middle_attack.Visible = false;
            mtmpic.Visible = false;
            hacker.Visible = false;
            xcal.Visible = false;
            forward.Visible = false;
            backward.Visible = false;
            setA.Visible = false;
            setb.Visible = false;
            left.Visible = false;
            right.Visible = false;
            texthacker.Visible = false;
            pichacker.Visible = false;

            txt = sending.Text;
            sending.Text = "";
            txt1 = recieving.Text;
            recieving.Text = "";


            one.Visible = false;
            two.Visible = false;
            three.Visible = false;
            four.Visible = false;
            five.Visible = false;
            six.Visible = false;
            seven.Visible = false;
            eight.Visible = false;
            bone.Visible = false;
            btwo.Visible = false;
            bthree.Visible = false;
            bfour.Visible = false;
            bfive.Visible = false;
            bsix.Visible = false;
            bseven.Visible = false;
            beight.Visible = false;
          

            p_number.Text = "11";
            q_number.Text = "7";
            pnum = Convert.ToInt32(p_number.Text);
            qnum = Convert.ToInt32(q_number.Text);
            


        }
        public void loaddata()
        {
            XkeyNumber = Convert.ToInt32(Xkeybox.Text);
            YkeyNumber = Convert.ToInt32(YkeybOX.Text);


            calculationAlexa = power(qnum, XkeyNumber);
            calculationAlexa = calculationAlexa % pnum;

            xcal.Text += String.Concat("A ", "= ", qnum, " pow (", XkeyNumber, ") MOD ", pnum, " = ", calculationAlexa, "\n");

            calculationBob = power(qnum, YkeyNumber);
            calculationBob = calculationBob % pnum;
            ycal.Text += String.Concat("B ", "= ", qnum, " pow (", YkeyNumber, ") MOD ", pnum, " = ", calculationBob, "\n");

            

            setForward = calculationAlexa;
            setbackward = calculationBob;

            setA.Text = setForward.ToString();
            setb.Text = setbackward.ToString();
        }

        private void DeffieHellmanVisualization_4__Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            

        }

        
        /*private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }*/

        private void ycal_TextChanged(object sender, EventArgs e)
        {

        }

        private void man_in_middle_attack_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
           
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void Resume_Click(object sender, EventArgs e)
        {
            start.Visible = false;
            stop.Visible = true;
            Resume.Visible = false;
            
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AsymmetricAlgoCategories uc_asymmetricAlgoCategories = new AsymmetricAlgoCategories();
            uc_asymmetricAlgoCategories.Dock = DockStyle.Fill;
            MainForm.Instance.panelContain.Controls.Add(uc_asymmetricAlgoCategories);
            MainForm.Instance.panelContain.Controls["AsymmetricAlgoCategories"].BringToFront();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Diffie-Hellman key exchange is vulnerable to a man-in-the-middle attack. In this attack, an opponent Carol intercepts Alice's public value and sends her own public value to Bob. When Bob transmits his public value, Carol substitutes it with her own and sends it to Alice");
        }

        private void YkeybOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;

            if (seconds >= 15)
            {
                downarrow2.Visible = true;
            }

            if (seconds >= 30)
            {
                A.Visible = true;
            }

            if (seconds >= 45)
            {
                downarrow3.Visible = true;
            }
            if (seconds == 60)
            {
                xcal.Visible = true;                        

            }
            if(seconds >= 75)
            {
                downarrrow4.Visible = true;
            }
            if (seconds >= 90)
            {
                B.Visible = true;
            }
            if (seconds >= 105)
            {
                downarrow5.Visible = true;                               
            }
            if (seconds >= 120)
            {
                ycal.Visible = true;
            }
            if(seconds >= 135)
            {
                left.Visible = true;
            }
            if (seconds >= 150 && count <= 6)
            {
                count++;
                sending.Text = txt.Substring(0, count);

                if (sending.ForeColor == Color.Black)
                {
                    sending.ForeColor = Color.DarkRed;
                }
                else
                {
                    sending.ForeColor = Color.Black;
                }
            }
            if(seconds>=170 && seconds < 185)
            {
                one.Text = calculationAlexa.ToString();
                one.Visible = true;
            }
            if (seconds >= 185)
            {
                pichacker.Visible = true;
                texthacker.Visible = true;
            }

            if (seconds >= 195)
            {
                right.Visible = true;
            }

            if (seconds >= 210 && count1 <= 6)
            {
                count1++;
                recieving.Text = txt1.Substring(0, count1);
                if (recieving.ForeColor == Color.Black)
                {
                    recieving.ForeColor = Color.Blue;
                }
                else
                {
                    recieving.ForeColor = Color.Black;
                }

            }

            if(seconds>=230 && seconds < 240)
            {
                bone.Text = calculationBob.ToString();
                bone.Visible = true;
            }

            if (seconds >= 240 )
            {
                pichacker.Visible = false;
                texthacker.Visible = false;
            }


            if (seconds >= 243 && seconds < 250)
            {
                hacker.Visible = true;
                man_in_middle_attack.Visible = true;
                
                mtmpic.Visible = true;
                
            }



            //sending Receving labels
            
            if (seconds >= 250 && seconds < 253)
            {
                one.Visible = false;
                two.Text = calculationAlexa.ToString();
                two.Visible = true;
            }
            if (seconds >= 253 && seconds < 256)
            {
                two.Visible = false;
                three.Text = calculationAlexa.ToString();
                three.Visible = true;
            }
            if (seconds >= 256 && seconds < 259)
            {
                three.Visible = false;
                four.Text = calculationAlexa.ToString();
                four.Visible = true;
            }
            if (seconds >= 259 && seconds < 261)
            {
                four.Visible = false;
                five.Text = calculationAlexa.ToString();
                five.Visible = true;
            }
            if (seconds >= 261 && seconds < 264)
            {
                five.Visible = false;
                six.Text = calculationAlexa.ToString();
                six.Visible = true;
            }
            if (seconds >= 264 && seconds < 267)
            {
                six.Visible = false;
                seven.Text = calculationAlexa.ToString();
                seven.Visible = true;
            }
            if (seconds >= 267 && seconds < 270)
            {
                seven.Visible = false;
                eight.Text = calculationAlexa.ToString();
                eight.Visible = true;
            }
            if (seconds >= 270 && seconds < 273)
            {
                eight.Visible = false;
                setA.Text = calculationAlexa.ToString();
                setA.Visible = true;
            }
            
            if (seconds >= 273 && seconds < 276)
            {
                bone.Visible = false;
                btwo.Text = calculationBob.ToString();
                btwo.Visible = true;
            }
            if (seconds >= 276 && seconds < 279)
            {
                btwo.Visible = false;
                bthree.Text = calculationBob.ToString();
                bthree.Visible = true;
            }
            if (seconds >= 279 && seconds < 282)
            {
                bthree.Visible = false;
                bfour.Text = calculationBob.ToString();
                bfour.Visible = true;
            }
            if (seconds >= 282 && seconds < 285)
            {
                bfour.Visible = false;
                bfive.Text = calculationBob.ToString();
                bfive.Visible = true;
            }
            if (seconds >= 285 && seconds < 288)
            {
                bfive.Visible = false;
                bsix.Text = calculationBob.ToString();
                bsix.Visible = true;
            }
            if (seconds >= 288 && seconds < 291)
            {
                bsix.Visible = false;
                bseven.Text = calculationBob.ToString();
                bseven.Visible = true;
            }
            if (seconds >= 291 && seconds < 294)
            {
                bseven.Visible = false;
                beight.Text = calculationBob.ToString();
                beight.Visible = true;
            }
            if (seconds >= 294 && seconds < 297)
            {
                beight.Visible = false;
                setb.Text = calculationBob.ToString();
                setb.Visible = true;
            }
            
            if(seconds >= 300)
            {
                timer1.Stop();
                timer1.Dispose();
                ManInMiddleAttack5 uc_manInMiddleAttack5 = new ManInMiddleAttack5(this);
                uc_manInMiddleAttack5.Dock = DockStyle.Fill;
                MainForm.Instance.panelContain.Controls.Add(uc_manInMiddleAttack5);

                MainForm.Instance.panelContain.Controls["ManInMiddleAttack5"].BringToFront();

            }
           
        }

        private void stop_Click(object sender, EventArgs e)
        {
            state = this.seconds;
            
            timer1.Enabled = false;
            Resume.Visible = true;
            stop.Visible = false;
            start.Visible = false;
        }

        private void start_Click(object sender, EventArgs e)
        {
            
            try
            {
                XkeyNumber = Convert.ToInt32(Xkeybox.Text);
                YkeyNumber = Convert.ToInt32(YkeybOX.Text);
                

                if (XkeyNumber == null || YkeyNumber == null)
                {
                    MessageBox.Show("Please Enter the Scerte KEY");
                    seconds = 0;
                    timer1.Stop();
                    start.Visible = true;
                    stop.Visible = false;
                    Resume.Visible = false;
                }
                else
                {
                    if(loaddataonce == 1)
                    {
                        loaddataonce++;
                        loaddata();
                    }
                    timer1.Start();
                    stop.Visible = true;
                    start.Visible = false;
                    Resume.Visible = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Enter the Scerte KEY");
                timer1.Stop();
                start.Visible = true;
                stop.Visible = false;
                man_in_middle_attack.Visible = false;

            }

            
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
        private void ManInTheMiddleAttack1_Load(object sender, EventArgs e)
        {

        }
    }
}
