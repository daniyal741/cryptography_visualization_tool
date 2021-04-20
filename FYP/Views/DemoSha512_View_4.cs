using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FYP.Model;

namespace FYP.Views
{
    public partial class DemoSha512_View_4 : UserControl
    {
        private int currentRound;
        private DemoSha512_View_3 view1;
        private Sha512 obj;
        private int currentBlock;

        public int CurrentRound { get => currentRound; set => currentRound = value; }
        public DemoSha512_View_3 View1 { get => view1; set => view1 = value; }
        internal Sha512 Obj { get => obj; set => obj = value; }
        public int CurrentBlock { get => currentBlock; set => currentBlock = value; }

        public DemoSha512_View_4()
        {
            InitializeComponent();
        }
        public DemoSha512_View_4(DemoSha512_View_3 obj)
        {
            InitializeComponent();
            this.Obj = obj.Obj;
            this.CurrentBlock = obj.CurrentBlock;
            this.CurrentRound = obj.CurrentRound;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {

            string message = "Do you want to close the Applicaion?";
            string title = "Warning";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                // Do Nothing 
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            MainForm.Instance.panelContain.Controls["DemoSha512_View_4"].Dispose();
            MainForm.Instance.panelContain.Controls["DemoSha512_View_3"].BringToFront();

        }

        private void DemoSha512_View_4_Load(object sender, EventArgs e)
        {
            blockInfo.Text = "Sha-2 Block # " + CurrentBlock;
            roundInfo.Text = "Sha-2 Round # " + CurrentRound;
        }

        private void aRRoT_MouseHover(object sender, EventArgs e)
        {
            string str = "";
            str = Obj.value_A_RROT[CurrentBlock - 1, CurrentRound - 1];
            toolTip1.Show(str, aRRoT);
        }

        private void majValue_MouseHover(object sender, EventArgs e)
        {
            string str = "";
            str = Obj.value_Maj[CurrentBlock - 1, CurrentRound - 1];
            toolTip1.Show(str, majValue);
        }

        private void mixer1Value_MouseHover(object sender, EventArgs e)
        {
            string str = "";
            str = Obj.value_Mix1[CurrentBlock - 1, CurrentRound - 1];
            toolTip1.Show(str, mixer1Value);
        }

        private void condValue_MouseHover(object sender, EventArgs e)
        {
            string str = "";
            str = Obj.value_Con[CurrentBlock - 1, CurrentRound - 1];
            toolTip1.Show(str, condValue);
        }

        private void eRRot_MouseHover(object sender, EventArgs e)
        {
            string str = "";
            str = Obj.value_E_RROT[CurrentBlock - 1, CurrentRound - 1];
            toolTip1.Show(str, eRRot);
        }

        private void kValue_MouseHover(object sender, EventArgs e)
        {
            string str = Obj.k[CurrentRound - 1].ToString("x8");
            toolTip1.Show(str, kValue);
        }

        private void wValue_MouseHover(object sender, EventArgs e)
        {
            string str = Obj.messageWords[CurrentBlock - 1, CurrentRound - 1];
            toolTip1.Show(str, wValue);
        }

        private void mixer2Value_MouseHover(object sender, EventArgs e)
        {
            string str = "";
            str = Obj.value_Mix2[CurrentBlock - 1, CurrentRound - 1];
            toolTip1.Show(str, mixer2Value);
        }

        private void pictureBox21_MouseHover(object sender, EventArgs e)
        {
            string str = "";
            str = Obj.value_Mix2[CurrentBlock - 1, CurrentRound - 1];
            toolTip1.Show(str, pictureBox21);
        }

        private void yValue_MouseHover(object sender, EventArgs e)
        {
            string str = "";
            str = Obj.value_E[CurrentBlock - 1, CurrentRound - 1];
            toolTip1.Show(str, yValue);
        }

        private void pictureBox14_MouseHover(object sender, EventArgs e)
        {
            string str = "";
            str = Obj.value_E[CurrentBlock - 1, CurrentRound - 1];
            toolTip1.Show(str, pictureBox14);
        }

        private void xValue_MouseHover(object sender, EventArgs e)
        {
            string str = "";
            str = Obj.value_A[CurrentBlock - 1, CurrentRound - 1];
            toolTip1.Show(str, xValue);
        }

        private void aArrow_MouseHover(object sender, EventArgs e)
        {
            string str = "";

            if (CurrentRound == 1 && CurrentBlock == 1)
            {
                str = Obj.iv[0].ToString("x8");
            }
            if (CurrentBlock > 1 && CurrentRound == 1)
            {
                str = Obj.value_A[CurrentBlock - 2, 80];

            }
            if (CurrentBlock == 1 && CurrentRound != 1)
            {
                str = Obj.value_A[CurrentBlock - 1, CurrentRound - 2];
            }
            if (CurrentBlock != 1 && CurrentRound != 1)
            {

                str = Obj.value_A[CurrentBlock - 1, CurrentRound - 2];

            }

            toolTip1.Show(str, aArrow);
        }

        private void bArrow_MouseHover(object sender, EventArgs e)
        {
            string str = "";

            if (CurrentRound == 1 && CurrentBlock == 1)
            {
                str = Obj.iv[1].ToString("x8");
            }
            if (CurrentBlock > 1 && CurrentRound == 1)
            {
                str = Obj.value_B[CurrentBlock - 2, 80];

            }
            if (CurrentBlock == 1 && CurrentRound != 1)
            {
                str = Obj.value_B[CurrentBlock - 1, CurrentRound - 2];
            }
            if (CurrentBlock != 1 && CurrentRound != 1)
            {

                str = Obj.value_B[CurrentBlock - 1, CurrentRound - 2];

            }

            toolTip1.Show(str, bArrow);
        }

        private void cArrow_MouseHover(object sender, EventArgs e)
        {
            string str = "";

            if (CurrentRound == 1 && CurrentBlock == 1)
            {
                str = Obj.iv[2].ToString("x8");
            }
            if (CurrentBlock > 1 && CurrentRound == 1)
            {
                str = Obj.value_C[CurrentBlock - 2, 80];

            }
            if (CurrentBlock == 1 && CurrentRound != 1)
            {
                str = Obj.value_C[CurrentBlock - 1, CurrentRound - 2];
            }
            if (CurrentBlock != 1 && CurrentRound != 1)
            {

                str = Obj.value_C[CurrentBlock - 1, CurrentRound - 2];

            }

            toolTip1.Show(str, cArrow);
        }

        private void aArrow1_MouseHover(object sender, EventArgs e)
        {
            string str = "";

            if (CurrentRound == 1 && CurrentBlock == 1)
            {
                str = Obj.iv[0].ToString("x8");
            }
            if (CurrentBlock > 1 && CurrentRound == 1)
            {
                str = Obj.value_A[CurrentBlock - 2, 80];

            }
            if (CurrentBlock == 1 && CurrentRound != 1)
            {
                str = Obj.value_A[CurrentBlock - 1, CurrentRound - 2];
            }
            if (CurrentBlock != 1 && CurrentRound != 1)
            {

                str = Obj.value_A[CurrentBlock - 1, CurrentRound - 2];

            }

            toolTip1.Show(str, aArrow1);
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Addition Mod 2⁶⁴", pictureBox1);

        }

        private void plusBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Addition Mod 2⁶⁴", plusBox2);

        }

