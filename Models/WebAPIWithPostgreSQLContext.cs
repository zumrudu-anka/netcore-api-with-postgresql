using Microsoft.EntityFrameworkCore;

namespace NetCoreWebAPIWithPostgreSQL.Models
{
    public class WebAPIWithPostgreSQLContext : DbContext
    {
        public WebAPIWithPostgreSQLContext(DbContextOptions<WebAPIWithPostgreSQLContext> options) : base (options){ }
            public DbSet<User> Users { get; set; }

    }
}