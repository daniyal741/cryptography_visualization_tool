using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYP
{
    class SyncRichTextBox : RichTextBox
    {

        public void SyncTextBox()
        {
            this.Multiline = true;
            this.ScrollBars = RichTextBoxScrollBars.Vertical;
        }
        int WM_MOUSEWHEEL = 0x20a; // or 522
        int WM_VSCROLL = 0x115; // or 277

        public Control[] Buddies { get; set; }
        private static bool scrolling;   // In case buddy tries to scroll us



        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            // Trap WM_VSCROLL message and pass to buddy
            if (Buddies != null)
            {
                foreach (Control ctr in Buddies)
                {
                    if (ctr != this)
                    {
                        if ((m.Msg == 0x115 || m.Msg == 0x20a) && !scrolling && ctr.IsHandleCreated)
                        {
                            scrolling = true;
                            SendMessage(ctr.Handle, m.Msg, m.WParam, m.LParam);
                            scrolling = false;
                        }
                    }
                }
            }

            //do the usual
        }
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

       
    }
}
