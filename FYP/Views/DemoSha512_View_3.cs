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
    public partial class DemoSha512_View_3 : UserControl
    {
        private int currentRound;
        private DemoSha512_View_2 view1;
        private Sha512 obj;
        private int currentBlock;

        public int CurrentRound { get => currentRound; set => currentRound = value; }
        public DemoSha512_View_2 View1 { get => view1; set => view1 = value; }
        internal Sha512 Obj { get => obj; set => obj = value; }
        public int CurrentBlock { get => currentBlock; set => currentBlock = value; }

        public DemoSha512_View_3()
        {
            InitializeComponent();
        }
        public DemoSha512_View_3(DemoSha512_View_2 obj)
        {
            InitializeComponent();
            this.Obj = obj.Obj;
            this.CurrentBlock = obj.CurrentBlock;
            this.CurrentRound = obj.CurrentRound;
        }

        private void DemoSha512_View_3_Load(object sender, EventArgs e)
        {
            blockInfo.Text = "Sha-2 Block # " + CurrentBlock;
            roundInfo.Text = "Sha-2 Round # " + CurrentRound;
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

            MainForm.Instance.panelContain.Controls["DemoSha512_View_3"].Dispose();
            MainForm.Instance.panelContain.Controls["DemoSha512_View_2"].BringToFront();

        }

        private void label16_Click(object sender, EventArgs e)
        {
            DisplayPicture uc = new DisplayPicture();


            uc.Pic.BackgroundImage = Image.FromFile(MainForm.Instance.path + "/images/Hashing/Sha_RoundFunction.jpg");
            uc.Dock = DockStyle.Fill;
            MainForm.Instance.panelContain.Controls.Add(uc);
            MainForm.Instance.panelContain.Controls["DisplayPicture"].BringToFront();
        }

        private void btnR1_Click(object sender, EventArgs e)
        {
            DemoSha512_View_4 uc_demo_sha = new DemoSha512_View_4(this);
            uc_demo_sha.Dock = DockStyle.Fill;


            MainForm.Instance.panelContain.Controls.Add(uc_demo_sha);
            MainForm.Instance.panelContain.Controls["DemoSha512_View_4"].BringToFront();
        }

        private void btnR2_Click(object sender, EventArgs e)
        {
            DemoSha512_View_4 uc_demo_sha = new DemoSha512_View_4(this);
            uc_demo_sha.Dock = DockStyle.Fill;


            MainForm.Instance.panelContain.Controls.Add(uc_demo_sha);
            MainForm.Instance.panelContain.Controls["DemoSha512_View_4"].BringToFront();
        }

        private void aBefore_MouseHover(object sender, EventArgs e)
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

            toolTip1.Show(str, aBefore);
        }

        private void bBefore_MouseHover(object sender, EventArgs e)
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

            toolTip1.Show(str, bBefore);
        }

        private void cBefore_MouseHover(object sender, EventArgs e)
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

            toolTip1.Show(str, cBefore);
        }

        private void dBefore_MouseHover(object sender, EventArgs e)
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

            toolTip1.Show(str, dBefore);
        }

        private void eBefore_MouseHover(object sender, EventArgs e)
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

            toolTip1.Show(str, eBefore);
        }

        private void fBefore_MouseHover(object sender, EventArgs e)
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

            toolTip1.Show(str, fBefore);
        }

        private void gBefore_MouseHover(object sender, EventArgs e)
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

            toolTip1.Show(str, gBefore);
        }

        private void hBefore_MouseHover(object sender, EventArgs e)
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

            toolTip1.Show(str, hBefore);
        }

        private void aAfter_MouseHover(object sender, EventArgs e)
        {
            string str = "";
            str = Obj.value_A[CurrentBlock - 1, CurrentRound - 1];
            toolTip1.Show(str, aAfter);
        }

        private void bAfter_MouseHover(object sender, EventArgs e)
        {
            string str = "";
            str = Obj.value_B[CurrentBlock - 1, CurrentRound - 1];
            toolTip1.Show(str, bAfter);
        }

        private void cAfter_MouseHover(object sender, EventArgs e)
        {
            string str = "";
            str = Obj.value_C[CurrentBlock - 1, CurrentRound - 1];
            toolTip1.Show(str, cAfter);
        }

        private void dAfter_MouseHover(object sender, EventArgs e)
        {
            string str = "";
            str = Obj.value_D[CurrentBlock - 1, CurrentRound - 1];
            toolTip1.Show(str, dAfter);
        }

        private void eAfter_MouseHover(object sender, EventArgs e)
        {
            string str = "";
            str = Obj.value_E[CurrentBlock - 1, CurrentRound - 1];
            toolTip1.Show(str, eAfter);
        }

        private void fAfter_MouseHover(object sender, EventArgs e)
        {
            string str = "";
            str = Obj.value_F[CurrentBlock - 1, CurrentRound - 1];
            toolTip1.Show(str, fAfter);
        }

        private void gAfter_MouseHover(object sender, EventArgs e)
        {
            string str = "";
            str = Obj.value_G[CurrentBlock - 1, CurrentRound - 1];
            toolTip1.Show(str, gAfter);
        }

        private void hAfter_MouseHover(object sender, EventArgs e)
        {
            string str = "";
            str = Obj.value_H[CurrentBlock - 1, CurrentRound - 1];
            toolTip1.Show(str, hAfter);
        }

        private void btnR1_MouseHover(object sender, EventArgs e)
        {
            string str = "";
            str = Obj.value_A[CurrentBlock - 1, CurrentRound - 1];
            toolTip1.Show(str, btnR1);
        }

        private void btnR2_MouseHover(object sender, EventArgs e)
        {
            string str = "";
            str = Obj.value_E[CurrentBlock - 1, CurrentRound - 1];
            toolTip1.Show(str, btnR2);
        }

        private void wValue_MouseHover(object sender, EventArgs e)
        {
            string str = Obj.messageWords[CurrentBlock - 1, CurrentRound - 1];
            toolTip1.Show(str, wValue);
        }

        private void kValue_MouseHover(object sender, EventArgs e)
        {
            string str = Obj.k[CurrentRound - 1].ToString("x8");
            toolTip1.Show(str, kValue);
        }
    }
}
