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
    public partial class DeffieHellmanVisualization_6_ : UserControl
    {
        public DeffieHellmanVisualization_6_()
        {
            InitializeComponent();
        }

        //variables
        int seconds = 0,count=0,counter1=0,counter2=0,count1=0,count2=0;
        string txt,txt1,txt2,txt3,txt4;
        DeffieHellmanVisualization_4_ obj1;       
        public int pnum { get; set; }
        public int qnum { get; set; }
        public int pow;
        public BigInteger calculationAlexa { get; set; }
        public BigInteger calculationBob { get; set; }
        public int XkeyNumber { get; set; }

        public int YkeyNumber { get; set; }
        public DeffieHellmanVisualization_6_(DeffieHellmanVisualization_4_ obj)
        {
            InitializeComponent();
            Reload.Visible = false;
            //Visibility
            arrowdown.Visible = false;
            arrowdown2.Visible = false;
            A.Visible = false;
            B.Visible = false;

            txt = Proved.Text;
            Proved.Text = "";

            txt3 = nowA.Text;
            txt4 = nowB.Text;
            nowA.Text = "";
            nowB.Text = "";

            arrow1down.Visible = false;
            arrow2down.Visible = false;
            xcal.Visible = false;
            ycal.Visible = false;
          

            txt1 = formulaA.Text;
            formulaA.Text = "";
            txt2 = formulaB.Text;
            formulaB.Text = "";

            timer1.Start();
           
            //set values here
            p_number.Text = obj.pnum.ToString();
            q_number.Text = obj.qnum.ToString();
            Xkeybox.Text = obj.XkeyNumber.ToString();
            YkeybOX.Text = obj.YkeyNumber.ToString();
            A.Text = obj.calculationBob.ToString();
            B.Text = obj.calculationAlexa.ToString();
            obj1 = obj;

            pnum = Convert.ToInt32(obj.pnum);
            qnum = Convert.ToInt32(obj.qnum);
            XkeyNumber = Convert.ToInt32(Xkeybox.Text);
            YkeyNumber = Convert.ToInt32(YkeybOX.Text);
            calculationAlexa = obj.calculationBob;
            calculationBob = obj.calculationAlexa;

            BigInteger x = calculationAlexa;
            BigInteger y= calculationBob;


            calculationAlexa = power(calculationAlexa,XkeyNumber);
            calculationAlexa = calculationAlexa % pnum;

            xcal.Text += String.Concat("S ", "= ", x, " pow (", XkeyNumber, ") MOD ", pnum, " = ", calculationAlexa, "\n");



            calculationBob = power(y, YkeyNumber);
            calculationBob = calculationBob % pnum;
            ycal.Text += String.Concat("S ", "= ", y, " pow (", YkeyNumber, ") MOD ", pnum, " = ", calculationBob, "\n");
        }

        private void DeffieHellmanVisualization_6__Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
             
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DeffieHellmanVisualization_4_ uc_deffie_HellmanVisualization = new DeffieHellmanVisualization_4_();
            uc_deffie_HellmanVisualization.Dock = DockStyle.Fill;
            MainForm.Instance.panelContain.Controls.Add(uc_deffie_HellmanVisualization);
            MainForm.Instance.panelContain.Controls["DeffieHellmanVisualization_4_"].BringToFront();
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            MainForm.Instance.panelContain.Controls.Clear();

            AsymmetricAlgoCategories uc_deffie_HellmanVisualization = new AsymmetricAlgoCategories();
            uc_deffie_HellmanVisualization.Dock = DockStyle.Fill;

            MainForm.Instance.panelContain.Controls.Add(uc_deffie_HellmanVisualization);
            MainForm.Instance.panelContain.Controls["AsymmetricAlgoCategories"].BringToFront();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            stop.Visible = false;
            Reload.Visible = false;
            start.Visible = true;
        }

        private void start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            Reload.Visible = false;
            stop.Visible = true;
            start.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Dispose();
            MainForm.Instance.panelContain.Controls.Clear();

            AsymmetricAlgoCategories uc_deffie_HellmanVisualization = new AsymmetricAlgoCategories();
            uc_deffie_HellmanVisualization.Dock = DockStyle.Fill;

            MainForm.Instance.panelContain.Controls.Add(uc_deffie_HellmanVisualization);
            MainForm.Instance.panelContain.Controls["AsymmetricAlgoCategories"].BringToFront();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            if (seconds >= 15)
            {
                arrowdown.Visible = true;
            }
            if (seconds >= 35 && count <= 8)
            {
                count++;
                nowA.Text = txt3.Substring(0, count);

            }

            if (seconds >= 60)
            {
                A.ForeColor = Color.Blue;
                A.Visible = true;
            }
            if (seconds >= 80)
            {
                arrowdown2.Visible = true;
            }

            if (seconds >= 95 && count1 <= 8)
            {
                count1++;
                nowB.Text = txt4.Substring(0, count1);
            }
            if (seconds >= 120)
            {
                B.ForeColor = Color.Red;
                B.Visible = true;
            }
            if (seconds >= 135)
            {
                nowB.Visible = true;
            }

            if (seconds >=150)
            {
                arrow1down.Visible = true;
            }
            if(seconds >= 165 && counter1<=19)
            {
                counter1++;
                formulaA.Text = txt1.Substring(0, counter1);
            }

            if (seconds >= 200)
            {
                xcal.Visible = true;
              
            }
            if (seconds >= 215)
            {
                arrow2down.Visible = true;
            }
            if (seconds >= 230 && counter2 <= 19)
            {
                counter2++;
                formulaB.Text = txt2.Substring(0, counter2);
            }
            if (seconds >= 270)
            {
                ycal.Visible = true;
            }

            if (seconds >= 290 && count2 <= 46)
            {
                count2++;
                Proved.Text = txt.Substring(0, count2);
            }
            if(seconds >= 355)
            {
                timer1.Stop();
                start.Visible = false;
                Reload.Visible = true;
                stop.Visible = false;
                
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
    }
}
