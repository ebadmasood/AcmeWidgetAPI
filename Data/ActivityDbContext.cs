using Microsoft.EntityFrameworkCore;

namespace AcmeWidgetAPI.Data
{
    public class ActivityDbContext : DbContext
    {
        public DbSet<ActivitySignUpForm> ActivitySignUpForms { get; set; }
        public ActivityDbContext(DbContextOptions<ActivityDbContext> options) : base(options)
        {
            
        }
    }
}
