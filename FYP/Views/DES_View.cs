using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using FYP.Model;

namespace FYP.Views
{
    public partial class DES_View : UserControl
    {

        private string msgInput;
        private string cipherOutput;
        private string keyInput;
        private Advance advanceObj;

        internal Advance AdvanceObj { get => advanceObj; set => advanceObj = value; }

        public DES_View()
        {
            InitializeComponent();

        }

        private void DES_View_Load(object sender, EventArgs e)
        {

        }

        private void AESmain_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Encrypt_Click(object sender, EventArgs e)
        {



            msgInput = messageText.Text.ToString();
            keyInput = keyValue.Text.ToString();

            if (keyInput.Length <= 8)
            {
                AdvanceObj = new Advance();
                cipherText.Text = AdvanceObj.Encrypt(msgInput, keyInput);
            }
            else
            {
                MessageBox.Show("Please Enter 8 characters = 64-bits for the key");
            }



            /*
            byte[] key = { };
            byte[] IV = { 10, 20, 30, 40, 50, 60, 70, 80 };
            byte[] inputBytes;

            try
            {
                key = Encoding.UTF8.GetBytes(keyInput);
                // DESCryptoServiceProvider is a cryptography class defind in c#.  
                DESCryptoServiceProvider ObjDES = new DESCryptoServiceProvider();
                inputBytes = Encoding.UTF8.GetBytes(msgInput);
                MemoryStream Objmst = new MemoryStream();
                CryptoStream Objcs = new CryptoStream(Objmst, ObjDES.CreateEncryptor(key, IV), CryptoStreamMode.Write);
                Objcs.Write(inputBytes, 0, inputBytes.Length);
                Objcs.FlushFinalBlock();

                cipherOutput = Convert.ToBase64String(Objmst.ToArray()); //encrypted string  
                cipherText.Text = cipherOutput;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Key must be 8 characters or 64-bits long");
            }

            */

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

        private void btnDemo_Click(object sender, EventArgs e)
        {

            msgInput = messageText.Text.ToString();
            keyInput = keyValue.Text.ToString();

            AdvanceObj = new Advance();
            cipherText.Text = AdvanceObj.Encrypt(msgInput, keyInput);

            AdvanceObj.setPlaintext(msgInput);
            AdvanceObj.setSecretKey(keyInput);
            AdvanceObj.setCiphertext(cipherText.Text);


            DemoDES_View_1 uc_demo = new DemoDES_View_1(this);
            // MainForm.Instance.LoadView(uc_demo);
            uc_demo.Dock = DockStyle.Fill;
            MainForm.Instance.panelContain.Controls.Add(uc_demo);
            MainForm.Instance.panelContain.Controls["DemoDES_View_1"].BringToFront();

        }
    }
}

