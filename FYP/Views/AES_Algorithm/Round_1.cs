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
    public partial class Round_1 : UserControl
    {
        public string[,] shiftrow;
        public string[,] s_box;
        public string[,] mix_Column;
        public string[,] final_Matrix;

        private int currentRound;
        private AES aes;

        public AES Aes { get => aes; set => aes = value; }
        public int CurrentRound { get => currentRound; set => currentRound = value; }

        public Round_1()
        {
            InitializeComponent();
        }
        public Round_1(AES_VISUALIZATION_1 obj)
        {
            InitializeComponent();
            CurrentRound = obj.CurrentRound;
            title.Text = "Round #" + CurrentRound;
            Aes = obj.Aes;
            if (CurrentRound == 1)
            {
                string[,] str = new string[4, 4];

                Aes.finalMatrix =  Aes.CalculatePreRound(Aes.message,Aes.key);
                for (int i = 0; i <= 3; i++)
                {
                    for (int j = 0; j <= 3; j++)
                    {
                        str[i, j] = Aes.finalMatrix[i, j];
                    }
                }
                Aes.finalMatrix =  Aes.CalculateRoundValues(str,Aes.keyStateArray);

            }
            if (CurrentRound == 2)
            {
                string[,] str = new string[4, 4];

                Aes.finalMatrix = Aes.CalculatePreRound(Aes.message, Aes.key);
                for (int i = 0; i <= 3; i++)
                {
                    for (int j = 0; j <= 3; j++)
                    {
                        str[i, j] = Aes.finalMatrix[i, j];
                    }
                }
                for (int i = 0; i < 2; i++)
                {
                    Aes.finalMatrix = Aes.CalculateRoundValues(str, Aes.keyStateArray);
                    for (int j = 0; j <= 3; j++)
                    {
                        for (int k = 0; k <= 3; k++)
                        {
                            str[j, k] = Aes.finalMatrix[j, k];
                        }
                    }
                }

            }
            if (CurrentRound == 3)
            {
                string[,] str = new string[4,4];
                
                final_Matrix = Aes.CalculatePreRound(Aes.message, Aes.key);
                for (int i = 0; i <= 3; i++)
                {
                    for (int j = 0; j <= 3; j++)
                    {
                        str[i, j] = final_Matrix[i, j];
                    }
                }
                for (int i = 0; i < 3; i++)
                {
                    final_Matrix = Aes.CalculateRoundValues(str, Aes.keyStateArray);
                    for (int j = 0; j <= 3; j++)
                    {
                        for (int k = 0; k <= 3; k++)
                        {
                            str[j, k] = final_Matrix[j, k];
                        }
                    }
                }
            }
            if (CurrentRound == 4)
            {
                string[,] str = new string[4, 4];

                final_Matrix = Aes.CalculatePreRound(Aes.message, Aes.key);
                for (int i = 0; i <= 3; i++)
                {
                    for (int j = 0; j <= 3; j++)
                    {
                        str[i, j] = final_Matrix[i, j];
                    }
                }

                for (int i = 0; i < 4; i++)
                {
                    final_Matrix = Aes.CalculateRoundValues(str, Aes.keyStateArray);
                    for (int j = 0; j <= 3; j++)
                    {
                        for (int k = 0; k <= 3; k++)
                        {
                            str[j, k] = final_Matrix[j, k];
                        }
                    }
                }

                for (int i = 0; i <= 3; i++)
                {
                    for (int j = 0; j <= 3; j++)
                    {
                        str[i, j] = final_Matrix[i, j];
                    }
                }
            }
            if (CurrentRound == 5)
            {
                string[,] str = new string[4, 4];

                final_Matrix = Aes.CalculatePreRound(Aes.message, Aes.key);
                for (int i = 0; i <= 3; i++)
                {
                    for (int j = 0; j <= 3; j++)
                    {
                        str[i, j] = final_Matrix[i, j];
                    }
                }
                for (int i = 0; i < 5; i++)
                {
                    final_Matrix = Aes.CalculateRoundValues(str, Aes.keyStateArray);
                    for (int j = 0; j <= 3; j++)
                    {
                        for (int k = 0; k <= 3; k++)
                        {
                            str[j, k] = final_Matrix[j, k];
                        }
                    }
                }
            }

            if (CurrentRound == 6)
            {
                string[,] str = new string[4, 4];

                final_Matrix = Aes.CalculatePreRound(Aes.message, Aes.key);
                for (int i = 0; i <= 3; i++)
                {
                    for (int j = 0; j <= 3; j++)
                    {
                        str[i, j] = final_Matrix[i, j];
                    }
                }
                for (int i = 0; i < 6; i++)
                {
                    final_Matrix = Aes.CalculateRoundValues(str, Aes.keyStateArray);
                    for (int j = 0; j <= 3; j++)
                    {
                        for (int k = 0; k <= 3; k++)
                        {
                            str[j, k] = final_Matrix[j, k];
                        }
                    }
                }
            }
            if (CurrentRound == 7)
            {
                string[,] str = new string[4, 4];

                final_Matrix = Aes.CalculatePreRound(Aes.message, Aes.key);
                for (int i = 0; i <= 3; i++)
                {
                    for (int j = 0; j <= 3; j++)
                    {
                        str[i, j] = final_Matrix[i, j];
                    }
                }
                for (int i = 0; i < 4; i++)
                {
                    final_Matrix = Aes.CalculateRoundValues(str, Aes.keyStateArray);
                    for (int j = 0; j <= 3; j++)
                    {
                        for (int k = 0; k <= 3; k++)
                        {
                            str[j, k] = final_Matrix[j, k];
                        }
                    }
                }
            }
            if (CurrentRound == 8)
            {
                string[,] str = new string[4, 4];

                final_Matrix = Aes.CalculatePreRound(Aes.message, Aes.key);
                for (int i = 0; i <= 3; i++)
                {
                    for (int j = 0; j <= 3; j++)
                    {
                        str[i, j] = final_Matrix[i, j];
                    }
                }
                for (int i = 0; i < 8; i++)
                {
                    final_Matrix = Aes.CalculateRoundValues(str, Aes.keyStateArray);
                    for (int j = 0; j <= 3; j++)
                    {
                        for (int k = 0; k <= 3; k++)
                        {
                            str[j, k] = final_Matrix[j, k];
                        }
                    }
                }
            }
            if (CurrentRound == 9)
            {
                string[,] str = new string[4, 4];

                final_Matrix = Aes.CalculatePreRound(Aes.message, Aes.key);
                for (int i = 0; i <= 3; i++)
                {
                    for (int j = 0; j <= 3; j++)
                    {
                        str[i, j] = final_Matrix[i, j];
                    }
                }
                for (int i = 0; i < 9; i++)
                {
                    final_Matrix = Aes.CalculateRoundValues(str, Aes.keyStateArray);
                    for (int j = 0; j <= 3; j++)
                    {
                        for (int k = 0; k <= 3; k++)
                        {
                            str[j, k] = final_Matrix[j, k];
                        }
                    }
                }
            }
            if (CurrentRound == 10)
            {
                string[,] str = new string[4, 4];

                final_Matrix = Aes.CalculatePreRound(Aes.message, Aes.key);
                for (int i = 0; i <= 3; i++)
                {
                    for (int j = 0; j <= 3; j++)
                    {
                        str[i, j] = final_Matrix[i, j];
                    }
                }
                for (int i = 0; i < 9; i++)
                {
                    final_Matrix = Aes.CalculateRoundValues(str, Aes.keyStateArray);
                    for (int j = 0; j <= 3; j++)
                    {
                        for (int k = 0; k <= 3; k++)
                        {
                            str[j, k] = final_Matrix[j, k];
                        }
                    }
                }

                final_Matrix =  Aes.CalculateLastRound(str,Aes.keyStateArray);
            }
            s_box = Aes.subBytesMatrix;
            shiftrow = Aes.shiftRowsMatrix;
            mix_Column = Aes.mixcolumnMatrix;
            final_Matrix = Aes.finalMatrix;

            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    plainMatrix.Text += String.Concat(s_box[i, j].ToString(), " ");
                }
                plainMatrix.Text += String.Concat("\n");
            }
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    shiftrows.Text += String.Concat(shiftrow[i, j].ToString(), " ");
                }
                shiftrows.Text += String.Concat("\n");
            }
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    mixColumnText.Text += String.Concat(mix_Column[i, j].ToString(), " ");
                }
                mixColumnText.Text += String.Concat("\n");
            }
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    finalMatrixText.Text += String.Concat(final_Matrix[i, j].ToString(), " ");
                }
                finalMatrixText.Text += String.Concat("\n");
            }
            
        }

      

        private void btnBack_Click(object sender, EventArgs e)
        {
           
            MainForm.Instance.panelContain.Controls["AES_VISUALIZATION_1"].BringToFront();

            MainForm.Instance.panelContain.Controls["Round_1"].Dispose();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void enterNum_Click(object sender, EventArgs e)
        {

        }

        private void Round_1_Load(object sender, EventArgs e)
        {

        }
    }
}
