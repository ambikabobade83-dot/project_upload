using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;

namespace HRMS
{
    public partial class AddProjects : Form
    {
        public AddProjects()
        {
            InitializeComponent();
        }

        private void aDDEMPLOYEEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmployee ae = new AddEmployee();
            ae.Show();
            this.Hide();
        }

        private void aDDSALARYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmployeeSalary ae = new AddEmployeeSalary();
            ae.Show();
            this.Hide();
        }

        private void aDDPROJECTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProjects ap = new AddProjects();
            ap.Show();
            this.Hide();
        }

        private void eMPLOYEEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeReport er = new EmployeeReport();
            er.Show();
            this.Hide();
        }

        private void sALARYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalaryReport sr = new SalaryReport();
            sr.Show();
            this.Hide();
        }

        private void pROJECTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project_Report pr = new Project_Report();
            pr.Show();
            this.Hide();
        }

        private void cHANGEPASSWORDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminChangePassword ac = new AdminChangePassword();
            ac.Show();
            this.Hide();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Please enter all the fields ");
            }
            else
            {

                String str = "DSN=HRMS";
                OdbcConnection conn = new OdbcConnection(str);
                String strComm = "insert into projectDetails values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.SelectedItem.ToString() + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                OdbcCommand cmd = new OdbcCommand(strComm, conn);
                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("project Details Added Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }

        }

        private void aBOUTUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs au = new AboutUs();
            au.Show();
            this.Hide();
        }

        private void AddProjects_Load(object sender, EventArgs e)
        {

        }
    }
}