        private void eArrow_MouseHover(object sender, EventArgs e)
        {
            string str = "";

            if (CurrentRound == 1 && CurrentBlock == 1)
            {
                str = Obj.iv[4].ToString("x8");
            }
            if (CurrentBlock > 1 && CurrentRound == 1)
            {
                str = Obj.value_E[CurrentBlock - 2, 80];

            }
            if (CurrentBlock == 1 && CurrentRound != 1)
            {
                str = Obj.value_E[CurrentBlock - 1, CurrentRound - 2];
            }
            if (CurrentBlock != 1 && CurrentRound != 1)
            {

                str = Obj.value_E[CurrentBlock - 1, CurrentRound - 2];

            }

            toolTip1.Show(str, eArrow);
        }

        private void fArrow_MouseHover(object sender, EventArgs e)
        {
            string str = "";

            if (CurrentRound == 1 && CurrentBlock == 1)
            {
                str = Obj.iv[5].ToString("x8");
            }
            if (CurrentBlock > 1 && CurrentRound == 1)
            {
                str = Obj.value_F[CurrentBlock - 2, 80];

            }
            if (CurrentBlock == 1 && CurrentRound != 1)
            {
                str = Obj.value_F[CurrentBlock - 1, CurrentRound - 2];
            }
            if (CurrentBlock != 1 && CurrentRound != 1)
            {

                str = Obj.value_F[CurrentBlock - 1, CurrentRound - 2];

            }

            toolTip1.Show(str, fArrow);
        }

