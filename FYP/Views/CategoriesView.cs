using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FYP.Views;

namespace FYP
{
    public partial class CategoriesView : UserControl
    {
        public CategoriesView()
        {
            InitializeComponent();
        }

        private void btnSymmetric_Click(object sender, EventArgs e)
        {
            SymmetricCategory uc_symmetricCategory = new SymmetricCategory();
            //MainForm.Instance.securityalgorithm.setCategoryName("Symmetric");
            this.Hide();
            MainForm.Instance.LoadView(uc_symmetricCategory);
           /* uc_symmetricCategory.Dock = DockStyle.Fill;

            MainForm.Instance.panelContain.Controls.Add(uc_symmetricCategory);
            MainForm.Instance.panelContain.Controls["SymmetricCategory"].BringToFront();
            MainForm.Instance.panelContain.Controls["SelectCategory"].Dispose();

    */
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

        private void btnAsymmetric_Click(object sender, EventArgs e)
        {
            AsymmetricAlgoCategories uc_asymmetricAlgoCategories = new AsymmetricAlgoCategories();
            MainForm.Instance.LoadView(uc_asymmetricAlgoCategories);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            HashingCategoryView uc_hashingCategoryView = new HashingCategoryView();
            MainForm.Instance.panelContain.Controls["CategoriesView"].Dispose();

            MainForm.Instance.LoadView(uc_hashingCategoryView);
        }

        private void CategoriesView_Load(object sender, EventArgs e)
        {

        }
    }
}
