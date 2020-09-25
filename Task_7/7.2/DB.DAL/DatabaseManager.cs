using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using Entites;


namespace DatabaseDAO
{
    public class DatabaseManager
    {
        private static string _connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;

        private static SqlConnection _connection = new SqlConnection(ConnectionString);

        public static object ConfigurationManager { get; private set; }
        public static string ConnectionString { get => _connectionString; set => _connectionString = value; }

        public IEnumerable<Users> GetAllUsers(bool orderedById = true)
        {
            using (_connection)
            {
                var query = "SELECT Id, Name, BirthDay, Age"
                    + (orderedById ? " ORDER BY Id" : "");

                var command = new SqlCommand(query, _connection);

                _connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    yield return new Users()
                    {
                        ID = Guid.NewGuid();
                        DateOfBirth = data;
                        Name = name;
                        Age = age;
                    }
                }
            }
        }

        public bool CreateNewUser(Guid id, string name, DateTime DateOfBirth, int age)
        {
            using (_connection)
            {
                var query = "INSERT INTO dbo.StudentsList(Name, BirthDay, IsEnglishSpeaker) " +
                    "VALUES(@Name, @BirthDay, @IsEnglishSpeaker)";
                var command = new SqlCommand(query, _connection);

                command.Parameters.AddWithValue("@Name", id);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@BirthDay", DateOfBirth);
                command.Parameters.AddWithValue("@IsEnglishSpeaker", age);

                // DBNull.Value

                _connection.Open();

                var result = command.ExecuteNonQuery();

                return result > 0;
            }
        }

        public Users GetUserById(int id)
        {
            using (_connection)
            {
                var stProc = "StudentsList_GetById";

                var command = new SqlCommand(stProc, _connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@id", id);

                _connection.Open();

                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return new Users()
                    {
                        ID = (Guid)reader["Id"],
                        Name = (string)reader["Name"],
                        DateOfBirth = (DateTime)reader["BirthDay"],
                        age = (int)reader["IsEnglishSpeaker"]
                    };
                }

                throw new InvalidOperationException("Cannot find User with ID = " + id);
            }
        }

        public Users CreateNewUserWithScopeID(Guid id, string name, DateTime dateOfBirth, int age)
    {
            using (_connection)
            {
                var query = "INSERT INTO dbo.UsersList(id, Name, BirthDay, age) " +
                    "VALUES(@id, @Name, @BirthDay, @age); SELECT CAST(scope_identity() AS INT) AS NewID";
                var command = new SqlCommand(query, _connection);

                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@BirthDay", dateOfBirth);
                command.Parameters.AddWithValue("@IsEnglishSpeaker", age);

                _connection.Open();

                var result = command.ExecuteScalar();

                if (result != null)
                    return new Users()
                    {
                        ID = (Guid)result,
                        Name = name,
                        DateOfBirth = dateOfBirth,
                        Age = age
                    };

                throw new InvalidOperationException(
                    string.Format("Cannot add Student with parameters: {0}, {1}, {2}, {3};",
                    id, name, dateOfBirth, age));
            }
        }
    }
}
