using System;
using System.Data.SqlClient;
using DataAccess.Sql;
using LawHouseLibrary.Models;

namespace DataAccess
{
    class SqlClient : SqlBase, IClient
    {

        public int CloseClient(int id)
        {
            _command.CommandText = "UPDATE Client SET CprNo = null, Address = null, PostNo = null, Email = null WHERE ID = @id";

            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@id", id));

            return ExecuteNonQuery();
        }

        public ClientM GetClient(string tlf)
        {
            ClientM c = new ClientM();
            _command.CommandText = "SELECT * FROM Client WHERE TlfNo = @tlf";
            _command.Parameters.Clear();

            _command.Parameters.Add(new SqlParameter("@tlf", tlf));
            PrepareSql();
            SqlDataReader reader = null;
            reader = _command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    c.Id = reader["ID"] != DBNull.Value ? Convert.ToInt32(reader["ID"]) : default(int);
                    c.CprNo = reader["CprNo"] != DBNull.Value ? reader["CprNo"].ToString() : string.Empty; 
                    c.FirstName = reader["FirstName"] != DBNull.Value ? reader["FirstName"].ToString() : string.Empty;
                    c.FirstName = reader["LastName"] != DBNull.Value ? reader["LastName"].ToString() : string.Empty;
                    c.Address = reader["Address"] != DBNull.Value ? reader["Address"].ToString() : string.Empty;
                    c.PostNo = reader["PostNo"] != DBNull.Value ? Convert.ToInt32(reader["PostNo"]) : default(int);
                    c.Email = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : string.Empty;
                    c.TlfNo = reader["TlfNo"] != DBNull.Value ? reader["TlfNo"].ToString() : string.Empty;

                }
            }
            _connection.Close();
            return c;
        }

        public int NewClient(ClientM client)
        {
            string sqlString = "INSERT INTO Client (CprNo, FirstName, LastName, Address, PostNo, Email, TlfNo) " +
                                 "VALUES (@CprNo, @FirstName, @LastName, @Address, @PostNo, @Email, @TlfNo)";

            _command.CommandText = sqlString;
            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@CprNo", client.CprNo));
            _command.Parameters.Add(new SqlParameter("@FirstName", client.FirstName));
            _command.Parameters.Add(new SqlParameter("@LastName", client.LastName));
            _command.Parameters.Add(new SqlParameter("@Address", client.Address));
            _command.Parameters.Add(new SqlParameter("@PostNo", client.PostNo));
            _command.Parameters.Add(new SqlParameter("@Email", client.Email));
            _command.Parameters.Add(new SqlParameter("@TlfNo", client.TlfNo));

            return ExecuteNonQuerySqlReturnId();
        }

        public int UpdateClient(ClientM client)
        {
            _command.CommandText = "UPDATE Client SET Address = @Address, PostNo = @PostNo, Email = @Email,  TlfNo = @TlfNo " +
                                  "WHERE ID = @id";

            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@id", client.Id));
            _command.Parameters.Add(new SqlParameter("@Address", client.Address));
            _command.Parameters.Add(new SqlParameter("@PostNo", client.PostNo));
            _command.Parameters.Add(new SqlParameter("@Email", client.Email));
            _command.Parameters.Add(new SqlParameter("@TlfNo", client.TlfNo));
            return ExecuteNonQuery();
        }
    }
}
