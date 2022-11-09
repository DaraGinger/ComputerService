namespace ComputerService.DataAcces
{
    using ComputerService.DataAcces.Entities;
    using Microsoft.EntityFrameworkCore;

    public class DataContext : DbContext
    {
        private const string _connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ComputerService;Integrated Security=True;Connection Timeout=90;MultipleActiveResultSets=true";

        public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<Owner> Owners { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }*/
    }
}