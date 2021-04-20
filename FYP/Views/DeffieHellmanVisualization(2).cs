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
    public partial class DeffieHellmanVisualization_2_ : UserControl
    {
        public DeffieHellmanVisualization_2_()
        {
            InitializeComponent();
        }
        int seconds = 0;
        

        public int p;
        public int q;
        DeffieHellmanVisualization_1_ obj1;
        public int XkeyNumber { get; set;}

        public int YkeyNumber { get; set; }

        public DeffieHellmanVisualization_2_(DeffieHellmanVisualization_1_ obj)
        {

            InitializeComponent();
            
            p_number.Text = obj.setpnum.ToString();
            q_number.Text = obj.setqnum.ToString();
            obj1 = obj;
        }

        private void DeffieHellmanVisualization_2__Load(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DeffieHellmanVisualization_1_ uc_deffie_HellmanVisualization = new DeffieHellmanVisualization_1_();
            uc_deffie_HellmanVisualization.Dock = DockStyle.Fill;
            
            MainForm.Instance.panelContain.Controls.Add(uc_deffie_HellmanVisualization);
            MainForm.Instance.panelContain.Controls["DeffieHellmanVisualization_1_"].BringToFront();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DeffieHellmanVisualization_1_ uc_deffie_HellmanVisualization = new DeffieHellmanVisualization_1_();
            uc_deffie_HellmanVisualization.Dock = DockStyle.Fill;

            MainForm.Instance.panelContain.Controls.Add(uc_deffie_HellmanVisualization);
            MainForm.Instance.panelContain.Controls["DeffieHellmanVisualization_1_"].BringToFront();
        }

        public void loadNull_End()
        {
            Xkeybox.Text = null;
            YkeybOX.Text = null;
            XkeyNumber = 0;
            YkeyNumber = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            if(seconds >= 20)
            {
                timer1.Stop();
                timer1.Dispose();
                DeffieHellmanVisualization_4_ uc_deffie_HellmanVisualization = new DeffieHellmanVisualization_4_(this);
                uc_deffie_HellmanVisualization.Dock = DockStyle.Fill;

                MainForm.Instance.panelContain.Controls.Add(uc_deffie_HellmanVisualization);
                MainForm.Instance.panelContain.Controls["DeffieHellmanVisualization_4_"].BringToFront();
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            
        }

        private void BTNSWAP_Click(object sender, EventArgs e)
        {

            try
            {
                XkeyNumber = Convert.ToInt32(Xkeybox.Text);
                YkeyNumber = Convert.ToInt32(YkeybOX.Text);
                p = obj1.setpnum;
                q = obj1.setqnum;


                if (XkeyNumber == null || YkeyNumber == null)
                {
                    MessageBox.Show("Please Enter the Scerte KEY");
                    seconds = 0;
                    timer1.Stop();
                    start.Visible = true;
                    stop.Visible = false;
                }
                else
                {
                    timer1.Start();
                    start.Visible = false;
                    stop.Visible = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Enter the Scerte KEY");
                timer1.Stop();
                start.Visible = true;
                stop.Visible = false;

            }

            
        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled=false;
            start.Visible = true;
            stop.Visible = false;
        }

        private void Xkeybox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
