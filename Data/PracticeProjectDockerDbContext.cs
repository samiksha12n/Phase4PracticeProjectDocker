using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PracticeProjectDocker.Models;

namespace PracticeProjectDocker.Data
{
    public class PracticeProjectDockerDbContext : DbContext
    {
        public PracticeProjectDockerDbContext (DbContextOptions<PracticeProjectDockerDbContext> options)
            : base(options)
        {
        }

        public DbSet<PracticeProjectDocker.Models.Login> Login { get; set; } = default!;
    }
}
