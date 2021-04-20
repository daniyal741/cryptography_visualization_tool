using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FYP
{
    public partial class Deffie_HellmanVisualization : UserControl
    {
        public Deffie_HellmanVisualization()
        {
            InitializeComponent();
        }

        
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AsymmetricAlgoCategories uc_asymmetricAlgoCategories = new AsymmetricAlgoCategories();
            uc_asymmetricAlgoCategories.Dock = DockStyle.Fill;
            MainForm.Instance.panelContain.Controls.Add(uc_asymmetricAlgoCategories);
            MainForm.Instance.panelContain.Controls["AsymmetricAlgoCategories"].BringToFront();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DeffieHellmanVisualization_1_ uc_asymmetricAlgoCategories = new DeffieHellmanVisualization_1_();
            uc_asymmetricAlgoCategories.Dock = DockStyle.Fill;
            MainForm.Instance.panelContain.Controls.Add(uc_asymmetricAlgoCategories);
            MainForm.Instance.panelContain.Controls["DeffieHellmanVisualization_1_"].BringToFront();
        }

        private void Deffie_HellmanVisualization_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The simplest and the original implementation of the protocol uses the multiplicative group of integers modulo p, where p is prime, and g is a primitive root modulo p. These two values are chosen in this way to ensure that the resulting shared secret can take on any value from 1 to p–1.");
        }
    }
}
