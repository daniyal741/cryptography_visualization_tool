using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYP.Views
{
    public partial class HashingCategoryView : UserControl
    {
        public HashingCategoryView()
        {
            InitializeComponent();
        }

        private void HashingCategoryView_Load(object sender, EventArgs e)
        {
        }

        private void btnMD5_Click(object sender, EventArgs e)
        {
            MD5_View us_md5 = new MD5_View();
            MainForm.Instance.LoadView(us_md5);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CategoriesView uc_selectCategory = new CategoriesView();
            uc_selectCategory.Dock = DockStyle.Fill;


            MainForm.Instance.panelContain.Controls.Add(uc_selectCategory);
            MainForm.Instance.panelContain.Controls["CategoriesView"].BringToFront();
            MainForm.Instance.panelContain.Controls["HashingCategoryView"].Dispose();

        }

        private void btnNonKey_Click(object sender, EventArgs e)
        {
            panel6.SendToBack();
            btnMD5.Visible = true;
            btnSHA.Visible = true;
        }

        private void btnSHA_Click(object sender, EventArgs e)
        {
            Sha512_View uc = new Sha512_View();
            MainForm.Instance.LoadView(uc);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            panel7.SendToBack();
            btnHMAC.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HMAC_View uc = new HMAC_View();
            MainForm.Instance.LoadView(uc);
        }
    }
}
