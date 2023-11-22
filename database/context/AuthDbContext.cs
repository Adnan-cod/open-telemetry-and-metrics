using database.context.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace database.context
{
    public class AuthDbContext : DbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
