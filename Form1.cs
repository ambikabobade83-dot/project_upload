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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aDMINSTRATORLOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AminstratorLogin al = new AminstratorLogin();
            al.Show();
            this.Hide();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs au = new AboutUs();
            au.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void eMPLOYEELOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
