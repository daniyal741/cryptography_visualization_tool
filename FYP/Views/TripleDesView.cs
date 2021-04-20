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
    public partial class TripleDesView : UserControl
    {

        Advance advanceObj;
        internal Advance AdvanceObj { get => advanceObj; set => advanceObj = value; }
        private string plainText1;
        private string key1;
        private string result1;
        private string key2;
        private string result2;
        private string key3;
        private string cipherText1;



        public TripleDesView()
        {
            InitializeComponent();
            AdvanceObj = new Advance();
            AdvanceObj.setCategoryName("TripleDES");




        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            FYP.SymmetricCategory uc_symmetricCategory = new FYP.SymmetricCategory();
            uc_symmetricCategory.Dock = DockStyle.Fill;
            MainForm.Instance.LoadView(uc_symmetricCategory);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LoadValues()
        {

            plainText1 = messageText.Text.ToString();
            key1 = key_1.Text.ToString();
            result1 = AdvanceObj.Encrypt(plainText1, key1);
            key2 = key_2.Text.ToString();
            result2 = AdvanceObj.Encrypt(result1, key2);
            key3 = key_3.Text.ToString();
            cipherText1 = AdvanceObj.Encrypt(result2, key3);

        }

        private void btnDES_1_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(messageText.Text) || String.IsNullOrEmpty(key_1.Text))
                {

                    throw new ApplicationException("Please Enter the Keys and Plaintext");


                }
                else
                {

                    if (key_1.Text.Length > 8)
                    {
                        throw new ApplicationException("Please Enter Keys <= 8 Characters ");

                    }
                    else
                    {

                        plainText1 = messageText.Text;
                        key1 = key_1.Text;
                        result1 = AdvanceObj.Encrypt(plainText1, key1);

                        AdvanceObj.setPlaintext(plainText1);
                        AdvanceObj.setSecretKey(key1);
                        AdvanceObj.setCiphertext(result1);


                        DemoDES_View_1 uc_demo = new DemoDES_View_1(this);
                        //MainForm.Instance.LoadView(uc_demo);


                        uc_demo.Dock = DockStyle.Fill;
                        MainForm.Instance.panelContain.Controls.Add(uc_demo);
                        MainForm.Instance.panelContain.Controls["DemoDES_View_1"].BringToFront();
                    }
                }
            }
            catch (ApplicationException a)
            {
                MessageBox.Show(a.Message);

            }



        }

        private void TripleDesView_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void messageText_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cipherText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(messageText.Text) || String.IsNullOrEmpty(key_1.Text) || String.IsNullOrEmpty(key_2.Text) || String.IsNullOrEmpty(key_3.Text) ) 
                {

                    

                        throw new ApplicationException("Please Enter the Values ");

               

                }
                else
                {

                    if (key_1.Text.Length > 8 || key_2.Text.Length > 8 || key_3.Text.Length > 8)
                    {
                        throw new ApplicationException("Please Enter Keys <= 8 Characters ");

                    }
                    else
                    {

                        plainText1 = messageText.Text;
                        key1 = key_1.Text;
                        key2 = key_2.Text;
                        key3 = key_3.Text;
                        result1 = AdvanceObj.Encrypt(plainText1, key1);
                        result2 = AdvanceObj.Encrypt(result1, key2);
                        cipherText1 = AdvanceObj.Encrypt(result2, key3);


                        // cipherText1 =  AdvanceObj.TripleDESEncrypt(plainText1,key1,key2,key3);

                        cipherText.Text = cipherText1;
                    }

                  
                }
            }
            catch (ApplicationException ex)
            {

                MessageBox.Show(ex.Message);

            }


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void key_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void FlowPanelHashBlock_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDES_2_Click(object sender, EventArgs e)
        {
            try
            {

                if (String.IsNullOrEmpty(messageText.Text) || String.IsNullOrEmpty(key_2.Text) || key_2.Text.Length > 8)
                {

                    throw new ApplicationException("Please Enter the Keys and Plaintext");


                }
                else
                {

                    if (key_2.Text.Length > 8)
                    {
                        throw new ApplicationException("Please Enter Keys <= 8 Characters ");

                    }
                    else
                    {
                        result1 = AdvanceObj.Encrypt(plainText1, key1);
                        key2 = key_2.Text;
                        result2 = AdvanceObj.Encrypt(result1, key2);

                        AdvanceObj.setPlaintext(result1);
                        AdvanceObj.setSecretKey(key2);
                        AdvanceObj.setCiphertext(result2);


                        DemoDES_View_1 uc_demo = new DemoDES_View_1(this);
                        //MainForm.Instance.LoadView(uc_demo);


                        uc_demo.Dock = DockStyle.Fill;
                        MainForm.Instance.panelContain.Controls.Add(uc_demo);
                        MainForm.Instance.panelContain.Controls["DemoDES_View_1"].BringToFront();

                    }
                }
            }
            catch (ApplicationException a)
            {

                MessageBox.Show(a.Message);

            }
            


        }

        private void btnDES_3_Click(object sender, EventArgs e)
        {

            try
            {
                if (String.IsNullOrEmpty(messageText.Text) || String.IsNullOrEmpty(key_3.Text) || key_3.Text.Length>8)
                {

                    throw new ApplicationException("Please Enter the Keys and Plaintext");


                }
                else
                {

                    if (key_3.Text.Length > 8)
                    {
                        throw new ApplicationException("Please Enter Keys <= 8 Characters ");

                    }
                    else
                    {

                        result2 = AdvanceObj.Encrypt(result1, key2);
                        key3 = key_3.Text;
                        cipherText1 = AdvanceObj.Encrypt(result2, key3);

                        AdvanceObj.setPlaintext(result2);
                        AdvanceObj.setSecretKey(key3);
                        AdvanceObj.setCiphertext(cipherText1);


                        DemoDES_View_1 uc_demo = new DemoDES_View_1(this);
                        //MainForm.Instance.LoadView(uc_demo);


                        uc_demo.Dock = DockStyle.Fill;
                        MainForm.Instance.panelContain.Controls.Add(uc_demo);
                        MainForm.Instance.panelContain.Controls["DemoDES_View_1"].BringToFront();
                    }
                }
            }
            catch (ApplicationException a)
            {

                MessageBox.Show(a.Message);

            }




        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void key_2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void key_3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void plaintextValue_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(plainText1, plaintextValue);
        }

        private void cipher1Value_MouseHover(object sender, EventArgs e)
        {


            toolTip1.Show(result1, cipher1Value);

        }

        private void cipher2Value_MouseHover(object sender, EventArgs e)
        {

            result2 = AdvanceObj.Encrypt(result1, key2);

            toolTip1.Show(result2, cipher2Value);

        }

        private void cipher3Value_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(cipherText1, cipher3Value);

        }
    }
}
