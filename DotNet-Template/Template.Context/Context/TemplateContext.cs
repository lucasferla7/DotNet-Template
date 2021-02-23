using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Template.Context.Entities;
using Template.Context.Mapping;

namespace Template.Context.Context
{
    public class TemplateContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public DbSet<PeopleEntity> People { get; set; }

        public TemplateContext(IConfiguration configuration, DbContextOptions<TemplateContext> options) : base(options)
        {
            _configuration = configuration;
            Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = _configuration["ConnectionStrings:Sqlite"];
            optionsBuilder.UseSqlite(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PeopleMapping());
        }
    }
}