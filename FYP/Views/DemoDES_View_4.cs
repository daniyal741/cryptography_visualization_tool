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
    public partial class DemoDES_View_4 : UserControl
    {

        int seconds = 0;
        DemoDES_View_2 obj_des;


        private Advance advanceObj;

        internal Advance AdvanceObj { get => advanceObj; set => advanceObj = value; }

        public DemoDES_View_4()
        {
            InitializeComponent();
        }
        public DemoDES_View_4(DemoDES_View_2 obj)
        {
            InitializeComponent();
            obj_des = obj;
            AdvanceObj = obj_des.AdvanceObj;


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void DemoDES_View_4_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }


        private void RPT_Value_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(AdvanceObj.rightPlaintetxt[obj_des.CurrentRoundBlock - 1], RPT_Value);
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm.Instance.panelContain.Controls["DemoDES_View_4"].Dispose();

            MainForm.Instance.panelContain.Controls["DemoDES_View_3"].BringToFront();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void transformedKey_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(AdvanceObj.shiftedKeys[obj_des.CurrentRoundBlock - 1], transformedKey);

        }

        private void pictureBox14_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(AdvanceObj.shiftedKeys[obj_des.CurrentRoundBlock - 1], pictureBox14);

        }

        private void functionValue_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(AdvanceObj.pBoxPermutationRounds[obj_des.CurrentRoundBlock - 1], functionValue);

        }

        private void pictureBox13_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(AdvanceObj.shiftedKeys[obj_des.CurrentRoundBlock - 1], pictureBox13);

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void cKey_Value_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(AdvanceObj.cKey[obj_des.CurrentRoundBlock - 1], cKey_Value);

        }

        private void dKey_Value_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(AdvanceObj.dKey[obj_des.CurrentRoundBlock - 1], dKey_Value);

        }

        private void cls_cKey_Value_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(AdvanceObj.cls_ckey[obj_des.CurrentRoundBlock - 1], cls_cKey_Value);
        }

        private void cls_dKey_Value_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(AdvanceObj.cls_dkey[obj_des.CurrentRoundBlock - 1], cls_dKey_Value);
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("28-bits", pictureBox8);
        }

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("28-bits", pictureBox9);
        }

        private void ExpPer_Value_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(AdvanceObj.expandedRptValues[obj_des.CurrentRoundBlock - 1], ExpPer_Value);
        }

        private void CompPer_Value_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(AdvanceObj.compressedKeyValues[obj_des.CurrentRoundBlock - 1], CompPer_Value);
        }

        private void ExpXorComp_Value_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(AdvanceObj.expandedXORcompressedValues[obj_des.CurrentRoundBlock - 1], ExpXorComp_Value);
        }

        private void SBox_Value_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(AdvanceObj.sBoxSubstitutionRounds[obj_des.CurrentRoundBlock - 1], SBox_Value);
        }



        private void btn12_Click(object sender, EventArgs e)
        {
            DisplayPicture uc = new DisplayPicture();


            uc.Pic.BackgroundImage = Image.FromFile(MainForm.Instance.path + "/images/expansion.jpg");
            uc.Dock = DockStyle.Fill;
            MainForm.Instance.panelContain.Controls.Add(uc);
            MainForm.Instance.panelContain.Controls["DisplayPicture"].BringToFront();
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            DisplayPicture uc = new DisplayPicture();
            uc.Pic.BackgroundImage = Image.FromFile(MainForm.Instance.path + "/images/sbox.png");
            uc.Dock = DockStyle.Fill;
            MainForm.Instance.panelContain.Controls.Add(uc);
            MainForm.Instance.panelContain.Controls["DisplayPicture"].BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DisplayPicture uc = new DisplayPicture();
            uc.Pic.BackgroundImage = Image.FromFile(MainForm.Instance.path + "/images/sbox.png");
            uc.Dock = DockStyle.Fill;
            MainForm.Instance.panelContain.Controls.Add(uc);
            MainForm.Instance.panelContain.Controls["DisplayPicture"].BringToFront();
        }
    }
}
