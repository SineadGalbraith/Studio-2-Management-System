using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Studio2
{
    class Member
    {
        //Create the connection string.
        private static string _connectionString =
            ConfigurationManager.ConnectionStrings["Studio2ConnectionString"].ConnectionString;

        //This method will add a Member.
        public static int AddMember(string memberForename, string memberSurname, string memberDOB, string memberGender,
            string memberStreet, string memberTown, string memberCounty, string memberPostCode, string memberPhoneNo,
            string memberEmail, string membershipTypeID, string startDate, string expiryDate)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                //Open the connection.
                connection.Open();

                //Insert the values that have been passed across into the Member table.
                string sqlQuery = string.Format(@"INSERT INTO Member VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', 
                    '{8}', '{9}', '{10}', '{11}', '{12}')", memberForename, memberSurname, memberDOB, memberGender, memberStreet,
                                memberTown, memberCounty, memberPostCode, memberPhoneNo, memberEmail, membershipTypeID, startDate, expiryDate);
                SqlCommand insertMemberCommand = new SqlCommand(sqlQuery, connection);

                int rowsAffected = insertMemberCommand.ExecuteNonQuery();

                //Close the connection.
                connection.Close();
                //Return the value.
                return rowsAffected;
            }
        }

        //This method will edit a Member.
        public static int EditMember(string memberID, string forename, string surname, string dob, string gender, string street,
            string town, string county, string postCode, string phoneNo, string email, string memType, string sDate, string eDate)
        {
            using (SqlConnection _cstring = new SqlConnection(_connectionString))
            {
                //Open the connection
                _cstring.Open();
                //Convert the text in txtDOB to a string in the format "yyyy-mm-dd".
                string _date = Convert.ToDateTime(dob).ToString("yyyy-MM-dd");
                string sqlQuery = string.Format(@"UPDATE Member SET MemberForename = '" + forename + "', MemberSurname = '" + surname +
                    "', MemberDOB = '" + _date + "', MemberGender = '" + gender + "', MemberStreet = '" + street +
                    "', MemberTown = '" + town + "', MemberCounty = '" + county + "', MemberPostCode = '" + postCode +
                    "', MemberPhoneNo = '" + phoneNo + "', MemberEmail = '" + email + "', MembershipTypeID = '" + memType +
                    "'WHERE MemberID = '" + memberID + "'");
                SqlCommand editMemberCommand = new SqlCommand(sqlQuery, _cstring);

                int rowsAffected = editMemberCommand.ExecuteNonQuery();

                //Close the connection.
                _cstring.Close();
                //Return the values.
                return rowsAffected;
            }
        }

        //This method will delete a Member.
        public static int DeleteMember(string MemberID)
        {
            using (SqlConnection _ct = new SqlConnection(_connectionString))
            {
                //Open the connection.
                _ct.Open();
                //Delete the Member according to the MemberID that has been passed in.
                string Query = string.Format(@"DELETE FROM Member WHERE (MemberID = '{0}')", MemberID);
                SqlCommand deleteMemberCommand = new SqlCommand(Query, _ct);

                int rowsAffected = deleteMemberCommand.ExecuteNonQuery();

                //Close the connection.
                _ct.Close();
                //Return the list.
                return rowsAffected;
            }
        }

        //This method will get the MemberIDs from the Member table.
        public static int GetID()
        {
            using (SqlConnection connect = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<int> memberids = new List<int>();
                //Open the connection.
                connect.Open();
                //Select the MemberID from the Member table.
                string sqlQuery = string.Format(@"SELECT MemberID FROM Member");
                SqlCommand selectIDCommand = new SqlCommand(sqlQuery, connect);
                SqlDataReader sqlDataReader = selectIDCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    int memID = (int)sqlDataReader["MemberID"];
                    //Add the MemberID to the list.
                    memberids.Add(memID);
                }
                //Save the amount of MemberIDs in the variable countMemberIDs.
                int countMemberIDs = memberids.Count;
                //Increment countMemberIDs by 1.
                int newMemberID = memberids[countMemberIDs - 1] + 1;

                //Close the connection.
                connect.Close();
                //Return the list.
                return newMemberID;
            }
        }

        //This method will get the MembershipTypeIDs from the MemberType table.
        public static List<string> getMembershipID()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<string> ids = new List<string>();
                conn.Open();
                //Select the MemberTypeID from the MemberType table.
                string sqlQuery = string.Format(@"SELECT MembershipTypeID FROM MemberType");
                SqlCommand getMembershipIDCommand = new SqlCommand(sqlQuery, conn);
                SqlDataReader sqlDataReader = getMembershipIDCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string typeID = (string)sqlDataReader["MembershipTypeID"];
                    //Add the ID to the list.
                    ids.Add(typeID);
                }
                //Close the connection.
                conn.Close();
                //Return the list.
                return ids;
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

        //This method will get the MemberDOB from the Member table according to the MemberID that has been entered.
        public static List<DateTime> getMemberDOB(string m_Dob)
        {
            using (SqlConnection _connect = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<DateTime> m_Dobs = new List<DateTime>();
                //Open the connection.
                _connect.Open();
                //Select the MemberDOB from the Member table where the MemberID is the value that has been entered in.
                string sqlQuery = string.Format("SELECT MemberDOB FROM Member WHERE MemberID = '{0}'", m_Dob);
                SqlCommand getDobCommand = new SqlCommand(sqlQuery, _connect);
                SqlDataReader sqlDataReader = getDobCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    DateTime dob = (DateTime)sqlDataReader["MemberDOB"];
                    //Add the dob to the list.
                    m_Dobs.Add(dob);
                }
                //Close the connection.
                _connect.Close();
                //Return the list.
                return m_Dobs;
            }
        }

        //This method will get the MemberGender from the Member table according to the MemberID that has been entered.
        public static List<string> getMemberGender(string m_Gender)
        {
            using (SqlConnection c = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<string> m_Genders = new List<string>();
                //Open the connection.
                c.Open();
                //Select the MemberGender from the Member table where the MemberID is the value that has been entered in.
                string sqlQuery = string.Format("SELECT MemberGender FROM Member WHERE MemberID = '{0}'", m_Gender);
                SqlCommand getGenderCommand = new SqlCommand(sqlQuery, c);
                SqlDataReader sqlDataReader = getGenderCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string gender = (string)sqlDataReader["MemberGender"];
                    //Add the gender to the list.
                    m_Genders.Add(gender);
                }
                //Close the connection.
                c.Close();
                //Return the list.
                return m_Genders;
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

        //This method will get the MemberPhoneNo from the Member table according to the MemberID that has been entered.
        public static List<string> getMemberPhone(string m_Phone)
        {
            using (SqlConnection cnn = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<string> m_Phones = new List<string>();
                //Open the connection.
                cnn.Open();
                //Select the MemberPhoneNo from the Member table where the MemberID is the value that has been entered in.
                string sqlQuery = string.Format("SELECT MemberPhoneNo FROM Member WHERE MemberID = '{0}'", m_Phone);
                SqlCommand getPhoneCommand = new SqlCommand(sqlQuery, cnn);
                SqlDataReader sqlDataReader = getPhoneCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string phone = (string)sqlDataReader["MemberPhoneNo"];
                    //Add the phone number to the list.
                    m_Phones.Add(phone);
                }
                //Close the connection.
                cnn.Close();
                //Return the list.
                return m_Phones;
            }
        }

        //This method will get the MemberEmail from the Member table according to the MemberID that has been entered.
        public static List<string> getMemberEmail(string m_Email)
        {
            using (SqlConnection ctn = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<string> m_Emails = new List<string>();
                //Open the connection.
                ctn.Open();
                //Select the MemberEmail from the Member table according to the MemberID that has been entered in.
                string sqlQuery = string.Format("SELECT MemberEmail FROM Member WHERE MemberID = '{0}'", m_Email);
                SqlCommand getEmailCommand = new SqlCommand(sqlQuery, ctn);
                SqlDataReader sqlDataReader = getEmailCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string email = (string)sqlDataReader["MemberEmail"];
                    //Add the email to the list.
                    m_Emails.Add(email);
                }
                //Close the connection.
                ctn.Close();
                //Return the list.
                return m_Emails;
            }
        }

        //This method will get the MembershipTypeID from the Member table according to the MemberID that has been entered.
        public static List<string> getMembership(string m_Memship)
        {
            using (SqlConnection ctin = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<string> m_Memships = new List<string>();
                //Open the connection.
                ctin.Open();
                //Select the MembershipTypeID from the Member table according to the MemberID that has been entered in.
                string sqlQuery = string.Format("SELECT MembershipTypeID FROM Member WHERE MemberID = '{0}'", m_Memship);
                SqlCommand getMemshipCommand = new SqlCommand(sqlQuery, ctin);
                SqlDataReader sqlDataReader = getMemshipCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string memship = (string)sqlDataReader["MembershipTypeID"];
                    //Add the membership type to the list.
                    m_Memships.Add(memship);
                }
                //Close the connection.
                ctin.Close();
                //Return the list.
                return m_Memships;
            }
        }

        //This method will get the MemberStartDate from the Member table according to the MemberID that has been entered.
        public static List<DateTime> getStartDate(string sDate)
        {
            using (SqlConnection _connectString = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<DateTime> sDates = new List<DateTime>();
                //Open the connection.
                _connectString.Open();
                //Select the MemberStartDate from the Member table according to the MemberID that has been entered in.
                string sqlQuery = string.Format("SELECT MemberStartDate FROM Member WHERE MemberID = '{0}'", sDate);
                SqlCommand getSDateCommand = new SqlCommand(sqlQuery, _connectString);
                SqlDataReader sqlDataReader = getSDateCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    DateTime start = (DateTime)sqlDataReader["MemberStartDate"];
                    //Add the start date to the list.
                    sDates.Add(start);
                }
                //Close the connection.
                _connectString.Close();
                //Return the list.
                return sDates;
            }
        }

        //This method will get the MemberExpiryDate from the Member table according to the MemberID that has been entered.
        public static List<DateTime> getExpiryDate(string eDate)
        {
            using (SqlConnection _connectS = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<DateTime> eDates = new List<DateTime>();
                //Open the connection.
                _connectS.Open();
                //Select the MemberExpiryDate from the Member table according to the MemberID that has been entered in.
                string sqlQuery = string.Format("SELECT MemberExpiryDate FROM Member WHERE MemberID = '{0}'", eDate);
                SqlCommand getSDateCommand = new SqlCommand(sqlQuery, _connectS);
                SqlDataReader sqlDataReader = getSDateCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    DateTime expiry = (DateTime)sqlDataReader["MemberExpiryDate"];
                    //Add the expiry date to the list.
                    eDates.Add(expiry);
                }
                //Close the connection.
                _connectS.Close();
                //Return the list.
                return eDates;
            }
        }
    }
}
    

