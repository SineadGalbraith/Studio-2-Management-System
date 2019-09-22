using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Studio2
{
    public partial class AddNewMember : Form
    {
        public AddNewMember()
        {
            InitializeComponent();
            //Center the form to the middle of the screen.
            CenterToScreen();
            //Call the MembershipTypes method.
            MembershipTypes();
            //Call the GetID method.
            GetID();
            //Call the Reset method.
            Reset();
        }

        public void MembershipTypes()
        {
            //Call the getMembershipID method from the Member class and save the data into a list.
            List<string> types = Member.getMembershipID();
            {
                foreach (string type in types)
                {
                    //Add each Membership Type to the combobox.
                    cbMembershipType.Items.Add(type);
                }
            }
        }

        private void GetID()
        {
            //Call the GetID method from the Member class and save the ID as the variable newMemberID.
            int newMemberID = Member.GetID();
            //Convert the MemberID to a string and display the new ID in lblID along with the letters "MBR" before it.
            lblID.Text = "MBR" + Convert.ToString(newMemberID);
        }

        private void cbMembershipType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Call the ExpiryDate method.
            ExpiryDate();
        }

        private void ExpiryDate()
        {
            //Save the date in six months to the variable sixMonths.
            DateTime sixMonths = DateTime.Today.AddMonths(6);
            //Save the date in one year to the variable twelveMonths.
            DateTime twelveMonths = DateTime.Today.AddYears(1);
            //If the fourth letter of the MembershipType is 6...
            if (cbMembershipType.Text.Substring(3, 1) == "6")
            {
                //Set the expiry date to the date saved in sixMonths.
                txtExpiryDate.Text = sixMonths.ToString("yyyy-MM-dd");
            }
            //If the fourth letter of the MembershipType is 1...
            else if (cbMembershipType.Text.Substring(3, 1) == "1")
            {
                //Set the expiry date to the date saved in twelveMonths.
                txtExpiryDate.Text = twelveMonths.ToString("yyyy-MM-dd");
            }
            //If the sixth letter of the MembershipType is 6...
            else if (cbMembershipType.Text.Substring(5, 1) == "6")
            {
                //Set the expiry date to the date saved in sixMonths.
                txtExpiryDate.Text = sixMonths.ToString("yyyy-MM-dd");
            }
            //If the sixth letter of the MembershipType is 1...
            else if (cbMembershipType.Text.Substring(5, 1) == "1")
            {
                //Set the expiry date to the date saved in twelveMonths.
                txtExpiryDate.Text = twelveMonths.ToString("yyyy-MM-dd");
            }
            //Otherwise
            else
            {
                //Display the message below.
                MessageBox.Show("Please choose a MembershipID.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //If txtForename and txtSurname are not empty...
            if (txtForename.Text != "" && txtSurname.Text != "")
            {
                //If txtDOB is not empty...
                if (txtDOB.Text != "")
                {
                    //If the text in txtGender is "M" or "F"...
                    if (cbGender.Text == "M" || cbGender.Text == "F")
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
                                MessageBox.Show("The last character of the postcode must be a letter.");
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
                            MessageBox.Show("The second last character of the postcode must be a letter.");
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
                MessageBox.Show("The PostCode must have 6 or 7 characters e.g. BT354GT/BT75TH");
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
            //If the first three letters of the Membership Type are "CON"...
            if (cbMembershipType.Text.Substring(0, 3) == "CON")
            {
                //Save the current date in the variable today.
                DateTime today = DateTime.Today;
                //Convert and save the text in txtDOB in the variable bday.
                DateTime bday = Convert.ToDateTime(txtDOB.Text);
                //If the Member is not over 60 years of age...
                if (bday > today.AddYears(-60))
                {
                    //Display the message below.
                    MessageBox.Show("You must be over 60 to have the Membership Type: " + cbMembershipType.Text);
                }
                //Otherwise...
                else
                {
                    //Call the Check age method.
                    CheckAge();
                }
            }
            //Otherwise
            else
            {
                //Call the Check age method.
                CheckAge();
            }
        }

        private void CheckAge()
        {
            //Convert and save the text in txtDOB to the DateTime variable birthday.
            DateTime birthday = Convert.ToDateTime(txtDOB.Text);
            //If the Member is not 16 years old...
            if(birthday > DateTime.Today.AddYears(-16))
            {
                //Display the message below.
                MessageBox.Show("You must be at least 16 to become a Member.");
            }
            //Otherwise...
            else
            {
                //Call the Add Member method.
                AddMember();
            }
        }

        private void AddMember()
        {
            //Convert the text in txtDOB to DateTime.
            DateTime dob = Convert.ToDateTime(txtDOB.Text);
            //Try...
            try
            {
                //Call the Add Member method from the Member class and pass across the data.
                int rowsAffected = Member.AddMember(txtForename.Text, txtSurname.Text, dob.ToString("yyyy-MM-dd"), cbGender.Text,
                    txtStreet.Text, txtTown.Text, txtCounty.Text, txtPostCode.Text, txtPhoneNo.Text, txtEmail.Text, cbMembershipType.Text, txtStartDate.Text, txtExpiryDate.Text);

                if (rowsAffected > 0)
                {
                    //If a member has been successfully added, display the message below.
                    MessageBox.Show("New Member has been added successfully.");
                    //Call the reset method.
                    Reset();
                    //Call the GetID method.
                    GetID();
                }
            }
            //Catch any exceptions that may occur and display a message.
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtStartDate_TextChanged(object sender, EventArgs e)
        {
            //If the text is changed in txtStartDate from the current date...
            if (txtStartDate.Text != Convert.ToString(DateTime.Today.ToString("yyyy-MM-dd")))
            {
                //Display the message below.
                MessageBox.Show("The start date must be today.");
                //Reset the text in txtStartDate to the current date.
                txtStartDate.Text = Convert.ToString(DateTime.Today.ToString("yyyy-MM-dd"));
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Create a new instance of the MembersMenu screen.
            MembersMenu membersMenu = new MembersMenu();
            //Show the Members Menu screen.
            membersMenu.Show();
            //Hide this screen.
            Hide();
        }
        private void Reset()
        {
            //Reset all textboxes (apart from txtStartDate (see below)) to be empty.
            //Reset all comboboxes to display "Please Select...".
            txtForename.Text = "";
            txtSurname.Text = "";
            txtDOB.Text = "";
            cbGender.Text = "Please select...";
            txtStreet.Text = "";
            txtTown.Text = "";
            txtCounty.Text = "";
            txtPostCode.Text = "";
            txtPhoneNo.Text = "";
            txtEmail.Text = "";
            cbMembershipType.Text = "Please select...";
            //Reset txtStartDate to todays date and convert it to a strign in the format "yyyy-mm-dd".
            txtStartDate.Text = Convert.ToString(DateTime.Today.ToString("yyyy-MM-dd"));
            txtExpiryDate.Text = "";
        }
    }
}

