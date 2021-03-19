using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShelterPets.Models;

namespace ShelterPets.Data
{
    public class ShelterPetsContext : DbContext
    {
        public ShelterPetsContext (DbContextOptions<ShelterPetsContext> options)
            : base(options)
        {
        }

        public DbSet<ShelterPets.Models.Cat> Cat { get; set; }

        public DbSet<ShelterPets.Models.Shelter> Shelter { get; set; }
    }
}
