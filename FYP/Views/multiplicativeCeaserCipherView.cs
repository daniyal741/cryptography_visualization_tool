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
    public partial class multiplicativeCeaserCipherView : UserControl
    {
        public multiplicativeCeaserCipherView()
        {
            InitializeComponent();
        }

        private void multiplicativeCeaserCipherView_Load(object sender, EventArgs e)
        {

        }
        Classical obj1 = new Classical();
        public string plaintext { get; set; }
        public string ciphertext { get; set; }
        public int key { get; set; }

        

        private void validatePlaintext()
        {
            plaintext = plainText.Text;

            try
            {
                if (String.IsNullOrEmpty(plainText.Text))
                {

                    throw new ApplicationException("Please Enter Plaintext");

                }
                else
                {
                    foreach (var c in plaintext)
                    {
                        if (!Regex.IsMatch(c.ToString(), "[a-zA-Z]"))
                            plaintext = plaintext.Replace(c.ToString(), string.Empty);
                    }

                    plaintext = plaintext.ToLower();
                }
            }
            catch (ApplicationException e)
            {

                MessageBox.Show(e.Message);

            }

        }

        private void validateKey()
        {

            string tempkey = keyValue.Text;

            try
            {

                key = Convert.ToInt32(tempkey);

            }
            catch (Exception e)
            {
                MessageBox.Show("Please Enter Key Value");
            }


        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {

            


        }

        private void caesarcipherBox_Click(object sender, EventArgs e)
        {

           
        }




        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SymmetricCategory uc_symmetricCategory = new SymmetricCategory();
            uc_symmetricCategory.Dock = DockStyle.Fill;


            MainForm.Instance.panelContain.Controls.Add(uc_symmetricCategory);
            MainForm.Instance.panelContain.Controls["SymmetricCategory"].BringToFront();
        }

        private void btnEncrypt_Click_1(object sender, EventArgs e)
        {
            validatePlaintext();
            validateKey();

            // MainForm.Instance.securityalgorithm.setPlaintext(this.plaintext);
            //  MainForm.Instance.securityalgorithm.setCiphertext(this.ciphertext);

            obj1.setPlaintext(plaintext);
            obj1.setSecretKey(key.ToString());
            obj1.setCiphertext(obj1.MultiplicativeCaesarCipher('e'));
            if (obj1.getCiphertext() != null)
            {
                cipherText.Text = obj1.getCiphertext();
            }
            else
            {
                MessageBox.Show("Please check Key"+"\n"+"Key has only 12 memebrs : 1,3,5,7,9,11,15,17,19,21,23,25");
            }


            /* SymmetricEncryptions encrypt = new SymmetricEncryptions();
             ciphertext = encrypt.CaesarCipherEncryption(plaintext.ToCharArray(), key);
             cipherText.Text = ciphertext;

             */
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            CategoriesOfCaeserCipher uc_symmetricCategory = new CategoriesOfCaeserCipher();
            uc_symmetricCategory.Dock = DockStyle.Fill;


            MainForm.Instance.panelContain.Controls.Add(uc_symmetricCategory);
            MainForm.Instance.panelContain.Controls["CategoriesOfCaeserCipher"].BringToFront();
        }

        public void LoadValues()
        {
            this.plaintext = obj1.getPlaintext();
            this.key = Convert.ToInt32(obj1.getSecretKey());
            this.ciphertext = obj1.getCiphertext();
        }

        private void caesarcipherBox_Click_1(object sender, EventArgs e)
        {

            validatePlaintext();
            validateKey();


            obj1.setPlaintext(plaintext);
            obj1.setSecretKey(key.ToString());
            obj1.setCiphertext(obj1.MultiplicativeCaesarCipher('e'));

            LoadValues();

            if (!String.IsNullOrEmpty(plainText.Text))
            {
                DemoMultiplicativeCeaserCipher uc_demoAdditiveCaesarCipher = new DemoMultiplicativeCeaserCipher(this);

                uc_demoAdditiveCaesarCipher.Dock = DockStyle.Fill;

                MainForm.Instance.panelContain.Controls.Add(uc_demoAdditiveCaesarCipher);
                MainForm.Instance.panelContain.Controls["DemoMultiplicativeCeaserCipher"].BringToFront();

            }
        }
    }
}
