using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SuperHero_WebApplication.Models;

namespace SuperHero_WebApplication.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Hero> Heroes;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
