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
    public partial class AddNewMembership : Form
    {
        public AddNewMembership()
        {
            InitializeComponent();
            //Center the screen.
            CenterToScreen();
            //Call the reset method.
            Reset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //If all textboxes are not empty and all comboboxes are not displaying "Please Select..."...
            if (txtMembershipTypeID.Text != "" && txtDescription.Text != "" && cbLength.Text != "Please Select..." && cbPaymentType.Text != "Please Select..." && txtAmount.Text != "")
            {
                //Call the Check method.
                Check();
            }
            else
            {
                //Otherwise show the message below.
                MessageBox.Show("Please enter a Membership Type.");
            }
        }
        
        private void Check()
        {
            //Declare the variables below.
            string memType = txtMembershipTypeID.Text;
            string description = txtDescription.Text;
            string length = cbLength.Text;
            string payment = cbPaymentType.Text;

            //If the MembershipLength is 5...
            if (memType.Length == 5)
            {
                //Check that the first 3 letters of the description match the first 3 letters of the ID.
                if (memType.Substring(0, 3).ToUpper() == description.Substring(0, 3).ToUpper())
                {
                    //Check that the first letter of the length matched the fourth letter of the ID.
                    if (memType.Substring(3, 1) == length.Substring(0, 1))
                    {
                        //Check that the last letter of the ID is appropriate for the payment type. 
                        if ((memType.Substring(4, 1).ToUpper() == payment.Substring(0, 1).ToUpper()) || (memType.Substring(4, 1).ToUpper() == "M" && payment.Substring(0, 1).ToUpper() == "P"))
                        {
                            //Call the Add Membership Method.
                            Add();
                        }
                        //Otherwise, display the message below.
                        else
                        {
                            MessageBox.Show("The last letter must represent the Payment Type.");
                        }
                    }
                    //Otherwise, display the message below.
                    else
                    {
                        MessageBox.Show("The fourth character must represent the length of the membership, i.e 6 or 12 months.");
                    }
                }
                //Otherwise, display the message below.
                else
                {
                    MessageBox.Show("The first 3 letters of the MembershipTypeID must be the same as the first 3 letters of the description.");
                }
            }
            //If the MembershipLength is 6...
            else if (memType.Length == 6)
            {
                //Check that the first 3 letters of the description match the first 3 letters of the ID.
                if (memType.Substring(0, 3).ToUpper() == description.Substring(0, 3).ToUpper())
                {
                    //Check that the first letter of the length matched the fourth letter of the ID.
                    if (memType.Substring(3, 1) == length.Substring(0, 1))
                    {
                        //Check that the last letter of the ID is appropriate for the payment type. 
                        if ((memType.Substring(5, 1).ToUpper() == payment.Substring(0, 1).ToUpper()) ||  (memType.Substring(5, 1).ToUpper() == "M" && payment.Substring(0, 1).ToUpper() == "P"))
                        {
                            //Call the Add Membership Method.
                            Add();
                        }
                        //Otherwise, display the message below.
                        else
                        {
                            MessageBox.Show("The last letter must represent the Payment Type.");
                        }
                    }
                    //Otherwise, display the message below.
                    else
                    {
                        MessageBox.Show("The fourth and fifth characters must represent the length of the membership, i.e 12 months.");
                    }
                }
                //Otherwise, display the message below.
                else
                {
                    MessageBox.Show("The first 3 letters of the MembershipTypeID must be the same as the first 3 letters of the description.");
                }
            }
            //If the MembershipLength is 7...
            else if (memType.Length == 7)
            {
                //Check that the first 3 letters of the description match the first 3 letters of the ID.
                if (memType.Substring(0, 3).ToUpper() == description.Substring(0, 3).ToUpper())
                {
                    //Check that the first letter of the length matched the sixth letter of the ID.
                    if (memType.Substring(5, 1) == length.Substring(0, 1))
                    {
                        //Check that the last letter of the ID is appropriate for the payment type. 
                        if ((memType.Substring(6, 1).ToUpper() == payment.Substring(0, 1).ToUpper()) ||  (memType.Substring(6, 1).ToUpper() == "M" && payment.Substring(0, 1).ToUpper() == "P"))
                        {
                            //Call the Add Membership Method.
                            Add();
                        }
                        //Otherwise, display the message below.
                        else
                        {
                            MessageBox.Show("The last letter must represent the Payment Type.");
                        }
                    }
                    //Otherwise, display the message below.
                    else
                    {
                        MessageBox.Show("The sixth character must represent the length of the membership, i.e 6 or 12 months.");
                    }
                }
                //Otherwise, display the message below.
                else
                {
                    MessageBox.Show("The first 5 letters of the MembershipTypeID must represent the description.");
                }
            }
            //If the MembershipLength is 8...
            else if (memType.Length == 8)
            {
                //Check that the first 3 letters of the description match the first 3 letters of the ID.
                if (memType.Substring(0, 3).ToUpper() == description.Substring(0, 3).ToUpper())
                {
                    //Check that the first letter of the length matched the sixth letter of the ID.
                    if (memType.Substring(5, 1) == length.Substring(0, 1))
                    {
                        //Check that the last letter of the ID is appropriate for the payment type. 
                        if ((memType.Substring(7, 1).ToUpper() == payment.Substring(0, 1).ToUpper()) ||  (memType.Substring(7, 1).ToUpper() == "M" && payment.Substring(0, 1).ToUpper() == "P"))
                        {
                            //Call the Add Membership Method.
                            Add();
                        }
                        //Otherwise, display the message below.
                        else
                        {
                            MessageBox.Show("The last letter must represent the Payment Type.");
                        }
                    }
                    //Otherwise, display the message below.
                    else
                    {
                        MessageBox.Show("The sixth and seventh characters must represent the length of the membership, i.e 12 months.");
                    }
                }
                //Otherwise, display the message below.
                else
                {
                    MessageBox.Show("The first 5 letters of the MembershipTypeID must represent the description.");
                }
            }
            //Otherwise, display the message below.
            else
            {
                MessageBox.Show("The MembershipTypeID must be between 5 and 8 characters long.");
            }
        }
        
        private void Add()
        {
            //Try...
            try
            {
                //Call the Add Membership method from the Membership class and pass across the data.
                int rowsAffected = Membership.AddMembership(txtMembershipTypeID.Text, txtDescription.Text, cbLength.Text,
                    cbPaymentType.Text, txtAmount.Text);

                if (rowsAffected > 0)
                {
                    //If the membership has been added successfully, display the message below.
                    MessageBox.Show("New Membership Type has been added successfully.");
                    //Call the reset method.
                    Reset();
                }
            }
            //Catch any errors that may occur and display a message.
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void Reset()
        {
            //Reset all textboxes to be empty.
            txtMembershipTypeID.Text = "";
            txtDescription.Text = "";
            //Reset all comboboxes to display "Please Select...".
            cbLength.Text = "Please Select...";
            cbPaymentType.Text = "Please Select...";
            txtAmount.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Create a new instance of the MembershipMenu.
            MembershipMenu membershipMenu = new MembershipMenu();
            //Show the MembershipMenu.
            membershipMenu.Show();
            //Hide this screen.
            Hide();
        }
    }
}

