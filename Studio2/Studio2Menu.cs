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
    public partial class Studio2Menu : Form
    {
        public Studio2Menu()
        {
            InitializeComponent();
            //Center the form to the middle of the sreen.
            CenterToScreen();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            //Create a new instance of the MembersMenu Screen.
            MembersMenu membersMenu = new MembersMenu();
            //Show the Members Menu screen.
            membersMenu.Show();
            //Hide this screen.
            Hide();
        }
        
        private void btnMemberBookings_Click(object sender, EventArgs e)
        {
            //Create a new instance of the BookingsMenu screen.
            BookingsMenu bookingsMenu = new BookingsMenu();
            //Show the Bookings Menu screen.
            bookingsMenu.Show();
            //Hide this screen.
            Hide();
        }

        private void btnMembership_Click(object sender, EventArgs e)
        {
            //Create a new instance of the Membership Menu.
            MembershipMenu membershipMenu = new MembershipMenu();
            //Show the Membership Menu.
            membershipMenu.Show();
            //Hide this screen.
            Hide();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            //Create a new instance of the StaffMenu screen.
            StaffMenu staffMenu = new StaffMenu();
            //Show the StaffMenu.
            staffMenu.Show();
            //Hide this screen.
            Hide();
        }

        private void btnClasses_Click(object sender, EventArgs e)
        {
            //Create a new instance of the ClassMenu screen.
            ClassMenu classMenu = new ClassMenu();
            //Show the Class Menu.
            classMenu.Show();
            //Hide this Screen.
            Hide();
        }
        
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            //Create a new instance of the Welcome Screen.
            WelcomeScreen welcomeScreen = new WelcomeScreen();
            //Show the Welcome Screen.
            welcomeScreen.Show();
            //Hide this screen.
            Hide();
        }
    }
}
