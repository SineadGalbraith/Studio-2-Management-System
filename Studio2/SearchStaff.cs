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
    public partial class SearchStaff : Form
    {
        public SearchStaff()
        {
            InitializeComponent();
            //Center the form to the middle of the screen.
            CenterToScreen();
            //Call the reset method.
            Reset();
        }

        //Create the connection string.
        private static string _connectionString =
                    ConfigurationManager.ConnectionStrings["Studio2ConnectionString"].ConnectionString;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //When the search button is clicked, try to call the search method...
            try
            {
                Search();
            }
            //Otherwise, catch the error and display a message.
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        
        private void Search()
        {
            //If txtStaffID is not empty, check that the StaffID entered is valid.
            if (txtStaffID.Text != "")
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) FROM Staff WHERE (StaffID = @StaffID)", connection))
                    {
                        connection.Open();
                        sqlCommand.Parameters.AddWithValue("@StaffID", txtStaffID.Text);
                        int staff = (int)sqlCommand.ExecuteScalar();
                        bool staffExist = false;
                        if (staff > 0)
                        {
                            staffExist = true;
                            //If staffExist is true...
                            if (staffExist)
                            {
                                //Call the getStaffForename method from the Staff class and add the list to the new list that has been created.
                                List<string> fnames = Staff.getStaffForename(txtStaffID.Text);
                                {
                                    //If the amount of names in the list is greater than 0...
                                    if (fnames.Count > 0)
                                    {
                                        //Create an instantance of the stringbuilder class.
                                        StringBuilder stringb = new StringBuilder();

                                        foreach (string fname in fnames)
                                        {
                                            //Add the name to the stringbuilder.
                                            stringb.AppendLine(fname);
                                            //Display the name in txtForename.
                                            txtForename.Text = fname;
                                        }
                                    }
                                }

                                //Call the getStaffSurname method from the Staff class and add the list to the new list that has been created.
                                List<string> snames = Staff.getStaffSurname(txtStaffID.Text);
                                {
                                    //If the amount of names in the list is greater than 0...
                                    if (snames.Count > 0)
                                    {
                                        //Create an instantance of the stringbuilder class.
                                        StringBuilder string_b = new StringBuilder();

                                        foreach (string sname in snames)
                                        {
                                            //Add the name to the stringbuilder.
                                            string_b.AppendLine(sname);
                                            //Display the name in txtSurname.
                                            txtSurname.Text = sname;
                                        }
                                    }
                                }

                                //Call the getStaffDOB method from the Staff class and add the list to the new list that has been created.
                                List<DateTime> dobs = Staff.getStaffDOB(txtStaffID.Text);
                                {
                                    //If the amount of dobs in the list is greater than 0...
                                    if (fnames.Count > 0)
                                    {
                                        //Create an instantance of the stringbuilder class.
                                        StringBuilder stringBuilder = new StringBuilder();

                                        foreach (DateTime dob in dobs)
                                        {
                                            //Add the dob to the stringbuilder.
                                            stringBuilder.AppendLine(Convert.ToString(dob));
                                            //Convert the dob to a string and display in txtDOB.
                                            txtDOB.Text = Convert.ToString(dob.ToString("yyyy-MM-dd"));
                                        }
                                    }
                                }

                                //Call the getStaffGender method from the Staff class and add the list to the new list that has been created.
                                List<string> genders = Staff.getStaffGender(txtStaffID.Text);
                                {
                                    //If the amount of genders in the list is greater than 0...
                                    if (genders.Count > 0)
                                    {
                                        //Create an instantance of the stringbuilder class.
                                        StringBuilder sbuilder = new StringBuilder();

                                        foreach (string gender in genders)
                                        {
                                            //Add the gender to the stringbuilder.
                                            sbuilder.AppendLine(gender);
                                            //Display the gender in txtGender.
                                            txtGender.Text = gender;
                                        }
                                    }
                                }

                                //Call the getStaffStreet method from the Staff class and add the list to the new list that has been created.
                                List<string> streets = Staff.getStaffStreet(txtStaffID.Text);
                                {
                                    //If the amount of streets in the list is greater than 0...
                                    if (streets.Count > 0)
                                    {
                                        //Create an instantance of the stringbuilder class.
                                        StringBuilder s_b = new StringBuilder();

                                        foreach (string street in streets)
                                        {
                                            //Add the street to the stringbuilder.
                                            s_b.AppendLine(street);
                                            //Display the street in txtStreet.
                                            txtStreet.Text = street;
                                        }
                                    }
                                }

                                //Call the getStaffTown method from the Staff class and add the list to the new list that has been created.
                                List<string> towns = Staff.getStaffTown(txtStaffID.Text);
                                {
                                    //If the amount of towns in the list is greater than 0...
                                    if (towns.Count > 0)
                                    {
                                        //Create an instantance of the stringbuilder class.
                                        StringBuilder stringbuild = new StringBuilder();

                                        foreach (string town in towns)
                                        {
                                            //Add the town to the stringbuilder.
                                            stringbuild.AppendLine(town);
                                            //Display the town in txtTown.
                                            txtTown.Text = town;
                                        }
                                    }
                                }

                                //Call the getStaffCounty method from the Staff class and add the list to the new list that has been created.
                                List<string> counties = Staff.getStaffCounty(txtStaffID.Text);
                                {
                                    //If the amount of counties in the list is greater than 0...
                                    if (counties.Count > 0)
                                    {
                                        //Create an instantance of the stringbuilder class.
                                        StringBuilder sbuild = new StringBuilder();

                                        foreach (string county in counties)
                                        {
                                            //Add the county to the stringbuilder.
                                            sbuild.AppendLine(county);
                                            //Display the county in txtCounty.
                                            txtCounty.Text = county;
                                        }
                                    }
                                }

                                //Call the getStaffPostCode method from the Staff class and add the list to the new list that has been created.
                                List<string> pcs = Staff.getStaffPostCode(txtStaffID.Text);
                                {
                                    //If the amount of postcodes in the list is greater than 0...
                                    if (pcs.Count > 0)
                                    {
                                        //Create an instantance of the stringbuilder class.
                                        StringBuilder stbuilder = new StringBuilder();

                                        foreach (string pc in pcs)
                                        {
                                            //Add the postcode to the stringbuilder.
                                            stbuilder.AppendLine(pc);
                                            //Display the postcode in txtPostCode.
                                            txtPostCode.Text = pc;
                                        }
                                    }
                                }

                                //Call the getStaffPhone method from the Staff class and add the list to the new list that has been created.
                                List<string> phones = Staff.getStaffPhone(txtStaffID.Text);
                                {
                                    //If the amount of phone numbers in the list is greater than 0...
                                    if (phones.Count > 0)
                                    {
                                        //Create an instantance of the stringbuilder class.
                                        StringBuilder builder = new StringBuilder();

                                        foreach (string phone in phones)
                                        {
                                            //Add the phone number to the stringbuilder.
                                            builder.AppendLine(phone);
                                            //Display the phone number in txtPhoneNo.
                                            txtPhoneNo.Text = phone;
                                        }
                                    }
                                }

                                //Call the getStaffEmail method from the Staff class and add the list to the new list that has been created.
                                List<string> emails = Staff.getStaffEmail(txtStaffID.Text);
                                {
                                    //If the amount of emails in the list is greater than 0...
                                    if (emails.Count > 0)
                                    {
                                        //Create an instantance of the stringbuilder class.
                                        StringBuilder _stringb = new StringBuilder();

                                        foreach (string email in emails)
                                        {
                                            //Add the email to the stringbuilder.
                                            _stringb.AppendLine(email);
                                            //Display the email in txtEmail.
                                            txtEmail.Text = email;
                                        }
                                    }
                                }
                            }
                            //Otherwise, display a message telling the user that the Staff Member does not exist.
                            else
                            {
                                MessageBox.Show("Staff Member does not exist.");
                            }
                        }
                        //Otherwise, display a message telling the user that the Staff Member does not exist.
                        else
                        {
                            MessageBox.Show("Staff Member does not exist.");
                        }
                    }
                }
            }
            //Otherwise, display a message asking the user to enter a StaffID.
            else
            {
                MessageBox.Show("Please enter a StaffID");
            }
        }
        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //If txtStaffID is not empty...
            if (txtStaffID.Text != "")
            {
                //If txtForename and txtSurname are not empty...
                if (txtForename.Text != "" && txtSurname.Text != "")
                {
                    //If txtDOB is not empty...
                    if (txtDOB.Text != "")
                    {
                        //If txtGender is "M" or "F"...
                        if (txtGender.Text == "M" || txtGender.Text == "F")
                        {
                            //If txtStreet, txtTown and txtCounty are not empty...
                            if (txtStreet.Text != "" && txtTown.Text != "" && txtCounty.Text != "")
                            {
                                //If txtPhoneNo is not empty...
                                if (txtPhoneNo.Text != "")
                                {
                                    //If the Phone Number is 11 characters long.
                                    if (txtPhoneNo.Text.Length == 11)
                                    {
                                        //Call the CheckPostCode method.
                                        CheckPostCode();
                                    }
                                    //Otherwise, display the message below.
                                    else
                                    {
                                        MessageBox.Show("The Phone Number must be 11 characters long.");
                                    }
                                }
                                //Otherwise, display the message below.
                                else
                                {
                                    MessageBox.Show("Please enter a Phone Number.");
                                }
                            }
                            //Otherwise, display the message below.
                            else
                            {
                                MessageBox.Show("Please enter a Street, Town and County.");
                            }
                        }
                        //Otherwise, display the message below.
                        else
                        {
                            MessageBox.Show("The Gender must be either 'M' or 'F'.");
                        }
                    }
                    //Otherwise, display the message below.
                    else
                    {
                        MessageBox.Show("Please enter a Date of Birth.");
                    }
                }
                //Otherwise, display the message below.
                else
                {
                    MessageBox.Show("Please enter a name and surname.");
                }
            }
            //Otherwise, display the message below.
            else
            {
                MessageBox.Show("Please entere a StaffID.");
            }
        }

        private void CheckPostCode()
        {
            //Declare the following variables.
            string postCode = txtPostCode.Text;
            bool validNo, letter1, letter2;
            int num1, num2, num3;
            postCode = postCode.Replace(" ", "");

            //If the PostCode is 7 characters long...
            if (postCode.Length == 7)
            {
                //Check that the first 2 letters are "BT"
                if (postCode.Substring(0, 2).ToUpper() == "BT")
                {
                    string no = postCode.Substring(2, 3);
                    //Try to parse the 3rd to 5th characters.
                    validNo = Int32.TryParse(no, out num1);
                    //If the 3rd-5th characters are numbers...
                    if (validNo)
                    {
                        string let1 = postCode.Substring(5, 1);
                        //Try to parse the 6th character.
                        letter1 = Int32.TryParse(let1, out num2);
                        //If it is not a number...
                        if (!letter1)
                        {
                            string let2 = postCode.Substring(6, 1);
                            //Try to parse the 7th character.
                            letter2 = Int32.TryParse(let2, out num3);
                            //If the last character is a number...
                            if (letter2)
                            {
                                //Display the message below.
                                MessageBox.Show("The last character must be a letter.");
                            }
                            //Otherwise...
                            else
                            {
                                //Check if the email is valid or if txtEmail is empty.
                                if (ValidEmail(txtEmail.Text) || txtEmail.Text == "")
                                {
                                    //Call the CheckAge method.
                                    CheckAge();
                                }
                                //Otherwise, display the message below.
                                else
                                {
                                    MessageBox.Show("Please enter a valid email address.");
                                }
                            }
                        }
                        //Otherwise, display the message below.
                        else
                        {
                            MessageBox.Show("The second last character must be a letter.");
                        }
                    }
                    //Otherwise, display the message below.
                    else
                    {
                        MessageBox.Show("There must be 3 numbers in the middle of the PostCode,");
                    }
                }
                //Otherwise, display the message below.
                else
                {
                    MessageBox.Show("The PostCode must start with BT");
                }
            }
            //If the PostCode is 6 characters long...
            else if (postCode.Length == 6)
            {
                //Check that the first 2 letters are "BT"
                if (postCode.Substring(0, 2).ToUpper() == "BT")
                {
                    string no = postCode.Substring(2, 2);
                    //Try to parse the 3rd and 4th characters.
                    validNo = Int32.TryParse(no, out num1);
                    //If the 3rd and 4th characters are numbers...
                    if (validNo)
                    {
                        string let1 = postCode.Substring(4, 1);
                        //Try to parse the 5th character.
                        letter1 = Int32.TryParse(let1, out num2);
                        //If it is not a number...
                        if (!letter1)
                        {
                            string let2 = postCode.Substring(5, 1);
                            //Try to parse the 6th character.
                            letter2 = Int32.TryParse(let2, out num3);
                            //If the last character is a number...
                            if (letter2)
                            {
                                //Display the message below.
                                MessageBox.Show("The last character must be a letter.");
                            }
                            //Otherwise...
                            else
                            {
                                //Check if the email is valid or if txtEmail is empty.
                                if (ValidEmail(txtEmail.Text) || txtEmail.Text == "")
                                {
                                    //Call the CheckAge method.
                                    CheckAge();
                                }
                                //Otherwise, display the message below.
                                else
                                {
                                    MessageBox.Show("Please enter a valid email address.");
                                }
                            }
                        }
                        //Otherwise, display the message below.
                        else
                        {
                            MessageBox.Show("The second last character must be a letter.");
                        }
                    }
                    //Otherwise, display the message below.
                    else
                    {
                        MessageBox.Show("There must be 2 numbers in the middle of the PostCode,");
                    }
                }
                //Otherwise, display the message below.
                else
                {
                    MessageBox.Show("The PostCode must start with BT");
                }
            }
            //Otherwise, display the message below.
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

        //This method checks the age of the Staff Member.
        private void CheckAge()
        {
            //Convert the text in txtDOB to DateTime.
            DateTime birthday = Convert.ToDateTime(txtDOB.Text);
            //If the Staff Member is not 20 years old...
            if (birthday > DateTime.Today.AddYears(-20))
            {
                //Display the message below.
                MessageBox.Show("You must be at least 20 to become a Staff Member.");
            }
            //Otherwise, call the EditStaff method.
            else
            {
                EditStaff();
            }
        }
        
        private void EditStaff()
        {
            //Convert the text in txtDOB to a DateTime.
            DateTime dob = Convert.ToDateTime(txtDOB.Text);
            //Try to...
            try
            {
                //Call the EditStaff method from the Staff class and pass over the information.
                int rowsAffected = Staff.EditStaff(txtStaffID.Text, txtForename.Text, txtSurname.Text, dob.ToString("yyyy-MM-dd"), txtGender.Text,
                        txtStreet.Text, txtTown.Text, txtCounty.Text, txtPostCode.Text, txtPhoneNo.Text, txtEmail.Text);

                if (rowsAffected > 0)
                {
                    //If the member has been edited successully, display the message below.
                    MessageBox.Show("Staff Member edited successfully.");
                    //Call the reset method.
                    Reset();
                }
            }
            //If an exception occurs, catch the exception and display a message.
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        //This method will delete the Staff Member.
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //If txtStaffID is not empty...
            if (txtStaffID.Text != "")
            {
                //Call the DeleteStaff method/
                DeleteStaff();
            }
            //Otherwise...
            else
            {
                //Display the message below.
                MessageBox.Show("Please enter a StaffID.");
            }
        }
        
        private void DeleteStaff()
        {
            //Try...
            try
            {
                //Call the DeleteStaff Method from the Staff table and pass in the text in txtStaffID.
                int rowsAffected = Staff.DeleteStaff(txtStaffID.Text);
                
                if (rowsAffected > 0)
                {
                    //If the member has been deleted successfully, show the following message.
                    MessageBox.Show("Staff Member deleted successfully.");
                    //Call the reset method.
                    Reset();
                }
            }
            //If an exception occur, catch the exception and display the error message.
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
            //Set all of the textboxes to be empty.
            txtStaffID.Text = "";
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
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Create a new instance of the Staff Menu.
            StaffMenu staffMenu = new StaffMenu();
            //Show the StaffMenu.
            staffMenu.Show();
            //Hide this screen.
            Hide();
        } 
    }
}

