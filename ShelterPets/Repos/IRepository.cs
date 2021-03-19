using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ShelterPets.Models;
using Dapper;

namespace ShelterPets.Repos
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();
        List<T> GetOne(int id);
        void Delete(int id);
    }
}
