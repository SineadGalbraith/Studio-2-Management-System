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
    public partial class AddNewClassMenu : Form
    {
        public AddNewClassMenu()
        {
            InitializeComponent();
            //Center the form to the middle of the screen.
            CenterToScreen();
        }

        private void btnAddNewStudio2Class_Click(object sender, EventArgs e)
        {
            //Create a new instance of the Add New Class Screen.
            AddNewClass addNewClass = new AddNewClass();
            //Show the Add New Class Screen.
            addNewClass.Show();
            //Hide this screen.
            Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Create a new instance of the ClassMenu Screen.
            ClassMenu classMenu = new ClassMenu();
            //Show the Class Menu.
            classMenu.Show();
            //Hide this screen.
            Hide();
        }

        
    }
}
