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
using FYP.Views;

namespace FYP
{
    public partial class SymmetricCategory : UserControl
    {
        static bool flagSubstitutionClick = false;
        static bool flagTranspositionClick = false;
        static bool flagClassicalClick = false;

        public SymmetricCategory()
        {
            InitializeComponent();
        }

        private void btnClassical_Click(object sender, EventArgs e)
        {
            btnSubstitution.Visible = true;
            //MainForm.Instance.securityalgorithm.setAlgoType("Classical");
        }

        private void btnSubstitution_Click(object sender, EventArgs e)
        {
            if (flagSubstitutionClick == false)
            {

                btnCaesarCipher.Visible = true;
                btnVigenere.Visible = true;
                btnOneTimePad.Visible = true;
                mainBar.Visible = true;
                bar1.Visible = true;
                bar2.Visible = true;
                bar3.Visible = true;

                flagSubstitutionClick = true;

            }
            else {

                btnCaesarCipher.Visible = false;
                btnVigenere.Visible = false;
                btnOneTimePad.Visible = false;
                mainBar.Visible = false;
                bar1.Visible = false;
                bar2.Visible = false;
                bar3.Visible = false;

                flagSubstitutionClick = false;

            }
        }

        private void btnCaesarCipher_Click(object sender, EventArgs e)
        {
            CategoriesOfCaeserCipher uc_caesarCipher = new CategoriesOfCaeserCipher();
            // MainForm.Instance.securityalgorithm.setAlgorithmName("AdditiveCaesarCipher");
            uc_caesarCipher.Dock = DockStyle.Fill;
            MainForm.Instance.LoadView(uc_caesarCipher);
           


            /*
            MainForm.Instance.panelContain.Controls.Add(uc_caesarCipher);
            MainForm.Instance.panelContain.Controls["CaesarCipher"].BringToFront();
            MainForm.Instance.panelContain.Controls["SymmetricCategory"].Dispose();
          */
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
            MainForm.Instance.panelContain.Controls["SymmetricCategory"].Dispose();

        }

        private void SymmetricCategory_Load(object sender, EventArgs e)
        {

        }

        private void btnOneTimePad_Click(object sender, EventArgs e)
        {
             OneTimePadView uc_oneTimePadView = new OneTimePadView();
            uc_oneTimePadView.Dock = DockStyle.Fill;
            MainForm.Instance.LoadView(uc_oneTimePadView);

            
        }

        private void btnVigenere_Click(object sender, EventArgs e)
        {
            
             VigenereCipher uc_oneTimePadView = new VigenereCipher();
            uc_oneTimePadView.Dock = DockStyle.Fill;
            MainForm.Instance.LoadView(uc_oneTimePadView);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnDES.Visible = true;
            btn3DES.Visible = true;
            btnAES.Visible = true;
            panel4.Visible = true;
            panel3.Visible = true;
            panel2.Visible = true;
            panel1.Visible = true;
        }

        private void btnDES_Click(object sender, EventArgs e)
        {
            DES_View uc_des = new DES_View();
            MainForm.Instance.LoadView(uc_des);
        }

        private  void btnAES_Click(object sender, EventArgs e)
        {
            AES_Viualization uc_aes = new AES_Viualization();
           
            MainForm.Instance.LoadView(uc_aes);
          //  await Task.Delay(500);


        }

        private void btn3DES_Click(object sender, EventArgs e)
        {
            TripleDesView uc_des = new TripleDesView();
            MainForm.Instance.LoadView(uc_des);
        }
    }
}
