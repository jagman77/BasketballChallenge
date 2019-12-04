using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BBallChallenge.Models;

namespace BBallChallenge.Data
{
    public class BBallChallengeContext : DbContext
    {
        public BBallChallengeContext (DbContextOptions<BBallChallengeContext> options)
            : base(options)
        {
        }

        public DbSet<BBallChallenge.Models.Game> Game { get; set; }
    }
}
