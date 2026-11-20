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
    public partial class AddEmployee : Form
    {
        int Emp_id=0;
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
           /* String str = "DSN=HRMS";
            OdbcConnection conn = new OdbcConnection(str);
            String strComm = "select max(Employee_Id) from employeeDetails ";
            OdbcCommand cmd = new OdbcCommand(strComm, conn);
            OdbcDataReader dr;
            conn.Open();
            try
            {

              
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    int Emp_id = (dr.GetInt32 (0));
                    Emp_id++;
                   label15.Text = Emp_id.ToString ();
                   // Semp_id = label15.Text;
                }
                else
                {
                    MessageBox.Show("Invalid UserName ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }*/

            label15.Text = GenerateID();
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

        private bool IsTenDigitNumber(string input)
        {
            return input.Length == 10 && input.All(char.IsDigit);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Please Fill All the Fields");
            }
            else
            {
                string input = textBox4.Text.Trim(); // Get the text from the TextBox and trim any leading/trailing whitespace
               


               if(IsTenDigitNumber(input))
               {
                        string email = textBox5.Text;
                        if (IsValidEmail(email))
                        {

                            String password = textBox9.Text.Trim(); // Replace "user-entered-password" with the actual user input 

                            bool isPasswordValid = ValidatePassword(password);

                            if (textBox9.Text.Trim().Equals(textBox10.Text.Trim()))
                            {
                                if (isPasswordValid)
                                {
                                    int empid = Convert.ToInt32(label15.Text);
                                    String str = "DSN=HRMS";
                                    OdbcConnection conn = new OdbcConnection(str);
                                    String strComm = "insert into employeeDetails values(" + empid + ",'" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + comboBox2.SelectedItem.ToString() + "','" + comboBox3.SelectedItem.ToString() + "','" + textBox8.Text + "','" + textBox9.Text + "')";
                                    OdbcCommand cmd = new OdbcCommand(strComm, conn);
                                    conn.Open();
                                    try
                                    {
                                        cmd.ExecuteNonQuery();
                                        MessageBox.Show("Employee Registered Successfully");
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("" + ex);
                                    }
                                }
                                else
                                {

                                    MessageBox.Show("Minimum 8 characters, at least one number, and at least one special character ");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please Confirm Correct Password");
                            }
                        }

                        else
                        {

                            MessageBox.Show("Please Enter Valid Email ID");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter 10 Digits Mobile Number");
                    }
               

            }
        }
        
        private bool IsInteger(string input)
        {
            int result;
            return int.TryParse(input, out result);
        }
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
        public String GenerateID()
        {
            Random rnd = new Random();
            string randomNumber = string.Empty;

            for (int i = 0; i < 8; i++)
            {
                randomNumber += rnd.Next(0, 10).ToString();
            }
            return randomNumber;
        }

        private void aBOUTUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs au = new AboutUs();
            au.Show();
            this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        
        }
         static bool ValidatePassword(string password)
        {
            // Minimum 8 characters, at least one number, and at least one special character 
            string pattern = @"^(?=.*[0-9])(?=.*[^a-zA-Z0-9]).{8,}$";

            Match match = Regex.Match(password, pattern);

            return match.Success;
        }

         private void button2_Click(object sender, EventArgs e)
         {

         } 
                     
    }
}
