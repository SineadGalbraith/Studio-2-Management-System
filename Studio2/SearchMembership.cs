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
    public partial class SearchMembership : Form
    {
        public SearchMembership()
        {
            InitializeComponent();
            //Center the screen.
            CenterToScreen();
            //Call the reset method.
            Reset();
        }

        //Create the connection string.
        private static string _connectionString =
                    ConfigurationManager.ConnectionStrings["Studio2ConnectionString"].ConnectionString;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Try to call the search method.
            try
            {
                Search();
            }
            //Catch any exceptions that may occur and display the message for that exception.
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void Search()
        {
            //If txtMembershipTypeID is not null, this method will check that the MembershipTypeID is valid.
            if (txtMembershipTypeID.Text != "")
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) FROM MemberType WHERE (MembershipTypeID = @MembershipTypeID)", connection))
                    {
                        connection.Open();
                        sqlCommand.Parameters.AddWithValue("@MembershipTypeID", txtMembershipTypeID.Text);
                        int membership = (int)sqlCommand.ExecuteScalar();
                        bool membershipExist = false;
                        if (membership > 0)
                        {
                            membershipExist = true;
                            //If membershipExist is true...
                            if (membershipExist)
                            {
                                //Call the getMembershipDescription from the Membership class and pass the text in txtMembershipTypeID.
                                List<string> descs = Membership.getMembershipDescription(txtMembershipTypeID.Text);
                                {
                                    //If the amount of descriptions is greater than 0...
                                    if (descs.Count > 0)
                                    {
                                        //Create an instantance of the stringbuilder class.
                                        StringBuilder sb = new StringBuilder();

                                        foreach (string desc in descs)
                                        {
                                            //Add the description to the stringbuilder.
                                            sb.AppendLine(desc);
                                            //Display the description in txtDescription.
                                            txtDescription.Text = desc;
                                        }
                                    }
                                }

                                //Call the getMembershipLength from the Membership class and pass the text in txtMembershipTypeID.
                                List<string> lengths = Membership.getMembershipLength(txtMembershipTypeID.Text);
                                {
                                    //If the amount of lengths is greater than 0...
                                    if (lengths.Count > 0)
                                    {
                                        //Create an instantance of the stringbuilder class.
                                        StringBuilder sb = new StringBuilder();

                                        foreach (string length in lengths)
                                        {
                                            //Add the length to the stringbuilder.
                                            sb.AppendLine(length);
                                            //Display the length in cbLength.
                                            cbLength.Text = length;
                                        }
                                    }
                                }

                                //Call the getMembershipPayment from the Membership class and pass the text in txtMembershipTypeID.
                                List<string> payments = Membership.getMembershipPayment(txtMembershipTypeID.Text);
                                {
                                    //If the amount of payments is greater than 0...
                                    if (payments.Count > 0)
                                    {
                                        //Create an instantance of the stringbuilder class.
                                        StringBuilder sb = new StringBuilder();

                                        foreach (string payment in payments)
                                        {
                                            //Add the payment to the stringbuilder.
                                            sb.AppendLine(payment);
                                            //Display the payment in cbPayment.
                                            cbPaymentType.Text = payment;
                                        }
                                    }
                                }

                                //Call the getMembershipAmount from the Membership class and pass the text in txtMembershipTypeID.
                                List<decimal> amounts = Membership.getMembershipAmount(txtMembershipTypeID.Text);
                                {
                                    //If the amount of amounts is greater than 0.
                                    if (amounts.Count > 0)
                                    {
                                        //Create an instantance of the stringbuilder class.
                                        StringBuilder sb = new StringBuilder();

                                        foreach (decimal amount in amounts)
                                        {
                                            //Add the amount to the stringbuilder.
                                            sb.AppendLine(Convert.ToString(amount));
                                            //Display the amount in txtAmount.
                                            txtAmount.Text = Convert.ToString(amount);
                                        }
                                    }
                                }
                            }
                        }
                        //Otherwise, display the message below.
                        else
                        {
                            MessageBox.Show("Membership does not exist.");
                        }
                        
                    }
                }
            }
            //Otherwise, display the message below.
            else
            {
                MessageBox.Show("Please enter a MembershipTypeID before searching.");
            }
        }
        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //If txtMembershipTypeID is not empty...
            if (txtMembershipTypeID.Text != "")
            {
                //Call the Check method.
                Check();
            }
            //Otherwise, display the message below.
            else
            {
                MessageBox.Show("Please enter a MembershipTypeID.");
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
                            //Call the EditMembership method.
                            EditMembership();
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
                        if ((memType.Substring(5, 1).ToUpper() == payment.Substring(0, 1).ToUpper()) || (memType.Substring(5, 1).ToUpper() == "M" && payment.Substring(0, 1).ToUpper() == "P"))
                        {
                            //Call the EditMembership method.
                            EditMembership();
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
                        if ((memType.Substring(6, 1).ToUpper() == payment.Substring(0, 1).ToUpper()) || (memType.Substring(6, 1).ToUpper() == "M" && payment.Substring(0, 1).ToUpper() == "P"))
                        {
                            //Call the EditMembership method.
                            EditMembership();
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
                        if ((memType.Substring(7, 1).ToUpper() == payment.Substring(0, 1).ToUpper()) || (memType.Substring(7, 1).ToUpper() == "M" && payment.Substring(0, 1).ToUpper() == "P"))
                        {
                            //Call the EditMembership method.
                            EditMembership();
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
        }
        
        private void EditMembership()
        {
            //Try...
            try
            {
                //Call the EditMembership method from the Membership Class and pass in the values.
                int rowsAffected = Membership.EditMembership(txtMembershipTypeID.Text, txtDescription.Text, cbLength.Text,
                    cbPaymentType.Text, txtAmount.Text);
                if (rowsAffected > 0)
                {
                    //If the membership has been edited, display the message below.
                    MessageBox.Show("Membership has been edited successfully.");
                    //Call the reset method.
                    Reset();
                }
            }
            //If any exceptions occur, catch the exception and display a message.
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //If txtMembershipTypeID is not empty
            if (txtMembershipTypeID.Text != "")
            {
                //Call the DeleteMembership method.
                DeleteMembership();
            }
            //Otherwise, display the message below.
            else
            {
                MessageBox.Show("Please enter a MembershipTypeID.");
            }
        }
        
        private void DeleteMembership()
        {
            //Try...
            try
            {
                //Call the DeleteMembership method in the Membership class and pass in the text in txtMembershipTypeID
                int rowsAffected = Membership.DeleteMembership(txtMembershipTypeID.Text);

                if (rowsAffected > 0)
                {
                    //If the membership has been delete successfully, display the message below.
                    MessageBox.Show("Membership deleted successfully.");
                    //Call the reset method.
                    Reset();
                }
            }
            //If any exception occur, catch the exceptions and display an error message.
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
            //Reset all the textboxes to be empty.
            txtMembershipTypeID.Text = "";
            txtDescription.Text = "";
            cbLength.Text = "";
            cbPaymentType.Text = "";
            txtAmount.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Create a new instance of the MembershipMenu class.
            MembershipMenu membershipMenu = new MembershipMenu();
            //Show the MembershipMenu class.
            membershipMenu.Show();
            //Hide this class.
            Hide();
        } 
    }
}
