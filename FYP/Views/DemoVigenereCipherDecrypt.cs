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
    public partial class DemoVigenereCipherDecrypt : UserControl
    {
        public DemoVigenereCipherDecrypt()
        {
            InitializeComponent();
        }

        private void DemoVigenereCipherDecrypt_Load(object sender, EventArgs e)
        {

        }

        public int len = 0;
        public string plaintext { get; set; }
        public string ciphertext { get; set; }
        public string key { get; set; }
        DataTable dt = new DataTable();
        DemoVigenereCipher caesar;
        Classical obj = new Classical();
        char[] characterKey;


        public DemoVigenereCipherDecrypt(DemoVigenereCipher obj)
        {
            InitializeComponent();
            this.caesar = obj;


            Control[] syncedCtrls = new Control[] { PlaintextBox, CiphertextBox, arrow1Box, PlainvalueBox, PlusBox, KeyBox, modeTextBox, EqualBox, CiphervalueBox, arrow2Box, CiphertextBox };
            foreach (SyncRichTextBox ctr in syncedCtrls)
            {
                ctr.Buddies = syncedCtrls;
            }
        }

        public void LoadText()
        {

            plaintext = caesar.plaintext;
            key = caesar.key;
            characterKey = key.ToCharArray();
            ciphertext = caesar.ciphertext;

            Load_Table_1();
            Load_Table_2();
        }

        private void ClearText()
        {
            PlaintextBox.Clear();
            PlainvalueBox.Clear();
            arrow1Box.Clear();
            KeyBox.Clear();
            arrow2Box.Clear();
            modeTextBox.Clear();
            EqualBox.Clear();
            PlusBox.Clear();
            CiphertextBox.Clear();
            CiphervalueBox.Clear();


        }
        private async void Decrypt(char[] cipher_Text, char[] Key)
        {
            int j = 0;
            for (int i = 0; i < cipher_Text.Length; i++)
            {
                if (j >= Key.Length)
                {
                    j = 0;
                }

                PlaintextBox.Text += String.Concat(cipher_Text[i].ToString(), "\n"); //plain_text[i]-97 , " * " , key," = ", plain_text[i]+key);
                await Task.Delay(200);

                arrow1Box.Text += "->\n";
                await Task.Delay(200);

                cipher_Text[i] = (char)(cipher_Text[i] - 65);
                PlainvalueBox.Text += String.Concat(((int)cipher_Text[i]).ToString(), "\n");

                await Task.Delay(200);

                PlusBox.Text += "-\n";
                await Task.Delay(200);



                KeyBox.Text += String.Concat((char)Key[j], "(", ((int)Key[j] - 97), ")", "\n");
                await Task.Delay(200);

                modeTextBox.Text += String.Concat("%   ", "26", "\n");
                await Task.Delay(200);

                EqualBox.Text += "=\n";
                await Task.Delay(200);

                int x = (int)Key[j];
                if ((cipher_Text[i] - Key[j]) < 0)
                {
                    cipher_Text[i] = (char)(cipher_Text[i] - (Key[j] - 97) + 26);
                }
                else
                {
                    cipher_Text[i] = (char)(cipher_Text[i] - (Key[j] - 97));
                }

                cipher_Text[i] = (char)((cipher_Text[i] % 26));
                CiphervalueBox.Text += String.Concat(((int)cipher_Text[i]).ToString(), "\n");
                await Task.Delay(200);



                cipher_Text[i] = (char)(cipher_Text[i] + 97);

                j++;

                arrow2Box.Text += "->\n";
                await Task.Delay(200);


                // plain_text[i] = (char)(plain_text[i] - 32);


                CiphertextBox.Text += String.Concat(cipher_Text[i].ToString(), "\n");
                await Task.Delay(200);

                //  char temp = ' ';
                //   temp = (char)((((plain_text[i] - 97) + key) % 26) + 97);

                //   PlaintextBox.Text += "  ->  " + plain_text[i];




            }

        }

        private void Load_Table_1()
        {

            dt = new DataTable();
            dt.Columns.Add("a");
            dt.Columns.Add("b");
            dt.Columns.Add("c");
            dt.Columns.Add("d");
            dt.Columns.Add("e");
            dt.Columns.Add("f");
            dt.Columns.Add("g");
            dt.Columns.Add("h");
            dt.Columns.Add("i");
            dt.Columns.Add("j");
            dt.Columns.Add("k");
            dt.Columns.Add("l");
            dt.Columns.Add("m");
            dt.Columns.Add("n");
            dt.Columns.Add("o");
            dt.Columns.Add("p");
            dt.Columns.Add("q");
            dt.Columns.Add("r");
            dt.Columns.Add("s");
            dt.Columns.Add("t");
            dt.Columns.Add("u");
            dt.Columns.Add("v");
            dt.Columns.Add("w");
            dt.Columns.Add("x");
            dt.Columns.Add("y");
            dt.Columns.Add("z");


            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            dt.Rows.Add("0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25");
            dataGridView1.DataSource = dt;
        }

        private void Load_Table_2()
        {


            dt.Rows.Add();
            dt.Rows.Add();

            char temp;

            int j = 0;

            for (int i = 0; i <= 25; i++)
            {
                if (j >= characterKey.Length)
                {
                    j = 0;
                }

                temp = (char)(((i + ((int)characterKey[j] - 97)) % 26));
                dt.Rows[2][i] = (int)temp;
                temp = (char)(temp + 65);
                dt.Rows[1][i] = temp.ToString();

                j++;

            }


            dataGridView1.DataSource = dt;

            //dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.Red;
            dataGridView1.Rows[1].DefaultCellStyle.BackColor = Color.Green;
            dataGridView1.Rows[1].DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.Rows[0].Selected = false;
            dataGridView1.Rows[1].Selected = false;





        }


        private void btnStart_Click(object sender, EventArgs e)
        {
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
           
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {

            VigenereCipher uc_vigenere = new VigenereCipher();
            MainForm.Instance.LoadView(uc_vigenere);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            ClearText();
            LoadText();
            Decrypt(ciphertext.ToCharArray(), characterKey);
        }

        private void btnBackToMain_Click_1(object sender, EventArgs e)
        {
            SymmetricCategory uc_Vigenere = new SymmetricCategory();
            MainForm.Instance.LoadView(uc_Vigenere);

        }
    }
}

