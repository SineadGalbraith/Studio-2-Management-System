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
    public partial class MembersMenu : Form
    {
        public MembersMenu()
        {
            InitializeComponent();
            //Center the form to the middle of the screen.
            CenterToScreen();
        }

        private void btnAddNewMember_Click(object sender, EventArgs e)
        {
            //Create a new instance of the Add New Member screen.
            AddNewMember addNewMember = new AddNewMember();
            //Show the Add New Member screen.
            addNewMember.Show();
            //Hide this screen.
            Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Create a new instance of the Search Member screen.
            SearchMember searchMember = new SearchMember();
            //Show the Search Member Screen.
            searchMember.Show();
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

        private void btnMemberCard_Click(object sender, EventArgs e)
        {
            //Create a new instance of the MemberCard Screen.
            MemberCard memberCard = new MemberCard();
            //Show the MemberCard Screen.
            memberCard.Show();
            //Hide this screen.
            Hide();
        }
    }
}
