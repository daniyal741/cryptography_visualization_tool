using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using FYP.Model;

namespace FYP.Views
{
    public partial class DemoSha512_View_2 : UserControl
    {

        private int currentRound;
        private DemoSha512_View_1 view1;
        private Sha512 obj;
        private int currentBlock;

        public int CurrentRound { get => currentRound; set => currentRound = value; }
        public DemoSha512_View_1 View1 { get => view1; set => view1 = value; }
        internal Sha512 Obj { get => obj; set => obj = value; }
        public int CurrentBlock { get => currentBlock; set => currentBlock = value; }

        public DemoSha512_View_2()
        {
            InitializeComponent();
        }
        public DemoSha512_View_2(DemoSha512_View_1 obj)
        {
            InitializeComponent();
            this.Obj = obj.Obj;
            this.CurrentBlock = obj.CurrentBlock;
            this.CurrentRound = 1;
        }


        private void btnBack_Click(object sender, EventArgs e)
        {

            MainForm.Instance.panelContain.Controls["DemoSha512_View_2"].Dispose();
            MainForm.Instance.panelContain.Controls["DemoSha512_View_1"].BringToFront();

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void roundValue_ValueChanged(object sender, EventArgs e)
        {
           string str = roundValue.Text;
            
            try
            {
                if (!String.IsNullOrEmpty(str) && str.All(char.IsDigit))
                {
                    roundValue.Text = str;
                    int num = Convert.ToInt32(str);
                    if (num > 0 && num < 81)
                    {
                        ClearLabels();

                        btnRound.Text = "Round - " + str;
                        k_label.Text = "K -" + num;
                        w_label.Text = "W -" + num;
                        CurrentRound = num;

                        if (num == 80)
                        {

                            LoadLabels();

                        }
                    }
                    else {


                        throw new ApplicationException("Please Enter Round Number Between 1 to 80");


                    }


                }

                else
                {
                    if (String.IsNullOrEmpty(str))
                    { }
                    else
                    {
                        throw new ApplicationException("Please Enter Round Number Between 1 to 80");

                    }


                }
            }
            catch (ApplicationException a)
            {
                MessageBox.Show(a.Message);

            }

            

        }
        private void ClearLabels()
        {
            plusBox1.Visible = false;
            plusBox2.Visible = false;
            plusBox3.Visible = false;
            plusBox4.Visible = false;
            plusBox5.Visible = false;
            plusBox6.Visible = false;
            plusBox7.Visible = false;
            plusBox8.Visible = false;

            aLast.Visible = false;
            bLast.Visible = false;
            cLast.Visible = false;
            dLast.Visible = false;
            eLast.Visible = false;
            fLast.Visible = false;
            gLast.Visible = false;
            hLast.Visible = false;
        }
        private void LoadLabels()
        {

            plusBox1.Visible = true;
            plusBox2.Visible = true;
            plusBox3.Visible = true;
            plusBox4.Visible = true;
            plusBox5.Visible = true;
            plusBox6.Visible = true;
            plusBox7.Visible = true;
            plusBox8.Visible = true;

            aLast.Visible = true;
            bLast.Visible = true;
            cLast.Visible = true;
            dLast.Visible = true;
            eLast.Visible = true;
            fLast.Visible = true;
            gLast.Visible = true;
            hLast.Visible = true;



        }
        private void label2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("A Constant K[1-80]", k_label);
        }

        private void kValue_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void w_label_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("A Word[1-80] from Message",w_label);
        }

        private void kValue_MouseHover_1(object sender, EventArgs e)
        {
            string str = Obj.k[CurrentRound - 1].ToString("x8");
            toolTip1.Show(str, kValue);
        }

        private void wValue_MouseHover(object sender, EventArgs e)
        {
            string str = Obj.messageWords[CurrentBlock-1,CurrentRound - 1];
            toolTip1.Show(str, wValue);
        }

