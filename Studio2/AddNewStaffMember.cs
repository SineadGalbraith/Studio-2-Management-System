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
    public partial class AddNewStaffMember : Form
    {
        public AddNewStaffMember()
        {
            InitializeComponent();
            //Center the form to the middle of the screen.
            CenterToScreen();
            //Call the GetID method.
            GetID();
            //Call the reset method.
            Reset();
        } 
        
        private void GetID()
        {
            //Call the GetID method from the Staff class and save the ID as the variable newstaffID.
            int newStaffID = Staff.GetID();
            //Convert the StaffID to a string and display the new ID in lblID along with the letters "STF" before it.
            lblID.Text = "STF" + Convert.ToString(newStaffID);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //If txtForename and txtSurname are not empty...
            if (txtForename.Text != "" && txtSurname.Text != "")
            {
                //If txtDOB is not empty...
                if (txtDOB.Text != "")
                {
                    //If txtGender is "M" or "F"...
                    if (cbGender.Text == "M" || cbGender.Text == "F")
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
                                if (ValidEmail(txtEmail.Text))
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
                                if (ValidEmail(txtEmail.Text))
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
                MessageBox.Show("The PostCode must have 6 or 7 characters e.g. BT354GT/BT3 4AH");
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
            //Otherwise, call the AddStaffMember method.
            else
            {
                AddStaffMember();
            }
        }
        
        private void AddStaffMember()
        {
            //Convert the text in txtDOB to a DateTime.
            DateTime dob = Convert.ToDateTime(txtDOB.Text);
            //Try to...
            try
            {
                //Call the AddStaff method from the Staff class and pass over the information.
                int rowsAffected = Staff.AddStaff(txtForename.Text, txtSurname.Text, dob.ToString("yyyy-MM-dd"), cbGender.Text,
                 txtStreet.Text, txtTown.Text, txtCounty.Text, txtPostCode.Text, txtPhoneNo.Text, txtEmail.Text);
                if (rowsAffected > 0)
                {
                    //If the member has been added successully, display the message below.
                    MessageBox.Show("New Staff Member has been added successfully.");
                    //Call the reset method.
                    Reset();
                    //Call the GetID method.
                    GetID();
                }
            }
            //If an exception occurs, catch the exception and display a message.
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Reset()
        {
            //Display the next StaffID.
            lblID.Text = "STF" + Convert.ToString(Staff.GetID());
            //Set all of the textboxes to be empty.
            txtForename.Text = "";
            txtSurname.Text = "";
            txtDOB.Text = "";
            //Set the combobox to display "Please Select..."
            cbGender.Text = "Please select...";
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
