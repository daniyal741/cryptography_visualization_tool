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
using System.Text.RegularExpressions;

namespace FYP
{
    public partial class OneTimePadView : UserControl
    {
        public OneTimePadView()
        {
            InitializeComponent();
        }

        private void plainText_TextChanged(object sender, EventArgs e)
        {

        }

        Classical obj1 = new Classical();

        public string plaintext { get; set; }
        public string ciphertext { get; set; }
        public string key { get; set; }

        

        private void validatePlaintext()
        {
            plaintext = plainText.Text.ToUpper();

            try
            {
                if (String.IsNullOrEmpty(plainText.Text) )
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

                    plaintext = plaintext.ToUpper();
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
            validatePlaintext();
            validateKey();

            if (!String.IsNullOrEmpty(keyValue.Text) && !String.IsNullOrEmpty(plainText.Text) && plaintext.Length == key.Length )
            {

                obj1.setPlaintext(plaintext.ToUpper());
                obj1.setSecretKey(key.ToString());
                obj1.setCiphertext(obj1.OneTimePadCipher('e'));
                cipherText.Text = obj1.getCiphertext();

            }
            else

            {

                MessageBox.Show("The lenght of Plain text and Key must be Same");


            }


        }

            private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
        }


        private void OneTimePadView_Load(object sender, EventArgs e)
        {

        }

      

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            SymmetricCategory uc_symmetricCategory = new SymmetricCategory();
            uc_symmetricCategory.Dock = DockStyle.Fill;


            MainForm.Instance.panelContain.Controls.Add(uc_symmetricCategory);
            MainForm.Instance.panelContain.Controls["SymmetricCategory"].BringToFront();
        }
        public void LoadValues()
        {
            this.plaintext = obj1.getPlaintext();
            this.key = obj1.getSecretKey();
            this.ciphertext = obj1.getCiphertext();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            validatePlaintext();
            validateKey();

            if (!String.IsNullOrEmpty(keyValue.Text) && !String.IsNullOrEmpty(plainText.Text) && plaintext.Length == key.Length)
            {

                obj1.setPlaintext(plaintext.ToUpper());
                obj1.setSecretKey(key.ToString());
                obj1.setCiphertext(obj1.OneTimePadCipher('e'));
                cipherText.Text = obj1.getCiphertext();

                LoadValues();

                DemoOneTimePad uc_demoOneTimePad = new DemoOneTimePad(this);
                uc_demoOneTimePad.Dock = DockStyle.Fill;
                MainForm.Instance.panelContain.Controls.Add(uc_demoOneTimePad);
                MainForm.Instance.panelContain.Controls["DemoOneTimePad"].BringToFront();
            }
            else

            {

                MessageBox.Show("The lenght of Plain text and Key must be Same");


            }

           
        }
    }
}
