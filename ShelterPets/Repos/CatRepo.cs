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
            var parameters = new { CatId = catNum };
            string select = @"SELECT * FROM Cats WHERE CatId = @CatId";

            var queryResult = dbConnection.Query<Cat>(select, parameters);

            return queryResult.ToList();
        }

        public void Delete(int catNum)
        {
            var parameters = new { CatId = catNum };
            string select = @"DELETE FROM Cats WHERE CatId = @CatId";
            dbConnection.Execute(select, parameters);
            
        }

        public void Add(int catId, string name, string gender, int age, string breed, int shelterId)
        {
            var parameters = new { CatId = catId, Name = name, Gender = gender, Age = age, Breed = breed, ShelterId = shelterId };
            string select = @"INSERT INTO Cats (CatId, Name, Gender, Age, Breed, ShelterId) VALUES (@CatId, @Name, @Gender, @Age, @Breed, @ShelterId)";
            dbConnection.Execute(select, parameters);
        }
    }
}
