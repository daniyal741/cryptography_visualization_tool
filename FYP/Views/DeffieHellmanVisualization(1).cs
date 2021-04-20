using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYP
{
    public partial class DeffieHellmanVisualization_1_ : UserControl
    {
        int pnum = 0;
        int qnum = 0;
        int a = 17;
        int b = 11;
        public int setpnum { get; set; }
        public int setqnum { get; set; }
        Random rand = new Random();

        public DeffieHellmanVisualization_1_()
        {
            InitializeComponent();
            int dum;

            //pnum = rand.Next(30);

            //dum = pnum - 2;

            //qnum = rand.Next(dum);
            p_number.Text = a.ToString();// pnum.ToString();
            q_number.Text = b.ToString();// qnum.ToString();
        }

        private void DeffieHellmanVisualization_1__Load(object sender, EventArgs e)
        {
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Deffie_HellmanVisualization uc_deffie_HellmanVisualization = new Deffie_HellmanVisualization();
            uc_deffie_HellmanVisualization.Dock = DockStyle.Fill;

            MainForm.Instance.panelContain.Controls.Add(uc_deffie_HellmanVisualization);
            MainForm.Instance.panelContain.Controls["Deffie_HellmanVisualization"].BringToFront();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            setpnum = Convert.ToInt32(p_number.Text);
            setqnum = Convert.ToInt32(q_number.Text);
            DeffieHellmanVisualization_2_ uc_deffie_HellmanVisualization = new DeffieHellmanVisualization_2_(this);
            uc_deffie_HellmanVisualization.Dock = DockStyle.Fill;

            MainForm.Instance.panelContain.Controls.Add(uc_deffie_HellmanVisualization);
            MainForm.Instance.panelContain.Controls["DeffieHellmanVisualization_2_"].BringToFront();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void p_number_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Deffie_HellmanVisualization uc_deffie_HellmanVisualization = new Deffie_HellmanVisualization();
            uc_deffie_HellmanVisualization.Dock = DockStyle.Fill;

            MainForm.Instance.panelContain.Controls.Add(uc_deffie_HellmanVisualization);
            MainForm.Instance.panelContain.Controls["Deffie_HellmanVisualization"].BringToFront();
        }
    }
}