        private void aValue1_MouseHover(object sender, EventArgs e)
        {

            string str = "";

            if (CurrentRound == 1 && CurrentBlock ==1)
            {
                str = Obj.iv[0].ToString("x8");
            }
            if (CurrentBlock > 1 && CurrentRound==1)
            {
                str = Obj.value_A[CurrentBlock - 2, 80];

            }
            if (CurrentBlock == 1 && CurrentRound != 1)
            {
                str = Obj.value_A[CurrentBlock - 1, CurrentRound - 2];
            }
            if(CurrentBlock != 1 && CurrentRound != 1)
            {

                str = Obj.value_A[CurrentBlock - 1, CurrentRound - 2];

            }

            toolTip1.Show(str, aValue1);
        }

        private void aValue2_MouseHover(object sender, EventArgs e)
        {
            string str = "";
            str = Obj.value_A[CurrentBlock - 1, CurrentRound - 1];
            toolTip1.Show(str, aValue2);

        }

        private void bValue1_MouseHover(object sender, EventArgs e)
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

            toolTip1.Show(str, bValue1);
        }

        private void bValue2_MouseHover(object sender, EventArgs e)
        {
            string str = "";
            str = Obj.value_B[CurrentBlock - 1, CurrentRound - 1];
            toolTip1.Show(str, bValue2);
        }

        private void DemoSha512_View_2_Load(object sender, EventArgs e)
        {

        }

        private void label2_MouseHover_1(object sender, EventArgs e)
        {
            string str = "";
            str = Obj.value_A[CurrentBlock - 1, 80];  // 81th
            toolTip1.Show(str, hLast);
        }

        private void cValue1_MouseHover(object sender, EventArgs e)
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

            toolTip1.Show(str, cValue1);
        }

        private void dValue1_MouseHover(object sender, EventArgs e)
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

            toolTip1.Show(str, dValue1);
        }

        private void eValue1_MouseHover(object sender, EventArgs e)
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

            toolTip1.Show(str, eValue1);
        }

        private void fValue1_MouseHover(object sender, EventArgs e)
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

            toolTip1.Show(str, fValue1);
        }

        private void gValue1_MouseHover(object sender, EventArgs e)
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

            toolTip1.Show(str, gValue1);
        }

        private void hValue1_MouseHover(object sender, EventArgs e)
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

            toolTip1.Show(str, hValue1);
        }

        private void cValue2_MouseHover(object sender, EventArgs e)
        {
            string str = "";
            str = Obj.value_C[CurrentBlock - 1, CurrentRound - 1];
            toolTip1.Show(str, cValue2);

        }

        private void dValue2_MouseHover(object sender, EventArgs e)
        {
            string str = "";
            str = Obj.value_D[CurrentBlock - 1, CurrentRound - 1];
            toolTip1.Show(str, dValue2);
        }

        private void eValue2_MouseHover(object sender, EventArgs e)
        {
            string str = "";
            str = Obj.value_E[CurrentBlock - 1, CurrentRound - 1];
            toolTip1.Show(str, eValue2);
        }

        private void fValue2_MouseHover(object sender, EventArgs e)
        {
            string str = "";
            str = Obj.value_F[CurrentBlock - 1, CurrentRound - 1];
            toolTip1.Show(str, fValue2);
        }

        private void gValue2_MouseHover(object sender, EventArgs e)
        {
            string str = "";
            str = Obj.value_G[CurrentBlock - 1, CurrentRound - 1];
            toolTip1.Show(str, gValue2);
        }

        private void hValue2_MouseHover(object sender, EventArgs e)
        {
            string str = "";
            str = Obj.value_H[CurrentBlock - 1, CurrentRound - 1];
            toolTip1.Show(str, hValue2);
        }

        private void aLast_MouseHover(object sender, EventArgs e)
        {
            string str = "";
            str = Obj.value_A[CurrentBlock - 1, 80];  // 81th Entry
            toolTip1.Show(str, aLast);
        }

        private void bLast_MouseHover(object sender, EventArgs e)
        {
            string str = "";
            str = Obj.value_B[CurrentBlock - 1, 80];  // 81th Entry
            toolTip1.Show(str, bLast);
        }

        private void cLast_MouseHover(object sender, EventArgs e)
        {
            string str = "";
            str = Obj.value_C[CurrentBlock - 1, 80];  // 81th Entry
            toolTip1.Show(str, cLast);
        }

        private void dLast_MouseHover(object sender, EventArgs e)
        {
            string str = "";
            str = Obj.value_D[CurrentBlock - 1, 80];  // 81th Entry
            toolTip1.Show(str, dLast);
        }

        private void eLast_MouseHover(object sender, EventArgs e)
        {
            string str = "";
            str = Obj.value_E[CurrentBlock - 1, 80];  // 81th Entry
            toolTip1.Show(str, eLast);
        }

        private void fLast_MouseHover(object sender, EventArgs e)
        {
            string str = "";
            str = Obj.value_F[CurrentBlock - 1, 80];  // 81th Entry
            toolTip1.Show(str, fLast);
        }

        private void gLast_MouseHover(object sender, EventArgs e)
        {
            string str = "";
            str = Obj.value_G[CurrentBlock - 1, 80];  // 81th Entry
            toolTip1.Show(str, gLast);
        }

        private void hLast_MouseHover(object sender, EventArgs e)
        {
            string str = "";
            str = Obj.value_H[CurrentBlock - 1, 80];  // 81th Entry
            toolTip1.Show(str, hLast);
        }

        private void plusBox1_MouseHover(object sender, EventArgs e)
        {

            toolTip1.Show("| A = a* + a |",plusBox1);

        }
        private void plusBox2_MouseHover(object sender, EventArgs e)
        {

            toolTip1.Show("| B = b* + b |", plusBox2);

        }

        private void plusBox3_MouseHover(object sender, EventArgs e)
        {

            toolTip1.Show("| C = c* + c |", plusBox3);

        }
        private void plusBox4_MouseHover(object sender, EventArgs e)
        {

            toolTip1.Show("| D = d* + d |", plusBox4);

        }
        private void plusBox5_MouseHover(object sender, EventArgs e)
        {

            toolTip1.Show("| E = e* + e |", plusBox5);

        }
        private void plusBox6_MouseHover(object sender, EventArgs e)
        {

            toolTip1.Show("| F = f* + f |", plusBox6);

        }

        private void plusBox7_MouseHover(object sender, EventArgs e)
        {

            toolTip1.Show("| G = g* + g |", plusBox7);

        }
        private void plusBox8_MouseHover(object sender, EventArgs e)
        {

            toolTip1.Show("| H = h* + h |", plusBox8);

        }

        private void btnRound_Click(object sender, EventArgs e)
        {
            
                
                DemoSha512_View_3 uc_demo_sha = new DemoSha512_View_3(this);
                uc_demo_sha.Dock = DockStyle.Fill;


                MainForm.Instance.panelContain.Controls.Add(uc_demo_sha);
                MainForm.Instance.panelContain.Controls["DemoSha512_View_3"].BringToFront();

            

        }

        private void label2_MouseHover_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            DisplayPicture uc = new DisplayPicture();


            uc.Pic.BackgroundImage = Image.FromFile(MainForm.Instance.path + "/images/Hashing/Sha_BlockRounds.jpg");
            uc.Dock = DockStyle.Fill;
            MainForm.Instance.panelContain.Controls.Add(uc);
            MainForm.Instance.panelContain.Controls["DisplayPicture"].BringToFront();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DisplayPicture uc = new DisplayPicture();


            uc.Pic.BackgroundImage = Image.FromFile(MainForm.Instance.path + "/images/Hashing/messageWords.jpg");
            uc.Dock = DockStyle.Fill;
            MainForm.Instance.panelContain.Controls.Add(uc);
            MainForm.Instance.panelContain.Controls["DisplayPicture"].BringToFront();
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Message Chunks of 1024-bits",pictureBox6);
        }
    }
}
