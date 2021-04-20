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
    public partial class CategoriesOfCaeserCipher : UserControl
    {
        public CategoriesOfCaeserCipher()
        {
            InitializeComponent();
        }

        private void btn_Symmetric_Click(object sender, EventArgs e)
        {
            CaesarCipherView obj = new CaesarCipherView();
            obj.Dock = DockStyle.Fill;
            MainForm.Instance.panelContain.Controls.Add(obj);
            MainForm.Instance.panelContain.Controls["CaesarCipherView"].BringToFront();
            MessageBox.Show("Please Enter A Key Between 0 to 26 Otherwise Key Will Be Automatically 25");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            multiplicativeCeaserCipherView obj = new multiplicativeCeaserCipherView();
            obj.Dock = DockStyle.Fill;
            MainForm.Instance.panelContain.Controls.Add(obj);
            MainForm.Instance.panelContain.Controls["multiplicativeCeaserCipherView"].BringToFront();
            MessageBox.Show("Key has only 12 memebrs : 1,3,5,7,9,11,15,17,19,21,23,25");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SymmetricCategory obj = new SymmetricCategory();
            obj.Dock = DockStyle.Fill;
            MainForm.Instance.panelContain.Controls.Add(obj);
            MainForm.Instance.panelContain.Controls["SymmetricCategory"].BringToFront();
        }
    }
}
