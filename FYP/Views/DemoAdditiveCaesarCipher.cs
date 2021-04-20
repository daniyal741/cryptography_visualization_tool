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
using FYP.Views;

namespace FYP
{
    public partial class DemoAdditiveCaesarCipher : UserControl
    {

        char[] plain_text;
        int keyy,i=0, flag = 0, flag1 = 0, flag2 = 0, flag3 = 0, flag4 = 0, flag5 = 0, flag6 = 0, flag7 = 0, flag8 = 0, flag9 = 0, flag10 = 0;

        public int len = 0,seconds=0;
        public string plaintext;
        public string ciphertext;
        public int key;
        DataTable dt = new DataTable();
        CaesarCipherView caesar = new CaesarCipherView();
        Classical obj = new Classical();

        // string text;
        // Label labelLoad;

        public DemoAdditiveCaesarCipher()
        {
            InitializeComponent();
        }

        public DemoAdditiveCaesarCipher(CaesarCipherView obj)
        {
            InitializeComponent();
            this.caesar = obj;
            btnNext.Enabled = false;
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

        private void Resume_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            Stop.Visible = true;
            Resume.Visible = false;
            timer1.Start();

        }

        private async void Encrypt(char[] plain_text, int key)
        {

            for (int i = 0; i < plain_text.Length; i++)
            {

              
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;

            if (seconds >= 10 && flag == 0)
            {
                PlaintextBox.Text += String.Concat(plain_text[i].ToString(), "\n"); //plain_text[i]-97 , " + " , key," = ", plain_text[i]+key);
                flag = 1;
            }
            if (seconds >= 15 && flag1 == 0)
            {
                arrow1Box.Text += "->\n";
                flag1 = 1;
            }

            if (seconds >= 20 && flag2 == 0)
            {
                plain_text[i] = (char)(plain_text[i] - 97);
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
                KeyBox.Text += String.Concat(key.ToString(), "\n");
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
                plain_text[i] = (char)(plain_text[i] + key);
                plain_text[i] = (char)(plain_text[i] % 26);
                CiphervalueBox.Text += String.Concat(((int)plain_text[i]).ToString(), "\n");
                flag7 = 1;
            }
            if (seconds >= 50 && flag8 == 0)
            {
                arrow2Box.Text += "->\n";
                flag8 = 1;
            }
            if (seconds >= 55 && flag9 == 0)
            {
                plain_text[i] = (char)(plain_text[i] + 65);
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
                Resume.Visible = false;
                Stop.Visible = false; ;
                btnStart.Visible = true;
                i = 0;
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
            for (int i = 0; i <= 25; i++)
            {
                temp = (char)(((i + key) % 26));
                dt.Rows[2][i] = (int)temp;
                temp = (char)(temp + 97 - 32);
                dt.Rows[1][i] = temp.ToString();

            }


            dataGridView1.DataSource = dt;

            //dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.Red;
            dataGridView1.Rows[1].DefaultCellStyle.BackColor = Color.Green;
            dataGridView1.Rows[1].DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.Rows[0].Selected = false;
            dataGridView1.Rows[1].Selected = false;





        }
        public void LoadText()
        {

            plaintext = caesar.plaintext;
            key = caesar.key;
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
            EqualBox.Clear();
            PlusBox.Clear();
            modeTextBox.Clear();
            CiphertextBox.Clear();
            CiphervalueBox.Clear();

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm.Instance.panelContain.Controls.Clear();

            CaesarCipherView uc_caesarCipher = new CaesarCipherView();
            MainForm.Instance.LoadView(uc_caesarCipher);
            MainForm.Instance.panelContain.Controls["CaesarCipherView"].BringToFront();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ClearText();
            LoadText();
            Stop.Visible = true;
            Resume.Visible = false;
            btnStart.Visible = false;
            plain_text = plaintext.ToCharArray();
            keyy = key;
            timer1.Start();
            btnNext.Enabled = true;           

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Stop();
                DemoAdditiveCaesarCipherDecrypt uc_demoAdditiveCaesarCipherDecrypt = new DemoAdditiveCaesarCipherDecrypt(this);
                uc_demoAdditiveCaesarCipherDecrypt.Dock = DockStyle.Fill;


                MainForm.Instance.panelContain.Controls.Add(uc_demoAdditiveCaesarCipherDecrypt);
                MainForm.Instance.panelContain.Controls["DemoAdditiveCaesarCipherDecrypt"].BringToFront();
            }
            catch (Exception)
            {
                MessageBox.Show("Please First Encrypt The PlainText ");
            }

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CipherText = PlainText + Key MOD 26", "Important Query", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            Stop.Visible = false;
            btnStart.Visible = false;
            Resume.Visible = true;

            timer1.Stop();
            btnNext.Enabled = true;
        }
    }
}
