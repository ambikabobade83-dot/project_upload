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
    public partial class AddEmployeeSalary : Form
    {
        public AddEmployeeSalary()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

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

        private void comboBox1_Click(object sender, EventArgs e)
        {

        }

        private void AddEmployeeSalary_Load(object sender, EventArgs e)
        {
            String str = "DSN=HRMS";
            OdbcConnection conn = new OdbcConnection(str);
            String strComm = "select Employee_Id from employeeDetails ";
            OdbcCommand cmd = new OdbcCommand(strComm, conn);
            OdbcDataReader dr;
            conn.Open();
            try
            {

                int i;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        comboBox1.Items.Add(dr.GetInt32(0));
                    }
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
        private bool IsInteger(string input)
        {
            int result;
            return int.TryParse(input, out result);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter amount Field");
            }
            else
            {
                if (IsInteger(textBox1.Text.Trim()))
                {

                    String str = "DSN=HRMS";
                    OdbcConnection conn = new OdbcConnection(str);
                    String strComm = "insert into SalaryDetails values('" + comboBox1.Text + "','" + monthCalendar1.TodayDateSet.ToString() + "','" + textBox1.Text + "')";
                    OdbcCommand cmd = new OdbcCommand(strComm, conn);
                    conn.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registerd succ");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter numeric value in amount field");
                }

            }
        }
        private void aBOUTUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs au = new AboutUs();
            au.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
