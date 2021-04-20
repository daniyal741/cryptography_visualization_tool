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
    public partial class ManInMiddleAttack5 : UserControl
    {
        public ManInMiddleAttack5()
        {
            InitializeComponent();
        }

        private void ManInMiddleAttack5_Load(object sender, EventArgs e)
        {

        }

        
        int seconds = 0, counter = 0,counter1=0,counter2=0,counter3=0;
        string txt,txt1,txt2,txt3,sendingyhacker,sendingxhacker;
        public BigInteger pnum;
        public BigInteger qnum;
        public BigInteger pow;
        public BigInteger calculationAlexa { get; set; }
        public BigInteger calculationBob { get; set; }
        public int XkeyNumber { get; set; }

        public int YkeyNumber { get; set; }

        private void stop_Click(object sender, EventArgs e)
        {
            start.Visible = true;
            stop.Visible = false;
            Reload.Visible = false;
            timer1.Stop();
        }

        private void start_Click(object sender, EventArgs e)
        {
            stop.Visible = true;
            start.Visible = false;
            Reload.Visible = false;
            timer1.Start();
        }

        private void back_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Dispose();
            MainForm.Instance.panelContain.Controls.Clear();
            AsymmetricAlgoCategories uc_category = new AsymmetricAlgoCategories();
            uc_category.Dock = DockStyle.Fill;

            MainForm.Instance.panelContain.Controls.Add(uc_category);
            MainForm.Instance.panelContain.Controls["AsymmetricAlgoCategories"].BringToFront();
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Dispose();
            MainForm.Instance.panelContain.Controls.Clear();

            AsymmetricAlgoCategories uc_deffie_HellmanVisualization = new AsymmetricAlgoCategories();
            uc_deffie_HellmanVisualization.Dock = DockStyle.Fill;

            MainForm.Instance.panelContain.Controls.Add(uc_deffie_HellmanVisualization);
            MainForm.Instance.panelContain.Controls["AsymmetricAlgoCategories"].BringToFront();
        }

        public int xhacker, yhacker;
        public int getxcal, getycal;

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ManInTheMiddleAttack1 obj = new ManInTheMiddleAttack1();
            obj.Dock = DockStyle.Fill;
            MainForm.Instance.panelContain.Controls.Add(obj);
            MainForm.Instance.panelContain.Controls["ManInTheMiddleAttack1"].BringToFront();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            seconds++;
            if(seconds >= 20)
            {
                hdown11.Visible = true;        
              
            }
            if (seconds >= 35)
            {
                htext11.Visible = true;
            }
            if (seconds >= 50)
            {
                hdown22.Visible = true;
            }
            if (seconds >= 65)
            {
                HackerCalculateY.Visible = true;
            }
            if (seconds >= 80 && seconds < 85)
            {
                one.Text = sendingyhacker;
                one.Visible = true;
            }
            if (seconds >= 85 && seconds < 95)
            {
                one.Visible = false;
                two.Text = sendingyhacker;
                two.Visible = true;
            }
            if (seconds >= 90 && seconds < 95)
            {
                two.Visible = false;
                three.Text = sendingyhacker;
                three.Visible = true;
            }
            if (seconds >= 95 && seconds < 100)
            {
                three.Visible = false;
                four.Text = sendingyhacker;
                four.Visible = true;
            }
            if (seconds >= 100 && seconds < 105)
            {
                four.Visible = false;
                five.Text = sendingyhacker;
                five.Visible = true;
            }
            if (seconds >= 105 && seconds < 110)
            {
                five.Visible = false;
                six.Text = sendingyhacker;
                six.Visible = true;
            }
            if (seconds >= 110 && seconds < 115)
            {
                six.Visible = false;
                seven.Text = sendingyhacker;
                seven.Visible = true;
            }
            if (seconds >= 115 && seconds < 120)
            {
                seven.Visible = false;
                eight.Text = sendingyhacker;
                eight.Visible = true;
            }
            if (seconds >= 120 && seconds < 125)
            {
                eight.Visible = false;
                nine.Text = sendingyhacker;
                nine.Visible = true;
            }
            if (seconds >= 125 && seconds < 130)
            {
                nine.Visible = false;
                ten.Text = sendingyhacker;
                ten.Visible = true;
            }
            if (seconds >= 130 && seconds < 135)
            {
                ten.Visible = false;
                eleven.Text = sendingyhacker;
                eleven.Visible = true;
            }
            if (seconds >= 135 && seconds < 140)
            {
                eleven.Visible = false;
                twelve.Text = sendingyhacker;
                twelve.Visible = true;
            }
            if(seconds >= 140 && seconds < 145)
            {
                Down1.Visible = true;
            }
            if (seconds >= 145 && counter <= 8)
            {
                counter++;
                A.Text = txt.Substring(0, counter);
            }
            
            if(seconds >= 165 && seconds < 180)
            {
                Down2.Visible = true;
            }
            if(seconds >=180 && counter1 <= 19)
            {
                counter1++;
                FormulaA.Text = txt1.Substring(0, counter1);
            }
            if(seconds >= 215 && seconds < 230)
            {
                xcal.Visible = true;
            }
            if(seconds >= 230 && seconds < 245)
            {
                hdown1.Visible = true;
            }
            if (seconds >= 245 && seconds < 260)
            {
                htext1.Visible = true;
            }
            if (seconds >= 260 && seconds < 275)
            {
                hdown2.Visible = true;
            }
            if (seconds >= 275 && seconds < 290)
            {
                hackerCAlculateX.Visible = true;
            }

           
            if (seconds >= 290 && seconds < 295)
            {
                
                btwo.Text = sendingxhacker;
                btwo.Visible = true;
            }
            if (seconds >= 295 && seconds < 300)
            {
                btwo.Visible = false;
                bthree.Text = sendingxhacker;
                bthree.Visible = true;
            }
            if (seconds >= 300 && seconds < 305)
            {
                bthree.Visible = false;
                bfour.Text = sendingxhacker;
                bfour.Visible = true;
            }
            if (seconds >= 305 && seconds < 310)
            {
                bfour.Visible = false;
                bfive.Text = sendingxhacker;
                bfive.Visible = true;
            }
            if (seconds >= 310 && seconds < 315)
            {
                bfive.Visible = false;
                bsix.Text = sendingxhacker;
                bsix.Visible = true;
            }
            if (seconds >= 315 && seconds < 320)
            {
                bsix.Visible = false;
                bseven.Text = sendingxhacker;
                bseven.Visible = true;
            }
            if (seconds >= 320 && seconds < 325)
            {
                bseven.Visible = false;
                beight.Text = sendingxhacker;
                beight.Visible = true;
            }
            if (seconds >= 325 && seconds < 330)
            {
                beight.Visible = false;
                bnine.Text = sendingxhacker;
                bnine.Visible = true;
            }
            if (seconds >= 330 && seconds < 335)
            {
                bnine.Visible = false;
                bten.Text = sendingxhacker;
                bten.Visible = true;
            }
            if (seconds >= 335 && seconds < 340)
            {
                bten.Visible = false;
                beleven.Text = sendingxhacker;
                beleven.Visible = true;
            }
            if (seconds >= 340 && seconds < 345)
            {
                beleven.Visible = false;
                btwelve.Text = sendingxhacker;
                btwelve.Visible = true;
            }
            if(seconds >= 345 && seconds < 350)
            {
                down3.Visible = true;
            }
            if (seconds >= 350 && counter2 <= 8)
            {
                counter2++;
                B.Text = txt2.Substring(0, counter2);
            }
            if (seconds >= 375 && seconds < 390)
            {
                down4.Visible = true;
            }
            if (seconds >= 390 && counter3 <= 20)
            {
                counter3++;
                FormulaB.Text = txt3.Substring(0, counter3);
            }
            if (seconds >= 428 && seconds < 445)
            {
                ycal.Visible = true;
            }
            if(seconds >= 445 && seconds < 460)
            {
                hdown3.Visible = true;
            }
            if(seconds >= 460 && seconds < 475)
            {
                htext2.Visible = true;
            }
            if(seconds >= 475 && seconds < 490)
            {
                hdown4.Visible = true;
            }
            if(seconds >= 490 && seconds < 510)
            {
                FinalManIntheMiddle.Visible = true;
            }
            if(seconds >= 510 && seconds < 525)
            {
                hdown33.Visible = true;
            }
            if(seconds >= 525 && seconds < 540)
            {
                htext22.Visible = true;
            }
            if(seconds >= 540 && seconds < 555)
            {
                hdown44.Visible = true;
            }
            if(seconds >= 555 && seconds < 570)
            {
                finalManInTheMiddleA.Visible = true;
            }

            if(seconds >= 570 && seconds < 577)
            {
                setA.Visible = false;
                two1.Text = setA.Text;
                two1.Visible = true;
            }
            if(seconds >= 577 && seconds < 583)
            {
                two1.Visible = false;
                two2.Text = setA.Text;
                two2.Visible = true;
            }
            if(seconds >= 583 && seconds < 590)
            {
                two2.Visible = false;
                two3.Text = setA.Text;
                two3.Visible = true;

            }

            if(seconds >= 590 && seconds < 597)
            {
                setb.Visible = false;
                eight1.Text = setb.Text;
                eight1.Visible = true;
            }
            if(seconds >= 597 && seconds < 604)
            {
                eight1.Visible = false;
                eight2.Text = setb.Text;
                eight2.Visible = true;
            }
            if(seconds >= 604 && seconds < 620)
            {
                eight2.Visible = false;
                eight3.Text = setb.Text;
                eight3.Visible = true;
            }
            if(seconds >= 620)
            {
                timer1.Stop();
                start.Visible = false;
                stop.Visible = false;
                Reload.Visible = true;              

            }
        }

        public int setForward, setbackward;

        public ManInMiddleAttack5(ManInTheMiddleAttack1 obj)
        {
            InitializeComponent();
            timer1.Start();
            Down1.Visible = false;
            Down2.Visible = false;
            down3.Visible = false;
            down4.Visible = false;
           
            xcal.Visible = false;
            ycal.Visible = false;

            txt = A.Text;
            A.Text = "";

            txt1 = FormulaA.Text;
            FormulaA.Text = "";

            txt2 = B.Text;
            B.Text = "";

            txt3 = FormulaB.Text;
            FormulaB.Text = "";


            p_number.Text = obj.pnum.ToString();
            q_number.Text = obj.qnum.ToString();
            Xkeybox.Text = obj.XkeyNumber.ToString();
            YkeybOX.Text = obj.YkeyNumber.ToString();
            hackerX.Text = "8";
            hackerY.Text = "6";

            pnum = Convert.ToInt32(obj.pnum);
            qnum = Convert.ToInt32(obj.qnum);
            XkeyNumber = Convert.ToInt32(Xkeybox.Text);
            YkeyNumber = Convert.ToInt32(YkeybOX.Text);
            xhacker = Convert.ToInt32(hackerX.Text);
            yhacker = Convert.ToInt32(hackerY.Text);

            //sending B to A
            one.Visible = false;
            two.Visible = false;
            three.Visible = false;
            four.Visible = false;
            five.Visible = false;
            six.Visible = false;
            seven.Visible = false;
            eight.Visible = false;
            nine.Visible = false;
            ten.Visible = false;
            eleven.Visible = false;
            twelve.Visible = false;

            //sending A to B
            btwo.Visible = false;
            bthree.Visible = false;
            bfour.Visible = false;
            bfive.Visible = false;
            bsix.Visible = false;
            bseven.Visible = false;
            beight.Visible = false;
            bnine.Visible = false;
            bten.Visible = false;
            beleven.Visible = false;
            btwelve.Visible = false;

            //For left side
            hdown1.Visible = false;
            htext1.Visible = false;
            hdown2.Visible = false;
            hackerCAlculateX.Visible = false;
            hdown3.Visible = false;
                        
            htext2.Visible = false;
            hdown4.Visible = false;
            FinalManIntheMiddle.Visible = false;

            //For Right side
            hdown11.Visible = false;
            htext11.Visible = false;
            hdown22.Visible = false;
            HackerCalculateY.Visible = false;
            hdown33.Visible = false;
            htext22.Visible = false;
            hdown44.Visible = false;
            finalManInTheMiddleA.Visible = false;

            //last step of A
            two1.Visible = false;
            two2.Visible = false;
            two3.Visible = false;

            //last step for B
            eight1.Visible = false;
            eight2.Visible = false;
            eight3.Visible = false;






            calculationAlexa = power(qnum, xhacker);
            calculationAlexa = calculationAlexa % pnum;
            hackerCAlculateX.Text += String.Concat("A(t) ", "= ", qnum, " pow (", xhacker, ") MOD ", pnum, " = ", calculationAlexa, "\n");
            sendingxhacker = calculationAlexa.ToString();
            getxcal = Convert.ToInt32(sendingxhacker);


            calculationBob = power(qnum,yhacker);
            calculationBob = calculationBob % pnum;
            HackerCalculateY.Text += String.Concat("B(t) ", "= ", qnum, " pow (", yhacker, ") MOD ", pnum, " = ", calculationBob, "\n");
            sendingyhacker = calculationBob.ToString();
            getycal = Convert.ToInt32(sendingyhacker);
            //forward.Text = calculationAlexa.ToString();

            calculationAlexa = power(getycal, XkeyNumber);
            calculationAlexa = calculationAlexa % pnum;
            xcal.Text += String.Concat("A ", "= ", getycal, " pow (", XkeyNumber, ") MOD ", pnum, " = ", calculationAlexa, "\n");




            


            calculationBob = power(getxcal, YkeyNumber);
            calculationBob = calculationBob % pnum;
            ycal.Text += String.Concat("B ", "= ", getxcal, " pow (", YkeyNumber, ") MOD ", pnum, " = ", calculationBob, "\n");

            setA.Text = obj.setForward.ToString();
            setb.Text = obj.setbackward.ToString();

            setForward = Convert.ToInt32(setA.Text);
            setbackward = Convert.ToInt32(setb.Text);

            calculationAlexa = power(setbackward,xhacker);
            calculationAlexa = calculationAlexa % pnum;
            FinalManIntheMiddle.Text += String.Concat("B ", "= ", setForward, " pow (", xhacker, ") MOD ", pnum, " = ", calculationAlexa, "\n");

            calculationBob = power(setForward , yhacker);
            calculationBob = calculationBob % pnum;
            finalManInTheMiddleA.Text += String.Concat("A ", "= ", setbackward, " pow (", yhacker, ") MOD ", pnum, " = ", calculationBob, "\n");
            

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
