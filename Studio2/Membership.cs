using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;


namespace Studio2
{
    class Membership
    {
        //Create the connection string.
        private static string _connectionString =
            ConfigurationManager.ConnectionStrings["Studio2ConnectionString"].ConnectionString;

        //This method will add a Membership.
        public static int AddMembership(string MembershipTypeID, string MembershipDescription, string MembershipLength,
            string MembershipPaymentType, string MembershipAmount)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                //Open the connection.
                connection.Open();

                //Insert the values that have been passed across into the MemberType table.
                string sqlQuery = string.Format(@"INSERT INTO MemberType VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", MembershipTypeID,
                    MembershipDescription, MembershipLength, MembershipPaymentType, Convert.ToDecimal(MembershipAmount));
                SqlCommand insertMembershipCommand = new SqlCommand(sqlQuery, connection);

                int rowsAffected = insertMembershipCommand.ExecuteNonQuery();

                //Close the connection.
                connection.Close();
                //Return the value.
                return rowsAffected;
            }
        }

        //This method will edit a Membership type.
        public static int EditMembership(string memshipID, string description, string length, string paymentType, string amount)
        {
            using (SqlConnection _cstring = new SqlConnection(_connectionString))
            {
                //Open the connection
                _cstring.Open();
                //Update the MemberType table with the new data that has been passed across.
                string sqlQuery = string.Format(@"UPDATE MemberType SET MembershipDescription = '" + description +
                    "', MembershipLength = '" + length + "', MembershipPaymentType = '" + paymentType + 
                    "', MembershipAmount = '" + amount + "'WHERE MembershipTypeID = '" + memshipID + "'");

                SqlCommand editMembershipCommand = new SqlCommand(sqlQuery, _cstring);

                int rowsAffected = editMembershipCommand.ExecuteNonQuery();

                //Close the connection.
                _cstring.Close();
                //Return the values.
                return rowsAffected;
            }
        }

        //This method will delete the Membership.
        public static int DeleteMembership(string Membership)
        {
            using (SqlConnection _ct = new SqlConnection(_connectionString))
            {
                //Open the connection.
                _ct.Open();
                //Delete the Membership according to the MembershipTypeID that has been passed in.
                string Query = string.Format(@"DELETE FROM MemberType WHERE (MembershipTypeID = '{0}')", Membership);
                SqlCommand deleteMembershipCommand = new SqlCommand(Query, _ct);

                int rowsAffected = deleteMembershipCommand.ExecuteNonQuery();

                //Close the connection.
                _ct.Close();
                //Return the value.
                return rowsAffected;
            }
        }

        //This method will get the MembershipDescriptions from the MemberType table according to the MembershipTypeID that has been passed in.
        public static List<string> getMembershipDescription(string memtype_des)
        {
            using(SqlConnection conn = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<string> memtypeDesc= new List<string>();
                //Open the connection.
                conn.Open();
                //Select the MembershipDescription from the MemberType table where the MembershipTypeID is the value that has been entered in.
                string sqlQuery = string.Format("SELECT MembershipDescription FROM MemberType WHERE MembershipTypeID = '{0}'", memtype_des);
                SqlCommand getDescCommand = new SqlCommand(sqlQuery, conn);
                SqlDataReader sqlDataReader = getDescCommand.ExecuteReader();
                while(sqlDataReader.Read())
                {
                    string desc = (string)sqlDataReader["MembershipDescription"];
                    //Add the MembershipDescription to the list.
                    memtypeDesc.Add(desc);
                }
                //Close the connection.
                conn.Close();
                //Return the list.
                return memtypeDesc;
            }
        }

        //This method will get the MembershipLengths from the MemberType table according to the MembershipTypeID that has been passed in.
        public static List<string> getMembershipLength(string memtype_length)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<string> memtypeLength = new List<string>();
                //Open the connection.
                conn.Open();
                //Select the MembershipLength from the MemberType table where the MembershipTypeID is the value that has been entered in.
                string sqlQuery = string.Format("SELECT MembershipLength FROM MemberType WHERE MembershipTypeID = '{0}'", memtype_length);
                SqlCommand getLengthCommand = new SqlCommand(sqlQuery, conn);
                SqlDataReader sqlDataReader = getLengthCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string length = (string)sqlDataReader["MembershipLength"];
                    //Add the MembershipLength to the list.
                    memtypeLength.Add(length);
                }
                //Close the connection.
                conn.Close();
                //Return the list.
                return memtypeLength;
            }
        }

        //This method will get the MembershipPaymentTypes from the MemberType table according to the MembershipTypeID that has been passed in.
        public static List<string> getMembershipPayment(string memtype_payment)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<string> memtypePayment = new List<string>();
                //Open the connection.
                conn.Open();
                //Select the MembershipPaymentTypes from the MemberType table where the MembershipTypeID is the value that has been entered in.
                string sqlQuery = string.Format("SELECT MembershipPaymentType FROM MemberType WHERE MembershipTypeID = '{0}'", memtype_payment);
                SqlCommand getPaymentCommand = new SqlCommand(sqlQuery, conn);
                SqlDataReader sqlDataReader = getPaymentCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string payment = (string)sqlDataReader["MembershipPaymentType"];
                    //Add the MembershipPaymentType to the list.
                    memtypePayment.Add(payment);
                }
                //Close the connection.
                conn.Close();
                //Return the list.
                return memtypePayment;
            }
        }

        //This method will get the MembershipAmounts from the MemberType table according to the MembershipTypeID that has been passed in.
        public static List<decimal> getMembershipAmount(string memtype_amount)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                //Create a list.
                List<decimal> memtypeAmount = new List<decimal>();
                //Open the connection.
                conn.Open();
                //Select the MembershipAmounts from the MemberType table where the MembershipTypeID is the value that has been entered in.
                string sqlQuery = string.Format("SELECT MembershipAmount FROM MemberType WHERE MembershipTypeID = '{0}'", memtype_amount);
                SqlCommand getAmountCommand = new SqlCommand(sqlQuery, conn);
                SqlDataReader sqlDataReader = getAmountCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    decimal amount = (decimal)sqlDataReader["MembershipAmount"];
                    //Add the MembershipAmount to the list.
                    memtypeAmount.Add(amount);
                }
                //Close the connection.
                conn.Close();
                //Return the list.
                return memtypeAmount;
            }
        }
    }
}
