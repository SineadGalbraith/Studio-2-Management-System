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
    public partial class SearchBookings : Form
    {
        string _fname;
        public SearchBookings()
        {
            InitializeComponent();
            //Center the form to the middle of the screen.
            CenterToScreen();
            //Call the ClassIDs method.
            ClassIDs();
        }

        //Create the connection string.
        private static string _connectionString =
                    ConfigurationManager.ConnectionStrings["Studio2ConnectionString"].ConnectionString;

        public void ClassIDs()
        {
            //Call the getClassIDs method from the BookingsClass and save into a list.
            List<string> IDs = Bookings.getClassIDs();
            {
                foreach (string id in IDs)
                {
                    //Add each ID into cbClassID.
                    cbClassID.Items.Add(id);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Try to...
            try
            {
                //Call the Search method.
                Search();
            }
            //Catch any exceptions that occur and display a message below.
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Search()
        {
            //If txtBookingID is not empty.
            if (txtBookingID.Text != "")
            {
                //This method will check if the BookingID is valid.
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) FROM Booking WHERE (BookingID = @BookingID)", connection))
                    {
                        connection.Open();
                        sqlCommand.Parameters.AddWithValue("@BookingID", txtBookingID.Text);
                        int booking = (int)sqlCommand.ExecuteScalar();
                        bool bookingExist = false;
                        if (booking > 0)
                        {
                            bookingExist = true;
                            //If bookingExist is true.
                            if (bookingExist)
                            {
                                //Call the getBookingDate method from the Bookings Class and pass across the data.
                                List<DateTime> bDates = Bookings.getBookingDate(txtBookingID.Text);
                                {
                                    //If the amount of bookingsDates is greater than 0...
                                    if (bDates.Count > 0)
                                    {
                                        //Create an instance of the stringbuilder class.
                                        StringBuilder string_Builder = new StringBuilder();

                                        foreach (DateTime date in bDates)
                                        {
                                            string_Builder.AppendLine(Convert.ToString(date));
                                            //Display and convert the BookingDate in lblDisplayBookingDate.
                                            lblDisplayBookingDate.Text = Convert.ToString(date.ToString("yyyy-MM-dd"));
                                        }
                                    }
                                }

                                //Call the getMemberID method from the Bookings Class and pass across the data.
                                List<int> ids = Bookings.getMemberID(txtBookingID.Text);
                                {
                                    //If the amount of IDs is greater than 0...
                                    if (ids.Count > 0)
                                    {
                                        //Create an instance of the stringbuilder class.
                                        StringBuilder _sb = new StringBuilder();
                                        foreach (int id in ids)
                                        {
                                            _sb.AppendLine(Convert.ToString(id));
                                            //Display the ID in lblMemberID.
                                            txtMemberID.Text = Convert.ToString(id);
                                        }
                                    }
                                }

                                //Call the getMemberForename method from the Bookings Class and pass across the data.
                                List<string> fnames = Bookings.getMemberForename(txtMemberID.Text);
                                {
                                    //If the amount of names is greater than 0...
                                    if (fnames.Count > 0)
                                    {
                                        //Create an instance of the stringbuilder class.
                                        StringBuilder stringBuilder = new StringBuilder();
                                        foreach (string fname in fnames)
                                        {
                                            stringBuilder.AppendLine(fname);
                                            //Display the name in lblDisplayName.
                                            lblDisplayName.Text = fname;
                                            //Save the name into the variable _fname.
                                            _fname = lblDisplayName.Text;
                                        }
                                    }
                                }

                                //Call the getBookingSurname method from the Bookings Class and pass across the data.
                                List<string> snames = Bookings.getMemberSurname(txtMemberID.Text);
                                {
                                    //If the amount of names is greater than 0...
                                    if (snames.Count > 0)
                                    {
                                        //Create an instance of the stringbuilder class.
                                        StringBuilder string_Builder = new StringBuilder();
                                        foreach (string sname in snames)
                                        {
                                            string_Builder.AppendLine(sname);
                                            //Display the forname and surname in lblDisplayName.
                                            lblDisplayName.Text = _fname + " " + sname;
                                        }
                                    }
                                }

                                //Call the getMemberPostCode method from the Bookings Class and pass across the data.
                                List<string> postCodes = Bookings.getMemberPostCode(txtMemberID.Text);
                                {
                                    //If the amount of postcodes is greater than 0...
                                    if (postCodes.Count > 0)
                                    {
                                        //Create an instance of the stringbuilder class.
                                        StringBuilder string_Builder = new StringBuilder();
                                        foreach (string pc in postCodes)
                                        {
                                            string_Builder.AppendLine(pc);
                                            //Display the postcode in lblDisplayPostCode.
                                            lblDisplayPostCode.Text = pc;
                                        }
                                    }
                                }

                                //Call the getClassID method from the Bookings Class and pass across the data.
                                List<string> classIDs = Bookings.getClassID(txtBookingID.Text);
                                {
                                    //If the amount of IDs is greater than 0...
                                    if (classIDs.Count > 0)
                                    {
                                        //Create an instance of the stringbuilder class.
                                        StringBuilder s_b = new StringBuilder();
                                        foreach (string id in classIDs)
                                        {
                                            s_b.AppendLine(id);
                                            //Display the ClassID in lblClassID.
                                            cbClassID.Text = id;
                                        }
                                    }
                                }

                                //Call the getClassName method from the Bookings Class and pass across the data.
                                List<string> classNames = Bookings.getClassName(cbClassID.Text);
                                {
                                    //If the amount of names is greater than 0...
                                    if(classNames.Count > 0)
                                    {
                                        //Create an instance of the stringbuilder class.
                                        StringBuilder string_b = new StringBuilder();
                                        foreach (string name in classNames)
                                        {
                                            string_b.AppendLine(name);
                                            //Display the name in lblDisplayClassName.
                                            lblDisplayClassName.Text = name;
                                        }
                                    }
                                }

                                //Call the getClassDay method from the Bookings Class and pass across the data.
                                List<string> classDays = Bookings.getClassDay(cbClassID.Text);
                                {
                                    //If the amount of days is greater than 0...
                                    if (classDays.Count > 0)
                                    {
                                        //Create an instance of the stringbuilder class.
                                        StringBuilder string_build = new StringBuilder();
                                        foreach (string day in classDays)
                                        {
                                            string_build.AppendLine(day);
                                            //Display the day in lblDisplayDay.
                                            lblDisplayDay.Text = day;
                                        }
                                    }
                                }

                                //Call the getClassTime method from the Bookings Class and pass across the data.
                                List<string> classTimes = Bookings.getClassTime(cbClassID.Text);
                                {
                                    //If the amount of times is greater than 0...
                                    if (classTimes.Count > 0)
                                    {
                                        //Create an instance of the stringbuilder class.
                                        StringBuilder s_builder = new StringBuilder();
                                        foreach (string time in classTimes)
                                        {
                                            s_builder.AppendLine(time);
                                            //Display the time in lblDisplayTime.
                                            lblDisplayTime.Text = time;
                                        }
                                    }
                                }

                                //Call the getClassDate method from the Bookings Class and pass across the data.
                                List<DateTime> classDates = Bookings.getClassDate(txtBookingID.Text);
                                {
                                    //If the amount of dates is greater than 0...
                                    if (classDates.Count > 0)
                                    {
                                        //Create an instance of the stringbuilder class.
                                        StringBuilder string_builder = new StringBuilder();

                                        foreach (DateTime c_date in classDates)
                                        {
                                            string_builder.AppendLine(Convert.ToString(c_date));
                                            //Display the ClassDate in dateTimePickerClass.
                                            dateTimePickerClass.Value = c_date;
                                        }
                                    }
                                }
                            }
                            //Otherwise display the message below.
                            else
                            {
                                MessageBox.Show("This booking does not exist.");
                            }
                        }
                        //Otherwise display the message below.
                        else
                        {
                            MessageBox.Show("This booking does not exist.");
                        }
                        
                    }
                }
            }
            //Otherwise display the message below.
            else
            {
                MessageBox.Show("Please enter a BookingID.");

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //If txtBookingID, txtMemberID and txtClassID are not empty...
            if (txtBookingID.Text != "" && txtMemberID.Text != "" && cbClassID.Text != "")
            {
                //If the date on the date tiem picker is not in the past.
                if (dateTimePickerClass.Value >= DateTime.Today)
                {
                    //Call the CheckDate method.
                    CheckDate();
                }
                //Otherwise display the message below.
                else
                {
                    MessageBox.Show("You cannot book a class that is in the past.");
                }
            }
            //Otherwise display the message below.
            else
            {
                MessageBox.Show("Please enter a BookingID.");
            }
        }

        private void CheckDate()
        {
            //Save the day that is represented in the ClassID to the variable day.
            string day = cbClassID.Text.Substring(4, 2).ToUpper();
            //If the day is Monday and the date entered is Monday...
            if (day == "MO" && dateTimePickerClass.Value.DayOfWeek != DayOfWeek.Monday)
            {
                //Otherwise. display the message below.
                MessageBox.Show("The Class Date must be a Monday.");
            }
            //If the day is Tuesday and the date entered is Tuesday...
            else if (day == "TU" && dateTimePickerClass.Value.DayOfWeek != DayOfWeek.Tuesday)
            {
                //Otherwise. display the message below.
                MessageBox.Show("The Class Date must be a Tuesday.");
            }
            //If the day is Wednesday and the date entered is Wednesday...
            else if (day == "WE" && dateTimePickerClass.Value.DayOfWeek != DayOfWeek.Wednesday)
            {
                //Otherwise. display the message below.
                MessageBox.Show("The Class Date must be a Wednesday.");
            }
            //If the day is Thursday and the date entered is Thursday...
            else if (day == "TH" && dateTimePickerClass.Value.DayOfWeek != DayOfWeek.Thursday)
            {
                //Otherwise. display the message below.
                MessageBox.Show("The Class Date must be a Thursday.");
            }
            //If the day is Friday and the date entered is Friday...
            else if (day == "FR" && dateTimePickerClass.Value.DayOfWeek != DayOfWeek.Friday)
            {
                //Otherwise. display the message below.
                MessageBox.Show("The Class Date must be a Friday.");
            }
            //If the day is Saturday and the date entered is Saturday...
            else if (day == "SA" && dateTimePickerClass.Value.DayOfWeek != DayOfWeek.Saturday)
            {
                //Otherwise. display the message below.
                MessageBox.Show("The Class Date must be a Saturday.");
            }
            //If the day is Sunday and the date entered is Sunday...
            else if (day == "SU" && dateTimePickerClass.Value.DayOfWeek != DayOfWeek.Sunday)
            {
                //Otherwise. display the message below.
                MessageBox.Show("The Class Date must be a Sunday.");
            }
            //Otherwise
            else
            {
                //Call the EditBooking method.
                EditBooking();
            }
        }

        private void EditBooking()
        {
            //Try to...
            try
            {
                //Call the EditBooking method from the Bookings Class and pass across the data.
                int rowsAffected = Bookings.EditBooking(Convert.ToInt32(txtBookingID.Text), cbClassID.Text);

                if (rowsAffected > 0)
                {
                    //If the Booking has been edited successfully display the message below.
                    MessageBox.Show("Booking edited successfully.");
                    //Call the Reset button.
                    Reset();
                }
            }
            //Catch any exception which may occur and display an error message.
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //If txtBookingID, txtMemberID and txtClassID are not empty...
            if (txtBookingID.Text != "" && txtMemberID.Text != "" && cbClassID.Text != "")
            {
                //Call the DeleteBooking method.
                DeleteBooking();
            }
            //Otherwise. display the message below.
            else
            {
                MessageBox.Show("Please enter a BookingID.");
            }
        }

        private void DeleteBooking()
        {
            //Try to...
            try
            {
                //Call the DeleteBooking method from the Bookings Class and pass across the data.
                int rowsAffected = Bookings.DeleteBooking(txtBookingID.Text);

                if (rowsAffected > 0)
                {
                    //If the Booking has been deleted successfully, displaythe message below.
                    MessageBox.Show("Booking deleted successfully.");
                    //Call the reset method.
                    Reset();
                }
            }
            //Catch any exception which may occur and display an error message.
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Call the Reset method.
            Reset();
        }

        private void Reset()
        {
            //Reset all textboxes to be empty.
            txtBookingID.Text = "";
            lblDisplayBookingDate.Text = "";
            txtMemberID.Text = "";
            lblDisplayName.Text = "";
            lblDisplayPostCode.Text = "";
            cbClassID.Text = "";
            lblDisplayClassName.Text = "";
            lblDisplayDay.Text = "";
            lblDisplayTime.Text = "";
            //Reset the date time picker value to be the current date.
            dateTimePickerClass.Value = DateTime.Today;
            //Call the ClassIDs method.
            ClassIDs();
        }

        private void cbClassID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Call the getClassName method from the Bookings Class and pass across the data.
            List<string> classNames = Bookings.getClassName(cbClassID.Text);
            {
                //If the amount of names is greater than 0...
                if (classNames.Count > 0)
                {
                    //Create an instance of the stringbuilder class.
                    StringBuilder string_b = new StringBuilder();
                    foreach (string name in classNames)
                    {
                        string_b.AppendLine(name);
                        //Display the name in lblDisplayClassName.
                        lblDisplayClassName.Text = name;
                    }
                }
            }

            //Call the getClassDay method from the Bookings Class and pass across the data.
            List<string> classDays = Bookings.getClassDay(cbClassID.Text);
            {
                //If the amount of days is greater than 0...
                if (classDays.Count > 0)
                {
                    //Create an instance of the stringbuilder class.
                    StringBuilder string_build = new StringBuilder();
                    foreach (string day in classDays)
                    {
                        string_build.AppendLine(day);
                        //Display the day in lblDisplayDay.
                        lblDisplayDay.Text = day;
                    }
                }
            }

            //Call the getClassTime method from the Bookings Class and pass across the data.
            List<string> classTimes = Bookings.getClassTime(cbClassID.Text);
            {
                //If the amount of times is greater than 0...
                if (classTimes.Count > 0)
                {
                    //Create an instance of the stringbuilder class.
                    StringBuilder s_builder = new StringBuilder();
                    foreach (string time in classTimes)
                    {
                        s_builder.AppendLine(time);
                        //Display the time in lblDisplayTime.
                        lblDisplayTime.Text = time;
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Create a new instance of the BookingsMenu screen.
            BookingsMenu bookingsMenu = new BookingsMenu();
            //Show the BookingsMenu.
            bookingsMenu.Show();
            //Hide this Screen.
            Hide();
        }
    }
}
