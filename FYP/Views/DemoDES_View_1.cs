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
    public partial class DemoDES_View_1 : UserControl
    {
        private PictureBox[] PTimageControl;
        private PictureBox[] DESimageControl;
        private PictureBox[] CTimageControl;


        private int currentDesblock;
        private Advance advanceObj;
        private int currentBlock;

        public int currentDESblock { get => currentDesblock; set => currentDesblock = value; }
        internal Advance AdvanceObj { get => advanceObj; set => advanceObj = value; }
        public int CurrentBlock { get => currentBlock; set => currentBlock = value; }

        public DemoDES_View_1()
        {
            InitializeComponent();

        }

        public DemoDES_View_1(DES_View obj)
        {
            InitializeComponent();
            AdvanceObj = obj.AdvanceObj;
            int[] temp = new int[AdvanceObj.plaintextbin.Length];
            int st = AdvanceObj.ConvertTextToBits(AdvanceObj.getPlaintext().ToCharArray(), temp);
            int fst = AdvanceObj.AppendZeroes(temp, st);
            CurrentBlock = 0;
            totalBlocks.Text += "" + fst / 64;
            PTimageControl = new PictureBox[fst / 64];
            DESimageControl = new PictureBox[fst / 64];
            CTimageControl = new PictureBox[fst / 64];


        }
        public DemoDES_View_1(TripleDesView obj)
        {
            InitializeComponent();
            AdvanceObj = obj.AdvanceObj;
            int[] temp = new int[AdvanceObj.plaintextbin.Length];
            int st = AdvanceObj.ConvertTextToBits(AdvanceObj.getPlaintext().ToCharArray(), temp);
            int fst = AdvanceObj.AppendZeroes(temp, st);
            CurrentBlock = 0;
            totalBlocks.Text += "" + fst / 64;
            PTimageControl = new PictureBox[fst / 64];
            DESimageControl = new PictureBox[fst / 64];
            CTimageControl = new PictureBox[fst / 64];


        }
        private void DemoDES_View_1_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }
        private async void LoadBlocks(int blocks)
        {



            FlowPanelPlainTextBlocks.Controls.Clear();
            FlowPanelDESBlocks.Controls.Clear();
            FlowPanelCipherTextBlocks.Controls.Clear();

            btnPlaintext.Visible = true;
            downarrow1.Visible = true;

            String[] blockNames = new String[blocks];

            for (int i = 0; i < blocks; i++)
            {
                //////////////////////////////////// PlainText Blocks
                PictureBox a = new PictureBox();
                a.Name = "PT" + i;
                a.BackgroundImage = Image.FromFile(MainForm.Instance.path + "/images/bits_64.png");
                a.BackgroundImageLayout = ImageLayout.Zoom;

                PTimageControl[i] = a;

                await Task.Delay(400);

                FlowPanelPlainTextBlocks.Controls.Add(a);
                a.MouseHover += new EventHandler(PT_Hover);
                /////////////////////////////////////////  Down Arrows -1

                a = new PictureBox();
                a.Name = "Arrow" + i;
                a.BackgroundImage = Image.FromFile(MainForm.Instance.path + "/images/Hashing/down-arrow.png");
                a.BackgroundImageLayout = ImageLayout.Zoom;

                //a.BackColor = Color.Brown;
                await Task.Delay(400);

                FlowLayoutPanelArrows1.Controls.Add(a);


                /////////////////////////////////////////// DES Blocks

                PictureBox d = new PictureBox();
                d.Name = "DES" + i;
                d.BackgroundImage = Image.FromFile(MainForm.Instance.path + "/images/DES_Block.png");
                d.BackgroundImageLayout = ImageLayout.Stretch;

                d.BackColor = Color.Black;


                await Task.Delay(400);
                DESimageControl[i] = d;
                FlowPanelDESBlocks.Controls.Add(d);

                d.Click += new EventHandler(a_Click);
                d.MouseHover += new EventHandler(DES_Hover);

                ///////////////////////////////////////////// Down Arrows -2

                a = new PictureBox();
                a.Name = "Arrow" + i;
                a.BackgroundImage = Image.FromFile(MainForm.Instance.path + "/images/Hashing/down-arrow.png");
                a.BackgroundImageLayout = ImageLayout.Zoom;

                //a.BackColor = Color.Brown;
                await Task.Delay(400);

                FlowLayoutPanelArrows2.Controls.Add(a);

                //////////////////////////////////////////// CipherText Blocks
                ///
                a = new PictureBox();
                a.Name = "CT" + i;
                a.BackgroundImage = Image.FromFile(MainForm.Instance.path + "/images/bits_64.png");
                a.BackgroundImageLayout = ImageLayout.Zoom;


                CTimageControl[i] = a;

                await Task.Delay(400);

                FlowPanelCipherTextBlocks.Controls.Add(a);

                a.MouseHover += new EventHandler(CT_Hover);
            }




            await Task.Delay(400);

            FlowPanelPlainTextBlocks.VerticalScroll.Visible = false;
            FlowPanelDESBlocks.VerticalScroll.Visible = false;
            FlowPanelCipherTextBlocks.VerticalScroll.Visible = false;

            downarrow2.Visible = true;
            btnCiphertext.Visible = true;

        }

        private void DES_Hover(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;

            for (int i = 0; i < DESimageControl.Length; i++)
            {
                if (image.Name.ToString() == DESimageControl[i].Name.ToString())
                {
                    toolTip1.Show("DES Block # " + (i + 1), image);
                }


            }
        }
        private void PT_Hover(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            string str = "";

            for (int i = 0; i < PTimageControl.Length; i++)
            {
                if (image.Name == PTimageControl[i].Name)
                {

                    currentDESblock = i + 1;

                }
            }


            str = AdvanceObj.plaintextBlocks[currentDESblock - 1];

            toolTip1.Show(str, image);

        }

        private void CT_Hover(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            string str = "";

            for (int i = 0; i < CTimageControl.Length; i++)
            {
                if (image.Name == CTimageControl[i].Name)
                {

                    currentDESblock = i + 1;

                }
            }


            str = AdvanceObj.ciphertextBlocks[currentDESblock - 1];

            toolTip1.Show(str, image);

        }

        private void a_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;

            for (int i = 0; i < DESimageControl.Length; i++)
            {
                if (image.Name.ToString() == DESimageControl[i].Name.ToString())
                {
                    currentDESblock = i + 1;
                }

            }


            // MessageBox.Show("Alhamdulillah ! You have clicked block number-" + CurrentBlock);

            DemoDES_View_2 uc_demo_des = new DemoDES_View_2(this);
            uc_demo_des.Dock = DockStyle.Fill;


            MainForm.Instance.panelContain.Controls.Add(uc_demo_des);
            MainForm.Instance.panelContain.Controls["DemoDES_View_2"].BringToFront();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadBlocks(DESimageControl.Length);
            timer1.Stop();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (AdvanceObj.getCategoryName() == "TripleDES")
            {
               MainForm.Instance.panelContain.Controls["DemoDES_View_1"].Dispose();

                MainForm.Instance.panelContain.Controls["TripleDESView"].BringToFront();
            }
            else
            {
                MainForm.Instance.panelContain.Controls["DemoDES_View_1"].Dispose();

                MainForm.Instance.panelContain.Controls["DES_View"].BringToFront();
            }

        }

        private void downarrow1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(AdvanceObj.getPlaintext(),downarrow1);
        }

        private void downarrow2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(AdvanceObj.getCiphertext(), downarrow2);

        }
    }
}
