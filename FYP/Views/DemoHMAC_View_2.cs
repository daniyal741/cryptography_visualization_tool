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
    public partial class DemoHMAC_View_2 : UserControl
    {
        private KeyBased hmac;

        internal KeyBased Hmac { get => hmac; set => hmac = value; }


        public DemoHMAC_View_2()
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

            MainForm.Instance.panelContain.Controls["DemoHMAC_View_2"].SendToBack();
            MainForm.Instance.panelContain.Controls["DemoHMAC_View_1"].BringToFront();

        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("oPad ⨁ Key", pictureBox3);
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("iPad ⨁ Key", pictureBox1);

        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("0x36", pictureBox5);

        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("0x5c", pictureBox4);

        }

        private void pictureBox10_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(Hmac.HashEncode(Hmac.okeypad), pictureBox10);

        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(Hmac.HashEncode(Hmac.ikeypad), pictureBox6);

        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(Hmac.append1, pictureBox8);

        }

        private void pictureBox12_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(Hmac.append1, pictureBox12);

        }

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(Hmac.hash1, pictureBox9);

        }

        private void pictureBox11_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(Hmac.hash2, pictureBox11);

        }

        private void btnR1_Click(object sender, EventArgs e)
        {
            titleLabel.Text = "oPad" ;
            ValueText.Text = "0x5c";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            titleLabel.Text = "iPad";
            ValueText.Text = "0x36";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            titleLabel.Text = "Key";
            ValueText.Text = Hmac.SharedKey;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            titleLabel.Text = "Message without Padding";
            ValueText.Text = Hmac.getPlaintext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            titleLabel.Text = "Message with Padding";
            ValueText.Text = Hmac.HashEncode(Hmac.message);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            titleLabel.Text = "iPadKey";
            ValueText.Text = Hmac.HashEncode(Hmac.ikeypad);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            titleLabel.Text = "Hash-1";
            ValueText.Text = Hmac.hash1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            titleLabel.Text = "Hash-1";
            ValueText.Text = Hmac.hash1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            titleLabel.Text = "oPadKey";
            ValueText.Text = Hmac.HashEncode(Hmac.okeypad);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            titleLabel.Text = "Hash-2";
            ValueText.Text = Hmac.hash2;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            titleLabel.Text = "Appended-1";
            ValueText.Text = Hmac.append1;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            titleLabel.Text = "Appended-2";
            ValueText.Text = Hmac.append2;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            titleLabel.Text = "Hash-2";
            ValueText.Text = Hmac.hash2;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(Hmac.SharedKey, pictureBox2);

        }

        private void keyV_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(Hmac.SharedKey, keyV);

        }
    }
}
