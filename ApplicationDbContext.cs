using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AuthPractice.Data;

namespace AuthPractice.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<AuthPractice.Data.Team> Team { get; set; }
        public DbSet<AuthPractice.Data.Coach> Coach { get; set; }
        public DbSet<AuthPractice.Data.Players> Players { get; set; }
    }
}
