using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Studio2
{
    public class Class
    {
        //Declare the variables below.
        public string _classID;
        public string _className;
        public string _classDay;
        public string _classTime;
        public string _classLevel;

        //Create the connection string.
        private static string _connectionString =
            ConfigurationManager.ConnectionStrings["Studio2ConnectionString"].ConnectionString;

        //This method will add a Class.
        public static int AddClass(string classID, string className, string classTime, string classDay,
            string classLevel)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                //Open connection.
                connection.Open();

                //Insert the values that have been passed in, into the Class table.
                string time = Convert.ToDateTime(classTime).ToString("hh-mm");
                string sqlQuery = string.Format(@"INSERT INTO Class VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')",
                    classID, className, classTime, classDay, classLevel);
                SqlCommand insertClassCommand = new SqlCommand(sqlQuery, connection);

                int rowsAffected = insertClassCommand.ExecuteNonQuery();

                //Close the connection.
                connection.Close();
                return rowsAffected;
            }
        }

        //This method will edit a Class.
        public static int EditClass(string classID, string name, string time, string day, string level)
        {
            using (SqlConnection _cstring = new SqlConnection(_connectionString))
            {
                //Open the connection.
                _cstring.Open();
                //Convert the time to a DateTime in the format "hh:mm".
                string _time = Convert.ToDateTime(time).ToString("HH:mm");
                //Update the Class table with the new data that has been passed in.
                string sqlQuery = string.Format(@"UPDATE Class SET ClassName = '" + name + "', ClassTime = '" + _time +
                    "', ClassDay = '" + day + "', ClassLevel = '" + level + "'WHERE ClassID = '" + classID + "'");

                SqlCommand editClassCommand = new SqlCommand(sqlQuery, _cstring);

                int rowsAffected = editClassCommand.ExecuteNonQuery();

                //Close the connection.
                _cstring.Close();
                //Return the value.
                return rowsAffected;
            }
        }

        //This method will delete a Class.
        public static int DeleteClass(string classID)
        {
            using (SqlConnection _ct = new SqlConnection(_connectionString))
            {
                //Open connection.
                _ct.Open();
                //Delete the Class according to the ClassID that has been passed in.
                string Query = string.Format(@"DELETE FROM Class WHERE (ClassID = '{0}')", classID);
                SqlCommand deleteClassCommand = new SqlCommand(Query, _ct);

                int rowsAffected = deleteClassCommand.ExecuteNonQuery();
                //Close the connection.
                _ct.Close();
                //Return the value.
                return rowsAffected;
            }
        }

        //This method will delete a StaffClass.
        public static int DeleteStaffClass(string staffClass)
        {
            using (SqlConnection _ct = new SqlConnection(_connectionString))
            {
                //Open connection.
                _ct.Open();
                //Delete the StaffClass according to the ClassID that has been passed in.
                string Query = string.Format(@"DELETE FROM StaffClass WHERE (ClassID = '{0}')", staffClass);
                SqlCommand deleteStaffClassCommand = new SqlCommand(Query, _ct);

                int rowsAffected = deleteStaffClassCommand.ExecuteNonQuery();
                //Close the connection.
                _ct.Close();
                //Return the value.
                return rowsAffected;
            }
        }

        //This method will get the ClassName from the Class table according to the ClassID that has been passed in.
        public static List<string> getClassName(string c_ID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<string> classNames = new List<string>();
                //Open the connection.
                connection.Open();
                //Select the ClassName from the Class table where the ClassID is the value that has been entered in.
                string sqlQuery = string.Format("SELECT ClassName FROM Class WHERE ClassID = '{0}'", c_ID);
                SqlCommand getNamesCommand = new SqlCommand(sqlQuery, connection);
                SqlDataReader sqlDataReader = getNamesCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string names = (string)sqlDataReader["ClassName"];
                    //Add the name to the list.
                    classNames.Add(names);
                }
                //Close the connection.
                connection.Close();
                //Return the list.
                return classNames;
            }
        }

        //This method will get the ClassDay from the Class table according to the ClassID that has been passed in.
        public static List<string> getClassDay(string c_ID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<string> classDays = new List<string>();
                //Open the connection.
                connection.Open();
                //Select the ClassDay from the Class table where the ClassID is the value that has been entered in.
                string sqlQuery = string.Format("SELECT ClassDay FROM Class WHERE ClassID = '{0}'", c_ID);
                SqlCommand getDaysCommand = new SqlCommand(sqlQuery, connection);
                SqlDataReader sqlDataReader = getDaysCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string days = (string)sqlDataReader["ClassDay"];
                    //Add the day to the list.
                    classDays.Add(days);
                }
                //Close the connection.
                connection.Close();
                //Return the list.
                return classDays;
            }
        }

        //This method will get the ClassDate from the Booking table according to the ClassID that has been passed in.
        public static List<DateTime> getClassDate(string c_Date)
        {
            using (SqlConnection _connect = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<DateTime> c_Dates = new List<DateTime>();
                //Open the connection.
                _connect.Open();
                //Select the ClassDate from the Booking table where the ClassID is the value that has been entered in.
                string sqlQuery = string.Format("SELECT ClassDate FROM Booking WHERE ClassID = '{0}'", c_Date);
                SqlCommand getCDateCommand = new SqlCommand(sqlQuery, _connect);
                SqlDataReader sqlDataReader = getCDateCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    DateTime date = (DateTime)sqlDataReader["ClassDate"];
                    //Add the date to the list.
                    c_Dates.Add(date);
                }
                //Close the connection.
                _connect.Close();
                //Return the list.
                return c_Dates;
            }
        }

        //This method will get the ClassTime from the Class table according to the ClassID that has been passed in.
        public static List<string> getClassTime(string c_ID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<string> classTime = new List<string>();
                //Open the connection.
                connection.Open();
                //Select the ClassTime from the Class table where the ClassID is the value that has been entered in.
                string sqlQuery = string.Format("SELECT ClassTime FROM Class WHERE ClassID = '{0}'", c_ID);
                SqlCommand getTimesCommand = new SqlCommand(sqlQuery, connection);
                SqlDataReader sqlDataReader = getTimesCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string time = Convert.ToString(sqlDataReader["ClassTime"]);
                    //Add the time to the list.
                    classTime.Add(time);
                }
                //Close the connection.
                connection.Close();
                //Return the list.
                return classTime;
            }
        }

        //This method will get the ClassLevel from the Class table according to the ClassID that has been passed in.
        public static List<string> getClassLevel(string c_ID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<string> classLevels = new List<string>();
                //Open the connection.
                connection.Open();
                //Select the ClassLevel from the Class table where the ClassID is the value that has been entered in.
                string sqlQuery = string.Format("SELECT ClassLevel FROM Class WHERE ClassID = '{0}'", c_ID);
                SqlCommand getTimesCommand = new SqlCommand(sqlQuery, connection);
                SqlDataReader sqlDataReader = getTimesCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string level = (string)sqlDataReader["ClassLevel"];
                    //Add the level to the list.
                    classLevels.Add(level);
                }
                //Close the connection.
                connection.Close();
                //Return the list.
                return classLevels;
            }
        }

        //This method will get the StaffID from the StaffClass table according to the ClassID that has been passed in.
        public static List<string> getStaffID(string s_ID)
        {
            using (SqlConnection _string = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<string> s_IDs = new List<string>();
                //Open the connection.
                _string.Open();
                //Select the StaffID from the StaffClass table where the ClassID is the value that has been entered in.
                string sqlQuery = string.Format("SELECT StaffID FROM StaffClass WHERE (ClassID = '{0}')", s_ID);
                SqlCommand getIDCommand = new SqlCommand(sqlQuery, _string);
                SqlDataReader sqlDataReader = getIDCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string id = (string)sqlDataReader["StaffID"];
                    //Add the ID to the list.
                    s_IDs.Add(id);
                }
                //Close the connection.
                _string.Close();
                //Return the list.
                return s_IDs;
            }
        }

        //This method will get the MemberID from the Booking table according to the ClassID that has been passed in.
        public static List<int> CheckMember(string classID, DateTime classDate)
        {
            using (SqlConnection _connect = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<int> members = new List<int>();
                //Open the connection.
                _connect.Open();
                //Convert the classDate to a string in the format "yyyy-mm-dd"
                string date = classDate.ToString("yyyy-MM-dd");
                //Select the MemberID from the Booking table where the ClassID and the ClassDate are the values that have been entered in.
                string sqlQuery = string.Format(@"SELECT MemberID FROM Booking WHERE ClassID = '{0}' AND ClassDate = '{1}'", classID, date);
                SqlCommand getClassMember = new SqlCommand(sqlQuery, _connect);
                SqlDataReader sqlDataReader = getClassMember.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    int member = (int)sqlDataReader["MemberID"];
                    //Add the ID to the list.
                    members.Add(member);
                }
                //Close the connection.
                _connect.Close();
                //Return the list.
                return members;
            }
        }
    }
}