        private void gArrow_MouseHover(object sender, EventArgs e)
        {
            string str = "";

            if (CurrentRound == 1 && CurrentBlock == 1)
            {
                str = Obj.iv[6].ToString("x8");
            }
            if (CurrentBlock > 1 && CurrentRound == 1)
            {
                str = Obj.value_G[CurrentBlock - 2, 80];

            }
            if (CurrentBlock == 1 && CurrentRound != 1)
            {
                str = Obj.value_G[CurrentBlock - 1, CurrentRound - 2];
            }
            if (CurrentBlock != 1 && CurrentRound != 1)
            {

                str = Obj.value_G[CurrentBlock - 1, CurrentRound - 2];

            }

            toolTip1.Show(str, gArrow);
        }

        private void eArrow1_MouseHover(object sender, EventArgs e)
        {
            string str = "";

            if (CurrentRound == 1 && CurrentBlock == 1)
            {
                str = Obj.iv[4].ToString("x8");
            }
            if (CurrentBlock > 1 && CurrentRound == 1)
            {
                str = Obj.value_E[CurrentBlock - 2, 80];

            }
            if (CurrentBlock == 1 && CurrentRound != 1)
            {
                str = Obj.value_E[CurrentBlock - 1, CurrentRound - 2];
            }
            if (CurrentBlock != 1 && CurrentRound != 1)
            {

                str = Obj.value_E[CurrentBlock - 1, CurrentRound - 2];

            }

            toolTip1.Show(str, eArrow1);
        }

        private void hArrow_MouseHover(object sender, EventArgs e)
        {
            string str = "";

            if (CurrentRound == 1 && CurrentBlock == 1)
            {
                str = Obj.iv[7].ToString("x8");
            }
            if (CurrentBlock > 1 && CurrentRound == 1)
            {
                str = Obj.value_H[CurrentBlock - 2, 80];

            }
            if (CurrentBlock == 1 && CurrentRound != 1)
            {
                str = Obj.value_H[CurrentBlock - 1, CurrentRound - 2];
            }
            if (CurrentBlock != 1 && CurrentRound != 1)
            {

                str = Obj.value_H[CurrentBlock - 1, CurrentRound - 2];

            }

            toolTip1.Show(str, hArrow);
        }

        private void dArrow_MouseHover(object sender, EventArgs e)
        {
            string str = "";

            if (CurrentRound == 1 && CurrentBlock == 1)
            {
                str = Obj.iv[3].ToString("x8");
            }
            if (CurrentBlock > 1 && CurrentRound == 1)
            {
                str = Obj.value_D[CurrentBlock - 2, 80];

            }
            if (CurrentBlock == 1 && CurrentRound != 1)
            {
                str = Obj.value_D[CurrentBlock - 1, CurrentRound - 2];
            }
            if (CurrentBlock != 1 && CurrentRound != 1)
            {

                str = Obj.value_D[CurrentBlock - 1, CurrentRound - 2];

            }

            toolTip1.Show(str, dArrow);
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Addition Mod 2⁶⁴", pictureBox7);

        }

        private void label16_Click(object sender, EventArgs e)
        {
            DisplayPicture uc = new DisplayPicture();


            uc.Pic.BackgroundImage = Image.FromFile(MainForm.Instance.path + "/images/Hashing/Sha_XY.jpg");
            uc.Dock = DockStyle.Fill;
            MainForm.Instance.panelContain.Controls.Add(uc);
            MainForm.Instance.panelContain.Controls["DisplayPicture"].BringToFront();
        }

        private void btn12_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("(a AND b) ⨁ (a AND c) ⨁ (b AND c)",btn12);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            

            toolTip1.Show("(e AND f) ⨁ ((NOT e) AND g)", button1);

        }

        private void btn13_MouseHover(object sender, EventArgs e)
        {
            
            toolTip1.Show("ROTR(a , 28) ⨁ ROTR(a , 34) ⨁ ROTR(a , 39)", btn13);

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {

            toolTip1.Show("ROTR(e , 14) ⨁ ROTR(e , 18) ⨁ ROTR(a , 41)", button2);

        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Addition Mod 2⁶⁴", pictureBox4);

        }
    }
}
