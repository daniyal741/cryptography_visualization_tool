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
    public partial class DisplayPicture : UserControl
    {

        private PictureBox pic;
        public PictureBox Pic { get => pic; set => pic = value; }


        public DisplayPicture()
        {
            InitializeComponent();
            Pic = pictureBox1;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }
    }
}
