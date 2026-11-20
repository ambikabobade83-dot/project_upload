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
    public partial class AminstratorLogin : Form
    {
        public AminstratorLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Please Fill all the Fields");
            }
            else
            {
                String str = "DSN=HRMS";
                OdbcConnection conn = new OdbcConnection(str);
                String strComm = "select username,password from employeeDetails where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'";
                OdbcCommand cmd = new OdbcCommand(strComm, conn);
                OdbcDataReader dr;
                conn.Open();
                try
                {

                    int i;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        MessageBox.Show("Valid Username and Password");
                        AdminDashboard ad = new AdminDashboard();
                        ad.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid UserName and password");
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
        }
    }
}
