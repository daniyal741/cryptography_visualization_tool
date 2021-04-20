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
    public partial class DemoDES_View_3 : UserControl
    {

        int seconds = 0;
        DemoDES_View_2 obj_des;

        private Advance advanceObj;

        internal Advance AdvanceObj { get => advanceObj; set => advanceObj = value; }

        public DemoDES_View_3()
        {
            InitializeComponent();
        }
        public DemoDES_View_3(DemoDES_View_2 obj)
        {
            InitializeComponent();
            obj_des = obj;
            AdvanceObj = obj_des.AdvanceObj;
        }


        private void DemoDES_View_3_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (seconds == 1)
            {
                pictureBox3.BringToFront();
                seconds = 0;
            }
            else
            {
                pictureBox5.BringToFront();
                seconds = 1;
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm.Instance.panelContain.Controls["DemoDES_View_3"].Dispose();

            MainForm.Instance.panelContain.Controls["DemoDES_View_2"].BringToFront();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLeftPlaintext_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(AdvanceObj.leftPlaintext[obj_des.CurrentRoundBlock - 1], btnLeftPlaintext);
        }

        private void btnRightPlaintext_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(AdvanceObj.rightPlaintetxt[obj_des.CurrentRoundBlock - 1], btnRightPlaintext);

        }

        private void btnLeftChangedPlaintext_MouseHover(object sender, EventArgs e)
        {

            toolTip1.Show(AdvanceObj.rightPlaintetxt[obj_des.CurrentRoundBlock - 1], btnLeftChangedPlaintext);

        }

        private void btnRightChangedPlaintext_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(AdvanceObj.lptXORfunctionRounds[obj_des.CurrentRoundBlock - 1], btnRightChangedPlaintext);

        }

        private void btnRightChangedPlaintext_Click(object sender, EventArgs e)
        {

        }



        private void btnFunction_Click(object sender, EventArgs e)
        {
            DemoDES_View_4 uc_des = new DemoDES_View_4(obj_des);
            uc_des.Dock = DockStyle.Fill;
            MainForm.Instance.panelContain.Controls.Add(uc_des);
            MainForm.Instance.panelContain.Controls["DemoDES_View_4"].BringToFront();
        }

        private void btnFunction_MouseHover(object sender, EventArgs e)
        {
            // toolTip1.Show(AdvanceObj.pBoxPermutationRounds[obj_des.CurrentRoundBlock - 1], btnFunction);
        }

        private void FunctionValue_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(AdvanceObj.pBoxPermutationRounds[obj_des.CurrentRoundBlock - 1], FunctionValue);

        }

        private void lptXORfunction_Value_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(AdvanceObj.lptXORfunctionRounds[obj_des.CurrentRoundBlock - 1], lptXORfunction_Value);
        }

        private void ChangedLPT_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(AdvanceObj.rightPlaintetxt[obj_des.CurrentRoundBlock - 1], ChangedLPT);

        }

        private void ChangedRPT_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(AdvanceObj.lptXORfunctionRounds[obj_des.CurrentRoundBlock - 1], ChangedRPT);

        }

        private void LPT_Value_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(AdvanceObj.leftPlaintext[obj_des.CurrentRoundBlock - 1], LPT_Value);
        }

        private void RPT_Value_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(AdvanceObj.rightPlaintetxt[obj_des.CurrentRoundBlock - 1], RPT_Value);
        }

        private void KeyTranformation_Value_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(AdvanceObj.shiftedKeys[obj_des.CurrentRoundBlock - 1], KeyTranformation_Value);

        }

        private void XorBox_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("LPT ⨁ Function", XorBox);
        }

        private void RPT_Value_Click(object sender, EventArgs e)
        {

        }

        private void orignalKey_Value_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(AdvanceObj.getSecretKey(), orignalKey_Value);
        }

        private void discardedKey_Value_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(AdvanceObj.discardedKeys, discardedKey_Value);
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(AdvanceObj.shiftedKeys[obj_des.CurrentRoundBlock - 1], panel1);

        }

        private void pictureBox11_MouseHover(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DisplayPicture uc = new DisplayPicture();
            uc.Pic.BackgroundImage = Image.FromFile(MainForm.Instance.path + "/images/keybitDiscard.png");
            uc.Dock = DockStyle.Fill;
            MainForm.Instance.panelContain.Controls.Add(uc);
            MainForm.Instance.panelContain.Controls["DisplayPicture"].BringToFront();
        }
    }
}
