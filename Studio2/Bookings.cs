using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;


namespace Studio2
{
    public class Bookings
    {
        //Create the connection string.
        private static string _connectionString =
            ConfigurationManager.ConnectionStrings["Studio2ConnectionString"].ConnectionString;

        //This method will add a Booking.
        public static int AddBooking(string memberID, string classDate, string bookingDate, string classID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                //Open connection.
                connection.Open();

                //Insert the values that have been passed in, into the Booking table.
                string sqlQuery = string.Format(@"INSERT INTO Booking VALUES ('{0}', '{1}', '{2}', '{3}')",
                    memberID, classDate, bookingDate, classID);
                SqlCommand insertBookingCommand = new SqlCommand(sqlQuery, connection);

                int rowsAffected = insertBookingCommand.ExecuteNonQuery();

                //Close the connection.
                connection.Close();
                return rowsAffected;
            }
        }

        //This method will edit a Booking.
        public static int EditBooking(int _bookingID, string _classID)
        {
            using (SqlConnection _cstring = new SqlConnection(_connectionString))
            {
                //Open the connection.
                _cstring.Open();
                //Update the Booking table with the new data that has been passed in.
                string sqlQuery = string.Format(@"UPDATE Booking SET ClassID = '" + _classID + "'WHERE BookingID = '" + _bookingID 
                    + "'");
                SqlCommand editBookingCommand = new SqlCommand(sqlQuery, _cstring);

                int rowsAffected = editBookingCommand.ExecuteNonQuery();

                //Close the connection.
                _cstring.Close();
                //Return the value.
                return rowsAffected;
            }
        }

        //This method will delete a Booking.
        public static int DeleteBooking(string bookingID)
        {
            using (SqlConnection _ct = new SqlConnection(_connectionString))
            {
                //Open connection.
                _ct.Open();
                //Delete the Booking according to the BookingID that has been passed in.
                string Query = string.Format(@"DELETE FROM Booking WHERE (BookingID = '{0}')", bookingID);
                SqlCommand deleteBookingCommand = new SqlCommand(Query, _ct);

                int rowsAffected = deleteBookingCommand.ExecuteNonQuery();
                //Close the connection.
                _ct.Close();
                //Return the value.
                return rowsAffected;
            }
        }

