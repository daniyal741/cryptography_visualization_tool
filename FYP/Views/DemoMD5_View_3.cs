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
using FYP.Views;

namespace FYP
{
    public partial class DemoMD5_View_3 : UserControl
    {

        private string message;
        public string Message { get => message; set => message = value; }
        public string Hashvalue { get => hashvalue; set => hashvalue = value; }
        public int CurrentBlock { get => currentBlock; set => currentBlock = value; }
        internal NonKeyBased Obj { get => obj; set => obj = value; }
        public int CurrentRound { get => currentRound; set => currentRound = value; }
        public int CurrentFunctionBlock { get => currentFunctionBlock; set => currentFunctionBlock = value; }

        private DemoMD5_View_2 view1;
        private Control[] buttonControl;


        private string hashvalue;
        private int currentBlock;
        private Model.NonKeyBased obj;
        private int currentRound;
        private int currentFunctionBlock;

        public DemoMD5_View_3()
        {
            InitializeComponent();
        }

        public DemoMD5_View_3(DemoMD5_View_2 obj)
        {

            InitializeComponent();

            view1 = obj;
            this.Message = view1.Message;
            this.Hashvalue = view1.Hashvalue;
            this.CurrentBlock = view1.CurrentBlock;
            this.CurrentRound = view1.CurrentRound;
            this.CurrentFunctionBlock = 0;
            this.Obj = view1.Obj;
            buttonControl = new Control[4];

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // DemoMD5_View_2 uc_demo_md5 = new DemoMD5_View_2();
            // uc_demo_md5.Dock = DockStyle.Fill;


            //MainForm.Instance.panelContain.Controls.Add(uc_demo_md5);
            MainForm.Instance.panelContain.Controls["DemoMD5_View_2"].BringToFront();
            MainForm.Instance.panelContain.Controls["DemoMD5_View_3"].Dispose();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btnShow_Click(object sender, EventArgs e)
        {


            if (CurrentRound == 2)
            {
                btnR1.Text = "G x 4";
                btnR2.Text = "G x 4";
                btnR3.Text = "G x 4";
                btnR4.Text = "G x 4";
                functionInfo.Text = "'G' is a Function which takes 32-bits of input message, 4 variables of 32-bits, One constant of 32-bits and a shifting bit.";


            }
            if (CurrentRound == 3)
            {
                btnR1.Text = "H x 4";
                btnR2.Text = "H x 4";
                btnR3.Text = "H x 4";
                btnR4.Text = "H x 4";
                functionInfo.Text = "'H' is a Function which takes 32-bits of input message, 4 variables of 32-bits, One constant of 32-bits and a shifting bit.";


            }
            if (CurrentRound == 4)
            {
                btnR1.Text = "I x 4";
                btnR2.Text = "I x 4";
                btnR3.Text = "I x 4";
                btnR4.Text = "I x 4";
                functionInfo.Text = "'I' is a Function which takes 32-bits of input message, 4 variables of 32-bits, One constant of 32-bits and a shifting bit.";


            }
            await Task.Delay(500);
            btnR1.Visible = true;
            await Task.Delay(500);
            btnR2.Visible = true;
            await Task.Delay(500);
            btnR3.Visible = true;
            await Task.Delay(500);
            btnR4.Visible = true;
            await Task.Delay(500);
            functionInfo.Visible = true;
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
            await Task.Delay(500);
            viewResult.Text = Hashvalue.ToString();

        }

        protected void a_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            for (int i = 0; i < buttonControl.Length; i++)
            {
                if (btn.Name.ToString() == buttonControl[i].Name.ToString())
                {
                    CurrentFunctionBlock = i + 1;
                }

            }
            DemoMD5_View_4 uc_demo_md5 = new DemoMD5_View_4(this);
            uc_demo_md5.Dock = DockStyle.Fill;


            MainForm.Instance.panelContain.Controls.Add(uc_demo_md5);
            MainForm.Instance.panelContain.Controls["DemoMD5_View_4"].BringToFront();

        }


        private void label8_MouseHover(object sender, EventArgs e)
        {

            string msg = "";
            if (CurrentBlock == 1 && CurrentRound == 1)
            {
                msg = "A = 0x" + Obj.ChainingVariables[CurrentBlock - 1, 0] +
                       "\nB = 0x" + Obj.ChainingVariables[CurrentBlock - 1, 1] +
                       "\nC = 0x" + Obj.ChainingVariables[CurrentBlock - 1, 2] +
                       "\nD = 0x" + Obj.ChainingVariables[CurrentBlock - 1, 3];

            }
            else if (CurrentRound > 1)
            {

                msg = Obj.OutputRounds[CurrentBlock - 1, (CurrentRound - 2) + (CurrentBlock - 1) * 4];

            }
            toolTip1.Show(msg, label8);
        }

        private void label9_MouseHover(object sender, EventArgs e)
        {
            string msg = "";

            msg = Obj.OutputRounds[CurrentBlock - 1, (CurrentRound - 1) + ((CurrentBlock - 1) * 4)];

            toolTip1.Show(msg, label9);
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            string msg = "";
            msg = "0x" + Obj.InputBlocks[CurrentBlock - 1, 0 + ((CurrentRound - 1) * 4)];

            toolTip1.Show(msg, label3);
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            string msg = "";

            msg = "0x" + Obj.InputBlocks[CurrentBlock - 1, 1 + ((CurrentRound - 1) * 4)];

            toolTip1.Show(msg, label4);
        }


        private void label5_MouseHover(object sender, EventArgs e)
        {
            string msg = "";

            msg = "0x" + Obj.InputBlocks[CurrentBlock - 1, 2 + ((CurrentRound - 1) * 4)];

            toolTip1.Show(msg, label5);
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            string msg = "";

            msg = "0x" + Obj.InputBlocks[CurrentBlock - 1, 3 + ((CurrentRound - 1) * 4)];

            toolTip1.Show(msg, label6);
        }

        private void DemoMD5_View_3_Load(object sender, EventArgs e)
        {
            blockInfo.Text = "HMD5 Block # " + CurrentBlock;
            roundInfo.Text = "HMD5 Round # " + CurrentRound;
            btnShow_Click(sender, e);

        }

        private void btnR1_Click(object sender, EventArgs e)
        {

        }

        private void btnR1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnR2_Click(object sender, EventArgs e)
        {

        }
    }
}
