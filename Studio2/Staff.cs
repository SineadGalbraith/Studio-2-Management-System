using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Studio2
{
    class Staff
    {
        //Create the connection string.
        private static string _connectionString =
            ConfigurationManager.ConnectionStrings["Studio2ConnectionString"].ConnectionString;

        //This method will add a Staff Member.
        public static int AddStaff(string staffForename, string staffSurname, string staffDOB, string staffGender,
            string staffStreet, string staffTown, string staffCounty, string staffPostCode, string staffPhoneNo, string staffEmail)
        {
            using (SqlConnection connections = new SqlConnection(_connectionString))
            {
                //Open connection.
                connections.Open();

                //Insert the values that have been passed in, into the Staff table.
                string sqlQuery = string.Format(@"INSERT INTO Staff VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', 
                            '{8}', '{9}')", staffForename, staffSurname, staffDOB, staffGender, staffStreet, staffTown, staffCounty,
                             staffPostCode, staffPhoneNo, staffEmail);
                SqlCommand insertStaffCommand = new SqlCommand(sqlQuery, connections);

                int rowsAffected = insertStaffCommand.ExecuteNonQuery();

                //Close the connection.
                connections.Close();
                //Return the value.
                return rowsAffected;
            }
        }

        //This method will edit a staff member.
        public static int EditStaff(string staffID, string forename, string surname, string dob, string gender, string street, 
            string town, string county, string postCode, string phoneNo, string email)
        {
            using (SqlConnection _cstring = new SqlConnection(_connectionString))
            {
                //Open the connection.
                _cstring.Open();
                //Convert the date of birth to a DateTime in the format "yyyy-mm-dd".
                string date = Convert.ToDateTime(dob).ToString("yyyy-MM-dd");
                //Update the Staff table with the new data that has been passed in.
                string sqlQuery = string.Format(@"UPDATE Staff SET StaffForename = '" + forename + "', StaffSurname = '" + surname +
                    "', StaffDOB = '" + date + "', StaffGender = '" + gender + "', StaffStreet = '" + street +
                    "', StaffTown = '" + town + "', StaffCounty = '" + county + "', StaffPostCode = '" + postCode +
                    "', StaffPhoneNo = '" + phoneNo + "', StaffEmail = '" + email + "'WHERE StaffID = '" + staffID + "'");
                SqlCommand editStaffCommand = new SqlCommand(sqlQuery, _cstring);

                int rowsAffected = editStaffCommand.ExecuteNonQuery();

                //Close the connection.
                _cstring.Close();
                //Return the value.
                return rowsAffected;
            }
        }

        //This method will delete a Staff Member.
        public static int DeleteStaff(string StaffID)
        {
            using (SqlConnection _connection = new SqlConnection(_connectionString))
            {
                //Open connection.
                _connection.Open();
                //Delete the Staff Member according to the StaffID that has been passed in.
                string Query = string.Format(@"DELETE FROM Staff WHERE (StaffID = '{0}')", StaffID);
                SqlCommand deleteStaffCommand = new SqlCommand(Query, _connection);

                int rowsAffected = deleteStaffCommand.ExecuteNonQuery();
                //Close the connection.
                _connection.Close();
                //Return the value.
                return rowsAffected;
            }
        }

        //This method will get the StaffIDs from the Staff table.
        public static int GetID()
        {
            using (SqlConnection conne = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<int> staffIds = new List<int>();
                //Open the connection.
                conne.Open();
                //Select the StaffID from the Staff table.
                string sqlQuery = string.Format(@"SELECT StaffID FROM Staff");
                SqlCommand selectIDCommand = new SqlCommand(sqlQuery, conne);
                SqlDataReader sqlDataReader = selectIDCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    int staffID = (int)sqlDataReader["StaffID"];
                    //Add the StaffID to the list.
                    staffIds.Add(staffID);
                }
                //Save the amount of StaffIDs in the variable countStaffIDs.
                int countStaffIDs = staffIds.Count;
                //Increment countStaffIDs by 1.
                int newStaffID = staffIds[countStaffIDs - 1] + 1;

                //Close the connection.
                conne.Close();
                //Return the value.
                return newStaffID;
            }
        }

        //This method will get the StaffForename from the Staff table according to the StaffID that has been passed in.
        public static List<string> getStaffForename(string s_forename)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<string> s_fnames = new List<string>();

                //Open the connection.
                conn.Open();
                //Select the StaffForename from the Staff table where the StaffID is the value that has been entered in.
                string sqlQuery = string.Format("SELECT StaffForename FROM Staff WHERE StaffID = '{0}'", s_forename);
                SqlCommand getfnameCommand = new SqlCommand(sqlQuery, conn);
                SqlDataReader sqlDataReader = getfnameCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string fname = (string)sqlDataReader["StaffForename"];
                    //Add the name to the list.
                    s_fnames.Add(fname);
                }
                //Close the connection.
                conn.Close();
                //Return the value.
                return s_fnames;
            }
        }

        //This method will get the StaffSurname from the Staff table according to the StaffID that has been entered.
        public static List<string> getStaffSurname(string s_surname)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<string> s_snames = new List<string>();

                //Open the connection.
                connection.Open();
                //Select the StaffSurname from the Staff table where the StaffID is that value that has been entered in.
                string sqlQuery = string.Format("SELECT StaffSurname FROM Staff WHERE StaffID = '{0}'", s_surname);
                SqlCommand getsnameCommand = new SqlCommand(sqlQuery, connection);
                SqlDataReader sqlDataReader = getsnameCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string sname = (string)sqlDataReader["StaffSurname"];
                    //Add the name to the list.
                    s_snames.Add(sname);
                }

                //Close the connection.
                connection.Close();
                //Return the value.
                return s_snames;
            }
        }

        //This method will get the StaffDOB from the Staff table according to the StaffID that has been entered.
        public static List<DateTime> getStaffDOB(string s_dob)
        {
            using (SqlConnection connect = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<DateTime> s_dobs = new List<DateTime>();
                //Open the connection.
                connect.Open();
                //Select the StaffDOB from the Staff table where the StaffID is the value that has been entered in.
                string sqlQuery = string.Format("SELECT StaffDOB FROM Staff WHERE StaffID = '{0}'", s_dob);
                SqlCommand getdobCommand = new SqlCommand(sqlQuery, connect);
                SqlDataReader sqlDataReader = getdobCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    DateTime dob = (DateTime)sqlDataReader["StaffDOB"];
                    //Add the dob to the list.
                    s_dobs.Add(dob);
                }
                //Close the connection.
                connect.Close();
                //Return the list.
                return s_dobs;
            }
        }

        //This method will get the StaffGender from the Staff table according to the StaffID that has been entered.
        public static List<string> getStaffGender(string s_gender)
        {
            using (SqlConnection c = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<string> s_genders = new List<string>();
                //Open the connection.
                c.Open();
                //Select the StaffGender from the Staff table where the StaffID is the value that has been entered in.
                string sqlQuery = string.Format("SELECT StaffGender FROM Staff WHERE StaffID = '{0}'", s_gender);
                SqlCommand getgenderCommand = new SqlCommand(sqlQuery, c);
                SqlDataReader sqlDataReader = getgenderCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string gender = (string)sqlDataReader["StaffGender"];
                    //Add the gender to the list.
                    s_genders.Add(gender);
                }
                //Close the connection.
                c.Close();
                //Return the list.
                return s_genders;
            }
        }

        //This method will get the StaffStreet from the Staff table according to the StaffID that as been entered.
        public static List<string> getStaffStreet (string s_street)
        {
            using (SqlConnection co = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<string> s_streets = new List<string>();
                //Open the connection.
                co.Open();
                //Select the StaffStreet from the Staff table where the StaffID is the value that has been entered in.
                string sqlQuery = string.Format("SELECT StaffStreet FROM Staff WHERE StaffID = '{0}'", s_street);
                SqlCommand getstreetCommand = new SqlCommand(sqlQuery, co);
                SqlDataReader sqlDataReader = getstreetCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string street = (string)sqlDataReader["StaffStreet"];
                    //Add the street to the list.
                    s_streets.Add(street);
                }
                //Close the connection.
                co.Close();
                //Return the list.
                return s_streets;
            }
        }

        //This method will get the StaffTown from the Staff table according to the StaffID that has been entered.
        public static List<string> getStaffTown(string s_town)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<string> s_towns = new List<string>();
                //Open the connection.
                con.Open();
                //Select the StaffTown from the Stafftable where the StaffID is the value that has been entered in.
                string sqlQuery = string.Format("SELECT StaffTown FROM Staff WHERE StaffID = '{0}'", s_town);
                SqlCommand getTownCommand = new SqlCommand(sqlQuery, con);
                SqlDataReader sqlDataReader = getTownCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string town = (string)sqlDataReader["StaffTown"];
                    //Add the town to the list.
                    s_towns.Add(town);
                }

                //Close the connection.
                con.Close();
                //Return the list.
                return s_towns;
            }
        }

        //This method will get the StaffCounty from the Staff table according to the StaffID that has been entered,
        public static List<string> getStaffCounty(string s_county)
        {
            using (SqlConnection ct = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<string> s_counties = new List<string>();
                //Open the connection.
                ct.Open();
                //Select the StaffCounty from the Staff table where the StaffID is the value that has been entered in.
                string sqlQuery = string.Format("SELECT StaffCounty FROM Staff WHERE StaffID = '{0}'", s_county);
                SqlCommand getcountyCommand = new SqlCommand(sqlQuery, ct);
                SqlDataReader sqlDataReader = getcountyCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string county = (string)sqlDataReader["StaffCounty"];
                    //Add the county to the list.
                    s_counties.Add(county);
                }
                //Close the connection.
                ct.Close();
                //Return the list.
                return s_counties;
            }
        }

        //This method will get the StaffPostCode from the Staff table according to the StaffID that has been entered.
        public static List<string> getStaffPostCode(string s_pc)
        {
            using (SqlConnection cn = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<string> s_pcs = new List<string>();
                //Open the connection.
                cn.Open();
                //Select the StaffPostCde from the Staff table where the StaffID is the value that has been entered in.
                string sqlQuery = string.Format("SELECT StaffPostCode FROM Staff WHERE StaffID = '{0}'", s_pc);
                SqlCommand getpcCommand = new SqlCommand(sqlQuery, cn);
                SqlDataReader sqlDataReader = getpcCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string pc = (string)sqlDataReader["StaffPostCode"];
                    //Add the PostCode to the list.
                    s_pcs.Add(pc);
                }
                //Close the connection.
                cn.Close();
                //Return the list.
                return s_pcs;
            }
        }

        //This method will get the StaffPhoneNo from the Staff table according to the StaffID that has been entered.
        public static List<string> getStaffPhone (string s_phone)
        {
            using (SqlConnection cnn = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<string> s_phones = new List<string>();
                //Open the connection.
                cnn.Open();
                //Select the StaffPhoneNo from the Staff table where the StaffID is the value that has been entered in.
                string sqlQuery = string.Format("SELECT StaffPhoneNo FROM Staff WHERE StaffID = '{0}'", s_phone);
                SqlCommand getphoneCommand = new SqlCommand(sqlQuery, cnn);
                SqlDataReader sqlDataReader = getphoneCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string phone = (string)sqlDataReader["StaffPhoneNo"];
                    //Add the phone number to the list.
                    s_phones.Add(phone);
                }
                //Close the connection.
                cnn.Close();
                //Return the list.
                return s_phones;
            }
        }

        //This method will get the StaffEmail from the Staff table according to the StaffID that has been entered.
        public static List<string> getStaffEmail(string s_email)
        {
            using (SqlConnection ctn = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<string> s_emails = new List<string>();
                //Open te connection.
                ctn.Open();
                //Select the StaffEmail from the Staff table according to the StaffID that has been entered in.
                string sqlQuery = string.Format("SELECT StaffEmail FROM Staff WHERE StaffID = '{0}'", s_email);
                SqlCommand getemailCommand = new SqlCommand(sqlQuery, ctn);
                SqlDataReader sqlDataReader = getemailCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string email = (string)sqlDataReader["StaffEmail"];
                    //Add the email to the list.
                    s_emails.Add(email);
                }
                //Close the connection.
                ctn.Close();
                //Return the list.
                return s_emails;
            }
        }
    }
}
