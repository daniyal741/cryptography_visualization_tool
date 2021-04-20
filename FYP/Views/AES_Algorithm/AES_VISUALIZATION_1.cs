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
    public partial class AES_VISUALIZATION_1 : UserControl
    {
        int seconds = 0;
        AES_Viualization dum_object;
        public string input_Text;
        public string[,] plain_matrix;
        public string[,] key_matrix;
        public string[,] x;
        public string[,] s_boxMatrix;
        public string[,] shift_rows;
        private int currentRound;
        private AES aes;

        public AES Aes { get => aes; set => aes = value; }
        public int CurrentRound { get => currentRound; set => currentRound = value; }

        public AES_VISUALIZATION_1()
        {
            InitializeComponent();

        }
        public AES_VISUALIZATION_1(AES_Viualization obj)
        {
            InitializeComponent();
            input_Text = obj.input_Plaintext;
            Aes = obj.Aes;
            CurrentRound = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            MainForm.Instance.panelContain.Controls["AES_Viualization"].BringToFront();
            MainForm.Instance.panelContain.Controls["AES_VISUALIZATION_1"].Dispose();


        }

        private void AES_VISUALIZATION_1_Load(object sender, EventArgs e)
        {
            btnplian.Visible = false;
            arrow1.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;

            btn_preRound.Visible = false;
            btnRound1.Visible = false;
            btnRound2.Visible = false;
            btnRound3.Visible = false;
            btnRound4.Visible = false;
            btnRound5.Visible = false;
            btnRound6.Visible = false;
            btnRound7.Visible = false;
            btnRound8.Visible = false;
            btnRound9.Visible = false;
            btnRound10.Visible = false;

            arrow2.Visible = false;
            cipher.Visible = false;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            seconds++;
            if(seconds >= 15)
            {
                btnplian.Visible = true;
            }
            if(seconds>=30)
            {
                arrow1.Visible = true;
            }
            if(seconds>=45)
            {
                panel1.Visible = true;
            }
            if(seconds>=55)
            {
                panel2.Visible = true;
            }
            if(seconds>=65)
            {
                panel3.Visible = true;
            }
            if(seconds>=75)
            {
                panel4.Visible = true;
            }
            if(seconds>=85)
            {
                btn_preRound.Visible = true;
            }
            if(seconds >= 90)
            {
                btnRound1.Visible = true;
            }
            if(seconds>=95)
            {
                btnRound2.Visible = true;
            }
            if(seconds>=100)
            {
                btnRound3.Visible = true;
            }
            if(seconds>=105)
            {
                btnRound4.Visible = true;
            }
            if(seconds>=110)
            {
                btnRound5.Visible = true;
            }
            if(seconds>=115)
            {
                btnRound6.Visible = true;
            }
            if(seconds>=120)
            {
                btnRound7.Visible = true;
            }
            if(seconds>=125)
            {
                btnRound8.Visible = true;
            }
            if(seconds>=130)
            {
                btnRound9.Visible = true;
            }
            if(seconds>=135)
            {
                btnRound10.Visible = true;
            }
            if(seconds>=150)
            {
                arrow2.Visible = true;
            }
            if(seconds>=160)
            {
                cipher.Visible = true;
                timer1.Stop();
                timer1.Dispose();
            }
        }

        private void btnplian_Click(object sender, EventArgs e)
        {
            plian_tex_Informaion aES_Algorithm = new plian_tex_Informaion(this);
            aES_Algorithm.Dock = DockStyle.Fill;
            MainForm.Instance.panelContain.Controls.Add(aES_Algorithm);
            MainForm.Instance.panelContain.Controls["plian_tex_Informaion"].BringToFront();
        }

        private void btn_preRound_Click(object sender, EventArgs e)
        {
            preRound_information aES_Algorithm = new preRound_information(this);
            aES_Algorithm.Dock = DockStyle.Fill;
            MainForm.Instance.panelContain.Controls.Add(aES_Algorithm);
            MainForm.Instance.panelContain.Controls["preRound_information"].BringToFront();


        }

        private void btnRound1_Click(object sender, EventArgs e)
        {
          
            Round_1 aES_Algorithm = new Round_1(this);
            aES_Algorithm.Dock = DockStyle.Fill;
            MainForm.Instance.panelContain.Controls.Add(aES_Algorithm);
            MainForm.Instance.panelContain.Controls["Round_1"].BringToFront();

        }
        public void Round_Click(object sender, EventArgs e)
        {
            CurrentRound = 0;
           

            Button btn = (Button)sender;
            if (btn.Name == "btnRound1")
            {
                CurrentRound = 1;
            }
            if (btn.Name == "btnRound2")
            {
                CurrentRound = 2;
            }
            if (btn.Name == "btnRound3")
            {
                CurrentRound = 3;
            }
            if (btn.Name == "btnRound4")
            {
                CurrentRound = 4;
            }
            if (btn.Name == "btnRound5")
            {
                CurrentRound = 5;
            }
            if (btn.Name == "btnRound6")
            {
                CurrentRound = 6;
            }
            if (btn.Name == "btnRound7")
            {
                CurrentRound = 7;
            }
            if (btn.Name == "btnRound8")
            {
                CurrentRound = 8;
            }
            if (btn.Name == "btnRound9")
            {
                CurrentRound = 9;
            }
            if (btn.Name == "btnRound10")
            {
                CurrentRound = 10;
            }

            btnRound1_Click(sender,e);

        }
    }
}
