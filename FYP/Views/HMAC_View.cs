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
    public partial class HMAC_View : UserControl
    {


        private string message;
        private KeyBased hmac;

        public string Message { get => message; set => message = value; }
        internal KeyBased Hmac { get => hmac; set => hmac = value; }

        public HMAC_View()
        {
            InitializeComponent();
            Hmac = new KeyBased();

        }


        private void btnClose_Click(object sender, EventArgs e)
        {

            string message = "Do you want to close the Applicaion?";
            string title = "Warning";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                // Do Nothing 
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HashingCategoryView uc_selectCategory = new HashingCategoryView();
            uc_selectCategory.Dock = DockStyle.Fill;


            MainForm.Instance.panelContain.Controls.Add(uc_selectCategory);
            MainForm.Instance.panelContain.Controls["HashingCategoryView"].BringToFront();
            MainForm.Instance.panelContain.Controls["HMAC_View"].Dispose();

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(messageText.Text) || String.IsNullOrEmpty(keyValue.Text))
                {

                    throw new ApplicationException("Please Enter Plaintext and Key");

                }
                else
                {
                    Hmac.setPlaintext(messageText.Text);
                    Hmac.SharedKey = keyValue.Text;
                    Hmac.setCiphertext(Hmac.HMAC(Hmac.getPlaintext(), Hmac.SharedKey));
                    hashValueText.Text = Hmac.getCiphertext();

                }
            }
            catch (ApplicationException ex)
            {

                MessageBox.Show(ex.Message);

            }

           
        }

        private void btnDemo_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(messageText.Text) || String.IsNullOrEmpty(keyValue.Text))
                {

                    throw new ApplicationException("Please Enter Plaintext and Key");

                }
                else
                {
                    Hmac.setPlaintext(messageText.Text);
                    Hmac.SharedKey = keyValue.Text;
                    Hmac.setCiphertext(Hmac.HMAC(Hmac.getPlaintext(), Hmac.SharedKey));

                    DemoHMAC_View_1 uc_demo_sha = new DemoHMAC_View_1();
                    uc_demo_sha.Hmac = this.Hmac;

                    uc_demo_sha.Dock = DockStyle.Fill;

                    MainForm.Instance.panelContain.Controls.Add(uc_demo_sha);
                    MainForm.Instance.panelContain.Controls["DemoHMAC_View_1"].BringToFront();
                }
            }
            catch (ApplicationException ex)
            {

                MessageBox.Show(ex.Message);

            }
        }
    }
}
