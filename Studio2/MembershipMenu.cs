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
    public partial class MembershipMenu : Form
    {
        public MembershipMenu()
        {
            InitializeComponent();
            //Center the form to the middle of the screen.
            CenterToScreen();
        }

        private void btnAddNewMembership_Click(object sender, EventArgs e)
        {
            //Create a new instance of the Add new Membership Screen.
            AddNewMembership addNewMembership = new AddNewMembership();
            //Show the Add New Membership Screen.
            addNewMembership.Show();
            //Hide this screen.
            Hide();
        }

        private void btnSearchMemberships_Click(object sender, EventArgs e)
        {
            //Create a new instance of the Search Membership screen.
            SearchMembership searchMembership = new SearchMembership();
            //Show the Search Membership Screen.
            searchMembership.Show();
            //Hide this screen.
            Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Create a new instance of the Studio2 Menu screen.
            Studio2Menu studio2Menu = new Studio2Menu();
            //Show the Studio2Menu Screen.
            studio2Menu.Show();
            //Hide this screen.
            Hide();
        } 
    }
}
