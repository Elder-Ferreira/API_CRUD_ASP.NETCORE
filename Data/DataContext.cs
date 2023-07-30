using API_ASP.NET.Models;
using Microsoft.EntityFrameworkCore;


namespace API_ASP.NET.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Pessoa> pessoa {get; set; }
    }
}