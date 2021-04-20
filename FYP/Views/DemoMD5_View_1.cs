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
    public partial class DemoMD5_View_1 : UserControl
    {

        private string message;
        public string Message { get => message; set => message = value; }
        public string Hashvalue { get => hashvalue; set => hashvalue = value; }
        public int CurrentBlock { get => currentBlock; set => currentBlock = value; }
        internal NonKeyBased Obj { get => obj; set => obj = value; }

        private byte[] msgByte;
        private ulong sizeMsg;  // Represents the Size of the Bits in the Input Message/String.
        private uint pad;                                    //Represents the Number of Padding bits.
        private uint sizeMsgTotal;                          // Represents the Total Message Length bits .
        private byte[] totalBytes;
        private int totalBlocks = 0;
        private int seconds = 0;
        private string[] str;
        private int[] count;

        private string hashvalue;
        private int currentBlock;
        private Model.NonKeyBased obj;

        private Control[] imageControl;

        public DemoMD5_View_1()
        {
            InitializeComponent();
            Obj = new NonKeyBased();

            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";



        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoadValues()
        {
            seconds = 0;
            /// Getting the Message String in a Array of Bytes
            msgByte = new Byte[Message.Length];
            for (int i = 0; i < Message.Length; i++)
                msgByte[i] = (byte)Message[i];


            sizeMsg = (ulong)(msgByte.Length * 8);  // Represents the Size of the Bits in the Input Message/String.

            // Finding the Padding Bits
            pad = (uint)(512 - (sizeMsg + 64));
            pad = (pad + 512) % 512;
            if (pad == 0)
            {
                pad = 512;
            }

            sizeMsgTotal = (uint)((sizeMsg / 8) + (pad / 8) + 8);
            totalBytes = new Byte[sizeMsgTotal];

            for (int i = 0; i < msgByte.Length; i++)
                totalBytes[i] = (byte)msgByte[i];

            totalBytes[msgByte.Length] |= 0x80;      // It will Pad '1' bit


            for (int i = 8; i > 0; i--)
                totalBytes[sizeMsgTotal - i] = (byte)(sizeMsg >> ((8 - i) * 8) & 0x00000000000000ff);

            totalBlocks = (int)Math.Round((decimal)(totalBytes.Length * 8 / 512));


            label2.Text = "N = " + (msgByte.Length * 8);
            // await Task.Delay(700);

            label3.Text = "P = " + pad;
            //await Task.Delay(700);


            label4.Text = "L = 64";
            //await Task.Delay(700);


            label5.Text = "k = Multiple of 512 - 64 = " + ((msgByte.Length * 8 + pad));
            //await Task.Delay(700);


            label6.Text = "L = (m * 512) - k = " + ((512 * totalBlocks) - (msgByte.Length * 8 + pad));

            label1.Text = "Total Message Length = " + (sizeMsgTotal) * 8 + "-bits";
            ///await Task.Delay(700);


            label7.Text = "Total Blocks of 512-bits size  = " + totalBlocks;
            //await Task.Delay(700);


            str = new string[8];
            count = new int[] { 0, 0, 0, 0, 0, 0, 0, 0 };


            LoadLabelText();



            //timer1.Start();/////////////////////////////////////////////

        }
        private void LoadLabelText()
        {


            str[0] = label1.Text;
            label1.Text = "";
            str[1] = label2.Text;
            label2.Text = "";
            str[2] = label3.Text;
            label3.Text = "";
            str[3] = label4.Text;
            label4.Text = "";
            str[4] = label5.Text;
            label5.Text = "";
            str[5] = label6.Text;
            label6.Text = "";
            str[6] = label7.Text;
            label7.Text = "";


            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;

            if (seconds >= 10 && count[1] < str[1].Length)
            {
                count[1]++;
                label2.Text = str[1].Substring(0, count[1]);
            }
            if (seconds >= 30 && count[2] < str[2].Length)
            {
                count[2]++;
                label3.Text = str[2].Substring(0, count[2]);
            }
            if (seconds >= 45 && count[3] < str[3].Length)
            {
                count[3]++;
                label4.Text = str[3].Substring(0, count[3]);
            }
            if (seconds >= 60 && count[4] < str[4].Length)
            {
                count[4]++;
                label5.Text = str[4].Substring(0, count[4]);
            }
            if (seconds >= 90 && count[5] < str[5].Length)
            {
                count[5]++;
                label6.Text = str[5].Substring(0, count[5]);
            }

            if (seconds >= 120 && count[0] < str[0].Length)
            {
                count[0]++;
                label1.Text = str[0].Substring(0, count[0]);
            }
            if (seconds >= 165 && count[6] < str[6].Length)
            {
                count[6]++;
                label7.Text = str[6].Substring(0, count[6]);
            }
            if (seconds >= 200)
            {
                
                imageControl = new Control[totalBlocks];
                LoadBlocks(totalBlocks);
                btnPause.Visible = false;
                btnStart.Visible = true;
                seconds = 0;
                btnStart.Text = "Start";
                timer1.Stop();
                timer1.Dispose();

            }



            /*
            seconds++;

            if (seconds >= 20)
            {
                
                if (count < str.Length)
                {
                    count++;
                    label2.Text = str.Substring(0,count);
                }
            }
            
         */


        }



        private async void LoadBlocks(int blocks)
        {
            FlowPanelHashBlocks.Controls.Clear();
            FlowPanelMsgBlocks.Controls.Clear();



            String[] blockNames = new String[blocks];

            for (int i = 0; i < blocks; i++)
            {
                PictureBox a = new PictureBox();
                a.Name = "Block" + i;
                a.BackgroundImage = Image.FromFile(MainForm.Instance.path + "/images/Hashing/block512.png");
                a.BackgroundImageLayout = ImageLayout.Stretch;

                //a.BackColor = Color.Brown;
                await Task.Delay(400);

                FlowPanelMsgBlocks.Controls.Add(a);

            }

            for (int i = 0; i < blocks; i++)
            {
                PictureBox a = new PictureBox();
                a.Name = "Arrow" + i;
                a.BackgroundImage = Image.FromFile(MainForm.Instance.path + "/images/Hashing/down-arrow.png");
                a.BackgroundImageLayout = ImageLayout.Zoom;

                //a.BackColor = Color.Brown;
                await Task.Delay(400);

                FlowPanelArrows.Controls.Add(a);

            }
            for (int i = 0; i < blocks; i++)
            {
                PictureBox a = new PictureBox();
                a.Name = "Hash" + i;
                a.BackgroundImage = Image.FromFile(MainForm.Instance.path + "/images/Hashing/HMD5.png");
                a.BackgroundImageLayout = ImageLayout.Stretch;

                a.BackColor = Color.Black;
                a.Click += new EventHandler(a_Click);
                a.MouseHover += new EventHandler(a_Hover);

                await Task.Delay(400);


                FlowPanelHashBlocks.Controls.Add(a);
                imageControl[i] = a;


            }
            await Task.Delay(400);

            FlowPanelMsgBlocks.VerticalScroll.Visible = false;
            FlowPanelHashBlocks.VerticalScroll.Visible = false;

            Obj.setPlaintext(message);
            hashvalue = Obj.MD5();
            lbl_digest.Text = hashvalue;

        }

        private void a_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;

            for (int i = 0; i < imageControl.Length; i++)
            {
                if (image.Name.ToString() == imageControl[i].Name.ToString())
                {
                    CurrentBlock = i + 1;
                }

            }


            // MessageBox.Show("Alhamdulillah ! You have clicked block number-" + CurrentBlock);

            DemoMD5_View_2 uc_demo_md5 = new DemoMD5_View_2(this);
            uc_demo_md5.Dock = DockStyle.Fill;


            MainForm.Instance.panelContain.Controls.Add(uc_demo_md5);
            MainForm.Instance.panelContain.Controls["DemoMD5_View_2"].BringToFront();

        }

        private void a_Hover(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;

            for (int i = 0; i < imageControl.Length; i++)
            {
                if (image.Name.ToString() == imageControl[i].Name.ToString())
                {
                    toolTip1.Show("Block # " + (i + 1), image);
                }

            }

        }
        private void btnBack_Click(object sender, EventArgs e)
        {

            MainForm.Instance.panelContain.Controls["DemoMD5_View_1"].Dispose();
            MainForm.Instance.panelContain.Controls["MD5_View"].BringToFront();

        }
        private void ClearValues()
        {

            FlowPanelMsgBlocks.Controls.Clear();
            FlowPanelHashBlocks.Controls.Clear();
            FlowPanelArrows.Controls.Clear();
            lbl_digest.Text = "";

            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";




        }

        private void btnStart_Click(object sender, EventArgs e)
        {

          //  timer1.Interval = 100;
         //   fastforward.Visible = true;
            btnStart.Visible = false;
            btnStart.Text = "  Resume";
            btnPause.Visible = true;
            if (seconds != 0)
            {
                timer1.Start();
            }
            else
            {
                ClearValues();
                LoadValues();
            }
        }
        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnPause.Visible = false;
            btnStart.Visible = true;
        }
        private void fastforward_Click(object sender, EventArgs e)
        {
            timer1.Interval = 10;
            fastforward.Visible = false;
            btnPause.Visible = true;

            btnStart.Visible = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            DemoMD5_View_2 uc_demo_md5 = new DemoMD5_View_2(this);
            uc_demo_md5.Dock = DockStyle.Fill;


            MainForm.Instance.panelContain.Controls.Add(uc_demo_md5);
            MainForm.Instance.panelContain.Controls["DemoMD5_View_2"].BringToFront();
        }



        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void DemoMD5_View_1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void FlowPanelHashBlocks_Paint(object sender, PaintEventArgs e)
        {
        }

        private void FlowPanelMsgBlocks_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void lb_A_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void btnBack2_Click(object sender, EventArgs e)
        {


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FlowPanelArrows_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FlowPanelHashBlocks_Click(object sender, EventArgs e)
        {
            btnNext_Click(sender, e);

        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {

        }

        private void btnMsg_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            

        }

        private void btnMsg_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Font = new Font("Segoe UI", 12, FontStyle.Bold);
        }
    }
}
