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
using System.Text.RegularExpressions;

namespace FYP
{
    public partial class VigenereCipher : UserControl
    {

        Classical obj1 = new Classical();

        public string plaintext { get; set; }
        public string ciphertext { get; set; }
        public string key { get; set; }

        public VigenereCipher()
        {
            InitializeComponent();
        }
        private void validatePlaintext()
        {
            plaintext = plainText.Text;

            try
            {
                if (String.IsNullOrEmpty(plainText.Text))
                {

                    throw new ApplicationException("Please Enter Plaintext Correctly");

                }
                else
                {
                    foreach (var c in plaintext)
                    {
                        if (!Regex.IsMatch(c.ToString(), "[a-zA-Z]"))
                            plaintext = plaintext.Replace(c.ToString(), string.Empty);
                    }

                    plaintext = plaintext.ToLower();
                    plainText.Text = plaintext;
                }
            }
            catch (ApplicationException e)
            {

                MessageBox.Show(e.Message);

            }

        }

        public void validateKey()
        {

            string tempkey = keyValue.Text;
            try
            {
                if (String.IsNullOrEmpty(keyValue.Text))
                {

                    throw new ApplicationException("Please Enter Key Correctly");

                }
                else
                {
                    foreach (var c in tempkey)
                    {
                        if (!Regex.IsMatch(c.ToString(), "[a-zA-Z]"))
                            tempkey = tempkey.Replace(c.ToString(), string.Empty);
                    }

                    key = Convert.ToString(tempkey.ToLower());
                    keyValue.Text = key;
                }
            }
            catch (ApplicationException e)
            {

                MessageBox.Show(e.Message);

            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            
        }
        public void LoadValues()
        {
            this.plaintext = obj1.getPlaintext();
            this.key = obj1.getSecretKey();
            this.ciphertext = obj1.getCiphertext();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void keyValue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void keyValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
        }

        private void VigenereCipher_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {

            FYP.SymmetricCategory uc_symmetricCategory = new FYP.SymmetricCategory();
            MainForm.Instance.LoadView(uc_symmetricCategory);
        }

        private void btnEncrypt_Click_1(object sender, EventArgs e)
        {
            validatePlaintext();
            validateKey();

            if (!String.IsNullOrEmpty(keyValue.Text) && !String.IsNullOrEmpty(plainText.Text) && plaintext.Length >= key.Length)
            {

                obj1.setPlaintext(plaintext.ToLower());
                obj1.setSecretKey(key.ToString());
                obj1.setCiphertext(obj1.VigenereCipher('e'));
                cipherText.Text = obj1.getCiphertext();

            }
            else

            {

                MessageBox.Show("The length of Key must be Less than PlainText");


            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            validatePlaintext();
            validateKey();

            if (!String.IsNullOrEmpty(keyValue.Text) && !String.IsNullOrEmpty(plainText.Text) && plaintext.Length >= key.Length)
            {

                obj1.setPlaintext(plaintext);
                obj1.setSecretKey(key.ToString());
                obj1.setCiphertext(obj1.VigenereCipher('e'));
                cipherText.Text = obj1.getCiphertext();

                LoadValues();

                DemoVigenereCipher uc_demoVigenere = new DemoVigenereCipher(this);
                MainForm.Instance.LoadView(uc_demoVigenere);
            }
            else

            {

                MessageBox.Show("The lenght of Plain text and Key must be Same");


            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

