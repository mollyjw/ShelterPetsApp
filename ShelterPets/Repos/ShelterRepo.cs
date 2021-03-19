using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using ShelterPets.Models;
using Dapper;
using System.Threading.Tasks;

namespace ShelterPets.Repos
{
    public class ShelterRepo : IRepository<Shelter>
    {
        private const string ConnectionString =
            "Data Source=3ZMLHL2;Initial Catalog=Animals;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private IDbConnection dbConnection = null;

        public ShelterRepo()
        {
            dbConnection = new SqlConnection(ConnectionString);
        }

        public List<Shelter> GetAll()
        {
            string select = @"SELECT * FROM Shelters";

            var queryResult = dbConnection.Query<Shelter>(select);

            return queryResult.ToList();
        }

        public List<Shelter> GetOne(int shelterNum)
        {
            string select = @"SELECT * FROM Cats WHERE CatId = shelterNum";

            var queryResult = dbConnection.Query<Shelter>(select);

            return queryResult.ToList();
        }

        public void Delete(int shelterNum)
        {
            string select = @"DELETE FROM Cats WHERE ShelterId = shelterNum";
            dbConnection.Execute(select);

        }

        public void Add(int shelterId, string name, string description)
        {
            string select = @"INSERT INTO Shelters VALUES (ShelterId, Name, Description)";
            dbConnection.Execute(select);
        }
    }
}


