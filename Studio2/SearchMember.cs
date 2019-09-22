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
    public partial class SearchMember : Form
    {
        public SearchMember()
        {
            InitializeComponent();
            //Center the form to the middle of the screen.
            CenterToScreen();
            //Call the reset method.
            Reset();
            //Call the MembershipTypes method.
            MembershipTypes();
        }

        //Create the connection string.
        private static string _connectionString =
                    ConfigurationManager.ConnectionStrings["Studio2ConnectionString"].ConnectionString;

        public void MembershipTypes()
        {
            //Call the getMembershipID method in the Member class and save the results in a types list.
            List<string> types = Member.getMembershipID();
            {
                foreach (string type in types)
                {
                    //Add each membership type to cbMembershipType.
                    cbMembershipType.Items.Add(type);
                }
            }
        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Try..
            try
            {
                //Call the Search method.
                Search();
            }
            //If any exceptions occur, catch the exception and display a message.
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void Search()
        {
            //If txtMemberID is not empty, this method will check that the MemberID enter is valid.
            if (txtMemberID.Text != "")
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) FROM Member WHERE (MemberID = @MemberID)", connection))
                    {
                        connection.Open();
                        sqlCommand.Parameters.AddWithValue("@MemberID", txtMemberID.Text);
                        int member = (int)sqlCommand.ExecuteScalar();
                        bool memberExist = false;
                        if (member > 0)
                        {
                            memberExist = true;
                            //If memberExist is true...
                            if (memberExist)
                            {
                                //Call the getMemberForename method from the Member class and pass the text in txtMemberID.
                                List<string> fnames = Member.getMemberForename(txtMemberID.Text);
                                {
                                    //If the amount of names is greater than 0...
                                    if (fnames.Count > 0)
                                    {
                                        //Create a new instance of the stringbuilder class.
                                        StringBuilder stringb = new StringBuilder();
                                        foreach (string fname in fnames)
                                        {
                                            stringb.AppendLine(fname);
                                            //Display the forename in txtForename.
                                            txtForename.Text = fname;
                                        }
                                    }
                                }

                                //Call the getMemberSurname method from the Member class and pass the text in txtMemberID.
                                List<string> snames = Member.getMemberSurname(txtMemberID.Text);
                                {
                                    //If the amount of names is greater than 0...
                                    if (snames.Count > 0)
                                    {
                                        //Create a new instance of the stringbuilder class.
                                        StringBuilder string_b = new StringBuilder();

                                        foreach (string sname in snames)
                                        {
                                            string_b.AppendLine(sname);
                                            //Display the surname in txtSurname.
                                            txtSurname.Text = sname;
                                        }
                                    }
                                }

                                //Call the getMemberDOB method from the Member class and pass the text in txtMemberID.
                                List<DateTime> dobs = Member.getMemberDOB(txtMemberID.Text);
                                {
                                    //If the amount of dobs is greater than 0...
                                    if (dobs.Count > 0)
                                    {
                                        //Create a new instance of the stringbuilder class.
                                        StringBuilder stringBuilder = new StringBuilder();

                                        foreach (DateTime dob in dobs)
                                        {
                                            stringBuilder.AppendLine(Convert.ToString(dob));
                                            //Display and convert the dob in txtDOB.
                                            txtDOB.Text = Convert.ToString(dob.ToString("yyyy-MM-dd"));
                                        }
                                    }
                                }

                                //Call the getMemberGender method from the Member class and pass the text in txtMemberID.
                                List<string> genders = Member.getMemberGender(txtMemberID.Text);
                                {
                                    //If the amount of genders is greater than 0...
                                    if (genders.Count > 0)
                                    {
                                        //Create a new instance of the stringbuilder class.
                                        StringBuilder sbuilder = new StringBuilder();

                                        foreach (string gender in genders)
                                        {
                                            sbuilder.AppendLine(gender);
                                            //Display the gender in txtGender.
                                            txtGender.Text = gender;
                                        }
                                    }
                                }

                                //Call the getMemberStreet method from the Member class and pass the text in txtMemberID.
                                List<string> streets = Member.getMemberStreet(txtMemberID.Text);
                                {
                                    //If the amount of streets is greater than 0...
                                    if (streets.Count > 0)
                                    {
                                        //Create a new instance of the stringbuilder class.
                                        StringBuilder s_b = new StringBuilder();

                                        foreach (string street in streets)
                                        {
                                            s_b.AppendLine(street);
                                            //Display the street in txtStreet.
                                            txtStreet.Text = street;
                                        }
                                    }
                                }

                                //Call the getMemberTown method from the Member class and pass the text in txtMemberID.
                                List<string> towns = Member.getMemberTown(txtMemberID.Text);
                                {
                                    //If the amount of owns is greater than 0...
                                    if (towns.Count > 0)
                                    {
                                        //Create a new instance of the stringbuilder class.
                                        StringBuilder stringbuild = new StringBuilder();

                                        foreach (string town in towns)
                                        {
                                            stringbuild.AppendLine(town);
                                            //Display the town in txtTown.
                                            txtTown.Text = town;
                                        }
                                    }
                                }

                                //Call the getMemberCounty method from the Member class and pass the text in txtMemberID.
                                List<string> counties = Member.getMemberCounty(txtMemberID.Text);
                                {
                                    //If the amount of counties is greater than 0...
                                    if (counties.Count > 0)
                                    {
                                        //Create a new instance of the stringbuilder class.
                                        StringBuilder sbuild = new StringBuilder();

                                        foreach (string county in counties)
                                        {
                                            sbuild.AppendLine(county);
                                            //Display the county in txtCounty.
                                            txtCounty.Text = county;
                                        }
                                    }
                                }

                                //Call the getMemberPostCode method from the Member class and pass the text in txtMemberID.
                                List<string> pcs = Member.getMemberPostCode(txtMemberID.Text);
                                {
                                    //If the amount of postcodes is greater than 0...
                                    if (pcs.Count > 0)
                                    {
                                        //Create a new instance of the stringbuilder class.
                                        StringBuilder stbuilder = new StringBuilder();

                                        foreach (string pc in pcs)
                                        {
                                            stbuilder.AppendLine(pc);
                                            //Display the postcode in txtPostCode.
                                            txtPostCode.Text = pc;
                                        }
                                    }
                                }

                                //Call the getMemberPhone method from the Member class and pass the text in txtMemberID.
                                List<string> phones = Member.getMemberPhone(txtMemberID.Text);
                                {
                                    //If the amount of phone numbers is greater than 0...
                                    if (phones.Count > 0)
                                    {
                                        //Create a new instance of the stringbuilder class.
                                        StringBuilder builder = new StringBuilder();

                                        foreach (string phone in phones)
                                        {
                                            builder.AppendLine(phone);
                                            //Display the phoneNumber in txtPhoneNumber.
                                            txtPhoneNo.Text = phone;
                                        }
                                    }
                                }

                                //Call the getMemberEmail method from the Member class and pass the text in txtMemberID.
                                List<string> emails = Member.getMemberEmail(txtMemberID.Text);
                                {
                                    //If the amount of emails is greater than 0...
                                    if (emails.Count > 0)
                                    {
                                        //Create a new instance of the stringbuilder class.
                                        StringBuilder _stringb = new StringBuilder();

                                        foreach (string email in emails)
                                        {
                                            _stringb.AppendLine(email);
                                            //Display the email in txtEmail.
                                            txtEmail.Text = email;
                                        }
                                    }
                                }

                                //Call the getMembership method from the Member class and pass the text in txtMemberID.
                                List<string> memberships = Member.getMembership(txtMemberID.Text);
                                {
                                    //If the amount of memberships is greater than 0...
                                    if (memberships.Count > 0)
                                    {
                                        //Create a new instance of the stringbuilder class.
                                        StringBuilder _stringbuilder = new StringBuilder();

                                        foreach (string membership in memberships)
                                        {
                                            _stringbuilder.AppendLine(membership);
                                            //Display the membership type in cbMembershipType.
                                            cbMembershipType.Text = membership;
                                        }
                                    }
                                }

                                //Call the getStartDate method from the Member class and pass the text in txtMemberID.
                                List<DateTime> sDates = Member.getStartDate(txtMemberID.Text);
                                {
                                    //If the amount of start dates is greater than 0...
                                    if (sDates.Count > 0)
                                    {
                                        //Create a new instance of the stringbuilder class.
                                        StringBuilder string_Builder = new StringBuilder();

                                        foreach (DateTime date in sDates)
                                        {
                                            string_Builder.AppendLine(Convert.ToString(date));
                                            //Display and convert the startdate in txtStartDate.
                                            txtStartDate.Text = Convert.ToString(date.ToString("yyyy-MM-dd"));
                                        }
                                    }
                                }

                                //Call the getExpiryDate method from the Member class and pass the text in txtMemberID.
                                List<DateTime> eDates = Member.getExpiryDate(txtMemberID.Text);
                                {
                                    //If the amount of expiry dates is greater than 0...
                                    if (eDates.Count > 0)
                                    {
                                        //Create a new instance of the stringbuilder class.
                                        StringBuilder _string_Builder = new StringBuilder();

                                        foreach (DateTime edate in eDates)
                                        {
                                            _string_Builder.AppendLine(Convert.ToString(edate));
                                            //Display and convert the expirydate in txtExpiryDate.
                                            txtExpiryDate.Text = Convert.ToString(edate.ToString("yyyy-MM-dd"));
                                        }
                                    }
                                }
                            }
                            //Otherwise display the message below.
                            else
                            {
                                MessageBox.Show("Member does not exist.");
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
                MessageBox.Show("Please enter a MemberID.");
            }
            
        }
        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //If txtMemberID is not empty...
            if (txtMemberID.Text != "")
            {
                //If txtForename and txtSurname are not empty...
                if (txtForename.Text != "" && txtSurname.Text != "")
                {
                    //If txtDOB is not empty...
                    if (txtDOB.Text != "")
                    {
                        //If the text in txtGender is "M" or "F"...
                        if (txtGender.Text == "M" || txtGender.Text == "F")
                        {
                            //If txtStreet, txtTown and txtCounty are not empty...
                            if (txtStreet.Text != "" && txtTown.Text != "" && txtCounty.Text != "")
                            {
                                //If txtPhoneNo is not empty...
                                if (txtPhoneNo.Text != "")
                                    {
                                        //If the Phone Number is 11 characters.
                                        if (txtPhoneNo.Text.Length == 11)
                                        {
                                            //If the text in cbMembershipType is "Please Select..."
                                            if (cbMembershipType.Text == "Please select...")
                                            {
                                                //Display the message below.
                                                MessageBox.Show("Please choose a Membership Type.");
                                            }
                                            else
                                            {
                                                //Call the CheckPostcode method.
                                                CheckPostCode();
                                            }
                                        }
                                        //Otherwise display the message below.
                                        else
                                        {
                                            MessageBox.Show("The Phone Number must be 11 characters long.");
                                        }
                                    }
                                //Otherwise display the message below.
                                else
                                {
                                    MessageBox.Show("Please enter a Phone Number.");
                                }
                            }
                            //Otherwise display the message below.
                            else
                            {
                                MessageBox.Show("Please enter a Street, Town and County.");
                            }
                        }
                        //Otherwise display the message below.
                        else
                        {
                            MessageBox.Show("The Gender must be either 'M' or 'F'.");
                        }
                    }
                    //Otherwise display the message below.
                    else
                    {
                        MessageBox.Show("Please enter a Date of Birth.");
                    }
                }
                //Otherwise display the message below.
                else
                {
                    MessageBox.Show("Please enter a name and surname.");
                }
            }
            //Otherwise display the message below.
            else
            {
                MessageBox.Show("Please enter a MemberID.");
            }
        }

        private void CheckPostCode()
        {
            //Declare the variables below.
            string postCode = txtPostCode.Text;
            bool validNo, letter1, letter2;
            int num1, num2, num3;
            postCode = postCode.Replace(" ", "");

            //If the postcode is 7 characters long...
            if (postCode.Length == 7)
            {
                //Check that the first 2 letters of the postcode are BT
                if (postCode.Substring(0, 2).ToUpper() == "BT")
                {
                    string no = postCode.Substring(2, 3);
                    //Try to parse the 3rd to 5th characters.
                    validNo = Int32.TryParse(no, out num1);
                    //If the 3rd to 5th characters are numbers...
                    if (validNo)
                    {
                        string let1 = postCode.Substring(5, 1);
                        //Try to parse the 6th character.
                        letter1 = Int32.TryParse(let1, out num2);
                        //If the 6th character is not a number...
                        if (!letter1)
                        {
                            string let2 = postCode.Substring(6, 1);
                            //Try to parse the 7th character.
                            letter2 = Int32.TryParse(let2, out num3);
                            //If the 7th character is a number...
                            if (letter2)
                            {
                                //Display the message below.
                                MessageBox.Show("The last character must be a letter.");
                            }
                            else
                            {
                                //If the email address is valid or no email address has been entered...
                                if (ValidEmail(txtEmail.Text) || txtEmail.Text == "")
                                {
                                    //Call the CheckBirthday method.
                                    CheckBirthday();
                                }
                                //Otherwise display the message below.
                                else
                                {
                                    MessageBox.Show("Please enter a valid email address.");
                                }
                            }
                        }
                        //Otherwise display the message below.
                        else
                        {
                            MessageBox.Show("The second last character must be a letter.");
                        }
                    }
                    //Otherwise display the message below.
                    else
                    {
                        MessageBox.Show("There must be 3 numbers in the middle of the PostCode,");
                    }
                }
                //Otherwise display the message below.
                else
                {
                    MessageBox.Show("The PostCode must start with BT");
                }
            }
            //If the postcode is 6 characters long...
            else if (postCode.Length == 6)
            {
                //Check that the first 2 letters are BT.
                if (postCode.Substring(0, 2).ToUpper() == "BT")
                {
                    string no = postCode.Substring(2, 2);
                    //Try to parse the 3rd and 4th letters characters.
                    validNo = Int32.TryParse(no, out num1);
                    //If the 3rd and 4th characters are numbers...
                    if (validNo)
                    {
                        string let1 = postCode.Substring(4, 1);
                        //Try to parse the 5th character.
                        letter1 = Int32.TryParse(let1, out num2);
                        //If the 5th character is not a number...
                        if (!letter1)
                        {
                            string let2 = postCode.Substring(5, 1);
                            //Try to parse the 6th character.
                            letter2 = Int32.TryParse(let2, out num3);
                            //If the 6th character is a number...
                            if (letter2)
                            {
                                //Display the message below.
                                MessageBox.Show("The last character must be a letter.");
                            }
                            else
                            {
                                //If the email address is valid or no email address has been entered...
                                if (ValidEmail(txtEmail.Text) || txtEmail.Text == "")
                                {
                                    //Call the CheckBirthday method.
                                    CheckBirthday();
                                }
                                //Otherwise display the message below.
                                else
                                {
                                    MessageBox.Show("Please enter a valid email address.");
                                }
                            }
                        }
                        //Otherwise display the message below.
                        else
                        {
                            MessageBox.Show("The second last character must be a letter.");
                        }
                    }
                    //Otherwise display the message below.
                    else
                    {
                        MessageBox.Show("There must be 2 numbers in the middle of the PostCode,");
                    }
                }
                //Otherwise display the message below.
                else
                {
                    MessageBox.Show("The PostCode must start with BT");
                }
            }
            //Otherwise display the message below.
            else
            {
                MessageBox.Show("The PostCode must have 6 or 7 characters e.g. BT354GT");
            }
        }

        //This validation checks that the email address entered is valid. 
        public bool ValidEmail(string email)
        {
            //Try the validation check and see if the email is valid.
            try
            {
                var valEmail = new System.Net.Mail.MailAddress(email);
                //If the email address is valid, return the email address.
                return valEmail.Address == email;
            }
            //If an exception occurs, catch the exception and return false.
            catch
            {
                return false;
            }
        }

        private void CheckBirthday()
        {
            //If the first three letters of the MembershipTypeID are "CON"...
            if (cbMembershipType.Text.Substring(0, 3) == "CON")
            {
                //Assign the variable today to todays date.
                DateTime today = DateTime.Today;
                //Convert the text in txtDOB to DateTime.
                DateTime bday = Convert.ToDateTime(txtDOB.Text);
                //If the member is less than 60 years old...
                if (bday > today.AddYears(-60))
                {
                    //Display the message below.
                    MessageBox.Show("You must be over 60 to have the Membership Type: " + cbMembershipType.Text);
                }
                //Otherwise...
                else
                {
                    //Call the CheckAge method.
                    CheckAge();
                }
            }
            //Otherwise...
            else
            {
                //Call the CheckAge method.
                CheckAge();
            }
        }

        //This method checks the age of the Member.
        private void CheckAge()
        {
            //Convert the text in txtDOB to DateTime.
            DateTime birthday = Convert.ToDateTime(txtDOB.Text);
            //If the Member is not 16 years old...
            if (birthday > DateTime.Today.AddYears(-16))
            {
                //Display the message below.
                MessageBox.Show("You must be at least 16 to become a Member.");
            }
            //Otherwise, call the ExpiryDate method.
            else
            {
                ExpiryDate();
            }
        }

        private void ExpiryDate()
        {
            //Convert the text in txtStartDate to DateTime and save in the variable start.
            DateTime start = Convert.ToDateTime(txtStartDate.Text);
            //Save the date in six months to the variable sixMonths.
            DateTime sixMonths = DateTime.Today.AddMonths(6);
            //Save the date in one year to the variable twelveMonths.
            DateTime twelveMonths = DateTime.Today.AddYears(1);
            //If the fourth letter of the MembershipType is 6...
            if (cbMembershipType.Text.Substring(3, 1) == "6")
            {
                //Set the expiry date to the date saved in sixMonths.
                txtExpiryDate.Text = start.AddMonths(6).ToString("yyyy-MM-dd");
                //Call the EditMember method.
                EditMember();
            }
            //If the fourth letter of the MembershipType is 1...
            else if (cbMembershipType.Text.Substring(3, 1) == "1")
            {
                //Set the expiry date to the date saved in twelveMonths.
                txtExpiryDate.Text = start.AddYears(1).ToString("yyyy-MM-dd");
                //Call the EditMember method.
                EditMember();
            }
            //If the sixth letter of the MembershipType is 6...
            else if (cbMembershipType.Text.Substring(5, 1) == "6")
            {
                //Set the expiry date to the date saved in sixMonths.
                txtExpiryDate.Text = start.AddMonths(6).ToString("yyyy-MM-dd");
                //Call the EditMember method.
                EditMember();
            }
            //If the sixth letter of the MembershipType is 6...
            else if (cbMembershipType.Text.Substring(5, 1) == "1")
            {
                //Set the expiry date to the date saved in twelveMonths.
                txtExpiryDate.Text = start.AddYears(1).ToString("yyyy-MM-dd");
                //Call the EditMember method.
                EditMember();
            }
            //Otherwise
            else
            {
                //Display the message below.
                MessageBox.Show("Please choose a MembershipID.");
            }
        }

        private void EditMember()
        {
            //Convert the text in txtDOB to DateTime and save it in the variable dob.
            DateTime dob = Convert.ToDateTime(txtDOB.Text);
            //Try...
            try
            {
                //Call the EditMember method in the Member Class and pass the variables across.
                int rowsAffected = Member.EditMember(txtMemberID.Text, txtForename.Text, txtSurname.Text, dob.ToString("yyyy-MM-dd"), txtGender.Text,
                        txtStreet.Text, txtTown.Text, txtCounty.Text, txtPostCode.Text, txtPhoneNo.Text, txtEmail.Text, cbMembershipType.Text,
                        txtStartDate.Text, txtExpiryDate.Text);

                if (rowsAffected > 0)
                {
                    //If the Member has been edited successfully, display the message below.
                    MessageBox.Show("Member edited successfully.");
                    //Call the reset method.
                    Reset();
                }
            }
            //Catch any exceptions that may occur and dislay an error message.
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //If txtMemberID is not empty...
            if (txtMemberID.Text != "")
            {
                //Call the DeleteMember method.
                DeleteMember();
            }
            //Otherwise, display the message below.
            else
            {
                MessageBox.Show("Please enter a MemberID.");
            }
        }
        
        private void DeleteMember()
        {
            //Try...
            try
            {
                //Call the DeleteMember method from the Member class and pass the data in txtMember across.
                int rowsAffected = Member.DeleteMember(txtMemberID.Text);

                if (rowsAffected > 0)
                {
                    //If the member has been deleted successfully, display the message below.
                    MessageBox.Show("Member deleted successfully.");
                    //Call the Reset method.
                    Reset();
                }
            }
            //If any errors occur, catch the error and display an error message.
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Call the reset method.
            Reset();
        }
        
        private void Reset()
        {
            //Reset all of the textboxes to being empty.
            txtMemberID.Text = "";
            txtForename.Text = "";
            txtSurname.Text = "";
            txtDOB.Text = "";
            txtGender.Text = "";
            txtStreet.Text = "";
            txtTown.Text = "";
            txtCounty.Text = "";
            txtPostCode.Text = "";
            txtPhoneNo.Text = "";
            txtEmail.Text = "";
            cbMembershipType.Text = "";
            txtStartDate.Text = "";
            txtExpiryDate.Text = "";
        }
        
        private void btnBack_Click(object sender, EventArgs e)
        {
            //Create an instance of the MembersMenu form.
            MembersMenu membersMenu = new MembersMenu();
            //Show the MembersMenu form.
            membersMenu.Show();
            //Hide this form.
            Hide();
        }
    }
}
