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
    public partial class plian_tex_Informaion : UserControl
    {
       public string input_plain;
        public plian_tex_Informaion()
        {
            InitializeComponent();
        }
        public plian_tex_Informaion(AES_VISUALIZATION_1 obj)
        {
            InitializeComponent();
            input_plain = obj.input_Text;
            plainMessage.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            MainForm.Instance.panelContain.Controls["AES_VISUALIZATION_1"].BringToFront();
            MainForm.Instance.panelContain.Controls["plian_tex_Informaion"].Dispose();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void plian_tex_Informaion_Load(object sender, EventArgs e)
        {
            plainMessage.Text = input_plain.ToString();
        }
    }
}
