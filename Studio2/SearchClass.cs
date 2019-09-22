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
    public partial class SearchClass : Form
    {
        public SearchClass()
        {
            InitializeComponent();
            //Center the form on the screen.
            CenterToScreen();
            //Call the reset method.
            Reset();
        }

        //Create the connection string.
        private static string _connectionString =
                    ConfigurationManager.ConnectionStrings["Studio2ConnectionString"].ConnectionString;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Try to...
            try
            {
                //Call the Search method...
                Search();
            }
            //Catch any exceptions and display an error message.
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Search()
        {
            //If txtClassID is not empty...
            if (txtClassID.Text != "")
            {
                //If txtClassDate is not empty...
                if (txtDate.Text != "")
                {
                    //Call the CheckDate method.
                    CheckDate();
                }
                //Otherwise display the message below.
                else
                {
                    MessageBox.Show("Please enter a ClassDate to search.");
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
            //Convert and save the text in txtDate to the DateTime variable date.
            DateTime date = Convert.ToDateTime(txtDate.Text);
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
                //Call the ClassSearch method.
                ClassSearch();
            }
        }

        private void ClassSearch()
        {
            //This method will check that the ClassID enter is valid.
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
                        //If classExist is true...
                        if (classExist)
                        {
                            //Call the changeDataGridView...
                            changeDataGridView();
                            //Call the getClassName method from the Class class and pass the text in txtClassID.
                            List<string> names = Class.getClassName(txtClassID.Text);
                            {
                                //If the amount of names is greater than 0...
                                if (names.Count > 0)
                                {
                                    //Create a new instance of the stringbuilder class.
                                    StringBuilder sb = new StringBuilder();

                                    foreach (string name in names)
                                    {
                                        sb.AppendLine(name);
                                        //Display the class name in txtClassName.
                                        txtClassName.Text = name;
                                    }
                                }
                            }
                            //Call the getClassDay method from the Class class and pass the text in txtClassID
                            List<string> days = Class.getClassDay(txtClassID.Text);
                            {
                                //If the amount of days is greater than 0...
                                if (days.Count > 0)
                                {
                                    //Create a new instance of the stringbuilder class.
                                    StringBuilder sb = new StringBuilder();

                                    foreach (string day in days)
                                    {
                                        sb.AppendLine(day);
                                        //Display the day in cbDay.
                                        cbDay.Text = day;
                                    }
                                }
                            }

                            //Call the getClassTime method from the Class class and pass the text in txtClassID
                            List<string> times = Class.getClassTime(txtClassID.Text);
                            {
                                //If the amount of times is greater than 0...
                                if (times.Count > 0)
                                {
                                    //Create a new instance of the stringbuilder class.
                                    StringBuilder sb = new StringBuilder();

                                    foreach (string time in times)
                                    {
                                        sb.AppendLine(time);
                                        //Display the time in cbTime.
                                        cbTime.Text = time;
                                    }
                                }
                            }

                            //Call the getClassLevel method from the Class class and pass the text in txtClassID
                            List<string> levels = Class.getClassLevel(txtClassID.Text);
                            {
                                //If the amount of levels is greater than 0...
                                if (levels.Count > 0)
                                {
                                    //Create a new instance of the stringbuilder class.
                                    StringBuilder sb = new StringBuilder();

                                    foreach (string level in levels)
                                    {
                                        sb.AppendLine(level);
                                        //Display the level in cbLevel.
                                        cbLevel.Text = level;
                                    }
                                }
                            }
                            //Call the displayStaffID method from the StaffClass class and pass the text in txtClassID
                            List<int> ids = StaffClass.displayStaffID(txtClassID.Text);
                            {
                                //If the amount of IDs is greater than 0...
                                if (ids.Count > 0)
                                {
                                    //Create a new instance of the stringbuilder class.
                                    StringBuilder _sb = new StringBuilder();
                                    foreach (int id in ids)
                                    {
                                        _sb.AppendLine(Convert.ToString(id));
                                        //Display the ID in txtStaffID.
                                        txtStaffID.Text = Convert.ToString(id);
                                    }
                                }
                            }
                            //Call the displaysupportingStaffID method from the StaffClass class and pass the text in txtClassID
                            List<int> supportids = StaffClass.displaySupportingStaffID(txtClassID.Text);
                            {
                                //If the amount of IDs is greater than 0...
                                if (ids.Count > 0)
                                {
                                    //Create a new instance of the stringbuilder class.
                                    StringBuilder _sb1 = new StringBuilder();
                                    foreach (int id in supportids)
                                    {
                                        _sb1.AppendLine(Convert.ToString(id));
                                        //Display the ID in txtSupportingID.
                                        txtSupportingID.Text = Convert.ToString(id);
                                    }
                                }
                            }
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
        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //If txtClassID is not empty...
            if (txtClassID.Text != "")
            {
                //If txtDate is not empty...
                if (txtDate.Text != "")
                {
                    //Call the Check method.
                    Check();
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

        private void Check()
        {
            //Save the text in txtClassName to the variable className.
            string className = txtClassName.Text;
            //Save the text in cbLevel to the variable level.
            string level = cbLevel.Text;
            //Save the text in cbDay to the variable day.
            string day = cbDay.Text;

            //If the StaffID is not the same as the SupportingID...
            if (txtStaffID.Text != txtSupportingID.Text)
            {
                //If txtClassName is not empty.
                if (txtClassName.Text != "")
                {
                    //If the first letter of the ClassID is the same as the first letter of the Description.
                    if (className.Substring(0, 1).ToUpper() == txtClassID.Text.Substring(0, 1).ToUpper())
                    {
                        //If cbDay is not empty.
                        if (cbDay.Text != "")
                        {
                            //If the first two letters of the class Day and the 5th and 6th letters of the ClassID are equal...
                            if (cbDay.Text.Substring(0, 2).ToUpper() == txtClassID.Text.Substring(4, 2).ToUpper())
                            {
                                //If cbTime is not empty.
                                if (cbTime.Text != "")
                                {
                                    //If cbLevel is not empty.
                                    if (cbLevel.Text != "")
                                    {
                                        //Call the CheckTime method.
                                        CheckTime();

                                    }
                                    //Otherwise. display the message below.
                                    else
                                    {
                                        MessageBox.Show("Please choose a Class Level.");
                                    }
                                }
                                //Otherwise. display the message below.
                                else
                                {
                                    MessageBox.Show("Please choose a Class Time.");
                                }
                            }
                            //Otherwise. display the message below.
                            else
                            {
                                MessageBox.Show("The fifth and sixth letters of the ClassID must be the same as the first two letters of day.");
                            }
                        }
                        //Otherwise. display the message below.
                        else
                        {
                            MessageBox.Show("Please choose a Class Day.");

                        }
                    }
                    //Otherwise. display the message below.
                    else
                    {
                        MessageBox.Show("The first letter of the ClassID must be the same as the first letter of the Class Name.");
                    }
                }
                //Otherwise. display the message below.
                else
                {
                    MessageBox.Show("Please enter a Class Name.");
                }
            }
            //Otherwise. display the message below.
            else
            {
                MessageBox.Show("The StaffID and the SupportingID cannot be the same.");
            }
        }
        
        private void CheckTime()
        {
            //Save the last letter of the ClassID to the variable timeOfDay.
            string timeOfDay = txtClassID.Text.Substring(6, 1);
            //Convert the text in cbTime to DateTime and save it in the variable time.
            DateTime time = Convert.ToDateTime(cbTime.Text);
            //Save the time 12:00:00 to the variable twelve.
            DateTime twelve = Convert.ToDateTime("12:00:00");
            //Save the time 17:00:00 to the variable five.
            DateTime five = Convert.ToDateTime("17:00:00");
            //If the time of day is "M", the value in class time must be before 12pm, if the time of day is A, the value in 
            //class time must be between 12pm and 5pm and if the time of day is "E", the value in class time must be after 5pm.
            if ((timeOfDay == "M" && time < twelve) || (timeOfDay == "A" && (time > twelve && time < five)) ||
                (timeOfDay == "E" && (time > five)))
            {
                //If the fourth letter of the ClassID and the first letter of the ClassLevel are the same...
                if (cbLevel.Text.Substring(0, 1).ToUpper() == txtClassID.Text.Substring(3, 1).ToUpper())
                {
                    //Call the EditClass method.
                    EditClass();
                }
                //Otherwise, display the message below.
                else
                {
                    MessageBox.Show("The last letter of the ClassID must be the first letter of the level of class.");
                }
            }
            //Otherwise, display the message below.
            else
            {
                MessageBox.Show("The last letter of the ClassID must be M (before 12pm), A (between 12pm and 5pm) or E(after 5pm).");
            }
        }

        private void EditClass()
        {
            //Try...
            try
            {
                //Call the EditClass method from the Class class and pass across the data.
                int rowsAffected = Class.EditClass(txtClassID.Text, txtClassName.Text, cbTime.Text, cbDay.Text, cbLevel.Text);
                if (rowsAffected > 0)
                {
                    //If the Class has been edited successfully display the message below.
                    MessageBox.Show("Class has been edited successfully.");
                    //Call the reset method.
                    Reset();
                }
            }
            //Catch any exceptions that may occur and display an error message.
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //If txtClassID is not empty...
            if (txtClassID.Text != "")
            {
                //If txtDate is not empty...
                if (txtDate.Text != "")
                {
                    //Call the DeleteStaffClass method.
                    DeleteStaffClass();
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

        private void DeleteStaffClass()
        {
            //Try...
            try
            {
                //Call the DeleteStaffClass method from the Class class and pass across the data.
                int rowsAffected = Class.DeleteStaffClass(txtClassID.Text);

                if (rowsAffected > 0)
                {
                    //If the StaffClass has been deleted successfully call the Delete Class method.
                    DeleteClass();
                }
            }
            //Catch any exceptions that may occur and display an error message.
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteClass()
        {
            //Try...
            try
            {
                //Call the DeleteClass method from the Class class and pass across the data.
                int rowsAffected = Class.DeleteClass(txtClassID.Text);

                if (rowsAffected > 0)
                {
                    //If the Class has been deleted successfully call the Delete Class method.
                    MessageBox.Show("Class deleted successfully.");
                    //Call the Reset method.
                    Reset();
                }
            }
            //Catch any exceptions that may occur and display an error message.
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Reset()
        {
            //Reset all texboxes to be empty.
            //Reset all comboboxes to display "Please Select..."
            txtClassID.Text = "";
            txtDate.Text = "";
            txtClassName.Text = "";
            cbDay.Text = "Please Select...";
            cbTime.Text = "Please Select...";
            cbLevel.Text = "Please Select...";
            txtStaffID.Text = "";
            txtSupportingID.Text = "";
            //Reset the data grid view to be blank.
            dataGridViewClass.DataSource = null;
        }
        
        public static DataTable ConvertListToDataTable(List<int> members)
        {
            //Create a new instance of the Data Table class.
            DataTable table = new DataTable();

            //Declare the variable columns and make it 1.
            int columns = 1;

            //As i increments...
            for (int i = 0; i < columns; i++)
            {
                //Add a column.
                table.Columns.Add();
            }

            foreach (var member in members)
            {
                //Add a row for each member.
                table.Rows.Add(member);
            }

            //Return the Data Table.
            return table;
        }

        private void changeDataGridView()
        {
            //Call the CheckMember method from the Bookings class and pass across the data.
            List<int> members = Bookings.CheckMember(txtClassID.Text, Convert.ToDateTime(txtDate.Text));

            //Convert the list to a Data Table.
            DataTable memberData = ConvertListToDataTable(members);

            dataGridViewClass.DataSource = memberData;
            dataGridViewClass.Columns[0].HeaderText = "Member ID";
            //Count the amount of spaces left in the class.
            int count = dataGridViewClass.RowCount - 1;
            int amountLeft = 15 - count;
            //If there are spaces left in the class...
            if (amountLeft > 0)
            {
                //Display the number of spaces along with a message.
                lblDisplayNumber.Text = "Number of spaces left: " + Convert.ToString(amountLeft);
            }
            //Otherwise...
            else
            {
                //Display the message below.
                lblDisplayNumber.Text = "There are no spaces left in this class.";
                //Call the Blink method.
                Blink();
            }
        }

        //This method makes lblDisplayNumber blink red and black whenever the class is fully booked.
        private async void Blink()
        {
            while (true)
            {
                await Task.Delay(500);
                lblDisplayNumber.ForeColor = lblDisplayNumber.ForeColor == Color.Black ? Color.Red : Color.Black;
            }
        }

        //When a cell in the data grid view is clicked on, this method finds the forenames and surnames of all the members who are booked for that class
        //and returns the as a list. Then, when a cell is clicked on, the MemberForename and MemberSurname appear in a Message Box.
        private void dataGridViewClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (dataGridViewClass.CurrentCell.ColumnIndex.Equals(0))
                if (dataGridViewClass.CurrentCell != null && dataGridViewClass.CurrentCell.Value != null)
                {
                    int cell = Convert.ToInt32(dataGridViewClass.CurrentCell.Value);
                    List<string> mSurnames = Bookings.getMemberSurname(Convert.ToString(cell));
                    if (mSurnames.Count > 0)
                    {
                        StringBuilder sb = new StringBuilder();
                        foreach (string surname in mSurnames)
                        {
                            sb.AppendLine(Convert.ToString(mSurnames));
                        }
                        ;

                        List<string> mForenames = Bookings.getMemberForename(Convert.ToString(cell));
                        {
                            if (mForenames.Count > 0)
                            {
                                StringBuilder sb1 = new StringBuilder();
                                foreach (string fornames in mForenames)
                                {
                                    sb.AppendLine(Convert.ToString(mForenames));
                                }
                                string membername = mForenames[0] + " " + mSurnames[0];
                                MessageBox.Show(membername);
                            }
                        }
                    }
                }
        }

        

        

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Call the Reset method.
            Reset();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Create a new instance of the ClassMenu screen.
            ClassMenu classMenu = new ClassMenu();
            //Show the ClassMenu.
            classMenu.Show();
            //Hide this screen.
            Hide();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            //Create a new instance of the ClassReport screen.
            ClassReport classReport = new ClassReport();
            //Show the ClassReport screen.
            classReport.Show();
            //Hide this screen.
            Hide();
        }

        

       
    }
}   


