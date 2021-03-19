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
    public class CatRepo : IRepository<Cat>
    {
        private const string ConnectionString =
            "Data Source=3ZMLHL2;Initial Catalog=Animals;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private IDbConnection dbConnection = null;

        public CatRepo()
        {
            dbConnection = new SqlConnection(ConnectionString);
        }

        public List<Cat> GetAll()
        {
            string select = @"SELECT * FROM Cats";

            var queryResult = dbConnection.Query<Cat>(select);

            return queryResult.ToList();
        }

        public List<Cat> GetOne(int catNum)
        {
            string select = @"SELECT * FROM Cats WHERE CatId = catNum";

            var queryResult = dbConnection.Query<Cat>(select);

            return queryResult.ToList();
        }

        public void Delete(int catNum)
        {
            string select = @"DELETE FROM Cats WHERE CatId = catNum";
            dbConnection.Execute(select);
            
        }

        public void Add(int catId, string name, string gender, int age, string breed, int shelterId)
        {
            string select = @"INSERT INTO Cats VALUES (CatId, Name, Gender, Age, Breed, ShelterId)";
            dbConnection.Execute(select);
        }
    }
}
