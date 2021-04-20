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
    public partial class preRound_information : UserControl
    {
        public string[,] plain_matrix;
        public string[,] key_matrix;
        public string[,] x;

        private AES aes;

        public AES Aes { get => aes; set => aes = value; }

        public preRound_information()
        {
            InitializeComponent();
        }
        public preRound_information(AES_VISUALIZATION_1 obj)
        {
            InitializeComponent();

            Aes = obj.Aes;
            x = Aes.CalculatePreRound(Aes.message,Aes.key);
            plain_matrix = Aes.plaintextStateArray;
            key_matrix = Aes.keyStateArray;


            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    plainMatrix.Text += String.Concat(plain_matrix[i, j].ToString(), " ");
                }
                plainMatrix.Text += String.Concat("\n");
            }
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    keyMatrix.Text += String.Concat(key_matrix[i, j].ToString(), " ");
                }
                keyMatrix.Text += String.Concat("\n");
            }
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    XOR.Text += String.Concat(x[i, j].ToString(), " ");
                }
                XOR.Text += String.Concat("\n");
            }
        }

        private void preRound_information_Load(object sender, EventArgs e)
        {
        
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            MainForm.Instance.panelContain.Controls["AES_VISUALIZATION_1"].BringToFront();
            MainForm.Instance.panelContain.Controls["preRound_information"].SendToBack();
            MainForm.Instance.panelContain.Controls["preRound_information"].Dispose();


        }
    }
}
