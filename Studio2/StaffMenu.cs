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
    public partial class StaffMenu : Form
    {
        public StaffMenu()
        {
            InitializeComponent();
            //Center the form to the middle of the screen.
            CenterToScreen();
        }
        
        private void btnAddNewStaff_Click(object sender, EventArgs e)
        {
            //Create a new instance of the Add New Staff Member screen.
            AddNewStaffMember addNewStaffMember = new AddNewStaffMember();
            //Show the Add New Staff Member Screen.
            addNewStaffMember.Show();
            //Hide this screen.
            Hide();
        }

        private void btnSearchStaff_Click(object sender, EventArgs e)
        {
            //Create a new instance of the Search staff screen.
            SearchStaff searchStaff = new SearchStaff();
            //Show the Search Staff Screen.
            searchStaff.Show();
            //Hide this screen.
            Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Create a new instance of the Studio2Menu screen.
            Studio2Menu studio2Menu = new Studio2Menu();
            //Show the Studio2Menu screen.
            studio2Menu.Show();
            //Hide this screen.
            Hide();
        }

        
    }
}
