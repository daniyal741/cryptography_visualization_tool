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
    public partial class DemoDES_View_2 : UserControl
    {

        private int seconds = 0;
        private int count = 0;

        private int currentroundblock;
        private int currentDesblock;
        private Advance advanceObj;

        public int currentDESblock { get => currentDesblock; set => currentDesblock = value; }
        internal Advance AdvanceObj { get => advanceObj; set => advanceObj = value; }
        private Button[] imageControl = new Button[16];

        public int CurrentRoundBlock { get => currentroundblock; set => currentroundblock = value; }

        public DemoDES_View_2()
        {
            InitializeComponent();
            LoadRounds();
        }

        public DemoDES_View_2(DemoDES_View_1 obj)
        {
            InitializeComponent();
            imageControl = new Button[16];
            currentDESblock = obj.currentDESblock;
            AdvanceObj = obj.AdvanceObj;

        }
        private void DemoDES_View_2_Load(object sender, EventArgs e)
        {
            LoadRounds();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            timer1.Stop();
            timer1.Dispose();

            MainForm.Instance.panelContain.Controls["DemoDES_View_2"].Dispose();

            MainForm.Instance.panelContain.Controls["DemoDES_View_1"].BringToFront();





        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            if (seconds >= 5)
            {
                btnPlaintext.Visible = true;
            }
            if (seconds >= 10)
            {
                downarrow1.Visible = true;
            }
            if (seconds >= 15)
            {
                btnInitPer.Visible = true;
            }
            if (seconds >= 20)
            {
                downarrow2.Visible = true;

            }
            if (seconds >= 25 && count == 0)
            {
                btnR1.Visible = true;
                imageControl[count] = btnR1; count++;
            }
            if (seconds >= 30)
            {
                arrowR1.Visible = true;

            }
            if (seconds >= 35 && count == 1)
            {
                btnR2.Visible = true;
                imageControl[count] = btnR2; count++;

            }
            if (seconds >= 40)
            {
                arrowR2.Visible = true;

            }
            if (seconds >= 45 && count == 2)
            {
                btnR3.Visible = true;
                imageControl[count] = btnR3; count++;

            }

            if (seconds >= 50)
            {
                arrowR3.Visible = true;

            }
            if (seconds >= 55 && count == 3)
            {
                btnR4.Visible = true;
                imageControl[count] = btnR4; count++;

            }
            if (seconds >= 60)
            {
                downarrowR4.Visible = true;

            }
            if (seconds >= 65 && count == 4)
            {
                btnR5.Visible = true;
                imageControl[count] = btnR5; count++;

            }
            if (seconds >= 70)
            {
                arrowR5.Visible = true;

            }
            if (seconds >= 75 && count == 5)
            {
                btnR6.Visible = true;
                imageControl[count] = btnR6; count++;

            }
            if (seconds >= 80)
            {
                arrowR6.Visible = true;

            }
            if (seconds >= 85 && count == 6)
            {
                btnR7.Visible = true;
                imageControl[count] = btnR7; count++;

            }
            if (seconds >= 90)
            {
                arrowR7.Visible = true;

            }
            if (seconds >= 95 && count == 7)
            {
                btnR8.Visible = true;
                imageControl[count] = btnR8; count++;

            }
            if (seconds >= 100)
            {
                downarrowR8.Visible = true;

            }
            if (seconds >= 105 && count == 8)
            {
                btnR9.Visible = true;
                imageControl[count] = btnR9; count++;

            }
            if (seconds >= 110)
            {
                arrowR9.Visible = true;

            }
            if (seconds >= 115 && count == 9)
            {
                btnR10.Visible = true;
                imageControl[count] = btnR10; count++;

            }
            if (seconds >= 120)
            {
                arrowR10.Visible = true;

            }
            if (seconds >= 125 && count == 10)
            {
                btnR11.Visible = true;
                imageControl[count] = btnR11; count++;

            }
            if (seconds >= 130)
            {
                arrowR11.Visible = true;

            }
            if (seconds >= 135 && count == 11)
            {
                btnR12.Visible = true;
                imageControl[count] = btnR12; count++;

            }
            if (seconds >= 140)
            {
                downarrowR12.Visible = true;

            }
            if (seconds >= 145 && count == 12)
            {
                btnR13.Visible = true;
                imageControl[count] = btnR13; count++;

            }
            if (seconds >= 150)
            {
                arrowR13.Visible = true;

            }
            if (seconds >= 155 && count == 13)
            {
                btnR14.Visible = true;
                imageControl[count] = btnR14; count++;

            }
            if (seconds >= 160)
            {
                arrowR14.Visible = true;

            }
            if (seconds >= 165 && count == 14)
            {
                btnR15.Visible = true;
                imageControl[count] = btnR15; count++;

            }
            if (seconds >= 170)
            {
                arrowR15.Visible = true;

            }
            if (seconds >= 175 && count == 15)
            {
                btnR16.Visible = true;
                imageControl[count] = btnR16; count++;

            }
            if (seconds >= 180)
            {
                downarrowR16.Visible = true;

            }
            if (seconds >= 185)
            {
                btnFinalPer.Visible = true;

            }
            if (seconds >= 190)
            {
                downarrow7.Visible = true;

            }
            if (seconds >= 195)
            {

                btnCiphertext.Visible = true;

            }
            if (seconds >= 300)
            {
                seconds = 0;
                timer1.Stop();

            }
        }

        private void LoadRounds()
        {

            timer1.Start();


        }



        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            string str = "A Key(i) will be Generated for each Round(i) ";
            toolTip1.Show(str, button2);
        }

        private void btnRound_Click(object sender, EventArgs e)
        {


            Button image = sender as Button;

            for (int i = 0; i < imageControl.Length; i++)
            {
                if (image.Name.ToString() == imageControl[i].Name.ToString())
                {
                    CurrentRoundBlock = i + 1;
                }

            }




            // MessageBox.Show("Alhamdulillah ! You have clicked block number-" + CurrentBlock);

            try
            {
                timer1.Stop();
                seconds = 0;
                DemoDES_View_3 uc_des = new DemoDES_View_3(this);
                uc_des.Dock = DockStyle.Fill;
                MainForm.Instance.panelContain.Controls.Add(uc_des);
                MainForm.Instance.panelContain.Controls["DemoDES_View_3"].BringToFront();
            }
            catch (Exception)
            {
                MessageBox.Show("Please Wait a Moment ");
            }

        }

        private void roundValue_Hover(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            if (pic.Name == "arrowR1")
                toolTip1.Show(AdvanceObj.roundOutput[(currentDESblock - 1) * 16 + 0], arrowR1);
            if (pic.Name == "arrowR2")
                toolTip1.Show(AdvanceObj.roundOutput[(currentDESblock - 1) * 16 + 1], arrowR2);
            if (pic.Name == "arrowR3")
                toolTip1.Show(AdvanceObj.roundOutput[(currentDESblock - 1) * 16 + 2], arrowR3);
            if (pic.Name == "downarrowR4")
                toolTip1.Show(AdvanceObj.roundOutput[(currentDESblock - 1) * 16 + 3], downarrowR4);
            if (pic.Name == "arrowR5")
                toolTip1.Show(AdvanceObj.roundOutput[(currentDESblock - 1) * 16 + 4], arrowR5);
            if (pic.Name == "arrowR6")
                toolTip1.Show(AdvanceObj.roundOutput[(currentDESblock - 1) * 16 + 5], arrowR6);
            if (pic.Name == "arrowR7")
                toolTip1.Show(AdvanceObj.roundOutput[(currentDESblock - 1) * 16 + 6], arrowR7);
            if (pic.Name == "downarrowR8")
                toolTip1.Show(AdvanceObj.roundOutput[(currentDESblock - 1) * 16 + 7], downarrowR8);
            if (pic.Name == "arrowR9")
                toolTip1.Show(AdvanceObj.roundOutput[(currentDESblock - 1) * 16 + 8], arrowR9);
            if (pic.Name == "arrowR10")
                toolTip1.Show(AdvanceObj.roundOutput[(currentDESblock - 1) * 16 + 9], arrowR10);
            if (pic.Name == "arrowR11")
                toolTip1.Show(AdvanceObj.roundOutput[(currentDESblock - 1) * 16 + 10], arrowR11);
            if (pic.Name == "downarrowR12")
                toolTip1.Show(AdvanceObj.roundOutput[(currentDESblock - 1) * 16 + 11], downarrowR12);
            if (pic.Name == "arrowR13")
                toolTip1.Show(AdvanceObj.roundOutput[(currentDESblock - 1) * 16 + 12], arrowR13);
            if (pic.Name == "arrowR14")
                toolTip1.Show(AdvanceObj.roundOutput[(currentDESblock - 1) * 16 + 13], arrowR14);
            if (pic.Name == "arrowR15")
                toolTip1.Show(AdvanceObj.roundOutput[(currentDESblock - 1) * 16 + 14], arrowR15);
            if (pic.Name == "downarrowR16")
                toolTip1.Show(AdvanceObj.roundOutput[(currentDESblock - 1) * 16 + 15], downarrowR16);





        }

        

        private void downarrow7_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(AdvanceObj.finalPermutationForRounds[currentDESblock - 1], downarrow7);
        }

        private void downarrow2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(AdvanceObj.initialPermutationForRounds[currentDESblock - 1], downarrow2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            seconds = 5000;

        }

        private void downarrow1_MouseHover(object sender, EventArgs e)
        {
            string str = AdvanceObj.plaintextBlocks[currentDESblock - 1];

            toolTip1.Show(str, downarrow1);
        }
    }
}
