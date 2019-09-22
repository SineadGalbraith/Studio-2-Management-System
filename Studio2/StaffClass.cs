using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Studio2
{
    public class StaffClass
    {
        //Declare the variables listed below.
        public string _staffID;
        public string _supporting;
        public string _main;
        
        //Create the connection string.
        private static string _connectionString =
            ConfigurationManager.ConnectionStrings["Studio2ConnectionString"].ConnectionString;

        //This method will add the ClassID, StaffID and the StaffClassRole into the StaffClass table.
        public static int AddStaffClass(string classID, string staffID, string staffClassRole)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                //Open the connection.
                connection.Open();

                //Insert the values passed into the AddStaffClass Method into the StaffClass table.
                string sqlQuery = string.Format(@"INSERT INTO StaffClass VALUES ('{0}', '{1}', '{2}')", classID, staffID, 
                    staffClassRole);
                SqlCommand insertStaffClassCommand = new SqlCommand(sqlQuery, connection);

                int rowsAffected = insertStaffClassCommand.ExecuteNonQuery();

                //Close the connection.
                connection.Close();

                //Return the value.
                return rowsAffected;
            }
        }

        //This method selects all of the StaffIDs from the Staff table.
        public static List<int> getStaffID()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                //Create a new list.
                List<int> ids = new List<int>();
                //Open the connection.
                conn.Open();
                //Select the StaffIDs from the Staff table.
                string sqlQuery = string.Format(@"SELECT StaffID FROM Staff");
                SqlCommand getStaffIDCommand = new SqlCommand(sqlQuery, conn);
                SqlDataReader sqlDataReader = getStaffIDCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    int staffID = (int)sqlDataReader["StaffID"];
                    //Add the StaffIDs to a list.
                    ids.Add(staffID);
                }
                //Close the connection.
                conn.Close();
                //return the list.
                return ids;
            }
        }

        //This method selects the StaffForename from the Staff table according to the StaffID entered.
        public static List<string> getStaffForename(int staff_ID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<string> names = new List<string>();
                //Open the connection.
                connection.Open();
                //Select the StaffForename from the Staff table where the StaffID is the value that has been passed in.
                string sqlQuery = string.Format("SELECT StaffForename FROM Staff WHERE StaffID = '{0}'", staff_ID);
                SqlCommand getStaffNameCommand = new SqlCommand(sqlQuery, connection);
                SqlDataReader sqlDataReader = getStaffNameCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    string name = (string)sqlDataReader["StaffForename"];
                    //Add the name to the list.
                    names.Add(name);
                }
                
                //Close the connection.
                connection.Close();
                //Return the list of names.
                return names;
            }
        }

        //This method selects the StaffSurnames from the Staff table according to the StaffID entered.
        public static List<string> getStaffSurname(int staff_ID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<string> names = new List<string>();
                //Open the connection.
                connection.Open();
                //Select the StaffSurname from the Staff table where the StaffID is the value that has been passed in.
                string sqlQuery = string.Format("SELECT StaffSurname FROM Staff WHERE StaffID = '{0}'", staff_ID);
                SqlCommand getStaffNameCommand = new SqlCommand(sqlQuery, connection);
                SqlDataReader sqlDataReader = getStaffNameCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    string name = (string)sqlDataReader["StaffSurname"];
                    //Add the name to the list.
                    names.Add(name);
                }

                //Close the connection.
                connection.Close();
                //Return the list of names.
                return names;
            }
        }

        //This method selects the StaffIDs from the StaffClass table according to the ClassID and StaffClassRole entered.
        public static List<int> displayStaffID(string c_ID)
        {
            using (SqlConnection _connection = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<int> ids = new List<int>();
                //Open the connection.
                _connection.Open();
                //Select the StaffID from the StaffClass table where the ClassID is the value that has been passed in and the StaffClassRole is "Main".
                string sqlQuery = string.Format("SELECT StaffID FROM StaffClass WHERE ClassID = '{0}' AND StaffClassRole = 'Main'", c_ID);
                SqlCommand getStaffIDCommand = new SqlCommand(sqlQuery, _connection);
                SqlDataReader sqlDataReader = getStaffIDCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    int id = (int)sqlDataReader["StaffID"];
                    //Add the ID to the list.
                    ids.Add(id);
                }
                //Close the connection.
                _connection.Close();
                //Return the list of names.
                return ids;
            }
        }

        //This method selects the SupportingStaffIDs from the StaffClass table according to the ClassID and StaffClassRole entered.
        public static List<int> displaySupportingStaffID(string class_ID)
        {
            using (SqlConnection _connection = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<int> supportIds = new List<int>();
                //Open the connection.
                _connection.Open();
                //Select the StaffID from the StaffCLass table where the ClassID is the value that has been passed in and the StaffClassRole is "Supporting".
                string sqlQuery = string.Format("SELECT StaffID FROM StaffClass WHERE ClassID = '{0}' AND StaffClassRole = 'Supporting'", class_ID);
                SqlCommand getSupportStaffIDCommand = new SqlCommand(sqlQuery, _connection);
                SqlDataReader sqlDataReader = getSupportStaffIDCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    int supportId = (int)sqlDataReader["StaffID"];
                    //Add the ID to the list.
                    supportIds.Add(supportId);
                }

                //Close the connection.
                _connection.Close();
                //Return the list of IDs.
                return supportIds;
            }
        }
    }
}