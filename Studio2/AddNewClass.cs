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
    public partial class AddNewClass : Form
    {
        //Create an instance of the class Class.
        public static Class _class = new Class();
        public AddNewClass()
        {
            InitializeComponent();
            //Center the form on the screen.
            CenterToScreen();
            //Call the reset method.
            Reset();
        }

        //When the Allocate button is clicked...
        private void btnAllocate_Click(object sender, EventArgs e)
        {
            //If the text in cbDay is not "Please Select..."
            if (cbDay.Text != "Please Select...")
            {
                //If the text  in cbTime is not "Please Select..."
                if (cbTime.Text != "Please Select...")
                {
                    //If the text in cbLevel is not "Please Select..."
                    if (cbLevel.Text != "Please Select...")
                    {
                        //Call the CheckID method.
                        CheckID();
                    }
                    //Otherwise, display the message below.
                    else
                    {
                        MessageBox.Show("Please pick a class level.");
                    }
                //Otherwise, display the message below.
                }
                else
                {
                    MessageBox.Show("Please pick a class time.");
                }
            
            }
            //Otherwise, display the message below.
            else
            {
                MessageBox.Show("Please pick a class day.");
            }
        }
        
        private void CheckID()
        {
            //Declare the variables below.
            string classID = txtClassID.Text;
            bool validletter1, validletter2, validletter3;
            int num1, num2, num3;
            classID = classID.Replace(" ", "");
            //If txtClassID is not empty.
            if (txtClassID.Text != "")
            {
                //If the ClassID is 7 characters long...
                if (classID.Length == 7)
                {
                    //If the last letter of the ClassID is either "M", "A" or "E"...
                    if (classID.Substring(6, 1).ToUpper() == "M" || classID.Substring(6, 1).ToUpper() == "A" || classID.Substring(6, 1).ToUpper() == "E")
                    {
                        //If the fourth letter of the ClassID is either "B", "I", "A"...
                        if (classID.Substring(3, 1).ToUpper() == "B" || classID.Substring(3, 1).ToUpper() == "I" ||
                                classID.Substring(3, 1).ToUpper() == "A")
                        {
                            string letter1 = classID.Substring(0, 1).ToUpper();
                            //Try to parse the first letter of the ClassID...
                            validletter1 = Int32.TryParse(letter1, out num1);
                            //If the first letter is not a number...
                            if (!validletter1)
                            {
                                string letter2 = classID.Substring(1, 1).ToUpper();
                                //Try to parse the second letter of the ClassID...
                                validletter2 = Int32.TryParse(letter2, out num2);
                                //If the second letter is not a number...
                                if (!validletter2)
                                {
                                    string letter3 = classID.Substring(2, 1).ToUpper();
                                    //Try to parse the third letter of the ClassID...
                                    validletter3 = Int32.TryParse(letter3, out num3);
                                    //If the third letter is not a number...
                                    if (!validletter3)
                                    {
                                        //Check that the fifth and sixth letters are either "MO", "TU", "WE", "TH", "FR", "SA" or "SU"...
                                        if (classID.Substring(4, 2).ToUpper() == "MO" || classID.Substring(4, 2).ToUpper() == "TU" ||
                                        classID.Substring(4, 2).ToUpper() == "WE" || classID.Substring(4, 2).ToUpper() == "TH" ||
                                        classID.Substring(4, 2).ToUpper() == "FR" || classID.Substring(4, 2).ToUpper() == "SA" ||
                                        classID.Substring(4, 2).ToUpper() == "SU")
                                        {
                                            //Call the Check method.
                                            Check();
                                        }
                                        //Otherwise, display the message below.
                                        else
                                        {
                                            MessageBox.Show("The fifth and sixth characters must be either 'Mo', 'Tu', 'We', 'Th', 'Fr', 'Sa' or 'Su'");
                                        }
                                    }
                                    //Otherwise, display the message below.
                                    else
                                    {
                                        MessageBox.Show("The third character must be a letter.");
                                    }
                                }
                                //Otherwise, display the message below.
                                else
                                {
                                    MessageBox.Show("The second character must be a letter.");
                                }
                            }
                            //Otherwise, display the message below.
                            else
                            {
                                MessageBox.Show("The first character must be a letter.");
                            }
                        }
                        //Otherwise, display the message below.
                        else
                        {
                            MessageBox.Show("The fourth must be either B, I or A.");
                        }
                    }
                    //Otherwise, display the message below.
                    else
                    {
                        MessageBox.Show("The last letter must be 'M', 'A' or 'E'.");
                    }
                }
                //Otherwise, display the message below.
                else
                {
                    MessageBox.Show("The classID must be 7 characters long.");
                }
            }
            //Otherwise, display the message below. 
            else
            {
                MessageBox.Show("Please enter a Class ID.");
            }
        }

        private void Check()
        {
            //Save the text in txtClassName to the variable className.
            string className = txtClassName.Text;
            //Save the text in cbLevel to the variable level.
            string level = cbLevel.Text;
            //Save the text in cbDay to the variable day.
            string day = cbDay.Text;

            //If txtClassName is not empty.
            if (txtClassName.Text != "")
            {
                //If the first letter of the ClassID is the same as the first letter of the Description.
                if (className.Substring(0, 1).ToUpper() == txtClassID.Text.Substring(0, 1).ToUpper())
                {
                    //If cbDay is not empty.
                    if (cbDay.Text != "")
                    {
                        //If the first two letters of the class Day and the 5th and 6th letters of the ClassID are equal...
                        if (cbDay.Text.Substring(0, 2).ToUpper() == txtClassID.Text.Substring(4, 2).ToUpper())
                        {
                            //If cbTime is not empty.
                            if (cbTime.Text != "")
                            {
                                //If cbLevel is not empty.
                                if (cbLevel.Text != "")
                                {
                                    //Call the CheckTime method.
                                    CheckTime();
                                    
                                }
                                //Otherwise. display the message below.
                                else
                                {
                                    MessageBox.Show("Please choose a Class Level.");
                                }
                            }
                            //Otherwise. display the message below.
                            else
                            {
                                MessageBox.Show("Please choose a Class Time.");
                            }
                        }
                        //Otherwise. display the message below.
                        else
                        {
                            MessageBox.Show("The fifth and sixth letters of the ClassID must be the same as the first two letters of day.");
                        }
                    }
                    //Otherwise. display the message below.
                    else
                    {
                        MessageBox.Show("Please choose a Class Day.");

                    }
                }
                //Otherwise. display the message below.
                else
                {
                    MessageBox.Show("The first letter of the ClassID must be the same as the first letter of the Class Name.");
                }
            }
            //Otherwise. display the message below.
            else
            {
                MessageBox.Show("Please enter a Class Name.");
            }
        }
        
        private void CheckTime()
        {
            //Save the last letter of the ClassID to the variable timeOfDay.
            string timeOfDay = txtClassID.Text.Substring(6, 1); 
            //Convert the text in cbTime to DateTime and save it in the variable time.
            DateTime time = Convert.ToDateTime(cbTime.Text);
            //Save the time 12:00:00 to the variable twelve.
            DateTime twelve = Convert.ToDateTime("12:00:00");
            //Save the time 17:00:00 to the variable five.
            DateTime five = Convert.ToDateTime("17:00:00");
            
            //If the time of day is "M", the value in class time must be before 12pm, if the time of day is A, the value in 
            //class time must be between 12pm and 5pm and if the time of day is "E", the value in class time must be after 5pm.
            if ((timeOfDay == "M" && time < twelve) || (timeOfDay == "A" && (time > twelve && time < five)) ||
                (timeOfDay == "E" && (time > five)))
            {
                //If the fourth letter of the ClassID and the first letter of the ClassLevel are the same...
                if (cbLevel.Text.Substring(0, 1).ToUpper() == txtClassID.Text.Substring(3, 1).ToUpper())
                {
                    //Call the PassClassDetails method.
                    PassClassDetails();
                }
                //Otherwise, display the message below.
                else
                {
                    MessageBox.Show("The fourth letter of the ClassID must be the first letter of the level of class.");
                }
            }
            //Otherwise, display the message below.
            else
            {
                MessageBox.Show("The last letter of the ClassID must be M (before 12pm), A (between 12pm and 5pm) or E(after 5pm).");
            }
        }

        //This method passes the class details to the Class class.
        private void PassClassDetails()
        {
            //The text in txtClassID will be passed into the variable _classID in the Class class.
            _class._classID = txtClassID.Text;
            //The text in txtClassName will be passed into the variable _classIName in the Class class.
            _class._className = txtClassName.Text;
            //The text in txtClassDay will be passed into the variable _classday in the Class class.
            _class._classDay = cbDay.Text;
            //The text in txtClassText will be passed into the variable _classText in the Class class.
            _class._classTime = cbTime.Text;
            //The text in txtClassLevel will be passed into the variable _classLevel in the Class class.
            _class._classLevel = cbLevel.Text;
            //Call the Add Method.
            Add();
        }

        private void Add()
        {
            //Try...
            try
            {
                //Call the Add Class method in the Class class and pass the values across.
                int rowsAffected = Class.AddClass(txtClassID.Text, txtClassName.Text, cbTime.Text, cbDay.Text,
                   cbLevel.Text);
                if (rowsAffected > 0)
                {
                    //If the member has been added succesfully, call the AllocateStaffButton method.
                    AllocateStaffButton();
                }
            }
            //Catch any exceptions and display the exceptions with an error message.
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AllocateStaffButton()
        {
            //Create a new instance of the AllocateStaffMemberMenu.
            AllocateStaffMemberMenu allocateStaffMenu = new AllocateStaffMemberMenu();
            //Show the Allocate Staff Menu.
            allocateStaffMenu.Show();
            //Hide this screen.
            Hide();
        }

        private void Reset()
        {
            //Reset textboxes to be empty.
            txtClassID.Text = "";
            txtClassName.Text = "";
            //Reset comboboxes to say "Please Select...".
            cbDay.Text = "Please Select...";
            cbTime.Text = "Please Select...";
            cbLevel.Text = "Please Select...";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Create a new instance of the Add New Class Menu Screen.
            AddNewClassMenu addNewClassMenu = new AddNewClassMenu();
            //Show the Add New Class Menu.
            addNewClassMenu.Show();
            //Hide this screen.
            Hide();
        }
    }
}



