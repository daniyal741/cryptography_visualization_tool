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

    public partial class DemoMD5_View_4 : UserControl
    {

        private string message;
        public string Message { get => message; set => message = value; }
        public string Hashvalue { get => hashvalue; set => hashvalue = value; }
        public int CurrentBlock { get => currentBlock; set => currentBlock = value; }
        internal NonKeyBased Obj { get => obj; set => obj = value; }
        public int CurrentRound { get => currentRound; set => currentRound = value; }
        public int CurrentFunctionBlock { get => currentFunctionBlock; set => currentFunctionBlock = value; }

        private DemoMD5_View_3 view1;
        private Control[] buttonControl;
        private int iteration = 1;
        private int seconds = 0;

        private string hashvalue;
        private int currentBlock;
        private Model.NonKeyBased obj;
        private int currentRound;
        private int currentFunctionBlock;

        public DemoMD5_View_4()
        {
            InitializeComponent();
        }

        public DemoMD5_View_4(DemoMD5_View_3 obj)
        {
            InitializeComponent();

            view1 = obj;
            this.Message = view1.Message;
            this.Hashvalue = view1.Hashvalue;
            this.CurrentBlock = view1.CurrentBlock;
            this.CurrentRound = view1.CurrentRound;
            this.CurrentFunctionBlock = view1.CurrentFunctionBlock;
            this.Obj = view1.Obj;
            buttonControl = new Control[4];

        }


        private void DemoMD5_View_4_Load(object sender, EventArgs e)
        {
            blockInfo.Text = "HMD5 Block # " + CurrentBlock;
            roundInfo.Text = "HMD5 Round # " + CurrentRound;
            functionInfo.Text = "Function Block # " + CurrentFunctionBlock;
            iterationInfo.Text = "Iteration #" + iteration;
            btnShow_Click(sender, e);

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private async void btnShow_Click(object sender, EventArgs e)
        {
            await Task.Delay(500);
            if (CurrentRound == 1)
            {
                btnR1.Text = "F";

            }
            if (CurrentRound == 2)
            {
                btnR1.Text = "G";

            }
            if (CurrentRound == 3)
            {
                btnR1.Text = "H";

            }
            if (CurrentRound == 4)
            {
                btnR1.Text = "I";

            }

            btnR1.Visible = true;
            await Task.Delay(500);



            viewInput.Text = Message.ToString();
            await Task.Delay(500);
            viewResult.Text = Hashvalue.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // DemoMD5_View_2 uc_demo_md5 = new DemoMD5_View_2();
            // uc_demo_md5.Dock = DockStyle.Fill;


            //MainForm.Instance.panelContain.Controls.Add(uc_demo_md5);
            MainForm.Instance.panelContain.Controls["DemoMD5_View_3"].BringToFront();
            MainForm.Instance.panelContain.Controls["DemoMD5_View_4"].Dispose();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void plusBox1_MouseHover(object sender, EventArgs e)
        {
            string str = "A + F(B,C,D)";

            toolTip1.Show(str, plusBox1);
        }

        private void plusBox2_MouseHover(object sender, EventArgs e)
        {
            string str = "M[i] + ( A + F(B,C,D) )";

            toolTip1.Show(str, plusBox2);
        }

        private void plusBox3_MouseHover(object sender, EventArgs e)
        {
            string str = "K[i] + ( M[i] + ( A + F(B,C,D) ) )";

            toolTip1.Show(str, plusBox3);
        }

        private void plusBox4_MouseHover(object sender, EventArgs e)
        {

            string str = "( K[i] + ( M[i] + ( A + F(B,C,D) ) ) <<< s ) + B";

            toolTip1.Show(str, plusBox4);

        }

        private void shiftLabel_MouseHover(object sender, EventArgs e)
        {
            string str = "( K[i] + ( M[i] + ( A + F(B,C,D) ) ) ) <<< s ";

            toolTip1.Show(str, shiftLabel);
        }

        private void mLabel_MouseHover(object sender, EventArgs e)
        {
            string msg = "";
            msg = "0x" + Obj.InputBlocks[CurrentBlock - 1, 0 + ((CurrentRound - 1) * 4)];

            toolTip1.Show(msg, mLabel);
        }

        private void kLabel_MouseHover(object sender, EventArgs e)
        {
            string msg = "";
            msg = "0x" + Obj.T[0];

            toolTip1.Show(msg, kLabel);
        }

        private void label10_MouseHover(object sender, EventArgs e)
        {
            string msg = "";
            msg = "Message Block => 16 * 32-bits";

            toolTip1.Show(msg, label10);
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            string msg = "";
            msg = "Constant T => 64 * 32-bits";

            toolTip1.Show(msg, label4);
        }

        private void btnR1_MouseHover(object sender, EventArgs e)
        {
            string msg = "";
            if (CurrentRound == 1)
            {
                msg = "F(B,C,D) = (B ^ C) v (¬B ^ D)";
            }
            if (CurrentRound == 2)
            {
                msg = "G(B,C,D) = (B ^ D) v (C ^ ¬D)";
            }
            if (CurrentRound == 3)
            {
                msg = "H(B,C,D) = (B ⨁ C ⨁ D)";
            }
            if (CurrentRound == 4)
            {
                msg = "I(B,C,D) =  C ⨁ (B v ¬D)";
            }


            toolTip1.Show(msg, btnR1);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("s = number of Shifting bits\n" +
                            "M[i] = ith of Message Block of 32-bits\n " +
                             "T[i] = ith Constant of 32-bits");

        }

        private void label19_MouseHover(object sender, EventArgs e)
        {
            string temp = "";
            temp = "0x" + Obj.Value_A[(CurrentBlock - 1) + (CurrentRound - 1), ((4 * (CurrentFunctionBlock - 1)) + (iteration - 1))];
            toolTip1.Show(temp, label19);

        }

        private void label18_MouseHover(object sender, EventArgs e)
        {
            string temp = "";
            temp = "0x" + Obj.Value_B[(CurrentBlock - 1) + (CurrentRound - 1), ((4 * (CurrentFunctionBlock - 1)) + (iteration - 1))];
            toolTip1.Show(temp, label18);
        }

        private void label17_MouseHover(object sender, EventArgs e)
        {
            string temp = "";
            temp = "0x" + Obj.Value_C[(CurrentBlock - 1) + (CurrentRound - 1), ((4 * (CurrentFunctionBlock - 1)) + (iteration - 1))];
            toolTip1.Show(temp, label17);
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            string temp = "";
            temp = "0x" + Obj.Value_D[(CurrentBlock - 1) + (CurrentRound - 1), ((4 * (CurrentFunctionBlock - 1)) + (iteration - 1))];
            toolTip1.Show(temp, label2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            if (seconds >= 20 && iteration <= 1)
            {
                iterationInfo.Text = "Iteration #" + iteration;


            }
            if (seconds >= 40 && iteration <= 2)
            {
                iterationInfo.Text = "Iteration #" + iteration;

            }
            if (seconds >= 60 && iteration <= 3)
            {
                iterationInfo.Text = "Iteration #" + iteration;

            }
            if (seconds >= 80 && iteration <= 4)
            {
                iterationInfo.Text = "Iteration #" + iteration;

            }
            if (seconds >= 100 && iteration > 4)
            {

                seconds = 0;
                btnPause.Visible = false;
                btnResume.Visible = false;
                btnStart.Visible = true;
                timer1.Stop();
                timer1.Dispose();
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            iteration++;
            iterationInfo.Text = "Iteration #" + iteration;
            if (iteration == 4)
            {
                btnStart.Enabled = false;
            }


            /*
            btnStart.Visible = false;
            btnPause.Visible = true;
            btnResume.Visible = false;
            timer1.Start();
            */

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            btnPause.Visible = false;
            btnResume.Visible = true;
            timer1.Stop();

        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            btnResume.Visible = false;
            btnStart.Visible = false;
            btnPause.Visible = true;
            timer1.Start();

        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            if (CurrentFunctionBlock == 1 && iteration == 1)
            {

                string temp = "";
                temp = "0x01234567";
                toolTip1.Show(temp, label7);

            }
            else
            {
                string temp = "";
                temp = "0x" + Obj.Value_A[(CurrentBlock - 1) + (CurrentRound - 1), ((4 * (CurrentFunctionBlock - 1)) + (iteration - 2))];
                toolTip1.Show(temp, label7);
            }

        }

        private void label13_MouseHover(object sender, EventArgs e)
        {
            if (CurrentFunctionBlock == 1 && iteration == 1)
            {

                string temp = "";
                temp = "0x89abcdef";
                toolTip1.Show(temp, label13);

            }
            else
            {
                string temp = "";
                temp = "0x" + Obj.Value_B[(CurrentBlock - 1) + (CurrentRound - 1), ((4 * (CurrentFunctionBlock - 1)) + (iteration - 2))];
                toolTip1.Show(temp, label13);
            }
        }

        private void label14_MouseHover(object sender, EventArgs e)
        {
            if (CurrentFunctionBlock == 1 && iteration == 1)
            {

                string temp = "";
                temp = "0xfedcba98";
                toolTip1.Show(temp, label14);

            }
            else
            {
                string temp = "";
                temp = "0x" + Obj.Value_C[(CurrentBlock - 1) + (CurrentRound - 1), ((4 * (CurrentFunctionBlock - 1)) + (iteration - 2))];
                toolTip1.Show(temp, label14);
            }
        }

        private void label15_MouseHover(object sender, EventArgs e)
        {
            if (CurrentFunctionBlock == 1 && iteration == 1)
            {

                string temp = "";
                temp = "0x76543210";
                toolTip1.Show(temp, label15);

            }
            else
            {
                string temp = "";
                temp = "0x" + Obj.Value_D[(CurrentBlock - 1) + (CurrentRound - 1), ((4 * (CurrentFunctionBlock - 1)) + (iteration - 2))];
                toolTip1.Show(temp, label15);
            }
        }
    }
}
