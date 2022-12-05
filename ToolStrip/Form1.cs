using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolStrip
{
    public partial class Form1 : Form
    {
        int size = 12;
        public Form1()
        {
            InitializeComponent();
        }

        private void tstbtext_TextChanged(object sender, EventArgs e)
        {
            this.lbl.Text = tstbtext.Text;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.lbl.Font = new Font("tahoma", size);
            size += 4;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (size == 0)
            {
                size = 12;
            }
            this.lbl.Font = new Font("tahoma", size);
            size -= 4;
        }
    }
}
