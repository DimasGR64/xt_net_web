﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using EPAM.FoolballManager.Entites;
using EPAM.FoolballManager.DALCommon;
using System.Web.Helpers;

namespace EPAM.FoolballManager.DALCoach
{
    public class CoachDAL : ICoachDAL
    {
        private static string _connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;

        private static SqlConnection _connection = new SqlConnection(_connectionString);

        public IEnumerable<Players> GetAllPlayers(bool orderedById = true)
        {
            using (_connection)
            {
                var query = "SELECT Name, Age, Amplua_ID, Injurny_ID, Cards_ID FROM dbo.Players"
                    + (orderedById ? " ORDER BY id" : "");

                var command = new SqlCommand(query, _connection);

                _connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    yield return new Players()
                    {
                        Name = reader["Name"] as string,
                        Age = (int)reader["Age"],
                        Amplua_ID = (int)reader["Amplua_ID"],
                        Injurny_ID = (int)reader["Injurny_ID"],
                        Cards_ID = (int)reader["Cards_ID"],
                    };
                }
            }
        }
        public bool AddNewPlayer(string name, int amplua, int age)
        {
            using (_connection)
            {
                var query = "INSERT INTO dbo.Players(Name, Age, Amplua_ID) " +
                    "VALUES(@Name, @Age, @Amplua)";
                var command = new SqlCommand(query, _connection);

                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@age", age);
                command.Parameters.AddWithValue("@amplua", amplua);


                _connection.Open();

                var result = command.ExecuteNonQuery();

                return result > 0;
            }
        }
        public Players GetPlayerById(int id)
        {
            using (_connection)
            {
                var stProc = "dbo.Players_GetById";

                var command = new SqlCommand(stProc, _connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@id", id);

                _connection.Open();

                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return new Players()
                    {
                        ID = (int)reader["id"],
                        Name = reader["Name"] as string,
                        Amplua_ID = (int)reader["Amplua"],
                        Age = (int)reader["Age"],
                        Injurny_ID = (int)reader["Injurny_ID"],
                        Cards_ID = (int)reader["Card_ID"],
                    };
                }
                throw new InvalidOperationException("Cannot find Players with ID = " + id);
            }
        }
        public bool DeletePlayer(int id)
        {
            using (_connection)
            {
                var stProc = "dbo.Players_DeletePlayer";

                var command = new SqlCommand(stProc, _connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@id", id);

                _connection.Open();

                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return true;
                }
                else
                {
                    throw new InvalidOperationException("Cannot find Players with ID = " + id);
                }
            }
        }
        public bool AddCardsToPlayer(int cardID, int playerID)
        {
            return true;
        }
        public bool AddInjurnyToPlayer(int injurnyID, int playerID)
        {
            return true;
        }

        public bool DelCardsToPlayer(int cardID, int playerID)
        {
            return true;
        }

        public bool DelInjurnyToPlayer(int injurnyID, int playerID)
        {
            return true;
        }

        //public IEnumerable<Players> GetAllPlayers(bool orderedById = true)
        //{
        //    var providerName = "System.Data.SqlClient";
        //    string conn = @"Data Source=DIMASPC\SQLEXPRESS;Initial Catalog=EPAM.FootballManager;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //    var db = WebMatrix.Data.Database.OpenConnectionString(conn, providerName);
        //    var selectData = db.Query("SELECT * FROM Players");
        //    var grid = new WebGrid(source: selectData);
        //    return grid;
        //}
    }
}
