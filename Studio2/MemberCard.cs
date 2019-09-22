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
    public partial class MemberCard : Form
    {
        public MemberCard()
        {
            InitializeComponent(); 
            //Center the form to the middle of the screen.
            CenterToScreen();
        }

        //Create the connection string.
        private static string _connectionString =
                    ConfigurationManager.ConnectionStrings["Studio2ConnectionString"].ConnectionString;

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Create an instance of the Members Menu form.
            MembersMenu membersMenu = new MembersMenu();
            //Show the instance.
            membersMenu.Show();
            //Hide this screen.
            Hide();
        }

        private void MemberCard_Load(object sender, EventArgs e)
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //If txtMemberID is not empty, this method will checkthat the MemberID entered is valid.
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
                            //If memberExist is true.
                            if (memberExist)
                            {
                                //Convert the MemberID to an int.
                                int memberID = Convert.ToInt32(txtMemberID.Text);
                                // TODO: This line of code loads data into the 'DataSetMember.Member' table. You can move, or remove it, as needed.
                                this.MemberTableAdapter.Fill(this.DataSetMember.Member, memberID);

                                //Refresh the report.
                                this.reportViewerMember.RefreshReport();
                            }
                            //Otherwise, display a message to tell the user that the Member does not exist.
                            else
                            {
                                MessageBox.Show("Member does not exist.");
                            }
                        }
                        //Otherwise, display a message to tell the user that the Member does not exist.
                        else
                        {
                            MessageBox.Show("Member does not exist.");
                        }
                    }
                }
            //Otherwise, display a message to ask the user to enter a MemberID.
            }
            else
            {
                MessageBox.Show("Please enter a MemberID.");
            }
        }
    }
}
