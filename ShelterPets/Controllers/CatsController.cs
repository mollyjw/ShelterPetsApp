using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShelterPets.Data;
using ShelterPets.Models;
using ShelterPets.Repos;
using Microsoft.Extensions.Configuration;


namespace ShelterPets.Controllers
{
    [Route("api/cats")]
    [ApiController]
    public class CatsController : ControllerBase
    {
        private CatRepo catRepo = null;
        private IConfiguration _config;

        public CatsController(IConfiguration config)
        {
            catRepo = new CatRepo();
            _config = config;
        }

        // GET: api/Cats
        [HttpGet]
        public ActionResult<IEnumerable<Cat>> GetCats()
        {
            IList<Cat> allCats = catRepo.GetAll();
            return Ok(allCats);
        }

        // GET: api/Cats/5
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Cat>> GetCat(int id)
        {
            IList<Cat> oneCat = catRepo.GetOne(id);
            
            if (oneCat == null)
            {
                return NotFound();
            }

            return Ok(oneCat);
        }

        // DELETE: api/Cats/5
        [HttpDelete("{id}")]
        public string DeleteCat(int id)
        {
            catRepo.Delete(id);
            return "Cat " + id + " deleted.";
        }

        // POST: api/Cats
        [HttpPost]
        public string AddCat(Cat cat)
        {
            catRepo.Add(cat);
            return "Cat added!";
        }

    }
}
