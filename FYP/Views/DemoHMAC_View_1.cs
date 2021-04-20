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
    public partial class DemoHMAC_View_1 : UserControl
    {

        private KeyBased hmac;

        internal KeyBased Hmac { get => hmac; set => hmac = value; }

        public DemoHMAC_View_1()
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
            
            MainForm.Instance.panelContain.Controls["DemoHMAC_View_1"].SendToBack();
            MainForm.Instance.panelContain.Controls["HMAC_View"].BringToFront();

        }

        private void pictureBox14_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(Hmac.getPlaintext() ,pictureBox14);
        }


        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(Hmac.getCiphertext(), pictureBox1);

        }

        private void btnHMAC_Click(object sender, EventArgs e)
        {
            DemoHMAC_View_2 uc = new DemoHMAC_View_2();
            uc.Hmac = this.Hmac;
            uc.Dock = DockStyle.Fill;
            MainForm.Instance.panelContain.Controls.Add(uc);
            MainForm.Instance.panelContain.Controls["DemoHMAC_View_2"].BringToFront();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            DisplayPicture uc = new DisplayPicture();


            uc.Pic.BackgroundImage = Image.FromFile(MainForm.Instance.path + "/images/Hashing/Sha_BlockRounds.jpg");
            uc.Dock = DockStyle.Fill;
            MainForm.Instance.panelContain.Controls.Add(uc);
            MainForm.Instance.panelContain.Controls["DisplayPicture"].BringToFront();
        }


        private void keyVAlue_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(Hmac.SharedKey, keyVAlue);

        }
    }
}
