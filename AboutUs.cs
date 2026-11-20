using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HRMS
{
    public partial class AboutUs : Form
    {
        public AboutUs()
        {
            InitializeComponent();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void aDMINSTRATORLOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AminstratorLogin al = new AminstratorLogin();
            al.Show();
            this.Hide();
        }

        private void AboutUs_Load(object sender, EventArgs e)
        {

        }
    }
}
