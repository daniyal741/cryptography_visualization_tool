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
    public partial class DeffieHellmanVisualization_4_ : UserControl
    {
        public DeffieHellmanVisualization_4_()
        {
            InitializeComponent();
            
            stop.Visible = false;
            start.Visible = true;
            timer1.Stop();
        }

        public int seconds = 0;
        int count = 0,exhanged_counter = 0;
        static int state = 0;
        int count1 = 0;
        string txt,txt1,keyecxchange;
      
  
        public int pnum { get; set; }
        public int qnum { get; set; }
        public int pow;
        public BigInteger calculationAlexa;
        public BigInteger calculationBob;
        public int XkeyNumber;

        public int YkeyNumber;

        public DeffieHellmanVisualization_4_(DeffieHellmanVisualization_2_ obj)
        {
            InitializeComponent();
            timer1.Stop();
            timer1.Dispose();


            send.Visible = false;
            recieve.Visible = false;
            forwardPic.Visible = false;    
            backwardPic.Visible = false;
            arrowdown1.Visible = false;
            arowdown.Visible = false;
            xcal.Visible = false;
            ycal.Visible = false;
            txt = forward.Text;
            txt1 = backward.Text;

            keyecxchange = exhchanged_label.Text;
            exhchanged_label.Text = "";
            forward.Text = "";
            backward.Text = "";
            timer1.Start();

            //sending circle
            one.Visible = false;
            two.Visible = false;
            three.Visible = false;
            four.Visible = false;
            five.Visible = false;
            six.Visible = false;
            seven.Visible = false;

            //Recienving Circle
            rone.Visible = false;
            rtwo.Visible = false;
            rthree.Visible = false;
            rfour.Visible = false;
            rfive.Visible = false;
            rsix.Visible = false;
            rseven.Visible = false;

            //first arrow seconds arrow + text labels
            first.Visible = false;
            formula.Visible = false;
            second.Visible = false;
            formula2.Visible = false;
          


            p_number.Text = obj.p.ToString();
            q_number.Text = obj.q.ToString();
            Xkeybox.Text = obj.XkeyNumber.ToString();
            YkeybOX.Text = obj.YkeyNumber.ToString();

            pnum = Convert.ToInt32(obj.p);
            qnum = Convert.ToInt32(obj.q);
            XkeyNumber = Convert.ToInt32(Xkeybox.Text);
            YkeyNumber = Convert.ToInt32(YkeybOX.Text);
            

            calculationAlexa = power(qnum, XkeyNumber);
            calculationAlexa = calculationAlexa % pnum;

            xcal.Text += String.Concat("A ", "= ", qnum," pow (", XkeyNumber,") MOD " ,pnum, " = ", calculationAlexa, "\n");
            
          
            calculationBob = power(qnum, YkeyNumber);
            calculationBob = calculationBob % pnum;
            ycal.Text += String.Concat("B ","= ",qnum, " pow (", YkeyNumber, ") MOD ", pnum, " = ", calculationBob, "\n");


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

        private void BTNSWAP_Click(object sender, EventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void ycal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            DeffieHellmanVisualization_2_ uc_deffie_HellmanVisualization = new DeffieHellmanVisualization_2_();
            uc_deffie_HellmanVisualization.Dock = DockStyle.Fill;

            MainForm.Instance.panelContain.Controls.Add(uc_deffie_HellmanVisualization);
            MainForm.Instance.panelContain.Controls["DeffieHellmanVisualization_2_"].BringToFront();
        }

        private void man_in_middle_attack_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void stop_Click(object sender, EventArgs e)
        {
            state = this.seconds;
            timer1.Enabled=false;
            stop.Visible = false;
            start.Visible = true;
        }

        private void backward_Click(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            seconds = state;
            timer1.Enabled=true;
            stop.Visible = true;
            start.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;


            if (seconds >= 15)
            {
                first.Visible = true;
            }

            if (seconds >= 30)
            {
                formula.Visible = true;
            }
            if (seconds >= 45)
            {
                arowdown.Visible = true;
            }

            if (seconds >= 60)
            {
                xcal.Visible = true;

            }
            if (seconds >= 75)
            {
                second.Visible = true;

            }

            if (seconds >= 90)
            {
                formula2.Visible = true;

            }

            if (seconds >= 105)
            {
                arrowdown1.Visible = true;
            }

            if (seconds >= 120)
            {
                ycal.Visible = true;
            }

            if (seconds >= 135)
            {
                forwardPic.Visible = true;
            }

            if(seconds >= 150 && count <=6)
            {
                count++;
                forward.Text = txt.Substring(0, count);

                if (forward.ForeColor == Color.Black)
                {
                    forward.ForeColor = Color.DarkRed;
                }
                else
                {
                    forward.ForeColor = Color.Black;
                }

                //backward.Text = calculationBob.ToString();                
                //forwardPic.Visible = true;
                //backwardPic.Visible = true;
                
            }
            if(seconds >= 175)
            {
                send.Text = calculationAlexa.ToString();
                send.ForeColor = Color.Red;
                send.Visible = true;
                
            }

            if (seconds >= 185)
            {
               backwardPic.Visible = true;
            }

            if (seconds >= 195 && count1<=6)
            {
                count1++;
                backward.Text = txt1.Substring(0, count1);
                if (backward.ForeColor == Color.Black)
                {
                    backward.ForeColor = Color.Blue;
                }
                else
                {
                    backward.ForeColor = Color.Black;
                }

            }
            if (seconds >= 215)
            {

                recieve.Text = calculationBob.ToString();
                recieve.ForeColor = Color.Blue;
                recieve.Visible = true;

            }
            
            if(seconds >= 230 && seconds < 233)
            {
                one.Text = calculationAlexa.ToString();
                one.Visible = true;
            }
            if (seconds >= 233 && seconds < 236)
            {
                one.Visible = false;
                two.Text = calculationAlexa.ToString();
                two.Visible = true;
            }
            if (seconds >= 236 && seconds < 239)
            {
                two.Visible = false;
                three.Text = calculationAlexa.ToString();
                three.Visible = true;
            }
            if (seconds >= 239 && seconds < 242)
            {
                three.Visible = false;
                four.Text = calculationAlexa.ToString();
                four.Visible = true;
            }
            if (seconds >= 242 && seconds < 245)
            {
                four.Visible = false;
                five.Text = calculationAlexa.ToString();
                five.Visible = true;
            }
            if (seconds >= 245 && seconds < 248)
            {
                five.Visible = false;
                six.Text = calculationAlexa.ToString();
                six.Visible = true;
            }
            if (seconds >= 248 && seconds < 251)
            {
                six.Visible = false;
                seven.Text = calculationAlexa.ToString();
                seven.Visible = true;
            }
            if (seconds >= 251 && seconds < 254)
            {
                rone.Text = calculationBob.ToString();
                rone.Visible = true;
            }
            if (seconds >= 254 && seconds < 257)
            {
                rone.Visible = false;
                rtwo.Text = calculationBob.ToString();
                rtwo.Visible = true;
            }
            if (seconds >= 257 && seconds < 260)
            {
                rtwo.Visible = false;
                rthree.Text = calculationBob.ToString();
                rthree.Visible = true;
            }
            if (seconds >= 260 && seconds < 263)
            {
                rthree.Visible = false;
                rfour.Text = calculationBob.ToString();
                rfour.Visible = true;
            }
            if (seconds >= 263 && seconds < 266)
            {
                rfour.Visible = false;
                rfive.Text = calculationBob.ToString();
                rfive.Visible = true;
            }
            if (seconds >= 266 && seconds < 269)
            {
                rfive.Visible = false;
                rsix.Text = calculationBob.ToString();
                rsix.Visible = true;
            }
            if (seconds >= 269 && seconds < 272)
            {
                rsix.Visible = false;
                rseven.Text = calculationBob.ToString();
                rseven.Visible = true;
            }

            if(seconds >= 272  && exhanged_counter <=24)
            {
                exhanged_counter++;
                exhchanged_label.Text = keyecxchange.Substring(0, exhanged_counter);
            }

            if (seconds > 300)
            {
                this.timer1.Stop();
               
                /*pnum = Convert.ToInt32(p_number.Text);
                qnum = Convert.ToInt32(q_number.Text);

                calculationAlexa = this.calculationAlexa;
                calculationBob = this.calculationBob;
                XkeyNumber = Convert.ToInt32(Xkeybox.Text);
                YkeyNumber = Convert.ToInt32(YkeybOX.Text);*/


                DeffieHellmanVisualization_6_ uc_deffie_HellmanVisualization = new DeffieHellmanVisualization_6_(this);
                uc_deffie_HellmanVisualization.Dock = DockStyle.Fill;

                MainForm.Instance.panelContain.Controls.Add(uc_deffie_HellmanVisualization);
                MainForm.Instance.panelContain.Controls["DeffieHellmanVisualization_6_"].BringToFront();
               
            }
            


        }

        private void xcal_TextChanged(object sender, EventArgs e)
        {

        }
        
        public BigInteger power(BigInteger x,BigInteger y)
        {
            BigInteger dum = 1;
            BigInteger D;
            for(int i=1; i<=y; i++)
            {
                dum = dum * x;
            }
            D = dum;
            dum = 1;
            return D;
            
            
        }
    }
}
