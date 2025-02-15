using Microsoft.EntityFrameworkCore;
using Portfolio_Project.Models;

namespace Portfolio_Project.Data
{
    public class PortfolioDBContext: DbContext
    {
        public PortfolioDBContext(DbContextOptions<PortfolioDBContext> options): base(options)
        {
            
        }

        public DbSet<Form> Forms { get; set; }
    }
}
