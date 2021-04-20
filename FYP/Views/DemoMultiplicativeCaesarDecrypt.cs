using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYP
{
    public partial class DemoMultiplicativeCaesarDecrypt : UserControl
    {
        public DemoMultiplicativeCaesarDecrypt()
        {
            InitializeComponent();
        }

        private void DemoMultiplicativeCaesarDecrypt_Load(object sender, EventArgs e)
        {

        }
        char[] cipher_Text,array1;
        int keyy, flag = 0, flag1 = 0, flag2 = 0, flag3 = 0, flag4 = 0, flag5 = 0, flag6 = 0, flag7 = 0, flag8 = 0, flag9 = 0, flag10 = 0;
        int k_inverse = 0,seconds=0,i=0;
        DemoMultiplicativeCeaserCipher caesar;
        DataTable dt = new DataTable();
        public String plaintext { get; set; }
        public String ciphertext { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            Stop.Visible = false;
            btnStart.Visible = false;
            Resume.Visible = true;
            timer1.Stop();
        }

        private void Resume_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            Stop.Visible = true;
            Resume.Visible = false;
            timer1.Start();
        }

        public int key { get; set; }

        public DemoMultiplicativeCaesarDecrypt(DemoMultiplicativeCeaserCipher obj)
        {
            InitializeComponent();
            caesar = obj;
            ClearText();

            Control[] syncedCtrls = new Control[] { PlaintextBox, CiphertextBox, arrow1Box, PlainvalueBox, PlusBox, KeyBox, EqualBox, CiphervalueBox, arrow2Box, CiphertextBox };
            foreach (SyncRichTextBox ctr in syncedCtrls)
            {
                ctr.Buddies = syncedCtrls;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;

            if (seconds >= 10 && flag == 0)
            {
                PlaintextBox.Text += String.Concat(cipher_Text[i].ToString(), "\n"); //plain_text[i]-65 , " * " , k_inverse," = ", plain_text[i]+key);
                flag = 1;
            }
            if (seconds >= 15 && flag1 == 0)
            {
                arrow1Box.Text += "->\n";
                flag1 = 1;
            }
            if (seconds >= 20 && flag2 == 0)
            {
                cipher_Text[i] = (char)(array1[i] - 65);
                PlainvalueBox.Text += String.Concat(((int)cipher_Text[i]).ToString(), "      *", "\n");
                flag2=1;

            }
            if (seconds >= 25 && flag3 == 0)
            {
                PlusBox.Text += String.Concat(k_inverse, "\n");
                flag3 = 1;
            }
            if (seconds >= 30 && flag4 == 0)
            {
                cipher_Text[i] = (char)(cipher_Text[i] * k_inverse);
                KeyBox.Text += String.Concat("%    ", "26", "\n");
                flag4 = 1;
            }

            if (seconds >= 35 && flag5 == 0)
            {
                EqualBox.Text += "=\n";
                flag5 = 1;
            }
            if (seconds >= 40 && flag6 == 0)
            {
                cipher_Text[i] = (char)(cipher_Text[i] % 26);
                CiphervalueBox.Text += String.Concat(((int)cipher_Text[i]).ToString(), "\n");
                flag6 = 1;

            }
            if (seconds >= 45 && flag7 == 0)
            {
                cipher_Text[i] = (char)(cipher_Text[i] + 97);

                arrow2Box.Text += "->\n";
                flag7 = 1;
            }


            if (seconds >= 50 && flag8 == 0)
            {
                CiphertextBox.Text += String.Concat(cipher_Text[i].ToString(), "\n");
                
                flag8 = 0;
                i++;
                seconds = 0;
                
                flag = 0;
                flag1 = 0;
                flag2 = 0;
                flag3 = 0;
                flag4 = 0;
                flag5 = 0;
                flag6 = 0;
                flag7 = 0;
                flag8 = 0;
            }

            if (i == ciphertext.Length)
            {
                timer1.Stop();
                Resume.Visible = false;
                Stop.Visible = false;
                btnStart.Visible = true;
            }



        }

        private void encrypt_value_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DemoMultiplicativeCeaserCipher uc_demoMultiplicativeCeaserCipher = new DemoMultiplicativeCeaserCipher();
            uc_demoMultiplicativeCeaserCipher.Dock = DockStyle.Fill;


            MainForm.Instance.panelContain.Controls.Add(uc_demoMultiplicativeCeaserCipher);
            MainForm.Instance.panelContain.Controls["DemoMultiplicativeCeaserCipher"].BringToFront();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            multiplicativeCeaserCipherView uc_multiplicativeCeaserCipherView = new multiplicativeCeaserCipherView();
            uc_multiplicativeCeaserCipherView.Dock = DockStyle.Fill;


            MainForm.Instance.panelContain.Controls.Add(uc_multiplicativeCeaserCipherView);
            MainForm.Instance.panelContain.Controls["multiplicativeCeaserCipherView"].BringToFront();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            LoadText();
            Stop.Visible = true;
            btnStart.Visible = false;
            Resume.Visible = false;

            cipher_Text = ciphertext.ToCharArray();
            array1 = ciphertext.ToCharArray();
            keyy = key;
            k_inverse=kinverse();
            timer1.Start();
            

            LoadText();
            
        }
        private void ClearText()
        {
            PlaintextBox.Clear();
            PlainvalueBox.Clear();
            arrow1Box.Clear();
            KeyBox.Clear();
            arrow2Box.Clear();
            EqualBox.Clear();
            PlusBox.Clear();
            CiphertextBox.Clear();
            CiphervalueBox.Clear();

        }

        public void LoadText()
        {


            this.plaintext = caesar.plaintext;
            this.key = caesar.key;
            this.ciphertext = caesar.ciphertext;

            encrypt_value.Text = "Your Encrypted value is ---->" + caesar.ciphertext;
            Load_Table_1();
            Load_Table_2();
        }

        private void Load_Table_1()
        {

            dt = new DataTable();

            dt.Columns.Add("A");
            dt.Columns.Add("B");
            dt.Columns.Add("C");
            dt.Columns.Add("D");
            dt.Columns.Add("E");
            dt.Columns.Add("F");
            dt.Columns.Add("G");
            dt.Columns.Add("H");
            dt.Columns.Add("I");
            dt.Columns.Add("J");
            dt.Columns.Add("K");
            dt.Columns.Add("L");
            dt.Columns.Add("M");
            dt.Columns.Add("N");
            dt.Columns.Add("O");
            dt.Columns.Add("P");
            dt.Columns.Add("Q");
            dt.Columns.Add("R");
            dt.Columns.Add("S");
            dt.Columns.Add("T");
            dt.Columns.Add("U");
            dt.Columns.Add("V");
            dt.Columns.Add("W");
            dt.Columns.Add("X");
            dt.Columns.Add("Y");
            dt.Columns.Add("Z");

            
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
            int k_inverse = 0;
            for (int j = 0; j < 26; j++) //for k inverse
            {
                if (key * j % 26 == 1)
                {
                    k_inverse = j;
                }
            }
            for (int i = 0; i <= 25; i++)
            {
                temp = (char)(((i * k_inverse) % 26));
                dt.Rows[2][i] = (int)temp;
                temp = (char)(temp + 97);
                dt.Rows[1][i] = temp.ToString();

            }


            dataGridView1.DataSource = dt;

            //dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.Red;
            dataGridView1.Rows[1].DefaultCellStyle.BackColor = Color.Green;
            dataGridView1.Rows[1].DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.Rows[0].Selected = false;
            dataGridView1.Rows[1].Selected = false;

        }
        public int kinverse()
        {
            //string encode = new string(arr);
            //string s = textBox2.Text;

            key = Convert.ToInt32(key);

            int k_inverse = 0;

            char[] array1 = ciphertext.ToCharArray();

            for (int j = 0; j < 26; j++) //for k inverse
            {
                if (key * j % 26 == 1)
                {
                    k_inverse = j;
                }
            }
            return k_inverse;
           

           

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" PlianText = CipherText * K_Inverse(GCD OF KEY) MOD 26", "Important Query", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }
    }
}
