using System.Collections.Generic;
using static System.Reflection.Metadata.BlobBuilder;
using Microsoft.EntityFrameworkCore;


namespace ProgrammingChallenge6._1.Models
{
    public class SchoolDbContext : DbContext
    {

        public DbSet<Department> Departments { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        {

        }
    }
}
