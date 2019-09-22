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
    public partial class MemberBookings : Form
    {
        public MemberBookings()
        {
            InitializeComponent();
            //Center the form to the middle of the screen.
            CenterToScreen();
            //Call the GetID method.
            GetID();
            //Call the ClassIDs method.
            ClassIDs();
            //Call the Reset method.
            Reset();
            
        }

        //Create the connection string.
        private static string _connectionString =
                    ConfigurationManager.ConnectionStrings["Studio2ConnectionString"].ConnectionString;

        private void GetID()
        {
            //Call the getBookingID method from the Bookings class and save the ID as the variable newBookingsID.
            int newBookingID = Bookings.getBookingID();
            //Convert the BookingID to a string and display the new ID in lblDisplayBookingID along with the letters "BKG" before it.
            lblDisplayBookingID.Text = "BKG" + Convert.ToString(newBookingID);
        }

        public void ClassIDs()
        {
            //Call the getClassID method from the Bookings form and save it in a list.
            List<string> ids = Bookings.getClassID();
            {
                foreach (string id in ids)
                {
                    //Add each ID to the combobox.
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
            //Catch any exception that may occur and display an error message.
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Search()
        {
            //If txtMemberID is not empty.
            if (txtMemberID.Text != "")
            {
                //If cbClassID does not display "Please Select..."
                if (cbClassID.Text != "Please Select...")
                {
                    //If the value on the date time picker is not in the past.
                    if (dateTimePickerClass.Value >= DateTime.Today)
                    {
                        //This method will check if the MemberID is valid.
                        using (SqlConnection connection = new SqlConnection(_connectionString))
                        {
                            using (SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) FROM Member WHERE (MemberID = @MemberID)", connection))
                            {
                                connection.Open();
                                sqlCommand.Parameters.AddWithValue("@MemberID", txtMemberID.Text);
                                int member = (int)sqlCommand.ExecuteScalar();
                                bool memberExist = false;
                                string memberID = txtMemberID.Text;
                                int _memberID = int.Parse(txtMemberID.Text);
                                if (member > 0)
                                {
                                    memberExist = true;
                                    //If memberExist is true...
                                    if (memberExist)
                                    {
                                        //Call the CheckDate method.
                                        CheckDate();
                                    }
                                }
                                //Otherwise display the message below.
                                else
                                {
                                    MessageBox.Show("Member does not exist.");
                                }
                            }
                        }
                    }
                    //Otherwise display the message below.
                    else
                    {
                        MessageBox.Show("The class date must be either today or in the future.");
                    }
                }
                //Otherwise display the message below.
                else
                {
                    MessageBox.Show("Please enter a ClassID.");           
                }
            }
            //Otherwise display the message below.
            else
            {
                MessageBox.Show("Please enter a MemberID.");
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
                //Call the SearchMember method.
                SearchMember();
                //Call the SearchClass method.
                SearchClass();
                //Call the changeDataGridView method.
                changeDataGridView();
            }
        }
        
        private void SearchMember()
        {
            //Call the getMemberForename method from the Bookings Class and pass across the data.
            List<string> fnames = Bookings.getMemberForename(txtMemberID.Text);
            {
                //If the amount of names is greater than 0...
                if (fnames.Count > 0)
                {
                    //Create an instance of the stringbuilder class.
                    StringBuilder stringb = new StringBuilder();

                    foreach (string fname in fnames)
                    {
                        stringb.AppendLine(fname);
                        //Display the name in lblDisplayForename.
                        lblDisplayForename.Text = fname;
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
                    StringBuilder string_b = new StringBuilder();

                    foreach (string sname in snames)
                    {
                        string_b.AppendLine(sname);
                        //Display the forname and surname in lblDisplaySurname.
                        lblDisplaySurname.Text = sname;
                    }
                }
            }

            //Call the getMemberStreet method from the Bookings Class and pass across the data.
            List<string> streets = Bookings.getMemberStreet(txtMemberID.Text);
            {
                //If the amount of streets is greater than 0...
                if (streets.Count > 0)
                {
                    //Create an instance of the stringbuilder class.
                    StringBuilder s_b = new StringBuilder();

                    foreach (string street in streets)
                    {
                        s_b.AppendLine(street);
                        //Display the postcode in lblDisplayStreet.
                        lblDisplayStreet.Text = street;
                    }
                }
            }

            //Call the getMemberTown method from the Bookings Class and pass across the data.
            List<string> towns = Bookings.getMemberTown(txtMemberID.Text);
            {
                //If the amount of towns is greater than 0...
                if (towns.Count > 0)
                {
                    //Create an instance of the stringbuilder class.
                    StringBuilder stringbuild = new StringBuilder();

                    foreach (string town in towns)
                    {
                        stringbuild.AppendLine(town);
                        //Display the postcode in lblDisplayTown.
                        lblDisplayTown.Text = town;
                    }
                }
            }

            //Call the getMemberCounty method from the Bookings Class and pass across the data.
            List<string> counties = Bookings.getMemberCounty(txtMemberID.Text);
            {
                //If the amount of counties is greater than 0...
                if (counties.Count > 0)
                {
                    //Create an instance of the stringbuilder class.
                    StringBuilder sbuild = new StringBuilder();

                    foreach (string county in counties)
                    {
                        sbuild.AppendLine(county);
                        //Display the postcode in lblDisplayCounty.
                        lblDisplayCounty.Text = county;
                    }
                }
            }

            //Call the getMemberPostCode method from the Bookings Class and pass across the data.
            List<string> pcs = Bookings.getMemberPostCode(txtMemberID.Text);
            {
                //If the amount of postcodes is greater than 0...
                if (pcs.Count > 0)
                {
                    //Create an instance of the stringbuilder class.
                    StringBuilder stbuilder = new StringBuilder();

                    foreach (string pc in pcs)
                    {
                        stbuilder.AppendLine(pc);
                        //Display the postcode in lblDisplayPostCode.
                        lblDisplayPostCode.Text = pc;
                    }
                }
            }
        }
        
        private void SearchClass()
        {
            //Call the getClassName method from the Class class and pass the text in txtClassID.
            List<string> names = Bookings.getClassName(cbClassID.Text);
            {
                //If the amount of names is greater than 0...
                if(names.Count > 0)
                {
                    //Create a new instance of the stringbuilder class.
                    StringBuilder sb = new StringBuilder();

                    foreach (string name in names)
                    {
                        sb.AppendLine(name);
                        //Display the class name in lblDisplayName.
                        lblDisplayName.Text = name;
                    }
                }
            }

            //Call the getClassDay method from the Class class and pass the text in txtClassID
            List<string> days = Bookings.getClassDay(cbClassID.Text);
            {
                //If the amount of days is greater than 0...
                if (days.Count > 0)
                {
                    //Create a new instance of the stringbuilder class.
                    StringBuilder _stringB = new StringBuilder();

                    foreach (string day in days)
                    {
                        _stringB.AppendLine(day);
                        //Display the day in lblDisplayDay.
                        lblDisplayDay.Text = day;
                    }
                }
            }

            //Call the getClassTime method from the Class class and pass the text in txtClassID
            List<string> times = Class.getClassTime(cbClassID.Text);
            {
                //If the amount of times is greater than 0...
                if (times.Count > 0)
                {
                    //Create a new instance of the stringbuilder class.
                    StringBuilder _stringBuilder = new StringBuilder();

                    foreach (string time in times)
                    {
                        _stringBuilder.AppendLine(time);
                        //Display the time in lblDisplayTime.
                        lblDisplayTime.Text = time;
                    }
                }
            }
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
            //If the date picked is greater than one month in advance...
            if (dateTimePickerClass.Value >= DateTime.Now.AddMonths(1))
            {
                //Display the message below.
                MessageBox.Show("You cannot book more than a month in advance.");
                //Reset the date to the current date.
                dateTimePickerClass.Value = DateTime.Now;
                //Call the Reset method.
                Reset();
            }
            else
            {
                //Call the CheckMember method from the Bookings class and pass across the data.
                List<int> members = Bookings.CheckMember(cbClassID.Text, dateTimePickerClass.Value);
                //Convert the list to a Data Table.
                DataTable memberData = ConvertListToDataTable(members);

                dataGridViewBooking.DataSource = memberData;
                dataGridViewBooking.Columns[0].HeaderText = "Member ID";
                //Count the amount of spaces left in the class.
                int count = dataGridViewBooking.RowCount - 1;
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
                    //The save button will disappear.
                    btnSave.Visible = false;
                }
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
        private void dataGridViewBooking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (dataGridViewBooking.CurrentCell.ColumnIndex.Equals(0))
                if (dataGridViewBooking.CurrentCell != null && dataGridViewBooking.CurrentCell.Value != null)
                {
                    int cell = Convert.ToInt32(dataGridViewBooking.CurrentCell.Value);
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
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            //If txtMemberID is not empty...
            if (txtMemberID.Text != "")
            {
                //Call the AddBookings class.
                AddBookings();
            }
            //Otherwise, display the message below.
            else
            {
                MessageBox.Show("Please enter a MemberID.");
            }
        }

        private void AddBookings()
        {
            //If the BookingDate is not in the past...
            if (Convert.ToDateTime(txtBookingDate.Text) >= DateTime.Today)
            {
                //Try to...
                try
                {
                    //Call the Add Booking Method from the Bookings table and pass across the data.
                    int rowsAffected = Bookings.AddBooking(txtMemberID.Text, dateTimePickerClass.Value.ToString("yyyy-MM-dd"), txtBookingDate.Text, cbClassID.Text);

                    if (rowsAffected > 0)
                    {
                        //If the Booking has been added successfully, display the message below.
                        MessageBox.Show("Class has been booked successfully.");
                        //Call the GetID method.
                        GetID();
                        //Call the Reset method.
                        Reset();
                    }
                }
                //Catch any possible exceptions and display an error message.
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            //Otherwise, display the message below.
            else
            {
                MessageBox.Show("The booking date cannot be in the past.");
            }
        }
        
        private void btnClear_Click(object sender, EventArgs e)
        {
            //Call the Reset method/
            Reset();
        }
        
        private void btnBack_Click(object sender, EventArgs e)
        {
            //Create a new instance of the BookingsMenu screen.
            BookingsMenu bookingsMenu = new BookingsMenu();
            //Show the BookingsMenu Screen.
            bookingsMenu.Show();
            //Hide this screen.
            Hide();
        }

        private void Reset()
        {
            //Set the Booking Date as the current date.
            txtBookingDate.Text = Convert.ToString(DateTime.Today.ToString("yyyy-MM-dd"));
            //Set the textboxes to be empty.
            txtMemberID.Text = "";
            lblDisplayForename.Text = "";
            lblDisplaySurname.Text = "";
            lblDisplayStreet.Text = "";
            lblDisplayTown.Text = "";
            lblDisplayCounty.Text = "";
            lblDisplayPostCode.Text = "";
            //Set the text in the combobox as "Please Select..."
            cbClassID.Text = "Please Select...";
            lblDisplayName.Text = "";
            lblDisplayDay.Text = "";
            lblDisplayTime.Text = "";
            //Set the date in the date time picker as todays date.
            dateTimePickerClass.Value = DateTime.Now;
            //Clear the data grid view.
            dataGridViewBooking.DataSource = null;
            lblDisplayNumber.Text = "";
        }

        private void txtBookingDate_TextChanged(object sender, EventArgs e)
        {
            //If the BookingDate is not the current date...
            if (txtBookingDate.Text != Convert.ToString(DateTime.Today.ToString("yyyy-MM-dd")))
            {
                //Display the message below.
                MessageBox.Show("The booking date must be today.");
                //Reset the Booking Date to the current date.
                txtBookingDate.Text = Convert.ToString(DateTime.Today.ToString("yyyy-MM-dd"));
            }
        }
    }
}


