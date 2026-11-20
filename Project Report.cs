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
    public partial class Project_Report : Form
    {
        public Project_Report()
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

        private void Project_Report_Load(object sender, EventArgs e)
        {
            String str = "DSN=HRMS";
            OdbcConnection conn = new OdbcConnection(str);
            String strComm = "select * from ProjectDetails";
            OdbcCommand cmd = new OdbcCommand(strComm, conn);
            OdbcDataReader dr;
            conn.Open();
            try
            {


                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Invalid User Name an");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void aBOUTUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs au = new AboutUs();
            au.Show();
            this.Hide();
        }
    }
}
