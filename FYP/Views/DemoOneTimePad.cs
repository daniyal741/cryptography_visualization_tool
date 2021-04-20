using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FYP.Model;
using System.Windows.Forms;

namespace FYP
{
    public partial class DemoOneTimePad : UserControl
    {
        public DemoOneTimePad()
        {
            InitializeComponent();
        }

        private void DemoOneTimePad_Load(object sender, EventArgs e)
        {

        }
        char[] plain_text;
        int flag = 0, flag1 = 0, flag2 = 0, flag3 = 0, flag4 = 0, flag5 = 0, flag6 = 0, flag7 = 0, flag8 = 0, flag9 = 0, flag10 = 0;
        public int seconds = 0, i = 0;
        public int len = 0;
        public string plaintext { get; set; }
        public string ciphertext { get; set; }
        public string key { get; set; }
        DataTable dt = new DataTable();
        OneTimePadView caesar;
        Classical obj = new Classical();
        char[] characterKey, Key;

        // string text;
        // Label labelLoad;


        public DemoOneTimePad(OneTimePadView obj)
        {
            InitializeComponent();
            this.caesar = obj;
            ClearText();



            Control[] syncedCtrls = new Control[] { PlaintextBox, CiphertextBox, arrow1Box, PlainvalueBox, PlusBox, KeyBox, modeTextBox, EqualBox, CiphervalueBox, arrow2Box, CiphertextBox };
            foreach (SyncRichTextBox ctr in syncedCtrls)
            {
                ctr.Buddies = syncedCtrls;
            }
        }



        private void DemoAdditiveCaesarCipher_Load(object sender, EventArgs e)
        {


            //   Encrypt(plaintext.ToCharArray(), key);


        }



        private async void Encrypt(char[] plain_text, char[] Key)
        {
            
            for (int i = 0; i < plain_text.Length; i++)
            {

               

            }

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
            for (int i = 0; i <= 25; i++)
            {
                for (int j = 0; j < characterKey.Length; j++)
                {
                    temp = (char)(((i + ((int)characterKey[j]-97)) % 26));
                    dt.Rows[2][i] = (int)temp;
                    temp = (char)(temp + 97);
                    dt.Rows[1][i] = temp.ToString();
                }
            }


            dataGridView1.DataSource = dt;

            //dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.Red;
            dataGridView1.Rows[1].DefaultCellStyle.BackColor = Color.Green;
            dataGridView1.Rows[1].DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.Rows[0].Selected = false;
            dataGridView1.Rows[1].Selected = false;





        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            if (seconds >= 10 && flag == 0)
            {
                PlaintextBox.Text += String.Concat(plain_text[i].ToString(), "\n"); //plain_text[i]-97 , " * " , key," = ", plain_text[i]+key);
                flag = 1;
            }
            if (seconds >= 15 && flag1 == 0)
            {
                arrow1Box.Text += "->\n";
                flag1 = 1;
            }
            if (seconds >= 20 && flag2 == 0)
            {

                plain_text[i] = (char)(plain_text[i] - 65);
                PlainvalueBox.Text += String.Concat(((int)plain_text[i]).ToString(), "\n");
                flag2 = 1;
            }
            if (seconds >= 25 && flag3 == 0)
            {
                PlusBox.Text += "+\n";
                flag3 = 1;
            }
            if (seconds >= 30 && flag4 == 0)
            {
                KeyBox.Text += String.Concat((char)Key[i], "(", ((int)Key[i] - 97), ")", "\n");
                flag4 = 1;
            }
            if (seconds >= 35 && flag5 == 0)
            {
                modeTextBox.Text += String.Concat("%   ", "26", "\n");
                flag5 = 1;
            }
            if (seconds >= 40 && flag6 == 0)
            {
                EqualBox.Text += "=\n";
                flag6 = 1;
            }
            if (seconds >= 45 && flag7 == 0)
            {
                plain_text[i] = (char)(((int)Key[i] - 97) + plain_text[i]);
                plain_text[i] = (char)((plain_text[i] % 26));
                CiphervalueBox.Text += String.Concat(((int)plain_text[i]).ToString(), "\n");
                flag7 = 1;
            }


            if (seconds >= 50 && flag8 == 0)
            {
                plain_text[i] = (char)(plain_text[i] + 97);
              

            arrow2Box.Text += "->\n";
                flag8 = 1;
            }
            
            if(seconds>=55 && flag9==0)
            { 
            CiphertextBox.Text += String.Concat(plain_text[i].ToString(), "\n");
                i++;
                seconds = 0;
                flag9 = 0;
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

            if (i == plaintext.Length)
            {
                timer1.Stop();
            }




        }

        private void Stop_Click(object sender, EventArgs e)
        {
            Stop.Visible = false;
            btnStart.Visible = false;
            Resume.Visible = true;
            timer1.Stop();
            btnNext.Enabled = true;
        }

        private void Resume_Click(object sender, EventArgs e)
        {
            Stop.Visible = true;
            Resume.Visible = false;
            btnStart.Visible = false;
            timer1.Start();
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
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OneTimePadView uc_oneTimePaidView = new OneTimePadView();
            uc_oneTimePaidView.Dock = DockStyle.Fill;
            MainForm.Instance.panelContain.Controls.Add(uc_oneTimePaidView);
            MainForm.Instance.panelContain.Controls["OneTimePadView"].BringToFront();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            /*

            */

        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnStart_Click_2(object sender, EventArgs e)
        {

                LoadText();
                Stop.Visible = true;
                btnStart.Visible = false;
                Resume.Visible = false;
                plain_text = plaintext.ToCharArray();
                characterKey = key.ToCharArray();
                Key = key.ToCharArray();
                timer1.Start();
                btnNext.Enabled = true;
            
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            try
            {
                timer1.Stop();
                DemoOneTimePadDecrypt uc_demoOneTimePadDecrypt = new DemoOneTimePadDecrypt(this);
                uc_demoOneTimePadDecrypt.Dock = DockStyle.Fill;
                MainForm.Instance.panelContain.Controls.Add(uc_demoOneTimePadDecrypt);
                MainForm.Instance.panelContain.Controls["DemoOneTimePadDecrypt"].BringToFront();
            }
            catch (Exception)
            {
                MessageBox.Show("Please First Encrypt The PlainText ");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" CipherText = PlianText + Key (position value) MOD 26", "Important Query", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }
    }
}
