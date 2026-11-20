using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Text.RegularExpressions;

namespace HRMS
{
    public partial class AdminChangePassword : Form
    {
        public AdminChangePassword()
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

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Please fill all the fields ");
            }
            else
            {

                String password = textBox2.Text; // Replace "user-entered-password" with the actual user input 

                bool isPasswordValid = ValidatePassword(password);

                if (textBox2.Text.Trim().Equals(textBox3.Text.Trim()))
                {
                    if (isPasswordValid)
                    {
                        String str = "DSN=HRMS";
                        OdbcConnection conn = new OdbcConnection(str);
                        String strComm = "update employeeDetails set password='" + textBox2.Text + "' where password='" + textBox1.Text + "'";
                        OdbcCommand cmd = new OdbcCommand(strComm, conn);
                        conn.Open();
                        try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Password Changed Successfully");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("" + ex);
                        }
                    }
                    else
                    {

                        MessageBox.Show("Please Enter Minimum 8 characters, at least one number, and at least one special character ");
                    }

                }
                else
                {
                    MessageBox.Show("Enter Password Correctly");
                }

            }
        }

        private void aBOUTUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs au = new AboutUs();
            au.Show();
            this.Hide();
        }

        static bool ValidatePassword(string password)
        {
            // Minimum 8 characters, at least one number, and at least one special character 
            string pattern = @"^(?=.*[0-9])(?=.*[^a-zA-Z0-9]).{8,}$";

            Match match = Regex.Match(password, pattern);

            return match.Success;
        } 
    }
}
