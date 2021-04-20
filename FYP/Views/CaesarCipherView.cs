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
using FYP.Model;

namespace FYP
{
    public partial class CaesarCipherView : UserControl
    {
        Classical obj1 = new Classical();
       
        public string plaintext { get; set; }
        public string ciphertext { get; set; }
        public int key { get; set; }

        public CaesarCipherView()
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


            validatePlaintext();
            validateKey();

            // MainForm.Instance.securityalgorithm.setPlaintext(this.plaintext);
            //  MainForm.Instance.securityalgorithm.setCiphertext(this.ciphertext);


            obj1.setPlaintext(plaintext);
            obj1.setSecretKey(key.ToString());
            obj1.setCiphertext(obj1.AdditiveCaesarCipher('e'));
            cipherText.Text = obj1.getCiphertext();


            /* SymmetricEncryptions encrypt = new SymmetricEncryptions();
             ciphertext = encrypt.CaesarCipherEncryption(plaintext.ToCharArray(), key);
             cipherText.Text = ciphertext;

             */


        }

        public void LoadValues()
        {
            this.plaintext = obj1.getPlaintext();
            this.key = Convert.ToInt32(obj1.getSecretKey());
            this.ciphertext = obj1.getCiphertext();
        }

        private void caesarcipherBox_Click(object sender, EventArgs e)
        {


            validatePlaintext();
            validateKey();
            

            obj1.setPlaintext(plaintext);
            obj1.setSecretKey(key.ToString());
            obj1.setCiphertext(obj1.AdditiveCaesarCipher('e'));

            LoadValues();



            DemoAdditiveCaesarCipher uc_demoAdditiveCaesarCipher = new DemoAdditiveCaesarCipher(this);
            
            MainForm.Instance.LoadView(uc_demoAdditiveCaesarCipher);

            
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

        private void CaesarCipherView_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void plainText_TextChanged(object sender, EventArgs e)
        {

        }
    }

 }
