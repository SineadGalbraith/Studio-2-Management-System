using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studio2
{
    public partial class AllocateStaff : Form
    {
        //Create a new instance of the StaffClass.
        public static StaffClass _staffClass = new StaffClass();
        //Declare the variable below.
        string staff_fname;

        public AllocateStaff()
        {
            InitializeComponent();
            //Center the form to the middle of the screen.
            CenterToScreen();
            //Call the StaffIDs method.
            StaffIds();
            //Call the Reset method.
            Reset();
        }

        private void AllocateStaff_Load(object sender, EventArgs e)
        {
            //When the screen loads, get the ClassID from the Class class.
            lblID.Text = AddNewClass._class._classID;
            //Display "Staff Name" in lblStaffName.
            lblStaffName.Text = "Staff Name:";
        }

        public void StaffIds()
        {
            //Call the getStaffID method and save it to a list.
            List<int> ids = StaffClass.getStaffID();
            {
                foreach (int id in ids)
                {
                    //Add each ID to the list.
                    cbStaffID.Items.Add(id);
                }
            }
        }
        
        private void cbStaffID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Call the getStaffForename and pass across the data.
            List<string> forenames = StaffClass.getStaffForename(Convert.ToInt32(cbStaffID.Text));
            if (forenames.Count > 0)
            {
                //Create a new instance of the stringbuilder class.
                StringBuilder sb = new StringBuilder();
                foreach (string fname in forenames)
                {
                    sb.AppendLine(fname);
                    //Save the forename to the variable staff_fname.
                    staff_fname = fname;
                }
            }
            //Call the getStaffSurname and pass across the data.
            List<string> surnames = StaffClass.getStaffSurname(Convert.ToInt32(cbStaffID.Text));
            if (surnames.Count > 0)
            {
                //Create a new instance of the stringbuilder class.
                StringBuilder s_b = new StringBuilder();
                foreach (string sname in surnames)
                {
                    s_b.AppendLine(sname);
                    //Display the forename and surname in lblDisplayName.
                    lblDisplayName.Text = staff_fname + " " + sname;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //If the text in cbStaffRolw is "Supporting"...
            if (cbStaffRole.Text == "Supporting")
            {
                //Save the Staff ID to the _supporting variable in the StaffClass.
                _staffClass._supporting = cbStaffID.Text;
                //Call the AddStaffClass method.
                AddStaffClass();
            }
            //If the text in cbStaffRolw is "Main"...
            else if (cbStaffRole.Text == "Main")
            {
                //Save the Staff ID to the _smain variable in the StaffClass.
                _staffClass._main = cbStaffID.Text;
                //Call the AddStaffClass method.
                AddStaffClass();
            }
            //Otherwise
            else
            {
                MessageBox.Show("Please choose a StaffID and StaffRole.");
            }
        }
        
        private void AddStaffClass()
        {
            //If the StaffID and the SupportingStaffID are not the same...
            if (_staffClass._main != _staffClass._supporting)
            {
                //Try to...
                try
                {
                    //Call the AddStaffClass method from the StaffClass and pass across the data.
                    int rowsAffected = StaffClass.AddStaffClass(lblID.Text, cbStaffID.Text, cbStaffRole.Text);

                    if (rowsAffected > 0)
                    {
                        //If the StaffClass has been added successfully, display the message below.
                        MessageBox.Show("Staff member has been allocated successfully.");
                        //Call the Back method.
                        Back();
                    }
                }
                //Catch any exceptions that may occur and display an error message.
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            //Otherwise, display the message below.
            else
            {
                MessageBox.Show("The Main staff Member and the Supporting Staff Member cannot be the same.");
            }
        }
        
        private void Back()
        {
            //Create an instance of the AllocateStaffMemberMenu.
            AllocateStaffMemberMenu allocateStaffMenu = new AllocateStaffMemberMenu();
            //Show the Allocate Staff Menu.
            allocateStaffMenu.Show();
            //Hide this screen.
            Hide();
        }
        
        private void Reset()
        {
            //Reset the comboboxes to display "Please Select...".
            cbStaffID.Text = "Please Select...";
            //Reset the textboxes to be empty.
            lblStaffName.Text = "";
            cbStaffRole.Text = "Please Select...";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Call the Back method.
            Back();
        }
    }
}