        public static int getBookingID()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<int> bookingIDs = new List<int>();
                //Open the connection.
                conn.Open();
                //Select the BookingID from the Booking table.
                string sqlQuery = string.Format(@"SELECT BookingID FROM Booking");
                SqlCommand selectIDCommand = new SqlCommand(sqlQuery, conn);
                SqlDataReader sqlDataReader = selectIDCommand.ExecuteReader();
                while(sqlDataReader.Read())
                {
                    int bookID = (int)sqlDataReader["BookingID"];
                    //Add the BookingID to the list.
                    bookingIDs.Add(bookID);
                }
                //Save the amount of BookingIDs in the variable countBookingIDs.
                int countBookingIDs = bookingIDs.Count;
                //Increment countBookingIDs by 1.
                int newBookingID = bookingIDs[countBookingIDs - 1] + 1;
                //Close the connection.
                conn.Close();
                //Return the value.
                return newBookingID;
            }
        }

        //This method will get the MemberID from the Booking Class according to the BookingID that has been passed in.
        public static List<int> getMemberID(string b_ID)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<int> memIDs = new List<int>();
                //Open the connection.
                conn.Open();
                //Select the MemberID from the Booking table where the BookingID is that value that has been entered in.
                string sqlQuery = string.Format(@"SELECT MemberID FROM Booking WHERE BookingID = {0}", b_ID);
                SqlCommand getMemberIDCommand = new SqlCommand(sqlQuery, conn);
                SqlDataReader sqlDataReader = getMemberIDCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    int memberID = (int)sqlDataReader["MemberID"];
                    //Add the ID to the list.
                    memIDs.Add(memberID);
                }
                //Close the connection.
                conn.Close();
                //Return the list.
                return memIDs;
            }
        }

        //This method will get the ClassIDs from the Class table.
        public static List<string> getClassID()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<string> ids = new List<string>();
                //Open the connection.
                conn.Open();
                //Select the ClassID from the Class table.
                string sqlQuery = string.Format(@"SELECT ClassID FROM Class");
                SqlCommand getClassIDCommand = new SqlCommand(sqlQuery, conn);
                SqlDataReader sqlDataReader = getClassIDCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string classID = (string)sqlDataReader["ClassID"];
                    //Add the IDs to the list.
                    ids.Add(classID);
                }
                //Close the connection.
                conn.Close();
                //Return the list.
                return ids;
            }
        }

        //This method will get the Booking Date from the Booking table according to the BookingID that has been passed in.
        public static List<DateTime> getBookingDate(string b_Date)
        {
            using (SqlConnection _connect = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<DateTime> b_Dates = new List<DateTime>();
                //Open the connection.
                _connect.Open();
                //Select the BookingDate from the Booking table where the BookingID is that value that has been entered in.
                string sqlQuery = string.Format("SELECT BookingDate FROM Booking WHERE BookingID = '{0}'", b_Date);
                SqlCommand getDateCommand = new SqlCommand(sqlQuery, _connect);
                SqlDataReader sqlDataReader = getDateCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    DateTime date = (DateTime)sqlDataReader["BookingDate"];
                    //Add the BookingDate to the list.
                    b_Dates.Add(date);
                }
                //Clost the connection.
                _connect.Close();
                //Return the list.
                return b_Dates;
            }
        }

        //This method will get the MemberForename from the Member table according to the MemberID that has been passed in.
        public static List<string> getMemberForename(string m_Forename)
        {
            using (SqlConnection _conn = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<string> m_Fnames = new List<string>();
                //Open the connection.
                _conn.Open();
                //Select the MemberForename from the Member table where the MemberID is the value that has been entered in.
                string sqlQuery = string.Format("SELECT MemberForename FROM Member WHERE MemberID = '{0}'", m_Forename);
                SqlCommand getFnameCommand = new SqlCommand(sqlQuery, _conn);
                SqlDataReader sqlDataReader = getFnameCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string fname = (string)sqlDataReader["MemberForename"];
                    //Add the name to the list.
                    m_Fnames.Add(fname);
                }
                //Close the connection.
                _conn.Close();
                //Return the list.
                return m_Fnames;
            }
        }

        //This method will get the MemberSurname from the Member table according to the MemberID that has been entered.
        public static List<string> getMemberSurname(string m_Surname)
        {
            using (SqlConnection _connection = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<string> m_Snames = new List<string>();
                //Open the connection.
                _connection.Open();
                //Select the MemberSurname from the Member table where the MemberID is that value that has been entered in.
                string sqlQuery = string.Format("SELECT MemberSurname FROM Member WHERE MemberID = '{0}'", m_Surname);
                SqlCommand getSnameCommand = new SqlCommand(sqlQuery, _connection);
                SqlDataReader sqlDataReader = getSnameCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string sname = (string)sqlDataReader["MemberSurname"];
                    //Add the name to the list.
                    m_Snames.Add(sname);
                }
                //Close the connection.
                _connection.Close();
                //Return the list.
                return m_Snames;
            }
        }

        //This method will get the MemberStreet from the Member table according to the MemberID that as been entered.
        public static List<string> getMemberStreet(string m_Street)
        {
            using (SqlConnection co = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<string> m_Streets = new List<string>();
                //Open the connection.
                co.Open();
                //Select the MemberStreet from the Member table where the MemberID is the value that has been entered in.
                string sqlQuery = string.Format("SELECT MemberStreet FROM Member WHERE MemberID = '{0}'", m_Street);
                SqlCommand getStreetCommand = new SqlCommand(sqlQuery, co);
                SqlDataReader sqlDataReader = getStreetCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string street = (string)sqlDataReader["MemberStreet"];
                    //Add the street to the list.
                    m_Streets.Add(street);
                }
                //Close the connection.
                co.Close();
                //Return the list.
                return m_Streets;
            }
        }

        //This method will get the MemberTown from the Member table according to the MemberID that has been entered.
        public static List<string> getMemberTown(string m_Town)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<string> m_Towns = new List<string>();
                //Open the connection.
                con.Open();
                //Select the MemberTown from the Membertable where the MemberID is the value that has been entered in.
                string sqlQuery = string.Format("SELECT MemberTown FROM Member WHERE MemberID = '{0}'", m_Town);
                SqlCommand getTownCommand = new SqlCommand(sqlQuery, con);
                SqlDataReader sqlDataReader = getTownCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string town = (string)sqlDataReader["MemberTown"];
                    //Add the town to the list.
                    m_Towns.Add(town);
                }
                //Close the connection.
                con.Close();
                //Return the list.
                return m_Towns;
            }
        }

        //This method will get the MemberCounty from the Member table according to the MemberID that has been entered,
        public static List<string> getMemberCounty(string m_County)
        {
            using (SqlConnection ct = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<string> s_Counties = new List<string>();
                //Open the connection.
                ct.Open();
                //Select the MemberCounty from the Member table where the MemberID is the value that has been entered in.
                string sqlQuery = string.Format("SELECT MemberCounty FROM Member WHERE MemberID = '{0}'", m_County);
                SqlCommand getCountyCommand = new SqlCommand(sqlQuery, ct);
                SqlDataReader sqlDataReader = getCountyCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string county = (string)sqlDataReader["MemberCounty"];
                    //Add the county to the list.
                    s_Counties.Add(county);
                }
                //Close the connection.
                ct.Close();
                //Return the list.
                return s_Counties;
            }
        }

        //This method will get the MemberPostCode from the Member table according to the MemberID that has been entered.
        public static List<string> getMemberPostCode(string m_Pc)
        {
            using (SqlConnection cn = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<string> m_Pcs = new List<string>();
                //Open the connection.
                cn.Open();
                //Select the MemberPostCde from the Member table where the MemberID is the value that has been entered in.
                string sqlQuery = string.Format("SELECT MemberPostCode FROM Member WHERE MemberID = '{0}'", m_Pc);
                SqlCommand getPcCommand = new SqlCommand(sqlQuery, cn);
                SqlDataReader sqlDataReader = getPcCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string pc = (string)sqlDataReader["MemberPostCode"];
                    //Add the PostCode to the list.
                    m_Pcs.Add(pc);
                }
                //Close the connection.
                cn.Close();
                //Return the list.
                return m_Pcs;
            }
        }

        //The method will get the ClassID from the Booking table according the the BookingID that has been passed in.
        public static List<string> getClassID(string b_ID)
        {
            using (SqlConnection _conn = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<string> classIDs = new List<string>();
                //Open the connection
                _conn.Open();
                //Select the ClassId from the Booking table where the BookingID is the value that has been passed in.
                string sqlQuery = string.Format("SELECT ClassID FROM Booking WHERE BookingID = '{0}'", b_ID);
                SqlCommand getIDCommand = new SqlCommand(sqlQuery, _conn);
                SqlDataReader sqlDataReader = getIDCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string id = (string)sqlDataReader["ClassID"];
                    //Add the ID to the list.
                    classIDs.Add(id);
                }
                //Close the connection.
                _conn.Close();
                //Return the list.
                return classIDs;
            }
        }

        //This method will get the ClassName from the Class table according to the ClassID that has been passed in.
        public static List<string> getClassName(string className)
        {
            using (SqlConnection _connect = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<string> classNames = new List<string>();
                //Open the connection.
                _connect.Open();
                //Select the ClassName from the Class table where the ClassID is the value that has been entered in.
                string sqlQuery = string.Format("SELECT ClassName FROM Class WHERE ClassID = '{0}'", className);
                SqlCommand getNameCommand = new SqlCommand(sqlQuery, _connect);
                SqlDataReader sqlDataReader = getNameCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string name = (string)sqlDataReader["ClassName"];
                    //Add the name to the list.
                    classNames.Add(name);
                }
                //Close the connection.
                _connect.Close();
                //Return the list.
                return classNames;
            }
        }

        //This method will get the ClassDay from the Class table according to the ClassID that has been passed in.
        public static List<string> getClassDay(string classDay)
        {
            using (SqlConnection _connect = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<string> classDays = new List<string>();
                //Open the connection.
                _connect.Open();
                //Select the ClassDay from the Class table where the ClassID is the value that has been entered in.
                string sqlQuery = string.Format("SELECT ClassDay FROM Class WHERE ClassID = '{0}'", classDay);
                SqlCommand getDayCommand = new SqlCommand(sqlQuery, _connect);
                SqlDataReader sqlDataReader = getDayCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string day = (string)sqlDataReader["ClassDay"];
                    //Add the day to the list.
                    classDays.Add(day);
                }
                //Close the connection.
                _connect.Close();
                //Return the list.
                return classDays;
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

        //This method will get the ClassIDs from the Class table.
        public static List<string> getClassIDs()
        {
            using (SqlConnection ctin = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<string> c_IDs = new List<string>();
                //Open the connection.
                ctin.Open();
                //Select the ClassID from the Class table.
                string sqlQuery = string.Format("SELECT ClassID FROM Class");
                SqlCommand getIDCommand = new SqlCommand(sqlQuery, ctin);
                SqlDataReader sqlDataReader = getIDCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string c_ID = (string)sqlDataReader["ClassID"];
                    //Add the IDs to the list.
                    c_IDs.Add(c_ID);
                }
                //Close the connection.
                ctin.Close();
                //Return the list.
                return c_IDs;
            }
        }

        //This method will get the ClassDate from the Booking table according to the ClassID that has been passed in.
        public static List<DateTime> getClassDate(string b_Date)
        {
            using (SqlConnection _connect = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<DateTime> c_Dates = new List<DateTime>();
                //Open the connection.
                _connect.Open();
                //Select the ClassDate from the Booking table where the ClassID is the value that has been entered in.
                string sqlQuery = string.Format("SELECT ClassDate FROM Booking WHERE BookingID = '{0}'", b_Date);
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
