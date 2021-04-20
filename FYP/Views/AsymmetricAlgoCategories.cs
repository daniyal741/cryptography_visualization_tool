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
    public partial class AsymmetricAlgoCategories : UserControl
    {
        public AsymmetricAlgoCategories()
        {
            InitializeComponent();
            
            panel4.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CategoriesView uc_categoriesView = new CategoriesView();
            uc_categoriesView.Dock = DockStyle.Fill;
            MainForm.Instance.panelContain.Controls.Add(uc_categoriesView);
            MainForm.Instance.panelContain.Controls["CategoriesView"].BringToFront();

        }

        private void btn_Hellman_Click(object sender, EventArgs e)
        {
            Deffie_HellmanVisualization uc_deffie_HellmanVisualization = new Deffie_HellmanVisualization();
            uc_deffie_HellmanVisualization.Dock = DockStyle.Fill;
            MainForm.Instance.panelContain.Controls.Add(uc_deffie_HellmanVisualization);
            MainForm.Instance.panelContain.Controls["Deffie_HellmanVisualization"].BringToFront();
        }

        private void AsymmetricAlgoCategories_Load(object sender, EventArgs e)
        {
        
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
           
        }

        private void bar1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bar3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void manIntheMiddleATTACK_Click(object sender, EventArgs e)
        {
            ManInTheMiddleAttack1 uc_manInTheMiddleAttack1 = new ManInTheMiddleAttack1();
            uc_manInTheMiddleAttack1.Dock = DockStyle.Fill;
            MainForm.Instance.panelContain.Controls.Add(uc_manInTheMiddleAttack1);
            MainForm.Instance.panelContain.Controls["ManInTheMiddleAttack1"].BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DemoRSA uc_demoRSA = new DemoRSA();
            uc_demoRSA.Dock = DockStyle.Fill;
            MainForm.Instance.panelContain.Controls.Add(uc_demoRSA);
            MainForm.Instance.panelContain.Controls["DemoRSA"].BringToFront();
        }
    }
}
