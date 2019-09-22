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
    public partial class BookingsMenu : Form
    {
        public BookingsMenu()
        {
            InitializeComponent();
            //Center the form to the middle of the Screen.
            CenterToScreen();
        }

        private void btnAddNewBooking_Click(object sender, EventArgs e)
        {
            //Create a new instance of the Member Bookings Screen.
            MemberBookings memberBookings = new MemberBookings();
            //Show the Member Bookings Screen.
            memberBookings.Show();
            //Hide thsi screen.
            Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Create a new instance of the Studio2Menu Screen.
            Studio2Menu studio2Menu = new Studio2Menu();
            //Show the Studio2 Menu Screen.
            studio2Menu.Show();
            //Hide this screen.
            Hide();
        }

        private void btnSearchBooking_Click(object sender, EventArgs e)
        {
            //Create a new instance of the Search Bookings Screen.
            SearchBookings searchBookings = new SearchBookings();
            //Show the Search Bookings screen.
            searchBookings.Show();
            //Hide this screen.
            Hide();
        }
    }
}
