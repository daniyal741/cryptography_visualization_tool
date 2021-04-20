using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using FYP.Views;

namespace FYP
{
    public partial class MD5_View : UserControl
    {

        private String message;
        private string hashvalue;


        public MD5_View()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

            message = messageText.Text;
            System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(message);
            bs = x.ComputeHash(bs); //this function is not in the above classdefinition
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2").ToLower());
            }
            hashValueText.Text = s.ToString();



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HashingCategoryView uc_selectCategory = new HashingCategoryView();
            uc_selectCategory.Dock = DockStyle.Fill;


            MainForm.Instance.panelContain.Controls.Add(uc_selectCategory);
            MainForm.Instance.panelContain.Controls["MD5_View"].Dispose();
            MainForm.Instance.panelContain.Controls["HashingCategoryView"].BringToFront();


        }

        private void btnDemo_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(messageText.Text))
                {

                    throw new ApplicationException("Please Enter Plaintext");

                }
                else
                {
                    message = messageText.Text;
                    DemoMD5_View_1 uc_demo_md5 = new DemoMD5_View_1();
                    uc_demo_md5.Message = message;

                    uc_demo_md5.Dock = DockStyle.Fill;

                    MainForm.Instance.panelContain.Controls.Add(uc_demo_md5);
                    MainForm.Instance.panelContain.Controls["DemoMD5_View_1"].BringToFront();
                }
            }
            catch (ApplicationException ex)
            {

                MessageBox.Show(ex.Message);

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            message = messageText.Text;

            Model.NonKeyBased obj = new Model.NonKeyBased();
            obj.setPlaintext(message);
            message = obj.MD5();
            hashValueText.Text = message;

        }

        private void MD5_View_Load(object sender, EventArgs e)
        {

        }

        private void checkEnglish_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEnglish.Checked)
            {
                checkUrdu.Enabled = false;
                messageText.RightToLeft = RightToLeft.No;

            }
            else
            {
                checkUrdu.Enabled = true;

            }
        }

        private void checkUrdu_CheckedChanged(object sender, EventArgs e)
        {
            if (checkUrdu.Checked)
            {

                checkEnglish.Enabled = false;
                messageText.RightToLeft = RightToLeft.Yes;

            }
            else
            {
                checkEnglish.Enabled = true;

            }


        }

        private void messageText_TextChanged(object sender, EventArgs e)
        {

            string str = messageText.Text;
            if (checkUrdu.Checked)
            {

                foreach (var c in str)
                {
                    if (!Regex.IsMatch(c.ToString(), "[a-zA-Z]"))
                        MessageBox.Show("Dont Type in English");
                    messageText.Text = "";



                }

            }
            else
            {


            }
        }
    }
}
