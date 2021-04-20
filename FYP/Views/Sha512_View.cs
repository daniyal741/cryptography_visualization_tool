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
    public partial class Sha512_View : UserControl
    {
        private String message;
        private string hashvalue;

        public string Message { get => message; set => message = value; }
        public string Hashvalue { get => hashvalue; set => hashvalue = value; }

        public Sha512_View()
        {
            InitializeComponent();
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
            MainForm.Instance.panelContain.Controls["Sha512_View"].Dispose();

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
                    Message = messageText.Text;
                    DemoSha512_View_1 uc_demo_sha = new DemoSha512_View_1();
                    uc_demo_sha.Message = Message;

                    uc_demo_sha.Dock = DockStyle.Fill;

                    MainForm.Instance.panelContain.Controls.Add(uc_demo_sha);
                    MainForm.Instance.panelContain.Controls["DemoSha512_View_1"].BringToFront();
                }
            }
            catch (ApplicationException ex)
            {

                MessageBox.Show(ex.Message);

            }

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Sha512 obj = new Sha512();
            hashValueText.Text =  obj.Encrypt(messageText.Text);
        }
    }
}
