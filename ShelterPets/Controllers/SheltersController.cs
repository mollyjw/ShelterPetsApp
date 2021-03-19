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
    [Route("api/[controller]")]
    [ApiController]
    public class SheltersController : ControllerBase
    {
        private ShelterRepo shelterRepo = null;
        private IConfiguration _config;

        public SheltersController(IConfiguration config)
        {
            shelterRepo = new ShelterRepo();
            _config = config;
        }

        // GET: api/Shelters
        [HttpGet]
        public ActionResult<IEnumerable<Shelter>> GetShelters()
        {
            IList<Shelter> allShelters = shelterRepo.GetAll();
            return Ok(allShelters);
        }

        // GET: api/Shelters/5
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Shelter>> GetShelter(int id)
        {
            IList<Shelter> oneShelter = shelterRepo.GetOne(id);

            if (oneShelter == null)
            {
                return NotFound();
            }

            return Ok(oneShelter);
        }

        // DELETE: api/Shelters/5
        [HttpDelete("{id}")]
        public string DeleteShelter(int id)
        {
            shelterRepo.Delete(id);
            return "Shelter {shelterNum} deleted.";
        }

        // POST: api/Shelters
        [HttpPost]
        public string AddShelter(int shelterId, string name, string description)
        {
            shelterRepo.Add(shelterId, name, description);
            return "{name} added!";
        }

    }
}
