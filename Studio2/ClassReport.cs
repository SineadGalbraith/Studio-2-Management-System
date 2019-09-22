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
    public partial class ClassReport : Form
    {
        public ClassReport()
        {
            InitializeComponent();
            //Center the for to the middle of the screen.
            CenterToScreen();
        }

        //Crete the connection string.
        private static string _connectionString =
                    ConfigurationManager.ConnectionStrings["Studio2ConnectionString"].ConnectionString;

        private void ClassReport_Load(object sender, EventArgs e)
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Try to...
            try
            {
                //Call the Search method.
                Search();
            }
            //Catch any exceptions that may occur and display an error message.
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Search()
        {
            //If txtClassID is not empty.
            if (txtClassID.Text != "")
            {
                //If txtClassDate is not empty.
                if (txtClassDate.Text != "")
                {
                    //This method will check that the ClassID is valid.
                    using (SqlConnection connection = new SqlConnection(_connectionString))
                    {
                        using (SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) FROM Class WHERE (ClassID = @ClassID)", connection))
                        {
                            connection.Open();
                            sqlCommand.Parameters.AddWithValue("@ClassID", txtClassID.Text);
                            int _class = (int)sqlCommand.ExecuteScalar();
                            bool classExist = false;
                            if (_class > 0)
                            {
                                classExist = true;
                                //If classExist is true.
                                if (classExist)
                                {
                                    //Call the CheckDate method.
                                    CheckDate();
                                }
                                //Otherwise display the message below.
                                else
                                {
                                    MessageBox.Show("Class does not exist.");
                                }
                            }
                            //Otherwise display the message below.
                            else
                            {
                                MessageBox.Show("Class does not exist.");
                            }
                        }
                    }
                }
                //Otherwise display the message below.
                else
                {
                    MessageBox.Show("Please enter a Class Date.");
                }
            }
            //Otherwise display the message below.
            else
            {
                MessageBox.Show("Please enter a ClassID.");
            }
        }

        private void CheckDate()
        {
            //Convert and save the text in txtClassDate to the DateTime variable date.
            DateTime date = Convert.ToDateTime(txtClassDate.Text);
            //Save the current date to the variable today.
            DateTime today = DateTime.Today;
            //Save the day that is represented in the ClassID to the variable day.
            string day = txtClassID.Text.Substring(4, 2).ToUpper();
            //If the day is Monday and the date entered is Monday...
            if (day == "MO" && date.DayOfWeek != DayOfWeek.Monday)
            {
                //Otherwise. display the message below.
                MessageBox.Show("The Class Date must be a Monday.");
            }
            //If the day is Tuesday and the date entered is Tuesday...
            else if (day == "TU" && date.DayOfWeek != DayOfWeek.Tuesday)
            {
                //Otherwise. display the message below.
                MessageBox.Show("The Class Date must be a Tuesday.");
            }
            //If the day is Wednesday and the date entered is Wednesday...
            else if (day == "WE" && date.DayOfWeek != DayOfWeek.Wednesday)
            {
                //Otherwise. display the message below.
                MessageBox.Show("The Class Date must be a Wednesday.");
            }
            //If the day is Thursday and the date entered is Thursday...
            else if (day == "TH" && date.DayOfWeek != DayOfWeek.Thursday)
            {
                //Otherwise. display the message below.
                MessageBox.Show("The Class Date must be a Thursday.");
            }
            //If the day is Friday and the date entered is Friday...
            else if (day == "FR" && date.DayOfWeek != DayOfWeek.Friday)
            {
                //Otherwise. display the message below.
                MessageBox.Show("The Class Date must be a Friday.");
            }
            //If the day is Saturday and the date entered is Saturday...
            else if (day == "SA" && date.DayOfWeek != DayOfWeek.Saturday)
            {
                //Otherwise. display the message below.
                MessageBox.Show("The Class Date must be a Saturday.");
            }
            //If the day is Sunday and the date entered is Sunday...
            else if (day == "SU" && date.DayOfWeek != DayOfWeek.Sunday)
            {
                //Otherwise. display the message below.
                MessageBox.Show("The Class Date must be a Sunday.");
            }
            //Otherwise
            else
            {
                //Call the Report method.
                Report();
            }
        }

        private void Report()
        {
            // TODO: This line of code loads data into the 'DataSetClass.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DataSetClass.DataTable1, txtClassID.Text);
            //Refresh the report.
            this.reportViewerClass.RefreshReport();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Create a new instance of the SearchClass screen.
            SearchClass searchClass = new SearchClass();
            //Show the SearchClass screen.
            searchClass.Show();
            //Hide this screen.
            Hide();
        }
    }
}
