using FYP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYP
{
    public partial class MainForm : Form
    {

        static MainForm Formobj;


        public string path;




        public Panel panelContain
        {
            get { return panelContainer; }
            set { panelContainer = value; }

        }


        public static MainForm Instance
        {
            get
            {
                if (Formobj == null)
                {
                    Formobj = new MainForm();


                }


                return Formobj;
            }
        }




        public MainForm()
        {
            InitializeComponent();
            CategoriesView uc_selectCategory = new CategoriesView();
            LoadView(uc_selectCategory);
            string workingPath = Environment.CurrentDirectory;
            path = Directory.GetParent(workingPath).Parent.FullName;
        }



        public void LoadView(UserControl uc)
        {
            panelContainer.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
        }

  

        public void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Formobj = this;
        }


        public void setValues(String plain,String key,char t)
        {
            SecurityAlgorithm.Instance.setPlaintext(plain);

        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            /*panelContainer.Controls.Clear();
            CategoriesView uc_selectCategory = new CategoriesView();
            uc_selectCategory.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc_selectCategory);
            */

            
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.05;

            }
            else {

                timer1.Stop();
                timer1.Dispose();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
