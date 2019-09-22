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
    public partial class ClassMenu : Form
    {
        public ClassMenu()
        {
            InitializeComponent();
            //Center the form to the middle of the screen.
            CenterToScreen();
        }

        private void btnAddNewClass_Click(object sender, EventArgs e)
        {
            //Create a new instance of the Add New Class Menu screen.
            AddNewClassMenu addNewClassMenu = new AddNewClassMenu();
            //Show the Add New Class Menu Screen.
            addNewClassMenu.Show();
            //Hide this screen.
            Hide();
        }

        private void btnSearchClass_Click(object sender, EventArgs e)
        {
            //Create a new instance of the Search Class Screen.
            SearchClass searchClass = new SearchClass();
            //Show the Search Class Screen.
            searchClass.Show();
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
