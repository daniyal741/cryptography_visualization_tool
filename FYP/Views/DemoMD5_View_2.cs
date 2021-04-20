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


namespace FYP
{
    public partial class DemoMD5_View_2 : UserControl
    {

        private string message;
        public string Message { get => message; set => message = value; }
        public string Hashvalue { get => hashvalue; set => hashvalue = value; }
        public int CurrentBlock { get => currentBlock; set => currentBlock = value; }
        internal NonKeyBased Obj { get => obj; set => obj = value; }
        public int CurrentRound { get => currentRound; set => currentRound = value; }

        private string hashvalue;
        private int currentBlock;
        private Model.NonKeyBased obj;
        private int currentRound;

        private DemoMD5_View_1 view1;
        private Control[] buttonControl;
        private int seconds = 0;
        private int count = 0;
        private string str = "";
        public DemoMD5_View_2()
        {
            InitializeComponent();
        }
        public DemoMD5_View_2(DemoMD5_View_1 obj)
        {
            InitializeComponent();
            view1 = obj;
            this.Message = view1.Message;
            this.Hashvalue = view1.Hashvalue;
            this.CurrentBlock = view1.CurrentBlock;
            this.Obj = view1.Obj;
            buttonControl = new Control[4];

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            MainForm.Instance.panelContain.Controls["DemoMD5_View_2"].Dispose();
            MainForm.Instance.panelContain.Controls["DemoMD5_View_1"].BringToFront();


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DemoMD5_View_2_Load(object sender, EventArgs e)
        {
            blockInfo.Text = "HMD5 Block # " + CurrentBlock;
            lb_A.Visible = false;
            lb_B.Visible = false;
            lb_C.Visible = false;
            lb_D.Visible = false;

            str = label2.Text;
            label2.Text = "";

            btnR1.Visible = false;
            btnR2.Visible = false;
            btnR3.Visible = false;
            btnR4.Visible = false;


            btnShow_Click(sender, e);

        }

        private void FlowPanelHashBlock_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.) A,B,C,D are the Initial Chaining Variables\n2.) A*,B*,C*,D* are updated Chaining variables that will be used for the next Hash Block");
        }

        private async void btnShow_Click(object sender, EventArgs e)
        {

            blockInfo.Text = "HMD5 Block # " + CurrentBlock;

            lb_A.Visible = true;
            lb_B.Visible = true;
            lb_C.Visible = true;
            lb_D.Visible = true;

            await Task.Delay(500);
            btnR1.Visible = true;
            await Task.Delay(500);
            arrow1.Visible = true;
            await Task.Delay(500);
            btnR2.Visible = true;
            await Task.Delay(500);
            arrow2.Visible = true;
            await Task.Delay(500);
            btnR3.Visible = true;
            await Task.Delay(500);
            arrow3.Visible = true;
            await Task.Delay(500);
            btnR4.Visible = true;
            await Task.Delay(500);


            buttonControl[0] = btnR1;
            buttonControl[1] = btnR2;
            buttonControl[2] = btnR3;
            buttonControl[3] = btnR4;

            btnR1.Click += new EventHandler(a_Click);
            btnR2.Click += new EventHandler(a_Click);
            btnR3.Click += new EventHandler(a_Click);
            btnR4.Click += new EventHandler(a_Click);


            viewInput.Text = Message.ToString();
            await Task.Delay(400);
            viewResult.Text = Hashvalue.ToString();
            await Task.Delay(400);

            timer1.Start();
        }

        protected void a_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            for (int i = 0; i < buttonControl.Length; i++)
            {
                if (btn.Name.ToString() == buttonControl[i].Name.ToString())
                {
                    CurrentRound = i + 1;
                }

            }
            DemoMD5_View_3 uc_demo_md5 = new DemoMD5_View_3(this);
            uc_demo_md5.Dock = DockStyle.Fill;


            MainForm.Instance.panelContain.Controls.Add(uc_demo_md5);
            MainForm.Instance.panelContain.Controls["DemoMD5_View_3"].BringToFront();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lb_A_Click(object sender, EventArgs e)
        {

        }

        private void lb_B_Click(object sender, EventArgs e)
        {

        }

        private void lb_C_Click(object sender, EventArgs e)
        {

        }

        private void lb_D_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnR2_Click(object sender, EventArgs e)
        {

        }

        private void btnR1_Click(object sender, EventArgs e)
        {
        }

        private void btnR3_Click(object sender, EventArgs e)
        {

        }

        private void btnR4_Click(object sender, EventArgs e)
        {

        }



        private void label3_MouseEnter(object sender, EventArgs e)
        {


        }



        private void label3_MouseHover(object sender, EventArgs e)
        {
            string msg = "";

            for (int i = 0; i < 4; i++)
            {

                msg += "0x" + Obj.InputBlocks[CurrentBlock - 1, i] + "\n";

            }

            toolTip1.Show(msg, label3);
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            string msg = "";

            for (int i = 4; i < 8; i++)
            {

                msg += "0x" + Obj.InputBlocks[CurrentBlock - 1, i] + "\n";

            }

            toolTip1.Show(msg, label4);
        }
        private void label5_MouseHover(object sender, EventArgs e)
        {
            string msg = "";

            for (int i = 8; i < 12; i++)
            {

                msg += "0x" + Obj.InputBlocks[CurrentBlock - 1, i] + "\n";

            }

            toolTip1.Show(msg, label5);
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            string msg = "";

            for (int i = 12; i < 16; i++)
            {

                msg += "0x" + Obj.InputBlocks[CurrentBlock - 1, i] + "\n";

            }

            toolTip1.Show(msg, label6);
        }

        private void label8_MouseHover(object sender, EventArgs e)
        {
            string msg = "A = 0x" + Obj.ChainingVariables[CurrentBlock - 1, 0] +
                         "\nB = 0x" + Obj.ChainingVariables[CurrentBlock - 1, 1] +
                         "\nC = 0x" + Obj.ChainingVariables[CurrentBlock - 1, 2] +
                         "\nD = 0x" + Obj.ChainingVariables[CurrentBlock - 1, 3];

            toolTip1.Show(msg, label8);
        }


        private void label9_MouseHover(object sender, EventArgs e)
        {

            string msg = "";
            CurrentRound = 4;
            msg = Obj.OutputRounds[CurrentBlock - 1, (CurrentRound - 1) + ((CurrentBlock - 1) * 4)];

            toolTip1.Show(msg, label9);


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            seconds++;
            if (seconds >= 15 && count < str.Length)
            {
                count++;
                label2.Text = str.Substring(0, count);
            }
            if (count == str.Length)
            {

                timer1.Stop();

            }

        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            string msg = "A = 0x" + Obj.ChainingVariables[CurrentBlock, 0] +
                      "\nB = 0x" + Obj.ChainingVariables[CurrentBlock, 1] +
                      "\nC = 0x" + Obj.ChainingVariables[CurrentBlock, 2] +
                      "\nD = 0x" + Obj.ChainingVariables[CurrentBlock, 3];

            toolTip1.Show(msg, label2);
        }

        private void arrow1_MouseHover(object sender, EventArgs e)
        {
            string msg = "";
            CurrentRound = 1;
            msg = Obj.OutputRounds[CurrentBlock - 1, (CurrentRound - 1) + ((CurrentBlock - 1) * 4)];

            toolTip1.Show(msg, arrow1);
        }

        private void arrow2_MouseHover(object sender, EventArgs e)
        {
            string msg = "";
            CurrentRound = 2;
            msg = Obj.OutputRounds[CurrentBlock - 1, (CurrentRound - 1) + ((CurrentBlock - 1) * 4)];

            toolTip1.Show(msg, arrow2);
        }

        private void arrow3_MouseHover(object sender, EventArgs e)
        {
            string msg = "";
            CurrentRound = 3;
            msg = Obj.OutputRounds[CurrentBlock - 1, (CurrentRound - 1) + ((CurrentBlock - 1) * 4)];

            toolTip1.Show(msg, arrow3);
        }

        private void btnR1_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Size = new Size(200, 60);
        }

        private void btnR1_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Size = new Size(188, 52);
        }
    }
}
