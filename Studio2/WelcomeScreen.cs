using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Studio2.Properties;
using System.Configuration;
using System.Data.SqlClient;

namespace Studio2
{
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
            //Centre the form to the middle of the screen.
            CenterToScreen();
        }

        //Create connection string.
        private static string _connectionString =
                    ConfigurationManager.ConnectionStrings["Studio2ConnectionString"].ConnectionString;

        //Create click event for btnEnter.
        private void btnEnter_Click(object sender, EventArgs e)
        {
            //If txtUsername is not empty...
            if (txtUsername.Text != "")
            {
                //If txtPassword is not empty...
                if (txtPassword.Text != "")
                {
                    //This section of code ensures that whatever StaffID is entered into the textbox is valid.
                    using (SqlConnection connection = new SqlConnection(_connectionString))
                    {
                        using (SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) FROM Staff WHERE (StaffID = @StaffID)", connection))
                        {
                            connection.Open();
                            sqlCommand.Parameters.AddWithValue("@StaffID", txtUsername.Text);
                            int user = (int)sqlCommand.ExecuteScalar();
                            bool userExist = false;
                            string staffID = txtUsername.Text;
                            int _staffID = int.Parse(txtUsername.Text);
                            string password = txtPassword.Text;
                            if (user > 0)
                            {
                                //If the password enters matches "Admin_Studio2"...
                                if (password == "Admin_Studio2")
                                {
                                    //Set the userExist variable to true.
                                    userExist = true;
                                    //If userExist is true...
                                    if (userExist)
                                    {
                                        //Create a new instance of the Studio2Menu screen.
                                        Studio2Menu studio2Menu = new Studio2Menu();
                                        //Show the Studio2 Menu screen.
                                        studio2Menu.Show();
                                        //Hide the Studio2 Menu screen.
                                        Hide();
                                    }
                                    //Otherwise, display a message telling the user that the username is invalid.
                                    else
                                    {
                                        MessageBox.Show("Invalid username.");
                                    }
                                //Otherwise, display a message telling the user that the password is incorrect.
                                }
                                else
                                {
                                    MessageBox.Show("Incorrect password.");
                                }
                            }
                            //Otherwise, display a message telling the user that the username is invalid.
                            else
                            {

                                MessageBox.Show("Invalid Username.");
                            }
                        }
                    }
                }
                //Otherwise, display a message asking the user to enter a password.
                else
                {
                    MessageBox.Show("Please enter a password.");
                }
            }
            //Otherwise, display a message asking the user to enter a username.
            else
            {
                MessageBox.Show("Please enter a username.");
            }
        }
    }
}
