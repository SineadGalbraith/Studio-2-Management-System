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
    public partial class AllocateStaffMemberMenu : Form
    {
        public AllocateStaffMemberMenu()
        {
            InitializeComponent();
            //Center the form to the middle of the screen.
            CenterToScreen();
        }

        private void AllocateStaffMemberMenu_Load(object sender, EventArgs e)
        {
            //Display the ClassID saved in the Class class.
            lblClassID.Text = AddNewClass._class._classID;
            //Call the Display method.
            Display();
        }

        private void btnAllocate_Click(object sender, EventArgs e)
        {
            //Call the AllocateButton.
            AllocateButton();
        }

        private void AllocateButton()
        {
            //Create an instance of the AllocateStaff screen.
            AllocateStaff allocateStaff = new AllocateStaff();
            //Show the AllocateStaff Screen.
            allocateStaff.Show();
            //Hide this screen.
            Hide();
        }

        private void Display()
        {
            //Save the data in the _main variable in the StaffClass class into the variable main.
            string main = AllocateStaff._staffClass._main;
            //Save the data in the _supporting variable in the StaffClass class into the variable supporting.
            string supporting = AllocateStaff._staffClass._supporting;

            //Display the StaffID in lblDisplayStaffID.
            lblDisplayStaffID.Text = main;
            //Display the SupportingID in lblDisplaySupportID.
            lblDisplaySupportID.Text = supporting;
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            //If lblDisplayID is not empty...
            if(lblDisplayStaffID.Text != "")
            {
                //If lblDisplaySupportID is not empty.
                if (lblDisplaySupportID.Text != "")
                {
                    //Display the message below.
                    MessageBox.Show("Class : " + AddNewClass._class._classID + " has been added succesfully.");
                    //Call the Reset method.
                    Reset();
                    //Call the New Class method.
                    NewClass();
                }
                //Otherwise display the message below.
                else
                {
                    MessageBox.Show("Please allocate a SupportingStaffID.");
                }
            }
            //Otherwise display the message below.
            else
            {
                MessageBox.Show("Please Allocate a StaffID.");
            }
        }
        
        private void Reset()
        {
            //Reset all labels and textboxes to be empty.
            lblDisplayStaffID.Text = "";
            lblDisplaySupportID.Text = "";
            AllocateStaff._staffClass._main = "";
            AllocateStaff._staffClass._supporting = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Call the New Class method.
            NewClass();
        }

        private void NewClass()
        {
            //Create a new instance of the AddNewClass screen.
            AddNewClass addNewClass = new AddNewClass();
            //Show the AddNewClass screen.
            addNewClass.Show();
            //Hide this screen.
            Hide();
        }

        
    }
}
