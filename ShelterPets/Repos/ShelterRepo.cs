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
            var parameters = new { ShelterId = shelterNum };
            string select = @"SELECT * FROM Shelters WHERE ShelterId = @ShelterId";

            var queryResult = dbConnection.Query<Shelter>(select, parameters);

            return queryResult.ToList();
        }

        public void Delete(int id) //WILL NOT DELETE UNTIL CATS FROM SHELTER ARE DELETED?
        {
            var parameters = new { ShelterId = id };
            string nullCats = @"UPDATE cats SET ShelterId = null WHERE ShelterId = @ShelterId";
                        
            string select = @"DELETE FROM Shelters WHERE ShelterId = @ShelterId";
            dbConnection.Execute(nullCats, parameters);
            dbConnection.Execute(select, parameters);

        }

        public void Add(Shelter shelter)
        {
            var parameters = new { ShelterId = shelter.ShelterId, Name = shelter.Name, Description = shelter.Description };
            string select = @"INSERT INTO Shelters VALUES (@ShelterId, @Name, @Description)";
            dbConnection.Execute(select, parameters);
        }
    }
}


